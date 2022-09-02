using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvc.Models;

namespace MyMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeModel> em = EmployeeModel.GetAllEmployees();
            var result = em.GroupBy(x => x.City);
            foreach(var item in result)
            {

            }









            //List<EmployeeModel> em = EmployeeModel.GetAllEmployees();

            //return View(em);
            //ViewBag.CompanyName="Global Logic";
            //ViewData["MyCompanyName"] = "My Company name is Global Logic";
            //List<int> rollNumber = new List<int>() { 10, 20, 30, 40, 50 };
            //ViewBag.Min = rollNumber.Min();
            //ViewBag.Max = rollNumber.Max();
            //ViewBag.Count = rollNumber.Count();
            //ViewBag.Sum = rollNumber.Sum();

            return View();
        }

        //public string Index()
        //{
        //    return "First MVC app";
        //}

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            List<EmployeeModel> listEmpModels= EmployeeModel.GetAllEmployees();

            //return View(em.FirstOrDefault(x=> x.id==id));
            // EmployeeModel em = listEmpModels.FirstOrDefault(x=>x.id==id);
            EmployeeModel em = null;
           foreach (var item in listEmpModels)
            {
                if(item.id==id)
                {
                    em = item;
                    break;
                }
            }
            return View(em);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EmployeeModel.GetAllEmployees();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
