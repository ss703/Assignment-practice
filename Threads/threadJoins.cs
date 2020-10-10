using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoins
{
    class ExThread
    {
        //        static void Thread1()
        //        {
        //            for (int i = 1; i <= 5; i++)
        //            {
        //                Console.WriteLine("Thread1 Executes Here1");
        //            }
        //        }
        //    }
        //    public class Thread
        //        {


        //        static void Main(string[] args)
        //        {
        //            Program obj=new Program();
        //            Thread T = new Thread(new ThreadStart(obj.Thread1));
        //            T.Start();
        //            T.Join();

        //        }
        //    }
        //}
        // Non-Static method 
        public void mythread()
        {
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(x);
                Thread.Sleep(10000);
            }
        }

        // Non-Static method 
        public void mythread1()
        {
            Console.WriteLine("2nd thread is Working..");
        }
    }

    // Driver Class 
    public class ThreadExample
    {
        // Main method 
        public static void Main()
        {
            // Creating instance for 
            // mythread() method 
            ExThread obj = new ExThread();
            // Creating and initializing threads  
            Thread thr1 = new Thread(new ThreadStart(obj.mythread));
            Thread thr2 = new Thread(new ThreadStart(obj.mythread1));
            thr1.Start();

            // Join thread 
            thr1.Join();
            thr2.Start();
            Console.ReadKey();

        }
    }
}
