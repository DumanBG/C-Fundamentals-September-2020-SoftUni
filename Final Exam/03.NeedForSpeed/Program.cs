using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                //{car}|{mileage}|{fuel}      //Audi A6|38000|62

                cars.Add(tokens[0], new List<int> { int.Parse(tokens[1]), int.Parse(tokens[2]) });

            }
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string cmdArg = tokens[0];
                string currentCar = tokens[1];
                switch (cmdArg)
                {
                    case "Drive":
                        //Drive : Audi A6 : 543 : 47
                        int distanceToDrive = int.Parse(tokens[2]);
                        int fuelNeed = int.Parse(tokens[3]);
                        if (cars[currentCar][1] >= fuelNeed)
                        {

                            Console.WriteLine($"{currentCar} driven for {distanceToDrive} kilometers. {fuelNeed} liters of fuel consumed.");
                            cars[currentCar][0] += distanceToDrive;
                            cars[currentCar][1] -= fuelNeed;
                            if (cars[currentCar][0] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {currentCar}!");
                                cars.Remove(currentCar);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }

                        break;

                    case "Refuel":
                        //•	Refuel : {car} : {fuel} // Refuel : Audi A6 : 50  //o	Each tank can hold a maximum of 75 liters of fuel, 
                        int fuelToRecharge = int.Parse(tokens[2]);
                        if (cars[currentCar][1] + fuelToRecharge > 75)
                        {
                            fuelToRecharge = 75 - cars[currentCar][1];
                            cars[currentCar][1] = 75;
                            Console.WriteLine($"{currentCar} refueled with {fuelToRecharge} liters");
                        }
                        else
                        {
                            cars[currentCar][1] += fuelToRecharge;
                            Console.WriteLine($"{currentCar} refueled with {fuelToRecharge} liters");
                        }


                        break;

                    case "Revert":
                        //•	Revert : {car} : {kilometers}
                        int kilometersToRevert = int.Parse(tokens[2]);
                        if (cars[currentCar][0] - kilometersToRevert < 10000)
                        {
                            cars[currentCar][0] = 10000;
                        }
                        else
                        {
                            cars[currentCar][0] -= kilometersToRevert;
                            Console.WriteLine($"{currentCar} mileage decreased by {kilometersToRevert} kilometers");


                        }


                        break;
                }
                input = Console.ReadLine();
            }
            //Audi A6 -> Mileage: 10000 kms, Fuel in the tank: 65 lt.
            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in cars)
            {
                
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");



            }

        }
    }
}

