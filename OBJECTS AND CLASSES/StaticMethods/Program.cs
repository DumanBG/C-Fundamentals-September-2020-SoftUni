using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student peshotoStudent = new Student()
            {
                Name = "pesho",
                Age = 10,
                Skills = new string[0]
            };


            Student peshoStudent = Student.ReadStudent();


            peshoStudent.AgeStudent();
               Student.PrintStudents(peshoStudent); //  когато метода е статик няма нужда да се инстанцира, може върху класа, не може да се ползва this
        }
    }
}
