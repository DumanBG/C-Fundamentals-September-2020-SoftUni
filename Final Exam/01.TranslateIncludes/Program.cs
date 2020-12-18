using System;

namespace _01.TranslateIncludes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while(input !="End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                switch(command)
                {
                    case "Translate":
                        string findChar = tokens[1];
                        string replaceCharWith = tokens[2];

                        break;
                    case "Includes":

                        break;
                    case "Start":

                        break;
                    case "Lowercase":

                        break;
                    case "FindIndex":

                        break;
                    case "Remove":

                        break;




                }


            }
        }
    }
}
