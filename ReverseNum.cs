using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class ReverseNum
    {
        public static void Main(string[] args)
        {
            int n;
            int r_n;
            int r;

            System.Console.Write("Enter a number :");
            n = Convert.ToInt16(Console.ReadLine());

            while (n > 0)
            {
                r= n % 10;
                r_n = r;
                n = n / 10;         

                System.Console.Write(r_n);
            }



            System.Console.Read();

        }
    }
}
