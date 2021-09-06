using System;
using System.Text.RegularExpressions;

namespace Regular_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ("1, 1000, 1 000 000, 100.23");
            string pattern = (@"\d{1,}\u002E*\s*\d*\s*\d*");

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            string text2 = ("http://ya.ru/api?r=1&x=23");
            string pattern2 = (@"\w{1}\u003D{1}\d{1,}");

            Regex regex2 = new Regex(pattern2);
            MatchCollection matches2 = regex2.Matches(text2);

            foreach (Match match in matches2)
            {
                Console.WriteLine(match.Value);
            }

            string text3 = ("У меня пробел сломался.");
            string pattern3 = (@"\s");
            string emptyString = ("");

            Regex regex3 = new Regex(pattern3);
            string text3WithoutSpaces = regex3.Replace(text3, emptyString);

            Console.WriteLine(text3WithoutSpaces);

            string[] numbersArray = new string[] { ("+373 77770330"), ("+373 77885062"), ("+33 77852"), ("+373 77522385") };
            string pattern4 = (@"^\+\d{3}\s\d{8}$");

            foreach (var number in numbersArray)
            {
                Console.WriteLine($"Номер {number} - {Regex.IsMatch(number, pattern4)}");
            }

            Console.ReadKey();
        }
    }
}
