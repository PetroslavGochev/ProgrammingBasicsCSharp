using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int teacher = int.Parse(Console.ReadLine());
            string presentation;
            double sumOfAllRating = 0.0;
            int ratings = 0;
            

            while ((presentation = Console.ReadLine()) != "Finish")
            {
                double sumOfRating = 0.0;
                for (int i = 1; i<= teacher; i++)
                {
                    double rating = double.Parse(Console.ReadLine());
                    ratings++;
                    sumOfRating += rating;
                    sumOfAllRating += rating;
                }
                Console.WriteLine($"{presentation} - {sumOfRating / teacher:f2}.");

            }
            Console.WriteLine($"Student's final assessment is {sumOfAllRating / ratings :f2}.");
        }
    }
}
