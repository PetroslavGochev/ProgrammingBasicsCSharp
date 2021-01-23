using System;

namespace _7.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double raspberriesQuantity = double.Parse(Console.ReadLine());
            double strawberryQuantity = double.Parse(Console.ReadLine());
            double raspberriesPrice = strawberryPrice * 0.5;
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.4);
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);
            double strawberryAmount = strawberryPrice * strawberryQuantity;
            double bananasAmount = bananasQuantity * bananasPrice;
            double raspberriesAmount = raspberriesPrice * raspberriesQuantity;
            double orangesAmount = orangesPrice * orangesQuantity;
            double money = strawberryAmount + bananasAmount + raspberriesAmount + orangesAmount;
            

            Console.WriteLine(Math.Round(money,2));

        }
    }
}
