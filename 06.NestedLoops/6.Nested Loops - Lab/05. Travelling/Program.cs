using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double sum = 0;
            

            while (destination != "End")
            {
                double sumForDestination = double.Parse(Console.ReadLine());
                while (sum < sumForDestination)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {destination}!");               
                sum = 0;
                destination = Console.ReadLine();
            }
        }
    }
}
