using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharpreflections1
{
    class student
    {
        public int rollno { get; set; }
        public string name { get; set; }

        public student()//defalut parametrized
        {
            rollno = 0;
            name = string.Empty;
        }
        public student(int RollNo, string Name)
        {
            this.rollno = RollNo;
            this.name = Name;
        }
        public void display()
        {
            Console.WriteLine("Roll no {0}", rollno);
            Console.WriteLine("name {0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //decalring instance of class assembly
            Assembly ex = Assembly.GetExecutingAssembly();//calling the Getexecuting assembly method here

            //Array to store type of assembly
            Type[] types = ex.GetTypes();
            foreach (var x in types)
            {
                Console.WriteLine("clas::{0}", x.Name);
                MethodInfo[] methods = x.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    Console.WriteLine("--> Method : {0}", method.Name);


                }
                Console.ReadKey();
            }
        }
    }
}
