using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter years");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter skills");
            //string[] skills = Console.ReadLine().Split();
            //PrintStudent(name, age, skills);

        }
        public static void PrintStudent (string name, int age, string[] skills)
        {
            Console.WriteLine
                ($"Student name ->{name}; age -> {age}; skills -> {string.Join(" ",skills)}");
        }
    }
}
