using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());
            var reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static decimal GetReversedNumber(decimal number)
        {
            char[] reverseNumberArray = number.ToString().ToCharArray();
            Array.Reverse(reverseNumberArray);
            return decimal.Parse(new string(reverseNumberArray));
        }
    }
}
