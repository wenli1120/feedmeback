using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FeedMeBack.Models;
using Microsoft.AspNet.Identity;

namespace FeedMeBack.Controllers
{
    public class SystemKeysController : Controller
    {
        private FeedMeBackContext db = new FeedMeBackContext();

        // GET: SystemKeys
        public ActionResult Index()
        {

            var userId = User.Identity.GetUserId();
            var systems = db.SystemKeys.Where(x => x.UserId == userId).ToList();

            return View(systems);
        }

        // GET: SystemKeys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemKey systemKey = db.SystemKeys.Find(id);
            if (systemKey == null)
            {
                return HttpNotFound();
            }
            return View(systemKey);
        }

        // GET: SystemKeys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemKeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,UserName,Key,System,Url,CreatedOn")] SystemKey systemKey)
        {
            if (ModelState.IsValid)
            {
                systemKey.CreatedOn = DateTime.Now;
                systemKey.UserId = User.Identity.GetUserId();
                systemKey.UserName = User.Identity.Name;
                systemKey.Key = Guid.NewGuid().ToString();
                db.SystemKeys.Add(systemKey);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemKey);
        }

        // GET: SystemKeys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemKey systemKey = db.SystemKeys.Find(id);
            if (systemKey == null)
            {
                return HttpNotFound();
            }
            return View(systemKey);
        }

        // POST: SystemKeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,UserName,Key,System,Url,CreatedOn")] SystemKey systemKey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemKey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemKey);
        }

        // GET: SystemKeys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemKey systemKey = db.SystemKeys.Find(id);
            if (systemKey == null)
            {
                return HttpNotFound();
            }
            return View(systemKey);
        }

        // POST: SystemKeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SystemKey systemKey = db.SystemKeys.Find(id);
            db.SystemKeys.Remove(systemKey);
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
