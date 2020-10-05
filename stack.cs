using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack1
{
    class stack
    {
        static void Main(string[] args)
        {
            Stack<int> MyStack = new Stack<int>();
            MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Push(10);
            MyStack.Push(12);
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            MyStack.Push(20);
            Console.WriteLine("the topmost element of the stack is {0} ", MyStack.Peek());

            foreach (int x in MyStack)
            {
                Console.WriteLine("elements are in stack are" + x);


            }
            Console.WriteLine("the elements after popping" + MyStack.Pop()); 
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("after 6 pop oprations");
            Console.WriteLine("the top ele of stack is{0}" + MyStack.Peek());

             Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
            Console.WriteLine("the elements after popping" + MyStack.Pop());
           // Console.WriteLine("the elements after popping" + MyStack.Pop());
            //Console.WriteLine("the elements after popping" + MyStack.Pop());

            Console.WriteLine("aftaer 5 oprations");
            //Console.WriteLine("the top ele of stack is{0}" + MyStack.Peek());




            //Console.WriteLine("the elements after popping" + MyStack.Peek());

            Console.ReadKey();

        }
    }
}
