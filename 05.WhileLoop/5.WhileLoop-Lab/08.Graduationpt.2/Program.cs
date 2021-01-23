using System;

namespace _08.Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine(); 
            int grade = 1;
            int time = 0;
            double average = 0.0;

            while (grade <= 12)
            {
                if (time == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
                double evaluation = double.Parse(Console.ReadLine());               
                if (evaluation < 4.00)
                {
                    time++;
                    continue;
                    if (evaluation < 4.00)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }
                average += evaluation;
                if (grade == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {average / 12:f2}");
                    break;
                }
                grade++;
                
            }
           


        }
    }
}
