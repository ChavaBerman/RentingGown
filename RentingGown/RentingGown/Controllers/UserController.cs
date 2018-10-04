using RentingGown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentingGown.Controllers
{
    public class UserController : Controller
    {
        private RentingGownDB db = new RentingGownDB();
        // GET: User
        public ActionResult Login(string name,string password)
        {
            Users user = db.Users.FirstOrDefault(u => u.username == name && u.password == password);
            if (user != null)
            {
                if (user.status == 1)//מנהל
                    return RedirectToAction("Manager", "Manager");
                //משכיר
                return RedirectToAction("Renter", "Renter");
            }
            return View();
        }
    }

    public class User
    {
        public ActionResult Login()
        {
            throw new System.NotImplementedException();
        }
    }
}