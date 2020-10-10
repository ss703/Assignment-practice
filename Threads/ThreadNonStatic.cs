using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadNonStat
{
    class Mythread
        {
    int Thread1(int x,int y)
    {
        Console.WriteLine("Thread1 executes");
        return x + y;
    }
    bool Thread2(string str)
    {
        Console.WriteLine("Thread2 executes");
            Thread.Sleep(10000);
            if (str.Length < 7)
                
                    {
                        return true;
                    }
                
                else
                {
                    return false;
                }
    }

    class program
    { 

    public static void Main(string[] args)
    {
                Mythread obj = new Mythread();
                Console.WriteLine(obj.Thread1(1, 2));
                Console.WriteLine("Thread1 Terminates Here!!");
                Console.WriteLine(obj.Thread2("soumya"));
                Console.WriteLine("Thread2 Terminates Here!!");
                Console.ReadKey();






    }
}
}
   
    }

