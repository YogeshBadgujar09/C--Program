using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Even_Odd
    {
        static void Main(string[] args) 
        {
            System.Console.WriteLine("Programe For Number Is Even Or odd \n");

            int a;

            System.Console.Write("Enter a number :");
            a = Convert.ToInt16(System.Console.ReadLine());

            if (a % 2 == 0)
            {
                System.Console.Write(a + " is Even Number");
            }
            else {
                System.Console.Write(a + " is Odd Number");
            }

            System.Console.Read();
        }
    }
}
