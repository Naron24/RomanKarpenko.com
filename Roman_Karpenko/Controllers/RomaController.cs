using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roman_Karpenko.Controllers
{
    public class RomaController : Controller
    {
        // GET: Roma
        public ActionResult Index()
        {
            return View();
        }
    }
}