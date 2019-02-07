using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use this if block to check for an even or odd number
            Console.WriteLine("Please enter an integer value ");
            //request user input with readline
            //Assign the entered value to the variable input and 
            //convert input to integer before using
            int input = Int32.Parse(Console.ReadLine());
            // Check input value is even or odd
            if (input % 2 == 0)
            {
                Console.WriteLine("The entered number was an even number");
            }
            else
            {
                Console.WriteLine("The entered number was an odd number");
            }
            
        }
    }
}
