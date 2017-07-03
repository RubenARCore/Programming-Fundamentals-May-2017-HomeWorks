using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double radius = Math.PI * r * r;
            Console.WriteLine($"{radius:f12}");
        }
    }
}
