using System;
using System.Linq;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());


            Console.WriteLine(FindSmallestNumber(first,second,third));
        }
      
       public static double FindSmallestNumber(double first, double second, double third)
        {
            double[] numbers = new[] { first, second, third };
            double min = numbers.Min();

            return min;
        }

    }
}
