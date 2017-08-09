using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrArrReverced = Console.ReadLine()
                .Split(' ')
                .ToArray()
                .Reverse()
                .ToArray();
            Console.WriteLine(string.Join(" ", inputStrArrReverced));
        }
    }
}
