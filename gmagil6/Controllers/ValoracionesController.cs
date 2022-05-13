using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortalWeb2019.Models;

namespace PortalWeb2019.Controllers
{
    [AllowAnonymous]
    public class ValoracionesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Valoraciones
        public ActionResult Index()
        {
            return View(db.Valoracions.ToList());
        }

        // GET: Valoraciones/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valoracion valoracion = db.Valoracions.Find(id);
            if (valoracion == null)
            {
                return HttpNotFound();
            }
            return View(valoracion);
        }

        // GET: Valoraciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Valoraciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Identificador,NombreEntrada,TipoEntrada,Voto")] Valoracion valoracion)
        {
            if (ModelState.IsValid)
            {
                db.Valoracions.Add(valoracion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(valoracion);
        }

        // GET: Valoraciones/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valoracion valoracion = db.Valoracions.Find(id);
            if (valoracion == null)
            {
                return HttpNotFound();
            }
            return View(valoracion);
        }

        // POST: Valoraciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Identificador,NombreEntrada,TipoEntrada,Voto")] Valoracion valoracion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valoracion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(valoracion);
        }

        // GET: Valoraciones/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Valoracion valoracion = db.Valoracions.Find(id);
            if (valoracion == null)
            {
                return HttpNotFound();
            }
            return View(valoracion);
        }

        // POST: Valoraciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Valoracion valoracion = db.Valoracions.Find(id);
            db.Valoracions.Remove(valoracion);
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
