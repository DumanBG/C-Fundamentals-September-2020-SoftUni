using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortDict = new SortedDictionary <string, double>();

            sortDict.Add("Desi", 6);
            sortDict.Add("Teodor", 5);
            sortDict.Add("Alex", 3);

            foreach(var pair in sortDict) // принт на целия сортед диктонари
            {
                //{ime} ->{ocenka}
                if(pair.Value %2 ==0)]
                    {
                Console.WriteLine(pair.Key + " -> " +pair.Value); //
                }
            }


             // сортиране на числа във Valio на Dictionary
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            dict.Add("one", new List<int>() { 2, 3, 6, 7 });
            dict.Add("three", new List<int>() { 1, 3, 6, 7 });
            dict.Add("two", new List<int>() { 12, 1, 4, 7 });
            dict.Add("six", new List<int>() { 9, 3, 6, 8 });
            dict["two"] = dict["2"].OrderBy(x => x).ToList(); //сортиране числа, може и  .Sort

            //Прехвърляне на List към Dictionary i golemini
            List<string> theWords = new List<string>() { "pesho", "abc", "gosho" };
            Dictionary < string, int> wordsAsDictt = theWords.ToDictionary(a => a +"op", b => b.Length);
            foreach (var word in wordsAsDictt)
            {
                Console.WriteLine($"{word.Key}:{String.Join(" ",word.Value)}");
            }
        }
    }
}
