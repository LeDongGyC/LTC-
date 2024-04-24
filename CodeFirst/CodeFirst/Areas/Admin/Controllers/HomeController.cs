using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            var items = db.nhanViens.Where(nv => nv.Gender == 1 &&
                 nv.Age >= 30 &&
                 nv.Age <= 40 &&
                 nv.PhongBan.Id == 2)
    .ToList();
            return View(items);
        }
    }
}