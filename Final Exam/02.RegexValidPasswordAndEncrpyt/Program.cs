using System;
using System.Text.RegularExpressions;

namespace _02.RegexValidPasswordAndEncrpyt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


         //   Regex regex = new Regex(@"(.*)>([0-9]){3}\|([a-z]){3}\|([A-Z]){3}\|([^<>]){3}<\1$"); // моя
            //  Работещ патерн // 
              Regex regex = new Regex(@"(.*)([>]{1})(?<password>(\d{3})|([a-z]{3})|([A-Z]{3})|([^<>]+))([<])\1$"); //твоя патерн
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);
                if (match.Success)
                {

                    string pass = match.Groups["password"].Value.Replace("|", "");
                        Console.WriteLine(pass);

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}