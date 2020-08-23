using System;

namespace week2task8sub8_
{
    class Program
    {
        static void Main(string[] args)
        {//reverse string
            Console.WriteLine("Provide string of chracters");
            string str = Console.ReadLine();
            //string word = "Abcdefg";
            char[] array = str.ToCharArray();
            Array.Reverse(array); 
            Console.WriteLine(array);

            Console.ReadKey();
        }
    }
}
