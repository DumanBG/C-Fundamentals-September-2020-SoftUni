using System;

namespace MultiplicationTableTwo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{integer} X {i} = {integer * i}");

            }
        }
    }
}
