using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] token = command.Split(" ");
                string firstCommand = token[0];
                int element = int.Parse(token[1]);
                
                if(token[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if(token[0]=="Insert")
                    {
                    int index = int.Parse(token[2]);
                    numbers.Insert(index, element);

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
