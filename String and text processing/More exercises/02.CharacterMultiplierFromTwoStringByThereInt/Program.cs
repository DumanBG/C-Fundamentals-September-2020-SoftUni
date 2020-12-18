using System;
using System.Security.Cryptography.X509Certificates;

namespace _02.CharacterMultiplierFromTwoStringByThereInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstWord = tokens[0];
            string secondWord = tokens[1];

            var longestWord = firstWord;
            var shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;

            }
            var total = CharMultiplier(longestWord, shortestWord);
            Console.WriteLine(total);
        }


           public  static long CharMultiplier (string longestWord, string shortestWord)
            {
            long result = 0;
            for (int i = 0; i < shortestWord.Length; i++)
            {
                var multiplier = longestWord[i] * shortestWord[i];
                result += multiplier;
            }
            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                result += longestWord[i];
            }


                return result;
            }

        }
    }
