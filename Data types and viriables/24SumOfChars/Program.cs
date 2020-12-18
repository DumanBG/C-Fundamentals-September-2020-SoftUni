using System;

namespace _24SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
