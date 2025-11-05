using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}