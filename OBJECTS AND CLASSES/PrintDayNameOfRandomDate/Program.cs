using System;
using System.Globalization;

namespace PrintDayNameOfRandomDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy",CultureInfo.InvariantCulture); // d day M month yyyy year, H hour, mm -minute, ss second
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
