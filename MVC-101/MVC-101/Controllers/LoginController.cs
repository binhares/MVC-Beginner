using MVC_101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_101.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            MVCBeginnerEntities cbe = new MVCBeginnerEntities();
            var s = cbe.GetLoginInfo(model.UserName, model.Password);

            var item = s.FirstOrDefault();
            if (item == "Success")
            {

                return View("UserLandingView");
            }
            else if (item == "User Does not Exists")

            {
                ViewBag.NotValidUser = item;

            }
            else
            {
                ViewBag.Failedcount = item;
            }

            return View("Index");
        }

        public ActionResult UserLandingView()
        {
            return View();
        }
    }
}