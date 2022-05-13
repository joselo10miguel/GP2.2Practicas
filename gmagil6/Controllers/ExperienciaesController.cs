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
    public class ExperienciaesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Experienciaes
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.Experiencias.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts);
        }

        // GET: Experienciaes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiencia experiencia = db.Experiencias.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if((experiencia.UserId != currentUserId) || experiencia == null)
            {
                return HttpNotFound();
            }
            return View(experiencia);
        }

        // GET: Experienciaes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Experienciaes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExperienciaId,TipoExperiencia,Lugar,Ciudad_Pueblo,AgenciaPatrocinadora,DiasSemana,RangoFechas,Hora,DuracionEstimada,PrecioMin,PrecioMed,PrecioMax,DescPrecios,Excepciones")] Experiencia experiencia)
        {
            string currentUserId = User.Identity.GetUserId();
            experiencia.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Experiencias.Add(experiencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experiencia);
        }

        // GET: Experienciaes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiencia experiencia = db.Experiencias.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((experiencia.UserId != currentUserId) || experiencia == null)
            {
                return HttpNotFound();
            }
            return View(experiencia);
        }

        // POST: Experienciaes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExperienciaId,TipoExperiencia,Lugar,Ciudad_Pueblo,AgenciaPatrocinadora,DiasSemana,RangoFechas,Hora,DuracionEstimada,PrecioMin,PrecioMed,PrecioMax,DescPrecios,Excepciones")] Experiencia experiencia)
        {
            string currentUserId = User.Identity.GetUserId();
            experiencia.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(experiencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experiencia);
        }

        // GET: Experienciaes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiencia experiencia = db.Experiencias.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((experiencia.UserId != currentUserId) || experiencia == null)
            {
                return HttpNotFound();
            }
            return View(experiencia);
        }

        // POST: Experienciaes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Experiencia experiencia = db.Experiencias.Find(id);
            db.Experiencias.Remove(experiencia);
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
