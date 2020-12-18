using System;
using System.Text.RegularExpressions;

namespace _02.RegexValidMsg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //  string pattern = @"\B([\$|%])([A-Z][a-z]{2,})\1:\s{1}\[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$";
            Regex regex = new Regex(@"([\$|%])([A-Z][a-z]{2,})\1:\s{1}\[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|");


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = regex.Matches(input);
                if (matches.Count == 1)
                {
                    string firstName = "";
                    foreach (Match match in matches)
                    {
                        firstName = match.Groups[1].Value + match.Groups[2].Value + match.Groups[1].Value + ":";
                        string firstChar = match.Groups[3].Value;
                        int firstNumber = int.Parse(firstChar);
                        char first = (char)firstNumber;
                       string secondtChar = match.Groups[4].Value;
                        int secondNumber = int.Parse(secondtChar);
                        char second = (char)secondNumber;
                        string thirdChar = match.Groups[5].Value;
                        int thirdNumber = int.Parse(thirdChar);
                        char third = (char)thirdNumber;

                        // Console.WriteLine(decryptedName);
                        //Console.WriteLine(firstName +" ");

                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}