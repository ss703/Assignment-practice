using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLinq2
{
    public class example
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public  string EmpDes { get; set; }
    }
    class linq
    {
        static void Main(string[] args)
        {
            List<example> ex = new List<example>()
            {
                 new example() { EmpID = 1, EmpName = "soumya", EmpSalary= 20000, EmpDes = "Associate" },
                  new example() { EmpID = 2, EmpName = "swathi", EmpSalary=25000, EmpDes = "Associate" },
                   new example() { EmpID = 3, EmpName = "usha", EmpSalary= 35000, EmpDes = "Lead" },
                    new example() { EmpID = 4, EmpName = "krupa", EmpSalary=50000, EmpDes = "Manager" },
            };
            var name = ex.Where(e => e.EmpSalary > 20000).Select(e => e).Where(e => e.EmpID > 1).Select(e => e.EmpName);
           
            var name1 = ex.Where(e => e.EmpDes == "Associate").Select(e => e).Where(e => e.EmpID > 0).Select(e => e.EmpID);
          
            var name2 = from e in ex
                     where e.EmpID > 1 && e.EmpID < 4
                     select new {  e.EmpName };

          //*************Sorting the names*************using GroupBy clause
            var group = from e in ex
                        group e by e.EmpName into em
                        orderby em.Key
                        select new { em.Key, em };

            


            foreach (var x in name)
            {
                Console.WriteLine(x);//swathi,uha,krupa
            }
            foreach (var y in name1)
            {
                Console.WriteLine(y);//1,2
            }
            foreach (var z in name2)
            {
                Console.WriteLine(z);//swathi,usha
            }
            foreach (var a in group)
            {
                Console.WriteLine("EmpName{0}",a.Key);
            }
            Console.ReadKey();
        }
    }
}
