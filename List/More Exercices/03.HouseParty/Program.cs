using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();


            for (int i = 0; i < number; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ");
                string guestName = cmdArgs[0];
                if (cmdArgs.Length > 3)
                {
                    if (guest.Contains(guestName))
                    {
                        guest.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }

                }
                else
                {
                    if (!guest.Contains(guestName))
                    {
                        guest.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guest));



        }
    }
}
