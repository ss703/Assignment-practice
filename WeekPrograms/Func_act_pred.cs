using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_act_pred
{
    public delegate int Delegate1(int num,int num1);
    public delegate string Delegate2(string name);
    public delegate string Delegate3(string name);
    class Func_act_pred
    {
        static void Main(string[] args)
        {
            Func<int, int, int> obj1 = (num1, num2) =>
            {

                return num1 + num2;


            };
           
            //Action
            Action<string> obj3 = (name) =>
            {

                Console.WriteLine(name);


            };

           
            //Predicate
            Predicate<string> obj5 = str =>
            {
                return str.Equals(str.ToUpper());
            };
           


            int val = obj1.Invoke(10, 20);
            Console.WriteLine(val);

            

            obj3.Invoke("soumya");

           

            Console.WriteLine(obj5("swathi"));

          







        }
    }
}
