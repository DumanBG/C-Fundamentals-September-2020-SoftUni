using System;

namespace _01.NextLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            
            int countOfBattle = int.Parse(Console.ReadLine());
          
            for (int i = 1; i <= countOfBattle; i++)
            {
                double currenExp = double.Parse(Console.ReadLine());


                if(i %3 ==0)
                {
                    currenExp = currenExp * 1.15;
                }

                else if(i % 5 ==0)
                {
                    currenExp = currenExp * 0.9;
                }
                if(i % 15 ==0)
                {
                    currenExp = currenExp * 1.05;
                }

                neededExp -= currenExp;


                if(neededExp <= 0)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {neededExp:F2} more needed.");



        }
    }
}
