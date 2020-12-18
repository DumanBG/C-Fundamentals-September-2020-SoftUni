using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrickFirstPlusLastSecondPlusLastMinusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1 2 3 4 5 събираме първи и с последни = 6 6 3
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ",SumPairs(list)));

            static List<int> SumPairs(List<int> numbers)
            {
                List<int> result = new List<int>();

                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
                }
                if(numbers.Count %2 !=0)
                {
                    result.Add(numbers[numbers.Count / 2]);
                }

                return result;

            }
        }
    }
}
