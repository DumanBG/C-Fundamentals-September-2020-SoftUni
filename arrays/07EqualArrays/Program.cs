using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrFirst = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] arrSecond = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            bool equal = true;

            for (int i = 0; i < arrFirst.Length; i++)
            {
                if (arrFirst[i] != arrSecond[i])

                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    equal = false;
                    break;
                }
                else
                {
                    sum += arrFirst[i];

                }
            }
            if (equal)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
        }
    }
}
