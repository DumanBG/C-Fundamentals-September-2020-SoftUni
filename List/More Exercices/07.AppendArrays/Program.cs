using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {




            List<string> items = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            items.Reverse();
            List<string> result = new List<string>();

            foreach (string currentItem in items)
            {
                string[] numbers = currentItem.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (string numberToAdd in numbers)
                {
                    result.Add(numberToAdd);
                }

            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
