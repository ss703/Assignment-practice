using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLinqjoins
{

    public class Employes
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
       // public string EmpDes { get; set; }
    }
    public class Employes2
    {
        public int EmpID { get; set; }
        public string EmpDes { get; set; }
    }
    

    
    class linqjoins
    {
        static void Main(string[] args)
        {
            List<Employes> emp1 = new List<Employes>()
            {
                 new Employes() { EmpID = 1, EmpName = "soumya", EmpSalary= 20000 },
                  new Employes() { EmpID = 2, EmpName = "swathi", EmpSalary=25000 },
                   new Employes() { EmpID = 3, EmpName = "usha", EmpSalary= 35000 },
                    new Employes() { EmpID = 4, EmpName = "krupa", EmpSalary=50000 },
            };
            List<Employes2> emp2 = new List<Employes2>()
            {
                 new Employes2() { EmpID = 1, EmpDes="Associate"},
                 new Employes2() { EmpID = 2, EmpDes="Associate"},
                 new Employes2() { EmpID = 3, EmpDes="Lead"},
                 new Employes2() { EmpID = 4, EmpDes="Manager"},


            };

            var joins = from e1 in emp1
                        join e2 in emp2
                        on e1.EmpID equals e2.EmpID
                        select new
                        {
                            empName = e1.EmpName,
                            empDes = e2.EmpDes
                        };
            foreach (var a in joins)
            {
                Console.WriteLine("EmpName{0 }EmpDes{1}", a.empName  ,  a.empDes);
            }
            Console.ReadKey();




        }
    }
}
