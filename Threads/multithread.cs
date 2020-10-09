﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithread
{
    class Program
    {
       
        
			static void Thread1()
			{
				for (int i = 1; i < 15; i++)
				{
					Console.WriteLine("Thread1 is started at the pos:" + i);

				}
			}
			static void Thread2()
			{
				for (int i = 1; i < 15; i++)
				{
					if (i == 4)
					{
						Console.WriteLine("thread2 sleeping for 10 sec");
						Thread.Sleep(10000);
					}
					Console.WriteLine("Thread2 is started at the pos:" + i);
				}
			}
			static void Thread3()
			{
				for (int i = 1; i < 15; i++)
				{
					Console.WriteLine("Thread3 is started at the pos:" + i);
				}
			}

			static void Main(string[] args)
			{
			//Main thread
			 //create the child  thread wrt Methods involved
				Thread T1 = new Thread(Thread1);
				Thread T2 = new Thread(Thread2);
				Thread T3 = new Thread(Thread3);//One main thread and 3 child Threads

				T1.Start(); T2.Start(); T3.Start();
			}
		}
    }

