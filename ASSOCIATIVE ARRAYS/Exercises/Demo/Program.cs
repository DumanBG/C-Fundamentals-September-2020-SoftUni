using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> persons = new Dictionary<string, int>();

            persons.Add("Petar", 5);
            persons.Add("Petq", 15);
            persons.Add("Stamat", 11);
            persons.Add("Ivan", 12);
            persons.Add("Petra",10);

            Console.WriteLine(string.Join(" ",persons));
        }
    }
}
