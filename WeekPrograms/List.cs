using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a lis
            List<int> Even = new List<int>();
            Even.Add(2);
            Even.Add(4);
            Even.Add(6);
            Even.Add(8);
            Even.Add(10);

            //Accesing the elemts here
            Console.WriteLine(Even[0]);
            Console.WriteLine(Even[1]);
            Console.WriteLine(Even[2]);
            Console.WriteLine(Even[3]);
            Console.WriteLine(Even[4]);

            //Inserting 
            Even.Insert(5, 12);
            Console.WriteLine(Even[5]);

            //Removing
            Even.Remove(6);//remove 6 from list
            Even.RemoveAt(1);//remove index 1 from list


            ////Adding custom obj
            //var students = new List<string>()
            //{
            //    new () { ID = 1, name = "a" },
            //    new Student() { ID = 2, name = "b" }
            //};

            //Adding arrays in a list
            string[] name = new string[2] { "soumya", "swathi" };
            var popularnames = new List<string>();
            //Adding an array in the list
            popularnames.AddRange(name);

            //Linq in List
            var res = from n in name
                      where n.popularnames == "soumya"
                      select n;



            Console.ReadKey();

        }
    }
}
