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

namespace E_OgrenmeApp.Areas.Ders.Controllers
{
    public class DersController : Controller
    {
        // GET: Ders/Ders
        [SelectedTabAttribute("DrsSil")]
        public ActionResult Index()
        {
            var user = Database.Session.Query<Dersler>().ToList();
            if (user == null)
            {
                return Content("İçi Boş");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(AnasayfaNew form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);

            }

            var dersler = new Dersler()
            {
                Ders_Adı = form.DersAdı,
                Ders_Konu = form.DersKonu,
                Link = form.Link,
                Pdf = form.Pdf

            };
            Database.Session.Save(dersler);
            return RedirectToAction("Index");

        }
        [SelectedTabAttribute("DrsEkle")]
        public ActionResult Post()
        {
            return View();
        }

        public ActionResult Auth()
        {
            return View();
        }
    }
}