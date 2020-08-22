using System;
using System.ComponentModel.Design.Serialization;

namespace week2task8sub4
{
    class Program
    {
        static void Main(string[] args)
        {//insert numbe and the you will get some kind of shape, in some cases will be triangle example for int number =7
            //1
            //2 3
            //4 5 6
            //7
            Console.WriteLine("Please provide int number");
            string strNum = Console.ReadLine();
            bool isNum = int.TryParse(strNum, out int myNum);
            int counter = 1;
            if (isNum && myNum>=0)
            {
                for (int i = 0; i <= myNum; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (myNum >= counter)
                        {
                            Console.Write(counter + " ");
                            counter++;
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            Console.ReadKey();
        }
    }
}
