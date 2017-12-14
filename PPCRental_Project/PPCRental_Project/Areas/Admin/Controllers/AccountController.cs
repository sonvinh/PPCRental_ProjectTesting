using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
            K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();
        //

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = model.USER.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    if (user.Status == true) 
                    {
                        Session["Fullname"] = user.FullName;
                        Session["UserID"] = user.ID;
                        Session["UserRole"] = user.Role;
                        if (user.Role.Equals("0"))
                        {
                            return RedirectToAction("Index", "PropertyAdmin");
                        }
                        else if (user.Role.Equals("2"))
                        {
                            return RedirectToAction("Index", "Engineer/PropertyAdmin");
                        }
                    }
                    else 
                    {
                        ViewBag.messageStatus = "Tai khoan khong kha dung";
                    }
                }
                ViewBag.message = "Email hoac mat khau khong hop le!";
            }
            else
            {
                ViewBag.message = "Email hoac mat khau khong hop le!";
            }
            return View();
        }

        [HttpGet]
        public ActionResult LogOut()
        {

            Session["FullName"] = null;
            Session["UserID"] = null;

            return RedirectToAction("Index", "Home", new { area=""});
        }
    }
}
