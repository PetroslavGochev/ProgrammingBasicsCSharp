using System;

namespace _01._Shoping_For_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPencil = int.Parse(Console.ReadLine());
            int numberOfFeltTippedPen = int.Parse(Console.ReadLine());
            int numberOfSketchbook = int.Parse(Console.ReadLine());
            int numberOfNotebook = int.Parse(Console.ReadLine());

            double pencilPrice = numberOfPencil * 4.75;
            double feltTippedpenPrice = numberOfFeltTippedPen * 1.80;
            double sketchbookPrice = numberOfSketchbook * 6.50;
            double notebookPrice = numberOfNotebook * 2.50;
            double totalPrice = (pencilPrice + feltTippedpenPrice + sketchbookPrice + notebookPrice);
            totalPrice -= totalPrice * 5 / 100;
            Console.WriteLine($"Your total is {totalPrice:f2}lv");
        }
    }
}
