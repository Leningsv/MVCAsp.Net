using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApi.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult GetPeople()
        {
            List<PeopleModel> peopleModel = new List<PeopleModel>
            {
                new PeopleModel {Id= 1, Etnia= "Mestisa", Country="Ecuador" }              
            };
            ViewData["GetPeople"] = peopleModel;
            return View(peopleModel);
        }
    }
}