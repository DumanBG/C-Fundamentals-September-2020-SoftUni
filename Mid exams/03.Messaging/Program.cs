using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(" ");
                string firstCommand = command[0];
                string secondCommand = command[1];

                if (firstCommand == "Chat")
                {
                    list.Add(secondCommand);
                }
                else if (firstCommand == "Delete")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);

                    }
                }
                else if (firstCommand == "Edit")
                {

                    if (list.Contains(command[1]))
                    {
                        int index = list.IndexOf(command[1]);

                        list[index] = command[2];
                    }
                }
                else if (firstCommand == "Pin")
                {
                    string current = command[1];
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);
                        list.Add(current);

                    }
                }
                else if (firstCommand == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        list.Add(command[i]);
                    }

                }
             //   Console.WriteLine(string.Join(" ", list));
                input = Console.ReadLine();
              
                if (list.Contains("Chat"))
                    {
                    list.Remove("Chat");
                }
                }
             Console.WriteLine(String.Join(Environment.NewLine, list));
           // Console.WriteLine(string.Join(" ",list));
            }

        }
    }
