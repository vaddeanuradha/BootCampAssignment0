using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "Grace";
            string lastName = "Laren";
            int age = 18;
            string street = "180th Street";
            string city = "Bellevue";
            string country = "USA";
            DateTime birthDate = new DateTime(1950,6,2);

           
            // output to the console window

            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine("{0} years old.", age);

            // use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            // use string interpolation
            // NOTE: This line of code only works with Visual Studio 2015 or C# 6.0 and later.
            // If you are using an earlier version, then comment out this line of code.
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}
