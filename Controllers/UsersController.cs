using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProj.Entity;

namespace TestProj.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        private WhereHouseEntities1 db = new WhereHouseEntities1();
        public ActionResult Index(int? page)
        {
            int pagesize = 3;
            int pageNum;
            if (page == null)
            {
                pageNum = (page ?? 1);
            }
            else
            {
                pageNum = (int)page;
            }
            var ruselt = db.Users.ToList();
            return View(ruselt.ToPagedList(pageNum, pagesize));
        }


        public ActionResult Details(int id)
        {

            var res = db.Users.Where(x => x.Id == id).FirstOrDefault();
            return View(res);
        }
        public ActionResult Edit(int id)
        {
            var res = db.Users.Where(x => x.Id == id).FirstOrDefault();

            var dev = db.Devices.ToList();
            ViewBag.dev = dev;

            return View(res);
        }



        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
