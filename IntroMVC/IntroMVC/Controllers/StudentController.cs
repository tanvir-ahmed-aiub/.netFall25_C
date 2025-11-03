using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Details() {
            var s1 = new Student()
            {
                Id = 1,
                Name = "Rahim",
                Cgpa = 2.34f
            };

            return View(s1);
        }
        public ActionResult Index() {
            var s1 = new Student() { 
                Id= 1,
                Name= "s1",
                Cgpa = 3.45f

            };
            var s2 = new Student()
            {
                Id = 3,
                Name = "s2",
                Cgpa = 3.45f

            };
            var s3 = new Student()
            {
                Id = 3,
                Name = "s3",
                Cgpa = 3.45f

            };
            var s4 = new Student()
            {
                Id = 4,
                Name = "s4",
                Cgpa = 3.45f

            };
            var students = new Student[4] {s1,s2,s3,s4 };
            return View(students);
        }
        public ActionResult Create() {
            return View();
        }

        // GET: Student
        //public ActionResult Index()
        //{
        //    ViewBag.S1 = "Rahim";
        //    ViewBag.S2 = "Karim";
        //    ViewBag.S3 = "Sattar";
        //    return View();
        //}
        //public ActionResult Create()
        //{
        //    return View();
        //}
    }
}