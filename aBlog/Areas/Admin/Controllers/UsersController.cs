using aBlog.Areas.Admin.ViewModels;
using aBlog.Infrastructure;
using aBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAttribute("users")]
    public class UsersController : Controller
    {
        UsersContext userContext = new UsersContext();

        public ActionResult Index()
        {

            return View(new UsersIndex()
            {
                Users = userContext.Users.ToList(),
                Roles = userContext.Roles.ToList(),
                Roles_Users = userContext.Roles_Users.ToList()
             });
        }



        public ActionResult New()
        {
            return View(new UsersNew());
        }
        [HttpPost]
        public ActionResult New(UsersNew form)
        {

            if (userContext.Users.Count(x => x.Username == form.Username) != 0)
                ModelState.AddModelError("Username", "Username already existed");

            if (!ModelState.IsValid)
                return View(form);

            var user = new User
            {
                Email = form.Email,
                Username = form.Username,
                
            };
            user.SetPassword(form.Password);
            userContext.Users.Add(user);
            userContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var user = userContext.Users.Find(id);
            if (user == null)
                return HttpNotFound();

            return View(new UsersEdit
            {
                Username = user.Username,
                Email = user.Email
            });
        }

        [HttpPost]
        public ActionResult Edit(int id , UsersEdit form)
        {
            var user = userContext.Users.Find(id);
            if (user == null)
                return HttpNotFound();

            if (userContext.Users.Count(a => a.Username == form.Username && a.Id != id) != 0)
                ModelState.AddModelError("Username", "Username already existed");

            if (!ModelState.IsValid)
                return View(form);

            user.Username = form.Username;
            user.Email = form.Email;
            userContext.SaveChanges();

            return RedirectToAction("Index");
                
        }

        public ActionResult ResetPassword(int id)
        {
            var user = userContext.Users.Find(id);
            if (user == null)
                return HttpNotFound();

            return View(new UsersResetPassword
            {
                Username = user.Username,
            });
        }

        [HttpPost]
        public ActionResult ResetPassword(int id, UsersResetPassword form)
        {

            var user = userContext.Users.Find(id);
            if (user == null)
                return HttpNotFound();

            form.Username = user.Username;

            if (!ModelState.IsValid)
                return View(form);

            user.SetPassword(form.Password);
            userContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var user = userContext.Users.Find(id);
            if (user == null)
                return HttpNotFound();
            userContext.Users.Remove(user);
            userContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}