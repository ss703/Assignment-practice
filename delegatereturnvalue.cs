using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignmentdelegate3
{
    public delegate int Delegate();
    public class Test1
    {
       public static int Method1()
        {
            return 100;
        }
    }
   public class Test2
    {
       public static int Method2()
        {
            return 200;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate D1 = Test1.Method1;
            Delegate D2 = Test2.Method2;

            Delegate D = D1 + D2;
            Console.WriteLine(D());
            Console.ReadKey();


























        }
    }
}
