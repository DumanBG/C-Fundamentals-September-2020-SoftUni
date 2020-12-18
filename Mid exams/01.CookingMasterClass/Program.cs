using System;

namespace _01.CookingMasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            //of 1 package of flour, 10 eggs and an apron. 
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double aprons = double.Parse(Console.ReadLine());

            double total = 0;
            eggPrice = students * (10*eggPrice);
            aprons = Math.Ceiling(students*1.2)*aprons;

            if (students > 5)
            {
                students = students - (students / 5);


            }
            flourPrice = students * flourPrice;
            total = eggPrice + aprons + flourPrice;

            if(budjet>=total)
            {
                Console.WriteLine($"Items purchased for {total:F2}$.");
            }
            else
            {
                double needMoney = total - budjet;
                Console.WriteLine($"{needMoney:F2}$ more needed.");
            }
        }
    }
}
