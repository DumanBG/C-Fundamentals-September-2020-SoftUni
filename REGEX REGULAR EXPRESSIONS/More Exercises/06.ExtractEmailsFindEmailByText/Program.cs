using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmailsFindEmailByText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)*@(?<hosts>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";

            MatchCollection mathes = Regex.Matches(input, pattern);

            Console.WriteLine(String.Join(Environment.NewLine, mathes));

        }
    }
}
