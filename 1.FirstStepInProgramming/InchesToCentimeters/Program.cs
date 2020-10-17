using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches = int.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
