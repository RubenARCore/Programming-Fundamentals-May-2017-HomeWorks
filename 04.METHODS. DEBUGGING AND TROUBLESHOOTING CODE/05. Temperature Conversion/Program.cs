using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FtociAmLazy(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        static double FtociAmLazy(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
