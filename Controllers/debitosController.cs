using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Control_cash.Models;

namespace Control_cash.Controllers
{
    public class debitosController : Controller
    {
        private contexto db = new contexto();

        // GET: debitos
        public ActionResult Index()
        {
            return View(db.Debitos.ToList());
        }

        // GET: debitoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debito debito = db.Debitos.Find(id);
            if (debito == null)
            {
                return HttpNotFound();
            }
            return View(debito);
        }

        // GET: debitos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: debitos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,valor,Data")] debito debito)
        {
            if (ModelState.IsValid)
            {
                db.Debitos.Add(debito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(debito);
        }

        // GET: debitoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debito debito = db.Debitos.Find(id);
            if (debito == null)
            {
                return HttpNotFound();
            }
            return View(debito);
        }

        // POST: debitoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,valor,Data")] debito debito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(debito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(debito);
        }

        // GET: debitoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            debito debito = db.Debitos.Find(id);
            if (debito == null)
            {
                return HttpNotFound();
            }
            return View(debito);
        }

        // POST: debitoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            debito debito = db.Debitos.Find(id);
            db.Debitos.Remove(debito);
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
