using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread
{
    class singleThread
    {
        static void Thraed1(int a)
        {
            int i = 0;
            while(i<15)
            {
                Console.WriteLine("thraed1 is stareted",a);
                i++;

            }
        }
        static void Thraed2(int b)
        {
            int i = 0;
            while (i < 15)
            {
                if(i==4)
                {
                    Console.WriteLine("Thread is sleeping for sometime");
                    Thread.Sleep(3000);
                }
                Console.WriteLine("thraed1 is stareted", a);
                i++;

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is started");
            Thraed1(2);
            Thraed2(3);
      
            Console.ReadKey();
        }
    }
}
