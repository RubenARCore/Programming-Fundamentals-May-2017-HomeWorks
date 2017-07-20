using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte lines = sbyte.Parse(Console.ReadLine());
            byte tankMaxCap = 255;
            int quantiti = 0;
            for (int i = 1; i <= lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                quantiti += liters;
                if (quantiti>tankMaxCap)
                {
                    Console.WriteLine("Insufficient capacity!");
                    quantiti -= liters;
                }                
            }
            Console.WriteLine(quantiti);
        }
    }
}
