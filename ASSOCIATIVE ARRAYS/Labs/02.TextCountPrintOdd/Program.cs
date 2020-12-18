using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TextCountPrintOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (counts.ContainsKey(wordInLowerCase))
                {
                    counts[wordInLowerCase]++;

                }
                else
                {
                    counts.Add(wordInLowerCase, 1);

                }
            }
            foreach(var count in counts)
            {
                if(count.Value % 2 !=0)
                {
                    Console.Write(count.Key +" ");

                }

            }
        }
    }
}
