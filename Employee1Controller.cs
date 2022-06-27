using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace mvc.Controllers
{
    public class Employee1Controller : Controller
    {
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer =
           new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Employee employee)
        {
            if (ModelState.IsValid)
            {

                EmployeeBusinessLayer employeeBusinessLayer =
                    new EmployeeBusinessLayer();

              UpdateModel(employee);
          
                employeeBusinessLayer.AddEmmployee(employee);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer =
                   new EmployeeBusinessLayer();
            Employee employee =
                   employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            Employee employee = employeeBusinessLayer.Employees.Single(x => x.EmployeeId == id);
            UpdateModel(employee, new string[] { "EmployeeId", "Gender", "Salary", "DepartmentId" });

            if (ModelState.IsValid)
            {
                employeeBusinessLayer.SaveEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }

    }
}