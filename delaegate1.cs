using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentdelagate1
{
    //Example of delegates
    public delegate void Delegate(string str);
    public class Test1
    {
        public static void Method1(string msg)
        {
            Console.WriteLine("Test1.Method called here"+msg);
        }
    }
    public class Test2
    {
        public static void Method2(string msg)
        {
            Console.WriteLine("Test.Method2 called here"+msg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Delegate D = Test1.Method1;
            D.Invoke("Hello world");
            D = Test2.Method2;
            D("soumya");//we xan write invoke also here...

            //without taking class
            D = (string msg) => Console.WriteLine("lamba exp" + msg);
            D("Hi world");

           
            
            Console.ReadKey();


        }
    }
}
