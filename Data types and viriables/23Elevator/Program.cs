using System;

namespace _23Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int pCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)nPeople / pCapacity);


            Console.WriteLine(courses);

        }
    }
}
