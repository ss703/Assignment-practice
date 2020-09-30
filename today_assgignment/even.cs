using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naturall_num_rev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("natural numbers in reverse orders is");
            for(int i=10;i>=1;i--)
            {
                Console.WriteLine("i=" + i);
            }
            Console.ReadKey();
        }
    }
}
