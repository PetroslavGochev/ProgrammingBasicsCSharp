using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForVacantion = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int timeSpend = 0;
            int days = 0;

            while(savedMoney < priceForVacantion && timeSpend < 5)
            {
                days++;
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if(action == "spend" && money >= savedMoney)
                {
                    savedMoney = 0;
                    timeSpend++;
                }
                else if (action == "spend" && money < savedMoney)
                {
                    savedMoney -= money;
                    timeSpend++;
                }
                else
                {
                    savedMoney += money;
                    timeSpend = 0;
                }            
            }
            if (savedMoney >= priceForVacantion)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else if (timeSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
        }
    }
}
