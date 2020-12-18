using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    // 40 oт 100
        class Program
        {
            static void Main(string[] args)
            {
                Dictionary<string, int> keyMatirial = new Dictionary<string, int>();
                Dictionary<string, int> junkMatirial = new Dictionary<string, int>();

                keyMatirial["shards"] = 0;
                keyMatirial["motes"] = 0;
                keyMatirial["fragments"] = 0;
                bool hasToBreak = false;
                while (true)
                {
                    string[] input = Console.ReadLine().Split();

                    for (int i = 0; i < input.Length; i += 2)
                    {
                        int quantity = int.Parse(input[i]);
                        string material = input[i + 1].ToLower();

                        if (material == "shards" || material == "motes" || material == "fragments")
                        {
                            keyMatirial[material] += quantity;

                            if (keyMatirial[material] >= 250)
                            {
                                keyMatirial[material] -= 250;

                                if (material == "shards")
                                {
                                    Console.WriteLine($"Shadowmourne obtained!");
                                }
                                else if (material == "motes")
                                {
                                    Console.WriteLine($"Dragonwrath obtained!");
                                }
                                else if (material == "fragments")
                                {
                                    Console.WriteLine($"Valanyr obtained!");
                                }

                                hasToBreak = true;
                                break;
                            }
                        }
                        else
                        {
                            if (!junkMatirial.ContainsKey(material))
                            {
                                junkMatirial.Add(material, 0);
                            }

                            junkMatirial[material] += quantity;
                        }
                    }

                    if (hasToBreak)
                    {
                        break;
                    }
                }

                Dictionary<string, int> filteredKeyMatirials = keyMatirial
                    .OrderByDescending(v => v.Value)
                    .ThenBy(k => k.Key)
                    .ToDictionary(a => a.Key, a => a.Value);

                foreach (var kvp in filteredKeyMatirials)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }

                foreach (var kvp in junkMatirial.OrderBy(k => k.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }