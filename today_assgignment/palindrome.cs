using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, rev=0, r;
            Console.WriteLine("enter a num");
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            while(n!=0)
            {
                r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;

            }
            if(rev==a)
            {
                Console.WriteLine("the given num is palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome"); ;
            }
            Console.ReadKey();
        }
    }
}
