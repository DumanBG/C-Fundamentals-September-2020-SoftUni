using System;
using System.Linq;

namespace _03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();


                for (int i = 0; i <array.Length; i++)
                {


                    var curentElement = array[i];
                   array[i] = (int)Math.Round(array[i],MidpointRounding.AwayFromZero);
                        if(array[i] == 0)
                {
                    curentElement = 0;
                }

                   Console.WriteLine($"{curentElement} => {array[i]}");

                }
            }
        }
    }
