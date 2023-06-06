using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProj.Entity;

namespace TestProj.Controllers
{
    public class HomeController : Controller
    {                               
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

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}