using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMultipleDelegates
{
    //Multiple Delegates
    public delegate void Delegate(string msg);//declare a delegate

    public class Test1
    {
       public static void Method1(string msg)
        {
            Console.WriteLine("Test1 .Class1 method will be called here" + msg);
        }
    }
   public class Test2
    {
        public static void Method2(string msg)
        {
            Console.WriteLine("Test2 .Class2 method will be called here" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate D1 = Test1.Method1;
            Delegate D2 = Test2.Method2;
            Delegate D= D1 + D2;//combining both here!!
            D("soumya shavi!!");

            //Delegate D3 = (string msg) => Console.WriteLine("lamba exp"+msg);
            //D += D3;//combines D1,D2 and D3
            //D("soumya shavi!!");

          //  D = D1 - D2;//removes delegate 2 here
           // D("soumya shavi");

            //D -= D1;//removes delagete 1
            //D("soumya shavi!!");


            Console.ReadKey();



        }
        
    }
}
