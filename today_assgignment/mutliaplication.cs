using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mul_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
           for(int i=1;i<=10;i++)
            {
                Console.Write("{0}*{1}={2} ", n,i,n*i);
            }

        }
           
        }
    }

