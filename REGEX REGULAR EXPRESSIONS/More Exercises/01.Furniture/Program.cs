using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Z]+[A-Za-z]+)<<([0-9]+\.?[0-9]*)!([0-9]+)";
            var regex = new Regex(pattern);
            string input = Console.ReadLine();

            double sum = 0;
            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                // >> Sofa << 312.23!3
                //  >> TV << 300.21!5
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    Console.WriteLine(name);
                    sum += (price * quantity);

                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
