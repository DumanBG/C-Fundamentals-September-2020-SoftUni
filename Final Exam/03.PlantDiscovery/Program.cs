using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plantsDict = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = text[0];
                double rarity = double.Parse(text[1]);
                // "{plant}<->{rarity}".  //   Arnoldii<->4
                if (!plantsDict.ContainsKey(plantName))
                {


                    plantsDict.Add(plantName, new List<double> { rarity });
                }
                else
                {
                    plantsDict[plantName][0] = rarity;
                    plantsDict[plantName][1] = 0.0;

                }
            }
            string input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] tokens = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                //•	Rate: {plant} - {rating} 
                string command = tokens[0];
                string plant = tokens[1];
                switch (command)
                {
                    case "Rate":
                        //   Rate: Woodii - 10   //•	Rate: {plant} - {rating} – add the given rating to the plant (store all ratings)
                        double rating = double.Parse(tokens[2]);
                        if (!plantsDict.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plantsDict[plant][1]+=rating;
                        }
                        break;
                    case "Update":
                        //Update: {plant} - {new_rarity} – update the rarity of the plant with the new one //Update: Woodii - 5
                        double newRarity = double.Parse(tokens[2]);
                        if (!plantsDict.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plantsDict[plant][0] = newRarity;
                        }

                        break;

                    case "Reset":
                        //Reset: { plant} – remove all the ratings of the given plant //Reset: Arnoldii
                        if (!plantsDict.ContainsKey(plant))
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            plantsDict[plant][1] = 0.00;
                        }

                        break;
                }
                input = Console.ReadLine();

            }
            //Plants for the exhibition:  // - Woodii; Rarity: 5; Rating: 7.50
            plantsDict = plantsDict.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantsDict)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]:F0}; Rating: { plant.Value[1]:F2}");
            }

        }
    }
}
