using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,  flag = 0;
            Console.WriteLine("enter a num");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("num not prime");
                    flag = 1;
                    break;
                }

            }
            if(flag==0)
            {
                Console.Write("num is prime");
            }
            Console.ReadKey();
        }
    }
}
