using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2_StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables with deafault values.
            string FirstName = "Rekha";
            string LastName = "Gunthoti";
            DateTime Birthdate = new DateTime(1983, 3, 2);
            string AddressLine1 = "40th Street";
            string City = "Redmond";
            string State = "WA";
            int Zip = 98008;
            string Country = "USA";
            //output to console window
            // simple output
            Console.WriteLine("**this is student information ***");
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            // use string interpolation
            Console.WriteLine($"Born on{Birthdate}");
            // String Concatenation
            Console.WriteLine(AddressLine1 + "," + City + "," + State + "-" + Zip + " , " + Country);
            Console.WriteLine();
            //initialize UProgram Information variables with default vlaues
            string ProgramName = "Math Club";
            string DepartmentHead = "Thomas Albert";
            string Degrees = "Master of Computer Science and Masters in Mathematics";
            // Simple output to console window
            Console.WriteLine("** This is UProgramInformation **");
            Console.WriteLine(ProgramName);
            Console.WriteLine(DepartmentHead);
            Console.WriteLine(Degrees);
            Console.WriteLine();
            //Initialize Degree Information with deafault values
            string DegreeName = "Masters in Math";
            int CreditsRequired = 5;

            //simple output to console window
            Console.WriteLine("** this is degree information **");
            Console.WriteLine(DegreeName);
            Console.WriteLine("Ctedits Required {0}", CreditsRequired);
            Console.WriteLine();
            // initialize Course Information with default values

            string CourseName = "Robotics Club";
            int Credits = 4;
            int DurationInWeeks = 6;
            string Teacher = "Mrs Hart";

            //Output to console window
            Console.WriteLine(CourseName);
            Console.WriteLine("Credits :{0}", Credits);
            Console.WriteLine("Duration in weeks :{0}", DurationInWeeks);
            Console.WriteLine("Teacher is :{0}", Teacher);

        }
    }

}
