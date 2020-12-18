using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativeAndReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            List<int> newList = new List<int>();

            list.RemoveAll(x => x < 0);
            list.Reverse();

            if (list.Count > 0) 
            { 
            Console.WriteLine(String.Join(" ",list));
            }
            else
            {
                Console.WriteLine("empty");
            }
            }
        }
    }
