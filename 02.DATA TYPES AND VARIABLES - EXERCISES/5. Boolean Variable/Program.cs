using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool name = bool.Parse(Console.ReadLine());            
            if (name==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
