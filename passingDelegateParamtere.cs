using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentDelegate2
{

    //passing delegate as parameter
    public delegate void Delegate(string str);//declaring delegates
    public class Test1
    {
        public static void Method1(string msg)
        {
            Console.WriteLine("Test1.Method called here" + msg);
        }
    }
    public class Test2
    {
        public static void Method2(string msg)
        {
            Console.WriteLine("Test.Method2 called here" + msg);
        }
    }
    class passingDelegateParamtere
    {
        static void Main(string[] args)
        {
            Delegate D = Test1.Method1;
            InvokeDelegate(D);
       

            D = Test2.Method2;
            InvokeDelegate(D);


            D = (string msg) => Console.WriteLine("lamba exp" + msg);
            InvokeDelegate(D);
            Console.ReadKey();
        }
        static void InvokeDelegate( Delegate  D)//Delegate type parameter
        {
            D("Hello world");

        }
    }
}
