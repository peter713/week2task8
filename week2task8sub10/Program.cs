using System;

namespace week2task8sub10
{
    class Program
    {
        static void Main(string[] args)
        {//this app will find lowest common multiple - we take into account that user will provide correct input data
            Console.WriteLine("Type in first int number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in first int number:");
            int secondNum = int.Parse(Console.ReadLine());

            for (double finalNum = 1; ; finalNum++)
            {
                if (finalNum % secondNum == 0 && finalNum % firstNum == 0)
                {
                    Console.Write($"LCM for {firstNum} and {secondNum} is equal to : ");
                    Console.WriteLine(finalNum.ToString());
                    break;
                }
            }
            Console.ReadKey();
        }    
    
    }
}
