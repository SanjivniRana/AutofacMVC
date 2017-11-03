using w6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace w6.Controllers
{
    public class UsersController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult loaddata()
        {

            // dc.Configuration.LazyLoadingEnabled = false; // if your table is relational, contain foreign key
            var data = db.Users.OrderBy(a => a.Name).ToList();
            return Json(new { data = data }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }



        //[HttpPost]
        //public ActionResult Index(State states)
        //{
        //    ViewBag.States = db.States.ToList();
        //    return View(states);
        //}



        //[HttpPost]
        //public ActionResult Index(Author author)
        //{
        //    if (string.IsNullOrEmpty(author.AuthorName))
        //    {
        //        ModelState.AddModelError("AuthorName", "Name is required");
        //    }

        //    if (string.IsNullOrEmpty(author.Address))
        //    {
        //        ModelState.AddModelError("Address", "Please enter your address in not more than 200 characters");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        ViewBag.AuthorName = author.AuthorName;
        //        ViewBag.Address = author.Address;
        //        ViewBag.DateOfBirth = author.DateOfBirth;
        //    }

        //    return View(author);
        //}



        public ActionResult Create()
        {
            ViewBag.StateList = db.Stas;
            var model = new User();
            return View(model);
          //  return View();
        }

        //  
        // POST: /CRUD/Create  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User employee)

        { 
            if (ModelState.IsValid)
            {
                db.Users.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StateList = db.Stas;

            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            User publisher = db.Users.Where(x => x.Id == id).SingleOrDefault();
            return View(publisher);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            User publisher = db.Users.Where(x => x.Id == model.Id).SingleOrDefault();
            if (publisher != null)
            {
                db.Entry(publisher).CurrentValues.SetValues(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        ////  
        //// GET: /CRUD/Delete/5  

        public ActionResult Delete(int id)
        {
            User publisher = db.Users.Find(id);//.Where(x => x.PublisherId == id).SingleOrDefault();
            return View(publisher);
        }
        [HttpPost]
        public ActionResult Delete(int id, User model)
        {
            var publisher = db.Users.Where(x => x.Id == id).SingleOrDefault();
            if (publisher != null)
            {
                db.Users.Remove(publisher);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Search(string q)
        {
            //q = "few random words" (no need to remove '+' signs) 
            var model = GetSearchResults(q);

             return View(model);
        }

        private object GetSearchResults(string q)
        {
            throw new NotImplementedException();
        }

        public ActionResult FillCity(int state)
        {
            var cities = db.Cts.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }


        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}

    }
}