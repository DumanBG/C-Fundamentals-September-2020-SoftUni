using System;
using System.Dynamic;

namespace _09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOddNumbers = int.Parse(Console.ReadLine());

            int sum = 0;
            int OddNumber = 0;
            for (int i = 1; i <= numberOddNumbers; i++)
            {
                OddNumber = i * 2 - 1;
                Console.WriteLine(OddNumber);
                sum += numberOddNumbers;
            }
           

            Console.WriteLine($"Sum: {sum}");
        }
        }
    }

