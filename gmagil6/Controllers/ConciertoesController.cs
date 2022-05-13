﻿using System;
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
    public class ConciertoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Conciertoes
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userProducts = db.Conciertoes.Where(p => p.UserId == currentUserId).ToList();
            return View(userProducts);
        }

        // GET: Conciertoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concierto concierto = db.Conciertoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((concierto.UserId != currentUserId) || concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // GET: Conciertoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conciertoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConciertoId,CantanteGrupo,Lugar,Ciudad,DiasSemana,RangoFechas,Hora,DuracionEstimada,PrecioMin,PrecioMed,PrecioMax,DescPrecios")] Concierto concierto)
        {
            string currentUserId = User.Identity.GetUserId();
            concierto.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Conciertoes.Add(concierto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(concierto);
        }

        // GET: Conciertoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concierto concierto = db.Conciertoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((concierto.UserId != currentUserId) || concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // POST: Conciertoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConciertoId,CantanteGrupo,Lugar,Ciudad,DiasSemana,RangoFechas,Hora,DuracionEstimada,PrecioMin,PrecioMed,PrecioMax,DescPrecios")] Concierto concierto)
        {
            string currentUserId = User.Identity.GetUserId();
            concierto.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(concierto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(concierto);
        }

        // GET: Conciertoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concierto concierto = db.Conciertoes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((concierto.UserId != currentUserId) || concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // POST: Conciertoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Concierto concierto = db.Conciertoes.Find(id);
            db.Conciertoes.Remove(concierto);
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
