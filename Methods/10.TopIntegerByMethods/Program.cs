using System;

namespace _10.TopIntegerByMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if(DivisionByEight(i) && MoreThanOneDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

            bool sumOfDigitsDivionByEight = DivisionByEight(number);
            bool haveMoreThenOneOddDigit = MoreThanOneDigit(number);
        }

        private static bool MoreThanOneDigit(int number)
        {
            bool odd = false;
            while(number >0)
            {
              if(number%2!=0)
                {
                    odd = true;
                    break;
                }
                else
                {
                    number /= 10;
                }
            }
            if(odd)
            {
                return true;
            }

            return false;
        }

        private static bool DivisionByEight(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if(sum % 8 == 0)
            {
                return true;
            }
            return false;
        }



    }
}
