using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webt.Controllers
{
    public class TecDashboardController : Controller
    {
        // GET: TecDashboard
        public ActionResult TechnicianDash()
        {
            return View();
        }
    }
}