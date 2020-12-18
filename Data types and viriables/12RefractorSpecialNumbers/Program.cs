using System;

namespace _12RefractorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int curentNumber = 0;
            bool specialOrNo = false;
            for (int i = 1; i <= number; i++)
            {
                curentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                specialOrNo = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", curentNumber, specialOrNo);
                sum = 0;
                i = curentNumber;
            }

        }
    }
}
