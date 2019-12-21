using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Examen.Models;

namespace Examen.Controllers
{
    public class HistoriasController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: Historias
        public ActionResult Index()
        {
            return View(db.Historia.ToList());
        }

        // GET: Historias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historia historia = db.Historia.Find(id);
            if (historia == null)
            {
                return HttpNotFound();
            }
            return View(historia);
        }

        // GET: Historias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Historias/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fechaAlta,ddoctor,dpaciente,observaciones")] Historia historia)
        {
            if (ModelState.IsValid)
            {
                db.Historia.Add(historia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historia);
        }

        // GET: Historias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historia historia = db.Historia.Find(id);
            if (historia == null)
            {
                return HttpNotFound();
            }
            return View(historia);
        }

        // POST: Historias/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fechaAlta,ddoctor,dpaciente,observaciones")] Historia historia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historia);
        }

        // GET: Historias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Historia historia = db.Historia.Find(id);
            if (historia == null)
            {
                return HttpNotFound();
            }
            return View(historia);
        }

        // POST: Historias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Historia historia = db.Historia.Find(id);
            db.Historia.Remove(historia);
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
