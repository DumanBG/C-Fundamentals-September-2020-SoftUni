using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PiratesSailTwoTimesWhileInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> listCity = new Dictionary<string, List<int>>();


            while (input != "Sail")
            {
                //Tortuga||345000||1250
                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0];
                int populations = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (!listCity.ContainsKey(city))
                {
                    listCity.Add(city, new List<int> { populations, gold });


                }
                else
                {
                    listCity[city][0] += populations;
                    listCity[city][1] += gold;

                }
                //Console.WriteLine(listCity[city][0]);
                //Console.WriteLine(listCity[city][1]);



                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cmdArg = tokens[0];
                string city = tokens[1];

                if (cmdArg == "Plunder")
                //Plunder=>{town}=>{people}=>{gold}"
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    if (listCity.ContainsKey(city))
                    {
                        listCity[city][0] -= people;
                        listCity[city][1] -= gold;
                        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                        if (listCity[city][0] <= 0 || listCity[city][1] <= 0)
                        {
                            Console.WriteLine($"{city} has been wiped off the map!");
                             listCity.Remove(city);
                        }

                    }

                }
                if (cmdArg == "Prosper")
                //Prosper=>Santo Domingo=>180
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");

                    }
                    else
                    {
                        listCity[city][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {listCity[city][1]} gold.");
                    }
                }

                input = Console.ReadLine();
            }
            
            if (listCity.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {listCity.Count} wealthy settlements to go to:");
                listCity = listCity.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                foreach (var item in listCity)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

    }
}
