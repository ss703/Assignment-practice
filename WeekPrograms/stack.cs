using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class stack
    {
        static void Main(string[] args)
        {
            //Creating stack method
            Stack<int> mystack = new Stack<int>();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            foreach(var item in mystack)
            {
                Console.WriteLine(item);
            }
            if(mystack.Count>0)
            {
                Console.WriteLine(mystack.Peek());//Prin4 4
            }
            if (mystack.Count > 0)
            {
                Console.WriteLine(mystack.Pop());//pop all the values here
            }
            Console.ReadKey();
        }
    }
}
