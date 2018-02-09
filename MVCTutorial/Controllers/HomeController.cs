using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Name = "Manoj Deshwal";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Name = "About Manoj Deshwal";
            return View();
        }
        public ActionResult Details()
        {
            List<Employee> listEmployee = new List<Employee>();
            Employee emp = new Employee();
            listEmployee.Add(new Employee { ID = 1, Name = "Ricky", Dept = "Sports", Address = "Australia" });
            listEmployee.Add(new Employee { ID = 2, Name = "Mark", Dept = "IT", Address = "England" });
            listEmployee.Add(new Employee { ID = 3, Name = "MSD", Dept = "Cricket", Address = "India" });
            listEmployee.Add(new Employee { ID = 4, Name = "Virat", Dept = "Cricket", Address = "India" });

            return View(listEmployee);
        }

    }
}