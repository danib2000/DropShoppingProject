using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseTest.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.UserProcessor;

namespace DatabaseTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult SignUp()
        {
            ViewBag.Message = "User Register";

            return View();
        }

        public ActionResult ViewUsers()
        {
            ViewBag.Message = " Users List";
            var data = LoadUsers();
            List<UsersModel> users = new List<UsersModel>();
            foreach(var row in data)
            {
                users.Add(new UsersModel
                {

                    UserName = row.UserName,
                    EmailAddress = row.Email,
                    ConfirmEmail = row.Email
                });
            }


            return View(users);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Models.UsersModel model)
        {
            if(ModelState.IsValid)
            {
                int rc =CreateUser(model.UserName, model.EmailAddress, 0);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}