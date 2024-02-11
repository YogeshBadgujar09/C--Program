using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int temp;
            int r;
            int p_n=0;

            System.Console.WriteLine("Enter a Number :");
            n = Convert.ToInt16(Console.ReadLine());

            temp = n;
            
            while (n > 0)
            {
                r = n % 10;
                p_n = (p_n * 10) + r;
                n = n / 10;
            }


            if (temp == p_n)
            {
                System.Console.WriteLine(p_n + " Number Is Palindrome");
            }
            else
            {
                System.Console.WriteLine(p_n + " Number Is Not Palindrome");
            }

            System.Console.ReadLine();

        }
    }
}
