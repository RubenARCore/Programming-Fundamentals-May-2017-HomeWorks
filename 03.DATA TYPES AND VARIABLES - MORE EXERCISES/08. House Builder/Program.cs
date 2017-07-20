using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstType = long.Parse(Console.ReadLine());
            long secondType = long.Parse(Console.ReadLine());

            if (firstType <= sbyte.MaxValue && firstType >= sbyte.MinValue)
            {
                firstType *= 4;
                secondType *= 10;
                Console.WriteLine(firstType + secondType);
            }
            else
            {
                firstType *= 10;
                secondType *= 4;
                Console.WriteLine(firstType + secondType);
            }
        }
    }
}
