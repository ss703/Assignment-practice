using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread
{
    class thread
    {
        public int Thread1(int num1, int num2)
        {

            return num1 + num2;
        }

        class MultiThreadNonstatic
        {
            static void Main(string[] args)
            {
                thread obj = new thread ();
                int sum = 0;
                int length = 0;
                string s = null;

                Thread T1 = new Thread(() => { sum = obj.Thread1(2, 3); });
                T1.Start();
                T1.Join();
            Console.ReadKey();
        }
    }
}
