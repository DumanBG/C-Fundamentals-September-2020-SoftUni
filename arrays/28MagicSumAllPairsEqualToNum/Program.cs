using System;
using System.Linq;

namespace _28MagicSumAllPairsEqualToNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                int firstNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int secondNumber = array[j];

                if (num == firstNumber + secondNumber)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");

                        break;
                    }
                }

            }
        }
    }
}

