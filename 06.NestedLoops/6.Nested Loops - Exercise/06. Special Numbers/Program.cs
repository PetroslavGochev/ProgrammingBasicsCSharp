using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for(int i = 1111; i<=9999; i++)
            {
                string currentNumber = i.ToString();
                bool flag = false;
                for (int j = 0; j< currentNumber.Length; j++)
                {
                    if(int.Parse(currentNumber[j].ToString()) == 0)
                    {
                        flag = true;
                        break;
                    }                   
                    if(number % int.Parse(currentNumber[j].ToString()) != 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
