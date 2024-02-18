using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeNumber
{
    class ArithmaticOperater
    {
        static void Main(string[] args)
        {

            int a = 15, b = 15;
            int c;

            c = a + b;
            Console.WriteLine("ADD : " + c);

            c = a - b;
            Console.WriteLine("SUB : " + c);

            c = a * b;
            Console.WriteLine("MUL : " + c);

            c = a / b;
            Console.WriteLine("DIV : " + c);

            c = a % b;
            Console.WriteLine("MOD : " + c);

            Console.Read();           
        
        }
    }
}
