using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();



            string input = Console.ReadLine();
            //Hawai::Cyprys-Greece
            while (input != "Travel")
            {
                string[] token = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                //Add Stop:7:Rome Switch:Hawai:Bulgaria
                string command = token[0];

                switch (command)
                {
                    case "Add Stop":
                        //•	Add Stop:{index}:{string} 
                        int index = int.Parse(token[1]);
                        string textToInsert = token[2];

                        if (index >= 0 && index < destinations.Length)
                        {
                            destinations = destinations.Insert(index, textToInsert);
                        }

                        Console.WriteLine(destinations);
                        break;
                    case "Remove Stop":
                        //Remove Stop:11:16 //•	Remove Stop:{start_index}:{end_index} 
                        int startIndex = int.Parse(token[1]);
                        int endIndex = int.Parse(token[2]);
                        if (startIndex >= 0 && startIndex < destinations.Length
                            && endIndex >= 0  && endIndex < destinations.Length)
                        {
                            destinations = destinations.Remove(startIndex, endIndex - startIndex +1); 
                            // още едно добавяме защото е включително

                        }

                        Console.WriteLine(destinations);
                        break;

                    case "Switch":
                        //•	Switch:{old_string}:{new_string}  //Switch:Hawai:Bulgaria
                        string oldString = token[1];
                        string newString = token[2];
                        if (destinations.Contains(oldString))
                        {
                            destinations = destinations.Replace(oldString, newString);


                        }
                        Console.WriteLine(destinations);
                        break;

                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");


        }
    }
}
