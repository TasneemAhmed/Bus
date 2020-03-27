using BusBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusBookingSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult List()
        {
            var users = getUsers();
            return View(users);
        }

        public IEnumerable<User> getUsers()
        {
            //this var users is dbset in db , that get all users in db.
            var users = db.Users.ToList();
            return users;
        }

        public ActionResult Details(int id)
        {

            //SingleOrDefault() : this is for single specific customer.
            var user = getUsers().SingleOrDefault(c => c.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var user = db.Users.SingleOrDefault(d => d.Id == id);
            db.Users.Remove(user);
            db.SaveChanges();

            return RedirectToAction("List");
        }


    }
}