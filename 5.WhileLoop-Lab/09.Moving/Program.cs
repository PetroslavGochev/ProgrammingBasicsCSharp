using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int allPlace = width * lenght * height;
            int sumOfAllCarton = 0;
            string numberOfCarton = Console.ReadLine();
            while (numberOfCarton != "Done")
            {
                sumOfAllCarton += int.Parse(numberOfCarton);
                if (sumOfAllCarton > allPlace)
                {
                    Console.WriteLine($"No more free space! You need {sumOfAllCarton - allPlace} Cubic meters more.");
                    break;
                }
                numberOfCarton = Console.ReadLine();

            }
            if (numberOfCarton == "Done")
            {
                Console.WriteLine($"{allPlace - sumOfAllCarton} Cubic meters left.");
            }
            

        }
    }
}
