using System;

namespace _01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //abcdefghijklmnopqrstuvwxyz

            string activationKey = Console.ReadLine();  // Letters and digits only

            string input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] tokens = input.Split(">>>");
                string cmdToDo = tokens[0];

                if (cmdToDo == "Contains") //Contains>>>def
                {
                    if (activationKey.IndexOf(tokens[1]) != -1)
                    {
                        Console.WriteLine($"{activationKey} contains {tokens[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }


                else if (cmdToDo == "Flip")  //Flip>>>Upper>>>3>>>14
                {
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    string firstPart = activationKey.Substring(0, startIndex); //Така се взима първата част
                    string secondPart = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();  //Така се намира дължина и предварително си го ъпваме
                    string thirdPart = activationKey.Substring(endIndex);
                    if (tokens[1] == "Upper")
                    {
                        secondPart = secondPart.ToUpper();

                    }
                    else if (tokens[1] == "Lower")
                    {
                        secondPart = secondPart.ToLower();
                    }
                    activationKey = firstPart + secondPart + thirdPart;
                    Console.WriteLine(activationKey);


                }
                else if (cmdToDo == "Slice")  //Slice>>>2>>>6
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);

                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
