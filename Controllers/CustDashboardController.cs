using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webt.Controllers
{
    public class CustDashboardController : Controller
    {
        // GET: CustDashboard
        public ActionResult CustomerDash()
        {
            return View();
        }
    }
}