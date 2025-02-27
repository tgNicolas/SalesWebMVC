using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesWebMVC.Controllers
{
    public class DepartamentsController : Controller
    {
        // GET: Departaments
        public ActionResult Index()
        {
            List<Departaments> List = new List<Departaments>();

            List.Add(new Departaments { Id = 1, Name = "Eletronics" });
            List.Add(new Departaments { Id = 2, Name = "Fashion" });
            return View(List);
        }
    }
}