using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        Fall25_CEntities db = new Fall25_CEntities();
        // GET: Student
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s) {
            //validation
            
            db.Students.Add(s);
            db.SaveChanges(); //return no of rows affected
            TempData["Msg"] = "Data Created";
            return RedirectToAction("Index");                   
        }
        public ActionResult Details(int id) {
            var data = db.Students.Find(id); //search with primary key
            return View(data);

        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var data = db.Students.Find(id); //search with primary key
            //db.Students.Remove(data);
            //db.SaveChanges();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Student s) { 
            var exObj = db.Students.Find(s.Id);
            exObj.Address = s.Address;
            exObj.Email = s.Email;
            exObj.Name = s.Name;
            db.SaveChanges();
            TempData["Msg"] = "Data Updated";
            return RedirectToAction("Index");
        }
    }
}