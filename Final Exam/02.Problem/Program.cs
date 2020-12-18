using System;
using System.Text.RegularExpressions;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           // string pattern = @"(U\$)([A-Z][a-z]{2,})\1(P@\$)([A-Za-z]{5,}[0-9]+)\3";
            Regex regex = new Regex(@"(U\$)([A-Z][a-z]{2,})\1(P@\$)([A-Za-z]{5,}[0-9]+)\3");
            int successReg = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
                if(matches.Count ==1)
                {
                    foreach (Match match in matches)
                    {
                        Console.WriteLine("Registration was Successful");
                        Console.WriteLine($"Username: {match.Groups[2].Value}, Password: {match.Groups[5].Value}");
                        }
                    successReg++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine(successReg);
        }
    }
}
