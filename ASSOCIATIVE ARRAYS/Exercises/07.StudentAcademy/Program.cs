using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine()); // брой ученици

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name)) // ako go nqma
                {
                    studentGrades.Add(name, new List<double>());
                    studentGrades[name].Add(grade);

                }
                else // ako go ima
                {
                    studentGrades[name].Add(grade);
                }

            }

            // преобразуване -. лист с оценнки в   име -> средна оценка нов речник

            var averageResult = new Dictionary<string, double>();

            foreach (var pair in studentGrades)
            {
                averageResult.Add(pair.Key, pair.Value.Average());


            }
            //1. iskame da firltrirame i vze,mem  vsi4ki s na4 4.5
            //2. sortirame po sr. ocenka

            foreach (var pair in averageResult
                .Where(student => student.Value >= 4.50)
                .OrderByDescending(st => st.Value))
            {


                Console.WriteLine($"{ pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
