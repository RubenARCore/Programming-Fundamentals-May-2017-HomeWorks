using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Fibonacci(number);
        }

        private static void Fibonacci(int number)
        {
            int fibMinus2 = 0;
            int fibMinus1 = 1;
            int fibonadcciN = 1;
            for (int i = 0; i < number; i++)
            {
                fibonadcciN = fibMinus2 + fibMinus1;
                fibMinus2 = fibMinus1;
                fibMinus1 = fibonadcciN;
            }

            Console.WriteLine(fibonadcciN);
        }
    }
}
