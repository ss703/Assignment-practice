using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numers from 2 to 200 are");
            for(int i=2;i<=100;i++)
            {
                Console.WriteLine("num=" + i);
            }
            Console.ReadKey();
        }
    }
}
