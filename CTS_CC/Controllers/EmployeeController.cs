using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CTS_CC.Models;
using CTS_CC.DbOperations;

namespace CTS_CC.Controllers
{
    [RoutePrefix("employee")]
    public class EmployeeController : Controller
    {

        EmployeeRepository employeeRepository = null;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }

        // GET: Employee
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                int id = employeeRepository.AddEmployee(emp);
                if(id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSccess = "Data Added";
                }
            }
            return View();
        }
    }
}