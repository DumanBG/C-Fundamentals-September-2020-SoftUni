using System;
using System.Linq;

namespace _23ZigZagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] first = new string[n];
            string[] second = new string[n];

            bool  flag = true;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (flag)
                {
                    first[0+i] = input[0];
                    second[0 + i] = input[1];
                    flag = false;
                }
                else
                {
                    second[0 + i] = input[0];
                    first[0 + i] = input[1];
                    flag = true;
                }

            }
            Console.WriteLine(String.Join(" ",first));
            Console.WriteLine(String.Join(" ",second));
        }
    }
}
