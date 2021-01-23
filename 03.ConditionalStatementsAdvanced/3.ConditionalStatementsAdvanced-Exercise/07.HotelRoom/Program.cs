using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartmentPrice = 0.0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50 * days;
                apartmentPrice = 65 * days;
                if (days > 7 && days <= 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (days > 14)
                {
                    studioPrice = studioPrice * 0.70;
                    apartmentPrice = apartmentPrice * 0.90;
                } 
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * days;
                apartmentPrice = 68.70 * days;
                if (days > 14)
                {
                    studioPrice = studioPrice * 0.80;
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            else
            {
                studioPrice = 76 * days;
                apartmentPrice = 77 * days;
                if (days > 14)
                {
                    apartmentPrice = apartmentPrice * 0.90;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
