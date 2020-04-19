using Bundles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bundles.Areas.HR.Controllers
{
    public class HomeController : Controller
    {
        // GET: HR/Home
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
    }
}