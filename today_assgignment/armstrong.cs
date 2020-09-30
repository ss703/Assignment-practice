using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, sum = 0, r;
            Console.WriteLine("enter a num");
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            while (n != 0)
            {
                r = n % 10;
                //rev = rev * 10 + r;
                sum = sum + (r*r*r);

                n = n / 10;

            }
            if (sum == a)
            {
                Console.WriteLine("the given num is armstroong");
            }
            else
            {
                Console.WriteLine("not a armstrong"); ;
            }
            Console.ReadKey();
        }
    }
    }

