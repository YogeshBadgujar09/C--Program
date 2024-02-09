using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class LeapYear
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Program for check year is Leap or Not");

            int year;

            System.Console.Write("Enter  a year :");
            year = Convert.ToInt16(System.Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {   
                
                System.Console.WriteLine(year + " is Leap Year ");
            }
            else {
                System.Console.WriteLine(year + " is not Leap Year ");
            }

            System.Console.Read();
        }
    }
}
