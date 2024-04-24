using DataFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataFirst.Controllers
{
    public class HomeController : Controller
    {
        private EFEntities db = new EFEntities();
        public ActionResult Index()
        {
            var items = db.NhanViens.Where(nv => 
                nv.Age >= 30 &&
                nv.Age <= 40 &&
                nv.PhongBan.Id == 2)
   .ToList();
            return View(items);
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
    }
}