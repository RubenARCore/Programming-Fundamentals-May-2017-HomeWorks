using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
                
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
