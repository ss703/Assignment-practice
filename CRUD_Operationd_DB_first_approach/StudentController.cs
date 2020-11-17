using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using frst_db_entity_framweork_again.Context;


namespace frst_db_entity_framweork_again.Controllers
{
    public class StudentController : Controller
    {
        db_testEntities dbObj = new db_testEntities();
        // GET: Student
        public ActionResult Student(db_student obj)
        {
        
                return View(obj);
           
        }

        [HttpPost]
        public ActionResult AddStudent(db_student model)
        {
            db_student obj = new db_student();


            if (ModelState.IsValid)
            {

                obj.Id = model.Id;
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Description = model.Description;
                obj.Mobile = model.Mobile;

                if(model.Id==0)
                {
                    dbObj.db_student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    dbObj.SaveChanges();

                }
                

            }
            ModelState.Clear();

            return View("Student");
        }


        public ActionResult StudentList()
        {
            var res = dbObj.db_student.ToList();

            return View(res);
        }

        public ActionResult Delete(int id)
        {
            var res1 = dbObj.db_student.Where(x => x.Id == id).First();
            dbObj.db_student.Remove(res1);
            dbObj.SaveChanges();

            var list = dbObj.db_student.ToList();


            return View("StudentList",list);
        }
    }
}