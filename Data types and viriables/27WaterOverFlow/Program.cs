﻿using System;
using System.Runtime.CompilerServices;

namespace _27WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

             
            int totalLiters = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters + totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {

                    totalLiters += liters;

                }

            }
            Console.WriteLine(totalLiters);
        }
    }
}
