using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreadnonstatic
{
	class mythreads
	{
        
            public int Thread1(int num1, int num2)
            {

                return num1 + num2;
            }

            public int Thred2(string str)
            {
                Thread.Sleep(2000);
                return str.Length;
            }

            public string Thread3(string s1, string s2)
            {
                return s1 + s2;
            }
           
            

        }

        class Program
        {
            static void Main(string[] args)
            {
                mythreads obj = new mythreads();
                int sum = 0;
                int length = 0;
                string s = null;
               
                Thread T1 = new Thread(() => { sum = obj.Thread1(2,3); });
                Thread T2 = new Thread(() => { length = obj.Thred2("soumya"); });
                Thread T3 = new Thread(() => { s = obj.Thread3("sou","mya"); });
                T1.Start();
                T2.Start();
                T3.Start();
              
                //T1.Join();
                //T2.Join();
                //T3.Join();
                //T4.Join();
                Console.WriteLine("the sum of two numbers is {0}", sum);
                Console.WriteLine("the length of the string is {0}", length);
                Console.WriteLine("the cancatenated string is {0} ", s);
           
                Console.ReadKey();


               


		}
		}
	}


        
