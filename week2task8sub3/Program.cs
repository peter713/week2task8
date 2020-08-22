using System;

namespace week2task8sub3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0, secondNum = 1, thirdNum;
            Console.WriteLine("Please give last index that you want to get from Fibonacci series");
            string strNum = Console.ReadLine();
            bool isNum = int.TryParse(strNum, out int lastNum);
          
            if (isNum && lastNum>=0)
            {
                for (int i = 2; i < lastNum; i++)
                {
                    Console.Write(firstNum + " " + secondNum);
                    thirdNum = firstNum + secondNum;
                    Console.Write( " " + thirdNum );
                    firstNum= secondNum;
                   secondNum = thirdNum ;
                }
            }
            else
            {
             //   Console.Clear();
                Console.WriteLine("Incorrect input");
            }
            Console.ReadKey();
        }
    }
}
