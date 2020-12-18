using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestinationMapperRegexDieHard
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         
            Regex regex = new Regex(@"(\/|=)([A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = regex.Matches(input);
            List<string> destinations = new List<string>();
         
            int travelPoints = 0;
            foreach(Match match in matches)
            {
                destinations.Add(match.Groups[2].Value);
                travelPoints += match.Groups[2].Value.Length;
            }

            Console.WriteLine("Destinations: " + String.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
           
        }
    }
}
