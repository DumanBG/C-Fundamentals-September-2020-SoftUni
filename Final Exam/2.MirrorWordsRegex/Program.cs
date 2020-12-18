using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.MirrorWordsRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            ;
            Regex regex = new Regex(@"(@|#)([A-Za-z]{3,})(\1){2}([A-Za-z]{3,})(\1)");
            MatchCollection matches = regex.Matches(text);

            int mirrowMatchesCount = 0;
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                string mirroredWords = "";
                foreach (Match match in matches)
                {
                    string firstWord = match.Groups[2].Value;
                    string secondWordBefore = match.Groups[4].Value;
                    string secondWordAfter = ReverseString(secondWordBefore);
                    // Console.WriteLine(firstWord);
                    //  Console.WriteLine(secondWord);
                    if (firstWord == secondWordAfter)
                    {
                        mirrowMatchesCount++;
                        mirroredWords += $"{firstWord} <=> {secondWordBefore}, ";
                    }

                }

                if (mirrowMatchesCount <= 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    char[] charsToTrim = { ',', ' ' }; // трием  ", " след последния concat
                    Console.WriteLine(mirroredWords.TrimEnd(charsToTrim));
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }


        }
        public static string ReverseString(string wordToReverse)
        {
            return new string(wordToReverse.Reverse().ToArray());
        }
    }
}
