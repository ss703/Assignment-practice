using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<int> myqueue = new Queue<int>();
            myqueue.Enqueue(1);
            myqueue.Enqueue(2);
            myqueue.Enqueue(3);
            myqueue.Enqueue(4);
            foreach (var item in myqueue)
            {
                Console.WriteLine(item);
            }
            if (myqueue.Count > 0)
            {
                Console.WriteLine(myqueue.Peek());//Prin4 4
            }
            if (myqueue.Count > 0)
            {
                Console.WriteLine(myqueue.Dequeue());//pop all the values here
            }
            Console.ReadKey();

        }
    }
}
