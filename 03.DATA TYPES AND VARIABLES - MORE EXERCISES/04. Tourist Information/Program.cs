using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double outValue;
            switch (imperialUnit)
            {
                case "miles":
                    outValue = value * 1.6;
                    Console.WriteLine($"{value} {imperialUnit} = {outValue:f2} kilometers");
                    break;
                case "inches":
                    outValue = value * 2.54;
                    Console.WriteLine($"{value} {imperialUnit} = {outValue:f2} centimeters");
                    break;
                case "feet":
                    outValue = value * 30;
                    Console.WriteLine($"{value} {imperialUnit} = {outValue:f2} centimeters");
                    break;
                case "yards":
                    outValue = value * 0.91;
                    Console.WriteLine($"{value} {imperialUnit} = {outValue:f2} meters");
                    break;
                case "gallons":
                    outValue = value * 3.8;
                    Console.WriteLine($"{value} {imperialUnit} = {outValue:f2} liters");
                    break;
            }
        }
    }
}
