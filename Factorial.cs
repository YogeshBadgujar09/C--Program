using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Factorial
    { 
        public static void Main(string[] args)
        {
            int num,fact=1 ,i=1;

            System.Console.Write("Enter a number :");
            num = Convert.ToInt16(System.Console.ReadLine());

            do
            {
                fact = fact * i;

                i++;
            }
            while (i <= num);

            System.Console.WriteLine("Factorial of "+num+" is "+fact);

            System.Console.Read();
        }
    }
}
