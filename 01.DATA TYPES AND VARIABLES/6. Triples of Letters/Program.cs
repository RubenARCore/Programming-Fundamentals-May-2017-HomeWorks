using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        char letter1 = (char) ('a' + i);    
                        char letter2 = (char) ('a' + j);
                        char letter3 = (char) ('a' + k);
                        Console.WriteLine(""+letter1+letter2+letter3);
                    }
                }
            }
        }
    }
}
