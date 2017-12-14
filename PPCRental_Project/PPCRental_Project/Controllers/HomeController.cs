using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class HomeController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();
        public ActionResult Index(int page = 1)
        {
            //liet ke cac bang se su dung trong trang index
            List<object> model = new List<object>();
            model.Add(db.PROPERTY.ToList());
            model.Add(db.DISTRICT.ToList());
            model.Add(db.STREET.ToList());
            model.Add(db.WARD.ToList());
            model.Add(db.PROPERTY_TYPE.ToList());
            model.Add(db.FEATURE.ToList());
            ViewBag.Page = page;
            return View(model);
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

        public ActionResult Error() 
        {
            return View();
        }

    }
}