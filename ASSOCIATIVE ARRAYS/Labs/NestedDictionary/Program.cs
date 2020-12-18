using System;
using System.Collections.Generic;

namespace NestedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
            string[] studentsNames =Console.ReadLine().Split();
            // Pesho Tosho Ivan Mitko
            foreach (var item in studentsNames)
            {
                students.Add(item, new Dictionary<string, int>());
            } // dobavqne nested dict predmet i ocenka na vseki student
            students["Pesho"].Add("Biologia", 4);
            students["Tosho"].Add("History", 6);
            students["Tosho"].Add("Biologia", 6);
            students["Ivan"].Add("Himia", 3);
            //print na vseki  student posle ot nested predmet i ocenka na vseki
            foreach (var student in students)
            {
                Console.WriteLine($"{ student.Key} -->");
                foreach (var grades in student.Value)
                {
                    Console.WriteLine($"{grades.Key}:{grades.Value}");
                }
            }
        }
    }
}
