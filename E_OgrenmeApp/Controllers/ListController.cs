using E_OgrenmeApp.Models;
using E_OgrenmeApp;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_OgrenmeApp.Controllers
{
    public class ListController : Controller
    {
        // GET: List

        public ActionResult Math()
        {
            var dersler = Database.Session.Query<Dersler>().ToList();
            return View(dersler);
        }
        public ActionResult Pysics()
        {
            var dersler = Database.Session.Query<Dersler>().ToList();
            return View(dersler);
        }
        public ActionResult Chemical()
        {
            var dersler = Database.Session.Query<Dersler>().ToList();
            return View(dersler);
        }
        public ActionResult Biology()
        {
            var dersler = Database.Session.Query<Dersler>().ToList();
            return View(dersler);
        }
    }
}