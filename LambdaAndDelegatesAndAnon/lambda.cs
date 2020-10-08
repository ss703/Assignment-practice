using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaassignment
{
    public delegate int Add1Delegate1(int a, int b);
    public delegate bool Add2Delegate2(int a);
    public delegate void Add3Delegate3(string name);
    public delegate void Add4Delegate4(int a);
    public delegate bool Add5Delegate5(string name);
    public delegate bool Add6Delegate6(string name);
    class Program
    {
        static void Main(string[] args)
        {
            Add1Delegate1 obj1 = (num1, num2) =>
            {

                return num1 + num2;


            };
            Add2Delegate2 obj2 = a =>
             {

                 if (a % 2 == 0)
                 {
                     return true;
                 }
                 else

                     return false;


             };
            Add3Delegate3 obj3 = (name) =>
            {

                Console.WriteLine(name);


            };

            Add4Delegate4 obj4 = a =>
           {

               Console.WriteLine(a * a);


           };
            Add5Delegate5 obj5 = str =>
            {
                return str.Equals(str.ToUpper());
            };
            Add6Delegate6 obj6 = delegate (string str)
            {
                if (str.Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };


            int val = obj1.Invoke(10, 20);
            Console.WriteLine(val);

            bool val1 = obj2.Invoke(10);
            Console.WriteLine(val1);

            obj3.Invoke("soumya");

            obj4.Invoke(2);

            Console.WriteLine(obj5("swathi"));

            Console.WriteLine(obj6("usha"));
            Console.ReadKey();

        }
    }
}
