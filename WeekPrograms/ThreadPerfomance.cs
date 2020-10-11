using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ThreadPerformance
{
    class ThreadPerfomance
    {
        public void Thread1()
        {
            long count = 0;
            for (int i = 0; i < 100000; i++)
            {
                count++;
                Console.WriteLine("num of count" + count);
            }
        }
        public void Thread2()
        {
            long count = 0;
            for (int i = 0; i < 100000; i++)
            {
                count++;
                Console.WriteLine("num of count" + count);
            }
        }

        static void Main(string[] args)
        {

            ThreadPerfomance P = new ThreadPerfomance();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //Mutli Thread
            Thread T1 = new Thread(P.Thread1);
            Thread T2 = new Thread(P.Thread2);
            T1.Start(); T2.Start();
            T1.Join(); T2.Join();

            //Single Thread
            //P.Thread1();
            //P.Thread2();
            Console.WriteLine("stop watch is started");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine("stop waatch is stopped ");
            Console.ReadKey();
        }
    }
}

   
