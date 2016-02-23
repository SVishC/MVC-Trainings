using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMVCApplication.Models;

namespace DemoMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Details()
        {
            Employee employee = new Employee() { EmployeeId = 1, Name = "Sebastien", Gender = "Male", City = "Newyork" };
     
            return View(employee);
        }

    }
}
