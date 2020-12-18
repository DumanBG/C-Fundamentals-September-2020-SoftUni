﻿using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\B%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            double totalIncome = 0;
            while(input != "end of shift")
            {
                Match match = regex.Match(input);

                if(match.Success)
                {
                    //customer, product, count and a price:
                    string customerName = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int qunatity = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    double totalPriceOfProduct = qunatity * price;
                   
                    totalIncome += totalPriceOfProduct;
                  
                    Console.WriteLine($"{customerName}: {product} - {totalPriceOfProduct:F2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
