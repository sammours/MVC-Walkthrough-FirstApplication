using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(int? id1, int? id2)
        {
            return View();
        }
    }
}