using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Dictionary<string, List<string>> wordsSynonyms = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms[word].Add(synonym);

                }
                else
                {
                    wordsSynonyms.Add(word, new List<string>());
                    wordsSynonyms[word].Add(synonym);
                }
            }

            foreach (var pair in wordsSynonyms)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");

            }
        }
    }
}
