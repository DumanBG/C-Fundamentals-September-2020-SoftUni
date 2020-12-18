using System;

namespace _04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            string format = " ";
            format = string.Format($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

            Console.WriteLine(format);




        }
    }
}
