﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriorities
{
    class Threadpriority
    {
        static long count1, count2, count3, count4, count5;
        public static void IncrementCount1()
        {
            while (true)//Indefinite loop

                count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)//Indefinite loop
                count2 += 1;


        }
        public static void IncrementCount3()
        {
            while (true)//Indefinite loop
                count3 += 1;


        }
        public static void IncrementCount4()
        {
            while (true)//Indefinite loop
                count4 += 1;


        }
        public static void IncrementCount5()
        {
            while (true)//Indefinite loop
                count5 += 1;


        }


        static void Main(string[] args)
        {
            Thread T1 = new Thread(IncrementCount1);//Invoke the method IncrementCount1
            Thread T2 = new Thread(IncrementCount2);//Invoke the method IncrementCount2
            Thread T3 = new Thread(IncrementCount3);
            Thread T4 = new Thread(IncrementCount4);
            Thread T5 = new Thread(IncrementCount5);
            Console.WriteLine("Thread is sleep for  5 sec");
            Thread.Sleep(5000);
            Console.WriteLine("Main Thread wake up");
            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;
            T3.Priority = ThreadPriority.AboveNormal;
            T4.Priority = ThreadPriority.BelowNormal;
            T5.Priority = ThreadPriority.Normal;
        
            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();
            T5.Start();
            T1.Abort();
            T2.Abort();
            T3.Abort();
            T4.Abort();
            T5.Abort();
            T1.Join();
            T2.Join();
            T3.Join();
            T4.Join();
            T5.Join();
            Console.WriteLine("count is" + count1);
            Console.WriteLine("count is" + count2);
            Console.WriteLine("count is" + count3);
            Console.WriteLine("count is" + count4);
            Console.WriteLine("count is" + count5);
            Console.ReadKey();
        }
    }
}

   
