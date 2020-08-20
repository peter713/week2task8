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
            Console.Write(firstNum +" "+secondNum);
            if (isNum)
            {
                for (int i = 2; i < lastNum; i++)
                {
                    thirdNum = firstNum + secondNum;
                    Console.Write( " " + thirdNum );
                    firstNum= secondNum;
                   secondNum = thirdNum ;
                }
            }
            Console.ReadKey();
        }
    }
}
