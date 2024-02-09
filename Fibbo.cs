using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class Fibbo
    {
        public static void Main(string[] args)
        {
            int n;
            int p1 = 0, p2 = 1, temp;

            System.Console.Write("Enter a number :");
            n = Convert.ToInt16(System.Console.ReadLine());

            System.Console.Write(p1 +" "+p2);

            for (int i = 3 ;i <= n ;i++)
            {
                temp = p1 + p2;
                p1 = p2;
                p2 = temp;

                System.Console.Write(" "+temp);
            }

            System.Console.Read();
        }
       
    }
}
