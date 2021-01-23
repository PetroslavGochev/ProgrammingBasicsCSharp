using System;

namespace _1.FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForProcessorInUSD = double.Parse(Console.ReadLine());
            double priceForVideoCardInUSd = double.Parse(Console.ReadLine());
            double priceForOneRAM = double.Parse(Console.ReadLine());
            int numberOfRAM = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceForProcessorInBgn = priceForProcessorInUSD * 1.57;
            double priceForVideoCardInBgn = priceForVideoCardInUSd * 1.57;
            double priceForRam = priceForOneRAM * 1.57;
            double priceForAllRam = priceForRam * numberOfRAM;
            double percent = discount * 100;
            double processorDiscount = priceForProcessorInBgn - (priceForProcessorInBgn * percent / 100);
            double videoCardDiscount = priceForVideoCardInBgn - (priceForVideoCardInBgn * percent / 100);
            double totalSum = processorDiscount + videoCardDiscount + priceForAllRam;
            Console.WriteLine($"Money needed - {totalSum:f2} leva.");
        }
    }
}
