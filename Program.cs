using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,sum=0 , r;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                r = n % 10;
               
                sum = sum + r;
                n = n / 10;

            }
            Console.WriteLine("sum is="+sum);
            Console.ReadKey();
        }
    }
}
