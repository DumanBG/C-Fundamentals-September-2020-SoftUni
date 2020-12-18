using System;

namespace _10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int i = multiplier;

            do
            {






                Console.WriteLine($"{integer} X {i} = {integer * i}");
                i++;

            } while (i <= 10);

 
        }
    }
}
