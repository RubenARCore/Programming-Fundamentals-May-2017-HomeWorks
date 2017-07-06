using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            Console.WriteLine(number.GetTypeCode());
        }
    }
}
