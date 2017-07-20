using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            long integerNumber;
            decimal floatingPointNumber;
            if (long.TryParse(inputNumber,out integerNumber))
            {
                if (integerNumber>=sbyte.MinValue && integerNumber<=sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (integerNumber >= int.MinValue && integerNumber <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (integerNumber >= long.MinValue && integerNumber <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else if (decimal.TryParse(inputNumber,out floatingPointNumber))
            {
                Console.WriteLine("Rainy");
            }
            
        }
    }
}
