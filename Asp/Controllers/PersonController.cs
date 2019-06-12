using System;
using System.Diagnostics;
using System.Web.Mvc;
using AspCore.Models;

namespace AspCore.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View(Services.PersonsList);
        }
        
        [AcceptVerbs("POST","GET")]
        public ActionResult Add()
        {
            if (Request.HttpMethod == "POST")
            {
                Services.PersonsList.Add(new Person()
                {
                    Lastname = Request["Lastname"],
                    Firstname = Request["Firstname"],
                    Email = Request["Email"],
                    Id = Services.PersonsList.Count
                });
                int id = Services.PersonsList.Count-1;
                return RedirectToAction("See", new { index = id});
            };
            return View();
        }
        public ActionResult See(int index)
        {
            Person myPerson = Services.PersonsList[index];
            return View(myPerson);
        }
        public ActionResult Edit(int index)
        {
            if (Request.HttpMethod == "POST")
            {
                Services.PersonsList[index].Lastname = Request["Lastname"];
                Services.PersonsList[index].Firstname = Request["Firstname"];
                Services.PersonsList[index].Email = Request["Email"];
                int id = Services.PersonsList[index].Id;
                return RedirectToAction("See", new { index = id});
            };
            Person myPerson = Services.PersonsList[index];
            return View(myPerson);
        }
    }
}