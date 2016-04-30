using aBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace aBlog.Controllers
{
    public class AuthController : Controller
    {
        UsersContext userContext = new UsersContext();
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin { });
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form , string ReturnUrl)
        {
            var user = userContext.Users.FirstOrDefault(u => u.Username == form.username);
            if (user == null)
                aBlog.Models.User.FakeHash();
   
            if (user == null || !user.CheckPassword(form.password))
                ModelState.AddModelError("Username", "Username or Password is incorrect!");

            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.username, true);
            

            if (!string.IsNullOrWhiteSpace(ReturnUrl))
                return Redirect(ReturnUrl);

            return RedirectToRoute("Home");     
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");
        }


    }
}