using System;

namespace _1.MyFirst
{
    class Program
    {
        static void Main(string[] args)
        {
          {
            string message = Console.ReadLine();
            string input = Console.ReadLine();
 
            while (input != "Finish")
            {
                string[] cmdArg = input.Split(" ");
                string command = cmdArg[0];
 
                if (command == "Replace")
                {
                    char currentChar = char.Parse(cmdArg[1]);
                    char newChar = char.Parse(cmdArg[2]);
                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
 
                    if (startIndex >= 0 && startIndex <= message.Length - 1 && endIndex >= 0 && endIndex <= message.Length - 1)
                    {
                        string sub = message.Substring(startIndex, endIndex - startIndex + 1);
                        message = message.Replace(sub, "");
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
 
                }
                else if (command == "Make")
                {
                    if (cmdArg[1] == "Upper")
                    {
                        message = message.ToUpper();
                        Console.WriteLine(message);
                    }
                    else if (cmdArg[1] == "Lower")
                    {
                        message = message.ToLower();
                        Console.WriteLine(message);
                    }
                }
                else if (command == "Check")
                {
                    string msgString = cmdArg[1];
                    if (message.Contains(msgString))
                    {
                        Console.WriteLine($"Message contains {msgString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {msgString}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
 
                    if (startIndex >= 0 && startIndex <= message.Length - 1 && endIndex >= 0 && endIndex <= message.Length - 1)
                    {
                        int sum = 0;
                        string sub = message.Substring(startIndex, endIndex - startIndex + 1);
                        sub.ToCharArray();
 
                        for (int i = 0; i < sub.Length; i++)
                        {
                            sum += sub[i];
                        }
                        Console.WriteLine(sum);                     
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
 
                }
                input = Console.ReadLine();
            }
        }
    }
}
        }
    }
}
