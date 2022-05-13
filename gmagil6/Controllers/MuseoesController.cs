using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortalWeb2019.Models;
using Microsoft.AspNet.Identity;

namespace PortalWeb2019.Controllers
{
    [Authorize]
    public class MuseoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Museoes
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.Museos.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts);
        }

        // GET: Museoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Museo museo = db.Museos.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((museo.UserId != currentUserId) || museo == null)
            {
                return HttpNotFound();
            }
            return View(museo);
        }

        // GET: Museoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Museoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "museoId,nombre,diasCerrado,obras,precio")] Museo museo)
        {
            string currentUserId = User.Identity.GetUserId();
            museo.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Museos.Add(museo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(museo);
        }

        // GET: Museoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Museo museo = db.Museos.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((museo.UserId != currentUserId) || museo == null)
            {
                return HttpNotFound();
            }
            return View(museo);
        }

        // POST: Museoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "museoId,nombre,diasCerrado,obras,precio")] Museo museo)
        {
            string currentUserId = User.Identity.GetUserId();
            museo.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(museo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(museo);
        }

        // GET: Museoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Museo museo = db.Museos.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((museo.UserId != currentUserId) || museo == null)
            {
                return HttpNotFound();
            }
            return View(museo);
        }

        // POST: Museoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Museo museo = db.Museos.Find(id);
            db.Museos.Remove(museo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
