using System;

namespace _08.Center_Podecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());

            Math.Abs(x);
            Math.Abs(y);
            Math.Abs(x1);
            Math.Abs(y1);

            var num1 = x + y;
            var num2 = x1 + y1;
            if (num1>num2)
            {
                Console.WriteLine($"({x}, {y})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }


        }
    }
}
