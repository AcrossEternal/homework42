using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewMusic.Models;

namespace NewMusic.Controllers
{
    public class LoveMusicsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LoveMusics
        public ActionResult Index()
        {
            return View(db.LoveMusics.ToList());
        }

        // GET: LoveMusics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoveMusic loveMusic = db.LoveMusics.Find(id);
            if (loveMusic == null)
            {
                return HttpNotFound();
            }
            return View(loveMusic);
        }

        // GET: LoveMusics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoveMusics/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusciID,MusicName,MusicWhoName")] LoveMusic loveMusic)
        {
            if (ModelState.IsValid)
            {
                db.LoveMusics.Add(loveMusic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loveMusic);
        }

        // GET: LoveMusics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoveMusic loveMusic = db.LoveMusics.Find(id);
            if (loveMusic == null)
            {
                return HttpNotFound();
            }
            return View(loveMusic);
        }

        // POST: LoveMusics/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusciID,MusicName,MusicWhoName")] LoveMusic loveMusic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loveMusic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loveMusic);
        }

        // GET: LoveMusics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoveMusic loveMusic = db.LoveMusics.Find(id);
            if (loveMusic == null)
            {
                return HttpNotFound();
            }
            return View(loveMusic);
        }

        // POST: LoveMusics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoveMusic loveMusic = db.LoveMusics.Find(id);
            db.LoveMusics.Remove(loveMusic);
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
