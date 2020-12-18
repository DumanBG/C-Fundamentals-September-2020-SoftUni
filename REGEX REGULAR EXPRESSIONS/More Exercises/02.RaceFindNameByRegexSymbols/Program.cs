using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.RaceFindNameByRegexSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lisOfPeople = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            foreach (var name in lisOfPeople)
            {
                dictionaryOfNames.Add(name, 0);
            }
            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");
               // Console.WriteLine(name);
               // Console.WriteLine(distance);

                int sum = 0;
                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }
                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;

                }
                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var kvp in dictionaryOfNames.OrderByDescending(x => x.Value))
            {
                   string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";  // ternaren operator e raven na dolnia if else
                /*
                string output = string.Empty;
                if (count == 1)
                {
                    output = "st";
                }
                else if (count == 2)
                {
                    output = "nd";
                }
                else if (count == 3)
                {
                    output = "rd";
                }
                */
            Console.WriteLine($"{count++}{text} place: {kvp.Key}");
                if(count ==4)
                {
                    break;
                }
            }
        }
    }
}
