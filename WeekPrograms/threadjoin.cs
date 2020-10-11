using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadJoin
{
    class Program
    {
        
            public void mythread()
            {

                for (int x = 0; x < 4; x++)
                {
                    Console.WriteLine(x);
                    Thread.Sleep(100);
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
                Program obj = new Program();

                // Creating and initializing threads  
                Thread thr1 = new Thread(obj.mythread));
                Thread thr2 = new Thread(obj.mythread1));
                thr1.Start();//Main Method start here

                // Join thread 
                thr1.Join();//Main method end here
                thr2.Start();
            }
    }
}
