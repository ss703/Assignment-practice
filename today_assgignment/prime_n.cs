using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, flag = 0;
            Console.WriteLine("enter a starting num");
           int FN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a starting num");
            int LN = Convert.ToInt32(Console.ReadLine());
            for ( i = FN; i <= LN; i++)
            {

                for (int j = 2; j <= i / 2; i++)
                {
                    if (i % j == 0)
                    {
                        Console.WriteLine("prime numbers are");
                        flag++;
                        break;
                    }
                }
            }
        
            if (flag == 0 && i!=1)
            {
                Console.Write("{0}",i);
            }
            Console.Write("\n");
            Console.ReadKey();

        }
    
        }
}


