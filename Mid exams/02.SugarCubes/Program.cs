using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();
        
        while(input!= "Mort")
            {
                string[] command = input.Split(" ");
                string firstCommand = command[0];
                if (firstCommand == "Add")
                {
                    theList.Add(int.Parse(command[1]));
                }
                else if (firstCommand == "Remove")
                {
                    if (theList.Contains(int.Parse(command[1])))
                    {
                        theList.Remove(int.Parse(command[1]));

                    }
                }
                else if (firstCommand == "Replace")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);
                    int index = theList.IndexOf(firstNumber);
                    theList[index] = secondNumber;

                }
                else if (firstCommand == "Collapse")
                {
                    int collapsedNumber = int.Parse(command[1]);
                    for (int i = 0; i < theList.Count; i++)
                    {
                        if (theList[i] < collapsedNumber)
                        {
                            theList.RemoveAt(i);
                            i = -1;
                        }


                    }
                }



                    input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",theList));
        
        
        }
    }
}
