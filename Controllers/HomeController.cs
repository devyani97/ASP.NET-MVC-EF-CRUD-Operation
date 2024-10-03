using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_EF_CRUD_Operation.Models;
using System.Data.Entity;


namespace ASP.NET_MVC_EF_CRUD_Operation.Controllers
{
    public class HomeController : Controller
    {
        ServicesContext db = new ServicesContext();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.emp.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                db.emp.Add(e);
                int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["CreateMessage"] = "<script>alert('Data Saved..')</script>";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["CreateMessage"] = "<script>alert('Data Not saved..')</script>";
                    }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.emp.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            db.Entry(e).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["UpdateMessage"] = "<script>alert('Data Updated..')</script>";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["UpdateMessage"] = "<script>alert('Data Not Updated..')</script>";
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row = db.emp.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            db.Entry(e).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["DeleteMessage"] = "<script>alert('Data Deleted..')</script>";
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["DeleteMessage"] = "<script>alert('Data Not Deleted..')</script>";
            }
            return View(e);
        }

        public ActionResult Details(int id)
        {
            var row = db.emp.Where(model => model.ID == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Details(Employee e)
        {
            db.Entry(e).State = EntityState.Unchanged;
            int a = db.SaveChanges();
            if (a > 0)
            {
                //ViewBag.UpdateMessage = ("<script>alert('Data Updated..')</script>");
                return RedirectToAction("Index");
            }
            else
            {
                //ViewBag.DetailsMessage = ("<script>alert('Not Available..')</script>");
            }
            return View();
        }
    }
}