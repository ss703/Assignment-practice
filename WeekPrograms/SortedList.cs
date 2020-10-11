using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class SortedList
    {
        static void Main(string[] args)
        {

            SortedList<int, string> numbers = new SortedList<int, string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(7, "Seven");
            numbers.Add(10, "Ten");
            numbers.Add(4, "null");
            foreach (var x in numbers)
            {
                Console.WriteLine("numbers are" + "key:{0},value{1}", x.Key, x.Value);
            }
            Console.ReadKey();
        }

    }
}

