﻿using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, count));

        }
        private static string RepeatString(string str, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += str;
            }


            return result;
        }

    }
}
