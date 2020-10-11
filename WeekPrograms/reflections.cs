using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class student
    {
        public int roolno
        {
            set; get;
        }
        public string name { get; set; }
        public student()
        {
            roolno = 0;
            name = string.Empty;
        }
        public student(int r, string n)
        {
            this.roolno = r;
            this.name = n;
        }
        public void display()
        {
            Console.WriteLine("Roll no{0}", roolno);
            Console.WriteLine("Name {0}", name);

        }
    }
    class reflections
    {
        static void Main(string[] args)
        {
            //Decalre the class of assembly here
            Assembly ex = Assembly.GetExecutingAssembly();

            //Array to store types of Assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine("class:{0}", item.Name);

                //Array to store Methods
                MethodInfo[] m = item.GetMethods();
                foreach(var method in m)
                {
                    Console.WriteLine("Mthod {0}", method.Name);
                }




            }
            Console.ReadKey();
        }
    }
}
