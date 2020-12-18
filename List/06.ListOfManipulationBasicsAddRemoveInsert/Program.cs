using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _06.ListOfManipulationBasicsAddRemoveInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] operation = command.Split(" ");
              
                if(operation[0]== "Add")
                {

                    list.Add(int.Parse(operation[1]));
                }
               else if(operation[0] == "Remove")
                {

                    list.Remove((int.Parse(operation[1])));
                }
                else if(operation[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(operation[1]));              
                }
                else if(operation[0] == "Insert")
                {
                    list.Insert((int.Parse(operation[2])),(int.Parse(operation[1])));
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",list));
        
        }
    }
}
