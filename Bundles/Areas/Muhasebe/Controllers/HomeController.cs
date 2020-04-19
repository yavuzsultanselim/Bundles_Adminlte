using Bundles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bundles.Areas.Muhasebe.Controllers
{
     
    public class HomeController : Controller
    {
        // GET: Muhasebe/Home
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(db.Orders.OrderByDescending(x=>x.OrderDate).ToList());
        }
    }
}