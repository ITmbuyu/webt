using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webt.Models;

namespace webt.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]

        public ActionResult LogIn(UserProfileClass LogingIn)
        {
            LogingIn.Views = LogingIn.ReturnView();
            return View(LogingIn);
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }

        
    }
}

//public ActionResult LogIn(UserProfileClass LogingIn)
//{
//    LogingIn.Views = LogingIn.ReturnView();

//    if (LogingIn.Email == "email@gmail.com" && LogingIn.Password == "password123")
//    {
//        ViewBag["IsSuccess"] = true;
//    }
//    else
//    {
//        ViewBag["IsSuccess"] = ;
//    }

//    return View(LogingIn);
//}