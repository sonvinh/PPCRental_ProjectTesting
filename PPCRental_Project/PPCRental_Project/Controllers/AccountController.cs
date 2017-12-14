using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class AccountController : Controller
    {
        
        K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();
        //
        public ActionResult ViewDetail() 
        {
            if (Session["UserID"] != null) 
            {
                int id = (int)Session["UserID"];
                var userdetail = model.USER.FirstOrDefault(x => x.ID == id);
                return View(userdetail);
            }
            else 
            {
                return RedirectToAction("Index","Home");
            }

        }

        [HttpGet]
        public ActionResult ChangePassword() 
        {
            int id = (int)Session["UserID"];
            var userdetail = model.USER.FirstOrDefault(x => x.ID == id);
            return View(userdetail);
        }

        [HttpPost]
        public ActionResult ChangePassword(string oldpass, string newpass, string conpass) 
        {
            int id = (int)Session["UserID"];
            var userdetail = model.USER.FirstOrDefault(x => x.ID == id);
            if (userdetail.Password==oldpass) 
            {
                if (newpass == conpass) 
                {
                    userdetail.Password = newpass;
                    model.SaveChanges();
                    return RedirectToAction("ViewDetail","Account");
                }

            }
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Register(USER u) 
        {
            USER nu = new USER();
            try 
            {
                if (ModelState.IsValid)
                {
                    nu.Email = u.Email;
                    nu.Password = u.Password;
                    nu.FullName = u.FullName;
                    nu.Address = u.Address;
                    nu.Phone = u.Phone;
                    nu.Role = "1";
                    nu.Status = false;
                    model.USER.Add(nu);
                    model.SaveChanges();
                    return RedirectToAction("Login", "Account", new { area = "" });
               }
            }
            catch 
            {
                return View("Login",u);
            }
            return View("Login", u);


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
                        Session["FullName"] = user.FullName;
                        Session["UserID"] = user.ID;
                        Session["Role"] = user.Role;

                        

                        

                        if (user.Role.Equals("1"))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            return RedirectToAction("Index", "Admin/PropertyAdmin");
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

            return RedirectToAction("Index","Home");
        }
    }
}