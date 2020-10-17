using System;

namespace _8.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentRead = double.Parse(Console.ReadLine());
            double volume = lenght * widht * height;
            double totalLiters = volume * 0.001;
            double percent = percentRead * 0.01;
            double aquarium = totalLiters * (1 - percent);

            Console.WriteLine(aquarium);
        }
    }
}
