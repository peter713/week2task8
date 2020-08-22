using System;

namespace week2task8sub5
{
    class Program
    {
        static void Main(string[] args)
        {//This app display all numbers from range from 1 to 20, their results to power of third
            int num = 20;
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(i+"^3 = "+Math.Pow(i, 3)+" ");
            }

            Console.ReadKey();
            
        }
    }
}
