using System;

namespace Fibonacci
{
    class Program
    {

                static void Main(string[] args)
        {

            int a = 0, b = 2, c = 4;
           
            Console.WriteLine("Quanti valori:");
           
            int valori = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Sequenze Fibonacci con" + valori + "valori");
           
            for (int i = 0; i < valori; i++)
            {
                if (i < valori - 1)
                {
                 Console.Write(a + ",");
                }
                else
                {
                 Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadKey();
        }
    }

}


