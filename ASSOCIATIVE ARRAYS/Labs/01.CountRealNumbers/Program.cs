﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Колко пъти се среща нещо някъде
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            SortedDictionary<double, int> sortedDictionary = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (sortedDictionary.ContainsKey(number))
                {
                    sortedDictionary[number]++; // doba

                }
                else
                {

                    sortedDictionary.Add(number, 1);

                }
            }
                foreach (var pair in sortedDictionary)
                {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");

                }



            }
        }
    }

