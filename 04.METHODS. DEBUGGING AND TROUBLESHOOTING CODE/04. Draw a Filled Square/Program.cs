using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Header(n);            
            for (int i = 0; i < n-2; i++)
            {
                Middle(n);
            }
            Footer(n);
        }

        static void Header(int n)
        {
            Console.WriteLine(new string('-',n*2));
        }

        static void Footer(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void Middle(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {                
                Console.Write("\\/");                
            }
            Console.WriteLine('-');            
        }
    }
}
