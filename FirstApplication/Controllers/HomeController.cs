

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplication.Models;


namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        private MvcContext _context = new MvcContext();
        public ActionResult Index()
        {
            throw new Exception();
            var list = _context.Students.ToList();
            return View(list);
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

        public ActionResult Team()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult GetBestStudent()
        {
            var student = _context.Students.OrderBy(x => x.Name).ToList();
            return PartialView("_GetBestStudent", student);
        }
    }
}