using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result=string.Empty;

            for (int i = 0; i < number; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                result += ch;
            }
            Console.WriteLine($"The word is: {result}");
        }
    }
}
