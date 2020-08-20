using System;

namespace week2task8sub1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                bool primeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }

                if (primeNumber && i != 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                    counter++;
                }

            }
            Console.WriteLine($"\r\nThere is {counter} prime numbers in this range of numbers");
            Console.ReadKey();
        }
    }
}
