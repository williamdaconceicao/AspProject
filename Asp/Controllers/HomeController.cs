using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AspCore.Models;

namespace AspCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Students()
        {
            StudentsModel john = new StudentsModel()
            {
                Id=1,
                Name = "John Doe",
                Email = "John.Doe@supinfo.com",
                Classes = 3,
                JoinDate = new DateTime(2000,01,01)
            };             
            StudentsModel jane = new StudentsModel()
            {
                Id=1,
                Name = "Jane Doe",
                Email = "Jane.Doe@supinfo.com",
                Classes = 5,
                JoinDate = new DateTime(1998,01,01)
            }; 
            List<StudentsModel> students = new List<StudentsModel>();
            students.Add(jane);
            students.Add(john);
            return View(students);
        }
    }
}