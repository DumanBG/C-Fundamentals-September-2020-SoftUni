using System;
using System.Collections.Generic;

namespace _04.ListOfProductsAndSortThem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string product = Console.ReadLine();
                productList.Add(product);

            }
            productList.Sort();
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{productList[i]}");
            }
        }
    }
}
