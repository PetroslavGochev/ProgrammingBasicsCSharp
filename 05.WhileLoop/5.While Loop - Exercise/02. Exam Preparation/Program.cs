using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rating = int.Parse(Console.ReadLine());
            string nameOfExercise = Console.ReadLine();
            string lastExercise = "";
            double ratings = 0.0;
            double numberOfExercise = 0;
            int bad = 0;
            while (nameOfExercise != "Enough")
            {
                int ratingFromExercise = int.Parse(Console.ReadLine());
                ratings += ratingFromExercise;
                numberOfExercise++;
                if (ratingFromExercise <= 4.00)
                {
                    rating--;
                    bad++;
                    if (rating == 0)
                    {
                        Console.WriteLine($"You need a break, {bad} poor grades.");
                        break;
                    }
                }
                lastExercise = nameOfExercise;
                nameOfExercise = Console.ReadLine();
            }
            if (nameOfExercise == "Enough")
            {
                Console.WriteLine($"Average score: {ratings/numberOfExercise:f2}");
                Console.WriteLine($"Number of problems: {numberOfExercise}");
                Console.WriteLine($"Last problem: {lastExercise}");
              
            }
        }
    }
}

