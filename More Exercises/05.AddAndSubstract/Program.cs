using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());


            int add = Sum(first, second);
            int substract = Substract(add, third);

            Console.WriteLine(substract);
        }

        private static int Substract(int add, int third)
        {
            return add - third;
        }

        private static int Sum(int first, int second)
        {

            return first + second;
        }

    }
}
