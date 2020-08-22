using System;
using System.ComponentModel.Design.Serialization;

namespace week2task8sub2
{
    class Program
    {
        static void Main(string[] args)
        {//all even number from 0 to 10000
            int a = 0;
            do
            {
                if (a%2==0)
                {
                    Console.Write(a+", ");
                    
                }
                a++;
            } while (a<=1000);
            Console.ReadKey();
        }
    }
}
;