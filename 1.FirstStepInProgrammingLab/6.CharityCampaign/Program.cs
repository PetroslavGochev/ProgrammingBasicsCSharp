using System;

namespace _6.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfConfectioner = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
            int cakes = numberOfCakes * 45;
            double waffles = numberOfWaffles * 5.80;
            double pancakes = numberOfPancakes * 3.20;
            double priceOneDay = (cakes + waffles + pancakes) * numberOfConfectioner;
            double allPrice = priceOneDay * numberOfDays;
            double charity = allPrice - (allPrice / 8); 
          
                Console.WriteLine(charity);
        }
    }
}
