using System;

namespace AnonymousObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new { name = "Pesho", age = 15, skills = new string[0] };
            Console.WriteLine(student.name);

            var birthday = new Birthday() { Day = 22, Month = 6, Year = 1990 }; // byrzo nalivane na danni s {}

            birthday.Day = 22;
            Console.WriteLine(birthday.Day);
        }


        public class Birthday
        {
           public  int Day;
            public  int Month;
           public  int Year;
        }
    }
}
