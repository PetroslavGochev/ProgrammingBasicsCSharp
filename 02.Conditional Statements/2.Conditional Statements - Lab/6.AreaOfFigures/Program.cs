using System;

namespace _6.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
         
            if (figures == "square")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine($"{number * number:f3}");
            }else if (figures == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b:f3}");
            }else if (figures == "circle")
            {
                double cirlce = double.Parse(Console.ReadLine());
                Console.WriteLine($"{cirlce * cirlce * Math.PI:f3}");
            }else if (figures == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * b / 2:f3}");
            }

        }
    }
}
