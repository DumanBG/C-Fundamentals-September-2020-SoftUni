using System;

namespace _22SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < input.Length ; i++)
            {
                int currentNumber = (int)Char.GetNumericValue(input[i]);
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
