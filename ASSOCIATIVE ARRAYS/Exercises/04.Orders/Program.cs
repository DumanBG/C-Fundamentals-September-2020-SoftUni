using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while(command != "buy")
            {
                string[] currentProduct = command.Split();
                string productName = currentProduct[0];
                double productPrice = double.Parse(currentProduct[1]);
                double quantity = double.Parse(currentProduct[2]);

                if(!output.ContainsKey(productName))
                {
                    List<double> priceAndQuantity = new List<double> { productPrice, quantity };

                    output.Add(productName, priceAndQuantity);



                }
                else
                {
                    output[productName][0] = productPrice;
                    output[productName][1] += quantity;
                }






                command = Console.ReadLine();
            }
            foreach (var item in output)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
            }
        }
    }
}
