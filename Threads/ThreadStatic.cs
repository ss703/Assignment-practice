﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingleThraedStatic
{
   public  class ThreadStatic
    {
        static void Thread1()
        {
            Console.WriteLine("Thread1 executes");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine(i);
                
            }
        }
        static void Thread2()
        {
            Console.WriteLine("Thread2 executes");
            for (int i = 1; i < 15; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Thread will sleep for some time");
                    Thread.Sleep(10000);
                }
                Console.WriteLine(i);
            }
           
        }
    
   
       public static void Main(string[] args)
        {
            Thread1();
            Console.WriteLine("Thread 1 terminates!!!!");
            Thread2();
            Console.WriteLine("Thread 2 terminates!!!!");
            Console.ReadKey();
            //Thread2();
            //Thread3();




        }
    }
}
