﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = long.Parse(Console.ReadLine());

            bool isPrime = GetNumPrimeStatus(number);
            Console.WriteLine(isPrime);
        }

        static bool GetNumPrimeStatus(long number)
        {

            if (number < 2)
            {
                return false;
            }
            if (number < 4)
            {
                return true;
            }
            for (int i = 5; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
