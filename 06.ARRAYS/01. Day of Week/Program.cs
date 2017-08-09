using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            try
            {
                string[] daysOfWeek =
                {
                    "Invalid Day!",
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday",
                };
                Console.WriteLine(daysOfWeek[n]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Day!");                
            }
        }
    }
}
