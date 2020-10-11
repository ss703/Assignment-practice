using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    public delegate bool Delegate2(int num);
    class anonymous
    {
        static void Main(string[] args)
        {
            Delegate2 obj2 = delegate (int a)
            {

                if (a % 2 == 0)
                {
                    return true;
                }
                else

                    return false;


            };
            bool val = obj2.Invoke(10);
            Console.WriteLine(val);
            Console.ReadKey();

        }
    }
}
