using System;
using System.Diagnostics.CodeAnalysis;

namespace week2task8sub6
{
    class Program
    {
        static void Main(string[] args)
        {//sum of 1+1/2+1/3+...+1/20
            double sum = 0;

            for (double nextNum = 1; nextNum <= 20; nextNum++)
            {
                sum += (1 / nextNum);

            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
