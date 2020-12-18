using System;
using System.Linq;

namespace _25TopIntegerRigh
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

          
            
            for (int i = 0; i < array.Length; i++)
            {
               bool bigInt = true;
                int current = array[i];

                for (int j = i+1; j < array.Length; j++)
                {
                    if(current <= array[j])
                    {
                        bigInt = false;
                        break;

                    }
                }
                if (bigInt)
                {
                    Console.Write($"{current} ");
                }
            }

        }
    }
}
