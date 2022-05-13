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
    public class ObraTeatroesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ObraTeatroes
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.ObraTeatroes.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts);
        }

        // GET: ObraTeatroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraTeatro obraTeatro = db.ObraTeatroes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((obraTeatro.UserId != currentUserId) || obraTeatro == null)
            {
                return HttpNotFound();
            }
            return View(obraTeatro);
        }

        // GET: ObraTeatroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObraTeatroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "obrasTeatroID,titulo,ciudad,lugar,duracion,diasMenos,rangoFechas,hora,duracionEstimada,precioMinimo,precioMedio,precioMaximo,descPrecios")] ObraTeatro obraTeatro)
        {
            string currentUserId = User.Identity.GetUserId();
            obraTeatro.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.ObraTeatroes.Add(obraTeatro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obraTeatro);
        }

        // GET: ObraTeatroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraTeatro obraTeatro = db.ObraTeatroes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((obraTeatro.UserId != currentUserId) || obraTeatro == null)
            {
                return HttpNotFound();
            }
            return View(obraTeatro);
        }

        // POST: ObraTeatroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "obrasTeatroID,titulo,ciudad,lugar,duracion,diasMenos,rangoFechas,hora,duracionEstimada,precioMinimo,precioMedio,precioMaximo,descPrecios")] ObraTeatro obraTeatro)
        {
            string currentUserId = User.Identity.GetUserId();
            obraTeatro.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(obraTeatro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obraTeatro);
        }

        // GET: ObraTeatroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraTeatro obraTeatro = db.ObraTeatroes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((obraTeatro.UserId != currentUserId) || obraTeatro == null)
            {
                return HttpNotFound();
            }
            return View(obraTeatro);
        }

        // POST: ObraTeatroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObraTeatro obraTeatro = db.ObraTeatroes.Find(id);
            db.ObraTeatroes.Remove(obraTeatro);
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
