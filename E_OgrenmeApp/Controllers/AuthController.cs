using E_OgrenmeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace E_OgrenmeApp.Controllers
{
    public class AuthController : Controller
    {
        private string returnUrl;

        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            FormsAuthentication.SetAuthCookie(form.username, true);
            if (form.username == "admin" || form.password == "admin")
            {
                return Redirect("Admin/Home");
                
            }
            else
            {
                return Redirect("Login");
            }
        }
    }
}