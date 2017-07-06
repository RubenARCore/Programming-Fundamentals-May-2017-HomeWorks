using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            short byteNumber = short.Parse(Console.ReadLine());
            short secondByteNumber = short.Parse(Console.ReadLine());
            short shortNumber = short.Parse(Console.ReadLine());
            ushort secondShortNumber = ushort.Parse(Console.ReadLine());
            uint intNumber = uint.Parse(Console.ReadLine());
            long longNumber = long.Parse(Console.ReadLine());
            decimal decimalNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine(byteNumber);
            Console.WriteLine(secondByteNumber);
            Console.WriteLine(shortNumber);
            Console.WriteLine(secondShortNumber);
            Console.WriteLine(intNumber);
            Console.WriteLine(longNumber);
            Console.WriteLine(decimalNumber);

        }
    }
}
