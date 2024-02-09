using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program for Mathematicals Operation \n");

            int a, b, c;

            System.Console.Write("Enter first number :");
            a = Convert.ToInt16(System.Console.ReadLine());

            System.Console.Write("Enter first number :");
            b = Convert.ToInt16(System.Console.ReadLine());

            c = a + b;
            System.Console.WriteLine("Addition :"+c);

            c = a - b;
            System.Console.WriteLine("Subtraction :" + c);

            c = a * b;
            System.Console.WriteLine("Multiplication :" + c);

            c = a / b;
            System.Console.WriteLine("Division :" + c);


            c = a % b;
            System.Console.WriteLine("Module :" + c);

            System.Console.Read();
        }
    }
}
