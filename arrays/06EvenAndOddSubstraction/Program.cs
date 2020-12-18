﻿using System;
using System.Linq;

namespace _06EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sumOfSubstraction = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumOfSubstraction += arr[i];

                }
                else
                {
                    sumOfSubstraction -= arr[i];
                }


            }
            Console.WriteLine(sumOfSubstraction);
        }
    }
}
