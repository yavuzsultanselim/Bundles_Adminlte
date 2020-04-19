using Bundles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bundles.Areas.IT.Controllers
{
    public class HomeController : Controller
    {
        // GET: IT/Home
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View(db.Employees.ToList()); ;

        }
        public ActionResult Orders()
        {
            return View(db.Orders.ToList());
        }

        public ActionResult Products()
        {
            return View(db.Products.ToList());
        }
    }
}