using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double priceOfLaundry = double.Parse(Console.ReadLine());
            double priceOfToy = double.Parse(Console.ReadLine());
            double money = 0;
            double moneyGift = 10.00;
            double toy = 0;
            for (int i = 1; i <= lilyAge; i++)
            { 
                if (i % 2 == 0)
                {
                    money += moneyGift;
                    moneyGift += 10.00;
                    money--;
                }
                else
                {
                    toy++;
                }
            }
            
            double toyMoney = toy * priceOfToy;
            double totalMoney = toyMoney + money;
            if (priceOfLaundry <= totalMoney)
            {
                Console.WriteLine($"Yes! {totalMoney-priceOfLaundry:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceOfLaundry - totalMoney:f2}");
            }
        }
    }
}
