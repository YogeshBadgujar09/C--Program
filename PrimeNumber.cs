using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigment2
{
    class PrimeNumber
    {
        public static void Main(string[] args)
        {
            int n;

            int flag=1;

            System.Console.Write("Enter a number :");
            n = Convert.ToInt16(Console.ReadLine());

            if (n == 1)
            {
                flag = 1;
            }
            else 
            {
                for (int i = 2; i < n; i++)
                { 
                    if(n%i==0)
                    {
                        flag = 0;

                        break;
                    }
                }
            }

            if (flag == 1)
            {
                System.Console.Write("Number is Prime");
            }
            else {
                System.Console.Write("Number is Not Prime");
            }
            
         
                System.Console.Read();

        }
    }
}
