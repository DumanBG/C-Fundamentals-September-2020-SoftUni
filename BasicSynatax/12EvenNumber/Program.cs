using System;

namespace _12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());


            bool evenOrNo = false;

            while (!evenOrNo)
            {
                if (input%2 != 0 || input == 0)
                {
                    Console.WriteLine("Please write an even number.");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    input = Math.Abs(input);
                    Console.WriteLine($"The number is: {input}");
                    evenOrNo = true;
                }

            }
        }
    }
}
