using System;
using System.Text;
using RegexUtils.Extensions;

namespace StringRegexExtension.Tests
{
    class Program
    {
        private static void ShowResults(
            string text, string[] results)
        {
            Console.WriteLine("Conteúdo da variável text = {0}", text);

            StringBuilder strb = new StringBuilder();
            strb.Append("[ ");
            foreach (string result in results)
            {
                if (strb.Length > 2)
                    strb.Append(" , ");
                strb.Append(result);
            }
            strb.Append(" ]");

            Console.WriteLine(
                "Strings encontradas = {0}",
                strb.ToString());
        }

        static void Main(string[] args)
        {
            string text;
            string[] results;

            text = "x=3.452 y=4521 z= 3412";
            results = text.ExtractStringsUsingRegex(@"\d+(?:\.\d+)?");
            ShowResults(text, results);

            Console.WriteLine(String.Empty);

            text = "Para entrar em contato envie um e-mail para test@acme.com. Caso não " +
                "obtenha uma rápida resposta, encaminhe um e-mail para answers@acme.com.br.";
            results = text.ExtractStringsUsingRegex("[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})");
            ShowResults(text, results);

            Console.ReadKey();
        }
    }
}