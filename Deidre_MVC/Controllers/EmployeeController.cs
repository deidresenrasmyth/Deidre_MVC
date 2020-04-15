using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Deidre_MVC.Models;

namespace Deidre_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();


        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(int? id)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            List<Employeeinfo> empList = new List<Employeeinfo>();
            empList = employeeDAL.GetAllEmployee().ToList(); ;
            return View(empList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Employeeinfo objEmp)
        {
            if (ModelState.IsValid)
            {
                employeeDAL.AddEmployee(objEmp);
                return RedirectToAction("Index");
            }
            return View(objEmp);
        }

      
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Employeeinfo emp = employeeDAL.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id,[Bind] Employeeinfo objEmp)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                employeeDAL.UpdateEmployee(objEmp);
                return RedirectToAction("Index");
            }
            return View(employeeDAL);
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Employeeinfo emp = employeeDAL.GetEmployeeById(id);
            if(emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employeeinfo emp = employeeDAL.GetEmployeeById(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        [AutoValidateAntiforgeryToken]
         public IActionResult DeleteEmp(int? id)
        {
            employeeDAL.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }





}