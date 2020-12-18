using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _04.OrdersByClassAndObectsAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }
                // Beer 2.20 100"
                string[] splittedInput = input.Split(); //"Beer", 2.20, 100
                string name = splittedInput[0];
                double price = double.Parse(splittedInput[1]); //"2.20 ->2.20
                int quantity = int.Parse(splittedInput[2]); // "100" -> 100

                Product product = new Product(name, price, quantity);
                //да имаме продукта в речника
                // да нямаме продукта в речника

                if (!products.ContainsKey(name))
                {

                    products.Add(name, product);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                    //обект, който има име, цена и количество вече
                }
            }
            foreach (var pair in products)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:F2}");
            }
        }

            class Product
        {
            string name;
            double price;
            int quantity;


            public Product(string name, double price, int quantity)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
            }
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }
            public int Quantity
            {
                get
                {
                    return quantity;
                }
                set
                {
                    quantity = value;
                }
            }

        }
    }
}
