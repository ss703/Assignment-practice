using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myapp.Models;


namespace MvcApp.Db.DbOperations
{
    public class Employe
    {
        public int AddEmploye(EmpModels model)
        {
            using (var context = new DXCEntities())
            {
                Db_approach ee = new Db_approach()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code

                };
                context.Db_approach.Add(ee);

                context.SaveChanges();

                return ee.Id;
            }
        }

        public List<EmpModels> GetAllEmployess()
        {
            using (var context = new DXCEntities())
            {
                var result = context.Db_approach.Select(x => new EmpModels()

                {
                    Id = x.Id,
                    Addressid = x.Addressid,
                    Code = x.Code,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = new AddressModels()
                    {
                        Id = x.Db_address.Id,
                        Details = x.Db_address.Details,
                        Country = x.Db_address.Country,
                        State = x.Db_address.State
                    }
                }).ToList();

                return result;
            }
        }


        public EmpModels GetEmployess(int id)
        {
            using (var context = new DXCEntities())
            {
                var result = context.Db_approach
                    .Where(x => x.Id == id)
                    .Select(x => new EmpModels()

                    {
                        Id = x.Id,
                        Addressid = x.Addressid,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = new AddressModels()
                        {
                            Id = x.Db_address.Id,
                            Details = x.Db_address.Details,
                            Country = x.Db_address.Country,
                            State = x.Db_address.State
                        }
                    }).FirstOrDefault();

                return result;
            }
        }


        public bool UpdateEmploye(int id, EmpModels model)
        {
            using (var context = new DXCEntities())
            {

                var empl = context.Db_approach.FirstOrDefault(x => x.Id == id);
                if (empl != null)
                {
                    empl.FirstName = model.FirstName;
                    empl.LastName = model.LastName;
                    empl.Email = model.Email;
                    empl.Code = model.Code;

                }
                context.SaveChanges();
                return true;
            }
        }



        public bool DeleteEmploy(int id)
        {
            using (var context = new DXCEntities())
            {
                var empl = context.Db_approach.FirstOrDefault(x => x.Id == id);
                if (empl != null)
                {
                    context.Db_approach.Remove(empl);
                    context.SaveChanges();
                    return true;

                }
                return false;
            }
        }
    }

}
