using System;
using System.Text.RegularExpressions;

namespace _02.NewSecondProblem

{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string pattern = @"(.*)([\>]{1})(?<password>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]+))([<])\1$";




            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match matches = regex.Match(input);

                if (matches.Success)
                {

                    string pass = matches.Groups["password"].Value.Replace("|", "");

                    Console.WriteLine($"Password: {pass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}