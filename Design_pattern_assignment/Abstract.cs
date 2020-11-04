using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_design
{
    class singlepattern
    {
        public class Singleton
        {

            //creating a class for singleton pattern
            private static Singleton instance = new Singleton();


            private Singleton() { }
            public static singlepattern Instance
            {
                get { return instance; }
            }

            public void Dosomething()
            {
                Console.WriteLine("Singleton pattern works");
            }
        }
            static void Main(string []args)
            {
                singlepattern obj = new singlepattern();
                obj.
            }

    }
    
}
