using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
         //MathesDatesSeparat   //13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
            //Day: 13, Month: Jul, Year: 1928  ; Day: 10, Month: Nov, Year: 1934 ;Day: 25, Month: Dec, Year: 1937
            MatchCollection dates=
                Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-za-z]{3})\k<separator>(?<year>[0-9]{4})");
            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value},Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
