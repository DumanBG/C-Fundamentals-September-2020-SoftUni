using System;
using System.Text.RegularExpressions;

namespace _02.FancyBarkodeRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+)";
            string patternNumbers = @"[0-9]";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                //  Regex regex = new Regex(@"(@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+)");
                MatchCollection matches = Regex.Matches(input, pattern);
                string matchAsString = "";
                if (matches.Count == 1)
                {
                    foreach (Match match in matches)
                        matchAsString = match.ToString();
                }
                if (matchAsString != input)
                {
                    Console.WriteLine("Invalid barcode");


                }
                else
                {
                    MatchCollection matchesNumbers = Regex.Matches(input, patternNumbers);
                    if (matchesNumbers.Count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        string productGroup = "";
                        foreach (Match number in matchesNumbers)
                        {
                            productGroup += number;

                        }

                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
            }


        }
    }
}
