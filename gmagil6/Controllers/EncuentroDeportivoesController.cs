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
    public class EncuentroDeportivoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EncuentroDeportivoes
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.EncuentroDeportivoes.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts);
        }

        // GET: EncuentroDeportivoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentroDeportivo encuentroDeportivo = db.EncuentroDeportivoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((encuentroDeportivo.UserId != currentUserId) || encuentroDeportivo == null)
            {
                return HttpNotFound();
            }
            return View(encuentroDeportivo);
        }

        // GET: EncuentroDeportivoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EncuentroDeportivoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "encuentroDeportivoId,deporte,equipoLocal,equipoVisitante,ciudad,lugar,fecha,hora,precioMin,precioMedio,precioMax")] EncuentroDeportivo encuentroDeportivo)
        {
            string currentUserId = User.Identity.GetUserId();
            encuentroDeportivo.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.EncuentroDeportivoes.Add(encuentroDeportivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encuentroDeportivo);
        }

        // GET: EncuentroDeportivoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentroDeportivo encuentroDeportivo = db.EncuentroDeportivoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((encuentroDeportivo.UserId != currentUserId) || encuentroDeportivo == null)
            {
                return HttpNotFound();
            }
            return View(encuentroDeportivo);
        }

        // POST: EncuentroDeportivoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "encuentroDeportivoId,deporte,equipoLocal,equipoVisitante,ciudad,lugar,fecha,hora,precioMin,precioMedio,precioMax")] EncuentroDeportivo encuentroDeportivo)
        {
            string currentUserId = User.Identity.GetUserId();
            encuentroDeportivo.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(encuentroDeportivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encuentroDeportivo);
        }

        // GET: EncuentroDeportivoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentroDeportivo encuentroDeportivo = db.EncuentroDeportivoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((encuentroDeportivo.UserId != currentUserId) || encuentroDeportivo == null)
            {
                return HttpNotFound();
            }
            return View(encuentroDeportivo);
        }

        // POST: EncuentroDeportivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EncuentroDeportivo encuentroDeportivo = db.EncuentroDeportivoes.Find(id);
            db.EncuentroDeportivoes.Remove(encuentroDeportivo);
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
