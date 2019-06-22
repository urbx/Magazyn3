using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using yyyooolo;

namespace yyyooolo.Controllers
{
    public class towariesController : Controller
    {
        private magazynEntities db = new magazynEntities();

        // GET: towaries
        public ActionResult Index()
        {
            return View(db.towary.ToList());
        }

        // GET: towaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            towary towary = db.towary.Find(id);
            if (towary == null)
            {
                return HttpNotFound();
            }
            return View(towary);
        }

        // GET: towaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: towaries/Create
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_towaru,nazwa_towaru,symbol,stan_poczatkowy,cena_zakupu,stawka_vat,marza,cena_sprzedazy")] towary towary)
        {
            if (ModelState.IsValid)
            {
                db.towary.Add(towary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(towary);
        }

        // GET: towaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            towary towary = db.towary.Find(id);
            if (towary == null)
            {
                return HttpNotFound();
            }
            return View(towary);
        }

        // POST: towaries/Edit/5
        // Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        // Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_towaru,nazwa_towaru,symbol,stan_poczatkowy,cena_zakupu,stawka_vat,marza,cena_sprzedazy")] towary towary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(towary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(towary);
        }

        // GET: towaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            towary towary = db.towary.Find(id);
            if (towary == null)
            {
                return HttpNotFound();
            }
            return View(towary);
        }

        // POST: towaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            towary towary = db.towary.Find(id);
            db.towary.Remove(towary);
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
