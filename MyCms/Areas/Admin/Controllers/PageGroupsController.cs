﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace MyCms.Areas.Admin.Controllers
{
    [Authorize]
    public class PageGroupsController : Controller
    {
        IPageGroupRepository pageGroupRepository;
        MyCmsContext db = new MyCmsContext();

        public PageGroupsController()
        {
            pageGroupRepository = new PageGroupRepository(db);
        }

        // GET: Admin/PageGroups
        public ActionResult Index()
        {
            return View(pageGroupRepository.GetAllGroups());
        }

        // GET: Admin/PageGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageGroup pageGroup = pageGroupRepository.GetGroupById(id.Value);
            if (pageGroup == null)
            {
                return HttpNotFound();
            }
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Admin/PageGroups/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (ModelState.IsValid)
            {
                pageGroupRepository.InsertGroup(pageGroup);
                pageGroupRepository.Save();
                return RedirectToAction("Index");
            }

            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageGroup pageGroup = pageGroupRepository.GetGroupById(id.Value);
            if (pageGroup == null)
            {
                return HttpNotFound();
            }
            return PartialView(pageGroup);
        }

        // POST: Admin/PageGroups/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GroupID,GroupTitle")] PageGroup pageGroup)
        {
            if (ModelState.IsValid)
            {
                pageGroupRepository.UpdateGroup(pageGroup);
                pageGroupRepository.Save();
                return RedirectToAction("Index");
            }
            return View(pageGroup);
        }

        // GET: Admin/PageGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageGroup pageGroup = pageGroupRepository.GetGroupById(id.Value);
            if (pageGroup == null)
            {
                return HttpNotFound();
            }
            return PartialView(pageGroup);
        }

        // POST: Admin/PageGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pageGroupRepository.DeleteGroup(id);
            pageGroupRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                pageGroupRepository.Dispose();
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
