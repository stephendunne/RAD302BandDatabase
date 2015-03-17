using RAD302Assignment.DAL;
using RAD302Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RAD302Assignment.Controllers
{
    public class HomeController : Controller
    {
        public MusicDb db = new MusicDb();


        public ActionResult Index()
        {
            ViewBag.PageTitle = "Stephen Dunne (s00130835) RAD302 Application";

            return View(db.Bands.OrderBy(b => b.Name).ToList());
        }

        //
        // GET: /Home/Details/5
        /*
        public ActionResult Details(int id)
        {
            ViewBag.PageTitle = "Details";

            Band band = db.Bands.Find(id);

            if (band == null)
            {
                return View();
            }

            else
            {
                return View(band);
            }
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            ViewBag.PageTitle = "Create";

            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Band band)
        {
            ViewBag.PageTitle = "Create";

            if(ModelState.IsValid)
            {
                db.Bands.Add(band);
                db.SaveChanges();
                return RedirectToAction("Index");
            };

            return View(band);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            ViewBag.PageTitle = "Edit";

            Band band = db.Bands.Find(id);
            if (band == null)
                return HttpNotFound();

            return View(band);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Band band)
        {
            ViewBag.PageTitle = "Edit";

            if (ModelState.IsValid)
            {
                db.Entry(band).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            };

            return View(band);
        }

        //
        // GET: /Home/Delete/5


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
         * */
    }
}
