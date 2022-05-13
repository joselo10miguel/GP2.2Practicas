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
    public class MusicalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Musicales
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.Musicals.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts); 
        }

        // GET: Musicales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((musical.UserId != currentUserId) || musical == null)
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // GET: Musicales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musicales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "musicalId,tituloMusical,ciudad,localizacion,duracionCiudad,fechaIni,fechaFin,hora,duracionObra,precioMin,precioMedio,precioMax,descripcionPrecios")] Musical musical)
        {
            string currentUserId = User.Identity.GetUserId();
            musical.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Musicals.Add(musical);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musical);
        }

        // GET: Musicales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((musical.UserId != currentUserId) || musical == null)
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // POST: Musicales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "musicalId,tituloMusical,ciudad,localizacion,duracionCiudad,fechaIni,fechaFin,hora,duracionObra,precioMin,precioMedio,precioMax,descripcionPrecios")] Musical musical)
        {
            string currentUserId = User.Identity.GetUserId();
            musical.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(musical).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musical);
        }

        // GET: Musicales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((musical.UserId != currentUserId) || musical == null)
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // POST: Musicales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Musical musical = db.Musicals.Find(id);
            db.Musicals.Remove(musical);
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
