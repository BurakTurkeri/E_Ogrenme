using E_OgrenmeApp.Infrastructure;
using E_OgrenmeApp.Models;
using E_OgrenmeApp;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using E_OgrenmeApp.Areas;
using E_OgrenmeApp.Areas.ViewModels;

namespace E_OgrenmeApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home

        [SelectedTabAttribute("OgrSil")]
        public ActionResult Index()
        {
            var user = Database.Session.Query<Ogretmenler>().ToList();
            if (user == null)
            {
                return Content("İçi Boş");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(HomeNew form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);

            }

            var ogretmen = new Ogretmenler()
            {
                Ogretmen_Adı = form.Adı,
                Ogretmen_Soyadı = form.Soyadı,
                Verdigi_Ders = form.Branşı


            };
            Database.Session.Save(ogretmen);
            return RedirectToAction("Index");

        }
        [SelectedTabAttribute("OgrEkle")]
        public ActionResult Post()
        {
            return View();
        }

        public ActionResult OgretmenListele()
        {
            var ogretmen = Database.Session.Query<Ogretmenler>().ToList();

            return View(new HomeOgretmenListele()
            {
                ogretmenler = ogretmen
            });
        }

        public ActionResult Auth()
        {
            return View();
        }
    }
}