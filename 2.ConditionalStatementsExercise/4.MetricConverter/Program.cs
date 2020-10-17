using System;

namespace _4.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberConvert = double.Parse(Console.ReadLine());
            string unitFrom = Console.ReadLine();
            string unitTo = Console.ReadLine();
            if (unitFrom == "mm" && unitTo == "m")
            {
                Console.WriteLine($"{numberConvert / 1000:f3}");
            }  else if (unitFrom == "m" && unitTo == "cm")
            {
                Console.WriteLine($"{numberConvert * 100:f3}");
            }else if (unitFrom == "cm" && unitTo == "mm")
            {
                Console.WriteLine($"{numberConvert * 10:f3}");
            }else if (unitFrom == "mm" && unitTo == "cm")
            {
                Console.WriteLine($"{numberConvert / 10:f3}");
            }else if (unitFrom == "cm" && unitTo == "m")
            {
                Console.WriteLine($"{numberConvert / 100:f3}");
            }else
            {
                Console.WriteLine($"{numberConvert * 1000:f3}");
            }
        }
    }
}
