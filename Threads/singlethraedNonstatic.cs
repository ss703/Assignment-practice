using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace singlethreadninstatic
{
    class singlethraed
    {
         string Thread1()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Thread1 start at pos", +i);
            }

            return "thraed1 started";
            


        }
         string Thread2()
        {

            for(int i=1;i<=5;i++)
            {
                if(i==4)
                {
                    Console.WriteLine("Thread is sleeping for few sec");
                    Thread.Sleep(10000);
                    
                }
            }
            return "thraed2 started";
        }
        string Thread3()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Thread3 start at pos", +i);

            }
            return "thraed3 started";
        }
        static void Main(string[] args)
        {
            singlethraed obj= new singlethraed();

          
            Console.WriteLine(obj.Thread1());
            Console.WriteLine(obj.Thread2());
            Console.WriteLine(obj.Thread3());

        }
    }
}
