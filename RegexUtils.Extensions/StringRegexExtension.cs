using System.Linq;
using System.Text.RegularExpressions;

namespace RegexUtils.Extensions
{
    /// <summary>
    /// Extensão que permite a extração de sequências de texto
    /// de uma string, a partir do uso de regular expressions
    /// </summary>
    public static class StringRegexExtension
    {
        /// <summary>
        /// Retorna todas as sequências de texto encontradas em
        /// uma string e que atendam a uma expressão regular fornecida
        /// como parâmetro.
        /// </summary>
        /// <param name="value">Valor a ser analisado.</param>
        /// <param name="regularExpression">Expressão regular.</param>
        /// <returns>Array com as sequências de texto encontradas.</returns>
        public static string[] ExtractStringsUsingRegex(
            this string value,
            string regularExpression)
        {
            MatchCollection mc =
                Regex.Matches(value, regularExpression);

            return (from Match m in mc
                    select m.Value).ToArray();
        }
    }
}