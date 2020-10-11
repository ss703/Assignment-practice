using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate bool Delegate1(int num);
    class Delegate
    {
        public static bool Isodd(int a)
        {
            if(a%2!=0)
            {
                return true;
            }
            else
            return false;
        }
        static void Main(string[] args)
        {
            //Instatinating the delaegate
            Delegate1 obj1 = new Delegate1(Isodd);//passing method here
            Console.WriteLine(obj1(2));
            Console.ReadKey();

        }
    }
}
