using FormProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        //public ActionResult Index()
        //{
        //    string uname = Request["Username"];

        //    return View();
        //}
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Login() { });
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (ModelState.IsValid) { 
                return RedirectToAction("Index","Home");
            }
            return View(login);
        }

        //[HttpPost]
        //public ActionResult Index(string Username, string Password)
        //{
        //    ViewBag.Uname = Username;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(FormCollection fc)
        //{
        //    ViewBag.Uname = fc["Username"];
        //    return View();
        //}
        [HttpGet]
        public ActionResult Register() {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Student s)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}