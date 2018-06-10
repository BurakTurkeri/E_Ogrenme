using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using E_OgrenmeApp;
using E_OgrenmeApp.Models;
using E_OgrenmeApp.ViewModels;
using NHibernate.Linq;

namespace E_OgrenmeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly string returnUrl;

        // GET: Home
        public ActionResult anasayfa()
        {
            string[] dersler = { "Matematik", "Kimya", "Biyoloji", "Fizik" };

            var user = Database.Session.Query<Dersler>().ToList();
            
            if (user == null)
            {
                return Content("Ders Yok");
            }
            return View(user);
        }

        public ActionResult VideoAra()
        {
            return View();
        }


        public ActionResult Detay()
        {
            return View();
        }
    }
}