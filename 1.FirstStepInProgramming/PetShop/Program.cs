using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherPets = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(dogs * 2.50) + (otherPets * 4)} lv.");
        }
    }
}
