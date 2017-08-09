using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int middleIndex = arrayOfInts.Length / 2;
            Console.WriteLine(
                arrayOfInts.Length == 1 ?
                    $"{arrayOfInts[0]}" :
                    arrayOfInts.Length % 2 == 1 ?
                        $"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}\n{arrayOfInts[middleIndex + 1]}" :
                        $"{arrayOfInts[middleIndex - 1]}\n{arrayOfInts[middleIndex]}"
            );
        }
    }
}
