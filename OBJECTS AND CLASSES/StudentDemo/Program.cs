using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student pesho = new Student();
            //pesho.name = "Pesho";
            //pesho.age = 15;
            //pesho.skills = new string[] { "nishto", "i", "poluvina" };

            //Student gosho = new Student();
            //gosho.name = "Georgi";
            //gosho.age = 16;
            //gosho.skills = new string[0];

            //PrintStudent(pesho);
            //PrintStudent(gosho);

            Console.WriteLine("How many students in softuni???");
            int number = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < number; i++)
            {
                students.Add(ReadStudent());
            }
            for (int i = 0; i < number; i++)
            {
                PrintStudent(students[i]);
            }

            
            static Student ReadStudent()
            {
                Student newStudent = new Student();
                Console.WriteLine("Enter name: ");
                newStudent.name = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                newStudent.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter skills: ");
                newStudent.skills = Console.ReadLine().Split();

                return newStudent;
            }
           static void PrintStudent(Student student)
            {

                Console.WriteLine($"Student name ->{student.name} ->age ->{student.age} -> skills ->{string.Join(" ",student.skills)}");
            }
        }
    }
}
