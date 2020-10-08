using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 10, 20 };
            int[] num2 = num1;
            if(num1==num2)
            {
                Console.WriteLine("Equal");
               
            }
            Console.ReadLine();
        }
    }
}
