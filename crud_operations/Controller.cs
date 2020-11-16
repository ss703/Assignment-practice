using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myapp.Models;
using MvcApp.Db.DbOperations;


namespace Setting_Entity_Framework.Controllers
{
    public class HomeController : Controller
    {
        Employe emp = null;
        public HomeController()
        {
            emp = new Employe();
        }
        
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(EmpModels model)
        {
            if(ModelState.IsValid)
            {
                int id = emp.AddEmploye(model);
                if(id>0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "Data Added";
                }
            }
            return View();
        }

        public ActionResult GetAllRecords()
        {
            var result = emp.GetAllEmployess();

            return View(result);
        }
        public ActionResult Details(int id)
        {
            var employe = emp.GetEmployess(id);
            return View(employe);
        }
       
        public ActionResult Edit(int id)
        {
            var empl = emp.GetEmployess(id);
            return View(empl);
        }

        [HttpPost]

        public ActionResult Edit(EmpModels model)
        {
            if (ModelState.IsValid)
            {
                  emp.UpdateEmploye(model.Id, model);
                return RedirectToAction("GetAllRecords");
            }
            return View();

        }


        

       
        public ActionResult Delete(int id)
        {
            emp.DeleteEmploy(id);
            return RedirectToAction("GetAllRecords");
        }










    }

}
