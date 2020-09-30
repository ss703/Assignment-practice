using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace natural_even_10
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("EVEN NUMBERS ARE");
            for(int i=0;i<=10;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("num"+i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
