using System;
using System.Collections.Generic;
using System.Linq;

namespace Landa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 4, 5, 6 };
            numbers = numbers.Select(xNumber => xNumber * 5).ToList();

            static int multiply(int mNumber)
            {
                return mNumber * 5;
            }
            //или  с методи в ланда metodi v Select
            numbers = numbers.Select(mNumber => multiply(mNumber)).ToList();

            List<int> oddNumbers = numbers.Select(number =>
            {
                if (number % 2 == 1)
                {
                    return number * 2;
                }
                return number;
            }
                ).ToList();

           
        }

    }
}


