namespace _06.Catch_the_Thief
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            var idType = Console.ReadLine();
            var idcount = long.Parse(Console.ReadLine());
            var checker = long.MinValue;
            decimal years;

            for (var i = 1; i <= idcount; i++)
            {
                var idnumber = long.Parse(Console.ReadLine());

                switch (idType)
                {
                    case "sbyte":
                        if (idnumber > checker && idnumber <= sbyte.MaxValue)
                        {
                            checker = idnumber;
                        }
                        break;
                    case "int":
                        if (idnumber > checker && idnumber <= int.MaxValue)
                        {
                            checker = idnumber;
                        }
                        break;
                    case "long":
                        if (idnumber > checker && idnumber <= long.MaxValue)
                        {
                            checker = idnumber;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (checker > 0)
            {
                years = checker / 127m;
                Console.WriteLine(years > 1
                    ? $"Prisoner with id {checker} is sentenced to {Math.Ceiling(years)} years"
                    : $"Prisoner with id {checker} is sentenced to {Math.Ceiling(years)} year");
            }
            else
            {
                years = checker / -128m;
                Console.WriteLine(years > 1
                    ? $"Prisoner with id {checker} is sentenced to {Math.Ceiling(years)} years"
                    : $"Prisoner with id {checker} is sentenced to {Math.Ceiling(years)} year");
            }
        }
    }
}
