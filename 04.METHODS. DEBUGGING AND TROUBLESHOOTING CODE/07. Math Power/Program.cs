using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double SecondNumber = double.Parse(Console.ReadLine());
            double power = MathPower(firstNumber, SecondNumber);
            Console.WriteLine(power);
        }

        private static double MathPower(double firstNumber, double secondNumber)
        {
           return Math.Pow(firstNumber, secondNumber);
        }
    }
}
