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

        public ActionResult Details(int id)
        {
           // Employee employee = new Employee() { EmployeeId = 1, Name = "Sebastien", Gender = "Male", City = "Newyork" };
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
     
            return View(employee);
        }

    }
}
