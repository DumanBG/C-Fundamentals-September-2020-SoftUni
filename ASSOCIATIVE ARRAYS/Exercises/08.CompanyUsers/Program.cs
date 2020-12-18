using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();
            // imeto na kompaniqta i ид на служителя : А123ВА3

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string companyName = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if (!companies.ContainsKey(companyName)) // ako q nqma kompaniata
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(id);
                }
                else //ako ve4e q ima kompaniqta, no proverqvame dali i slujitelq go ima ve4e!!
                {
                    List<string> ids = companies[companyName]; // dava iditata

                    if (!ids.Contains(id))
                    {
                        companies[companyName].Add(id);


                    }
                }
            }
                foreach (var pair in companies)
                {
                    Console.WriteLine(pair.Key);
                    foreach (string id in pair.Value)
                    {
                        Console.WriteLine("-- " +id);
                    }
                }

            }
        }
    }

