using Models;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarRental.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login()
        {
            return PartialView(new ViewModelUserLogin());
        }

        [HttpPost]
        public ActionResult Login(ViewModelUserLogin user)
        {
            return PartialView();
        }

        public ActionResult Register()
        {
            return View(new ViewModelUserRegister());
        }

        [HttpPost]
        public ActionResult Register(ViewModelUserRegister newUser)
        {
            return View();
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}