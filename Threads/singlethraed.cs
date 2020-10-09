using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace singlethreadninstatic
{
    class singlethraed
    {
        static string Thread1()
        {

            return "thraed1 started";
            


        }
        static string Thread2()
        {
            return "thraed2 started";
        }
        static string Thread3()
        {
            return "thraed3 started";
        }
        static void Main(string[] args)
        {
            string res = Thread1();
            Console.WriteLine(res);
            Console.WriteLine("end of thread1");

            string res1 = Thread2();
            Console.WriteLine(res1);
            Console.WriteLine("end of thread2");

            string res2 = Thread3();
            Console.WriteLine(res2);
            Console.WriteLine("end of thread3");
            Console.ReadKey();

        }
    }
}
