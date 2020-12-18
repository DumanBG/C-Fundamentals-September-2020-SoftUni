using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> theHeores = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] heroes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // Solmyr 85 120    Kyrre 99 50
                string name = heroes[0];
                int hp = int.Parse(heroes[1]);
                int mp = int.Parse(heroes[2]);

                //{hero name} {HP} {MP}     //-	a hero can have a maximum of 100 HP and 200 MP

                theHeores.Add(name, new int[] { hp, mp });
                //theHeores.Add(name, new List<int> { hp, mp });
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string currentHero = tokens[1];

                switch (command)
                {
                    case "CastSpell":
                        // CastSpell - Kyrre - 15 - ViewEarth
                        int manaNeed = int.Parse(tokens[2]);
                        string spellName = tokens[3];
                        if (theHeores[currentHero][1] >= manaNeed)
                        {
                            theHeores[currentHero][1] -= manaNeed;

                            Console.WriteLine($"{currentHero} has successfully cast {spellName} and now has {theHeores[currentHero][1]} MP!");

                        }
                        else
                        {
                            Console.WriteLine($"{currentHero} does not have enough MP to cast {spellName}!");
                        }

                        break;
                    case "Recharge":
                        // Recharge - Solmyr - 50
                        int manaRecharge = int.Parse(tokens[2]);
                        int currentMana = theHeores[currentHero][1];
                        if (theHeores[currentHero][1] + manaRecharge > 200)
                        {
                            theHeores[currentHero][1] = 200;
                        }
                        else
                        {
                            theHeores[currentHero][1] += manaRecharge;
                        }
                        Console.WriteLine($"{currentHero} recharged for {theHeores[currentHero][1] - currentMana} MP!");
                        break;
                    case "Heal":
                        //  Heal - Solmyr - 10
                        int currentHp = theHeores[currentHero][0];
                        int hpHeal = int.Parse(tokens[2]);

                        if (currentHp + hpHeal > 100)
                        {
                            theHeores[currentHero][0] = 100;
                        }
                        else
                        {
                            theHeores[currentHero][0] += hpHeal;
                        }
                        Console.WriteLine($"{currentHero} healed for {theHeores[currentHero][0] - currentHp} HP!");

                        break;
                    case "TakeDamage":
                        //TakeDamage - Kyrre - 66 - Orc
                        int dmgTaken = int.Parse(tokens[2]);
                        string attacker = tokens[3];
                        if (theHeores[currentHero][0] - dmgTaken <= 0)
                        {
                            Console.WriteLine($"{currentHero} has been killed by {attacker}!");
                            theHeores.Remove(currentHero);
                        }
                        else
                        {
                            theHeores[currentHero][0] -= dmgTaken;
                            Console.WriteLine($"{currentHero} was hit for {dmgTaken} HP by {attacker} and now has {theHeores[currentHero][0]} HP left!");
                        }

                        break;
                }

                input = Console.ReadLine();
            }
            theHeores= theHeores.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value); ;
    



            foreach (var item in theHeores)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value[0]}");
                Console.WriteLine($"  MP: {item.Value[1]}");

            }

        }
    }
}


