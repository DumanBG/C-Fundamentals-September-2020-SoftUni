using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());

            if (gradeInput >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
