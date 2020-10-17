using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {numberOfProjects * 3} hours to complete {numberOfProjects} project/s.");
        }
    }
}
