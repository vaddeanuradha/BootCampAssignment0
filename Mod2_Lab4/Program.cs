using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create While Loop
            //We start with n=1
            //print values upto 5 using with While loop
            int n = 1;
            while(n<6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }
            //create a do loop, and print values from 0 to 4
            // using do while loop
            Console.WriteLine("This values print by using do while loop");
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;

            } while (x < 5);
        }
    }
}
