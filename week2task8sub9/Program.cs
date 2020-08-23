using System;

namespace week2task8sub9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This app will covert your number on binary, type in number:");
            int num = int.Parse(Console.ReadLine());
            int reminder;
            string result = " ";
             Console.Write($"\r\nBinary of {num} is equal to ");
            while (num > 0)
            {
                reminder = num % 2;
                num /= 2; 
                result = reminder.ToString() + result; 
            }

            Console.Write(result); 

            Console.ReadKey();
        }
    }
}
