using System;

namespace _7.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            if (hours<10 || hours>18)
            {
                Console.WriteLine("closed");
            }
            else
            {
                if (dayOfWeek == "Sunday")
                {
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("open");
                }
            }
        }
    }
}
