using System;

namespace _27VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            double totalMoney = 0;
            while (input != "Start")
            {
                double currentCoins = double.Parse(input);

                if (currentCoins == 0.1 || currentCoins == 0.2 || currentCoins == 0.5 ||
                        currentCoins == 1 || currentCoins == 2)
                {
                    totalMoney += currentCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoins}");
                }

                input = Console.ReadLine();
            }
            //презаписваме нов инпут
            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        if (totalMoney >= 2)
                        {
                            totalMoney -= 2;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalMoney >= 0.7)
                        {
                            totalMoney -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney >= 1.5)
                        {
                            totalMoney -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalMoney >= 0.8)
                        {
                            totalMoney -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalMoney >= 1)
                        {
                            totalMoney -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");


        }
    }
}