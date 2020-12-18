using System;
using System.Text.RegularExpressions;

namespace _01.FindFullNamesIvanIvanov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test TestovТ, Ivan	Ivanov  
            // Ivan Ivanov Test Testov
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            MatchCollection mathes = regex.Matches(input);
            
            foreach(Match match in mathes)
            {
                Console.Write(match.Groups[0] + " ");

            }
        }
    }
}
