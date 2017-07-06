using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cemturies = decimal.Parse(Console.ReadLine());
            decimal years = cemturies * 100;
            decimal days = (int)Math.Floor(years * 365.2422m);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{cemturies} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes = {seconds:f0} seconds = " +
                              $"{milliseconds:f0} milliseconds = {microseconds:f0} microseconds = {nanoseconds:f0} nanoseconds");
        }
    }
}
