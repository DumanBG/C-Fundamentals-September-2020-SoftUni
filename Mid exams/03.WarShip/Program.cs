using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int maximumHealth = int.Parse(Console.ReadLine());
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] input = command.Split();
                switch (input[0])
                {
                    case "Fire":
                        int index = int.Parse(input[1]);
                        int damage = int.Parse(input[2]);
                        if (index < warShip.Count && index >= 0)
                        {
                            warShip[index] -= damage;
                            if (warShip[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        int damageD = int.Parse(input[3]);
                        for (int i = startIndex; i <= endIndex; i++)
                            if (i >= 0 && i < pirateShip.Count)
                            {
                                pirateShip[i] -= damageD;
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        break;
                    case "Repair":
                        int indexR = int.Parse(input[1]);
                        int health = int.Parse(input[2]);
                        if (indexR < pirateShip.Count && indexR >= 0
                            && health <= maximumHealth)
                            pirateShip[indexR] += health;
                        break;
                    case "Status":
                        int counter = 0;
                        foreach (int section in pirateShip)
                            if (section < 0.20 * maximumHealth) counter++;
                        Console.WriteLine($"{counter} sections need repair.");
                        break;
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}