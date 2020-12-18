using System;

namespace _01SignOfIntegerNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SighOfIntegerNumbers(number);
        }



            static void SighOfIntegerNumbers(int number)
            {
                if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");

                }
                else
                {
                    Console.WriteLine($"The number {number} is zero.");
                }
            }
         
        }
    }

