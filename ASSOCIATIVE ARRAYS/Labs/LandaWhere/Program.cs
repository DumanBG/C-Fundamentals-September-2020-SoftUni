using System;
using System.Collections.Generic;
using System.Linq;

namespace LandaWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 4, 5, 6, 7, };
            List<int> EvenNumbers = numbers.Where(number => number % 2 == 0)
                 .Where(number => number % 10 == 3).ToList();
            Console.WriteLine(string.Join(" ",EvenNumbers));
        }
    }
}
