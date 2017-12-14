using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Agency.Controllers
{


    public class PropertyAgencyController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();

        
            public long Insert(PROPERTY entytiy)
            {
                K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();
            db.PROPERTY.Add(entytiy);
            db.SaveChanges();
                return entytiy.ID;
            }
        

        //
        // GET: /Agency/PropertyAgency/
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                var id = (int)Session["UserID"];
                var user = db.PROPERTY.Where(x => x.USER.ID == id).ToList();
                return View(user);
            }
            else
            {
                return View();
            }

        }
       

        // POST: /Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        public ActionResult Create()
        {
            ViewBag.District_ID = new SelectList(db.DISTRICT.Where(y => y.ID >= 31 && y.ID <= 54), "ID", "DistrictName");
            ViewBag.Status_ID = new SelectList(db.PROJECT_STATUS, "ID", "Status_Name");
            ViewBag.PropertyType_ID = new SelectList(db.PROPERTY_TYPE, "ID", "CodeType");
            ViewBag.Street_ID = new SelectList(db.STREET.Where(y => y.ID >= 31 && y.ID <= 54), "ID", "StreetName");
            ViewBag.UserID = new SelectList(db.USER, "ID", "Email");
            ViewBag.Sale_ID = new SelectList(db.USER, "ID", "Email");
            ViewBag.Ward_ID = new SelectList(db.WARD.Where(y => y.ID >= 31 && y.ID <= 54), "ID", "WardName");
            ViewBag.Feature_ID = new SelectList(db.FEATURE, "ID", "FeatureName");
            return View();
        }

        // POST: /Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PROPERTY property)
        {

            property.Avatar = AvatarU(property);
            property.Images = ImagesU(property);
            property.Created_at = DateTime.Now;
            property.Create_post = DateTime.Now; // sua lai sau
            property.UnitPrice = "VND";
            property.Status_ID = 1;
            property.UserID = (int)Session["UserID"];

            if (ModelState.IsValid)
            {

                db.PROPERTY.Add(property);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.District_ID = new SelectList(db.DISTRICT, "ID", "DistrictName", property.District_ID);
            ViewBag.Status_ID = new SelectList(db.PROJECT_STATUS, "ID", "Status_Name", property.Status_ID);
            ViewBag.PropertyType_ID = new SelectList(db.PROPERTY_TYPE, "ID", "CodeType", property.PropertyType_ID);
            ViewBag.Street_ID = new SelectList(db.STREET, "ID", "StreetName", property.Street_ID);
            ViewBag.UserID = new SelectList(db.USER, "ID", "Email", property.UserID);
            ViewBag.Sale_ID = new SelectList(db.USER, "ID", "Email", property.Sale_ID);
            ViewBag.Ward_ID = new SelectList(db.WARD, "ID", "WardName", property.Ward_ID);
            return View(property);
        }

        private string ImagesU(PROPERTY p)
        {

            string filename;
            string extension;
            string b;
            string s = "";
            foreach (var file in p.ImageFile2)
            {
                if (file.ContentLength > 0)
                {
                    filename = Path.GetFileNameWithoutExtension(file.FileName);
                    extension = Path.GetExtension(file.FileName);
                    filename = filename + DateTime.Now.ToString("yymmssff") + extension;
                    p.Images = "~/Images/"+ filename;
                    b = p.Images;
                    s = string.Concat(s, b, ",");
                    filename = Path.Combine(Server.MapPath("~/Images"), filename);
                    file.SaveAs(filename);

                }

            }
            return s;

        }
        private string AvatarU(PROPERTY p)
        {
            string s = "";
            string filename;
            string extension;


          
                 filename = Path.GetFileNameWithoutExtension(p.ImageFile.FileName);
                 extension = Path.GetExtension(p.ImageFile.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                p.Avatar = "~/Images/" + filename;
                 s = p.Avatar;
                filename = Path.Combine(Server.MapPath("~/Images"), filename);
                p.ImageFile.SaveAs(filename);
                return s;
            
            //return s;

        }



        public void ListItem()
        {
            ViewBag.property_type = db.PROPERTY_TYPE.ToList();
            ViewBag.ward = db.WARD.OrderByDescending(x => x.ID).Where(x=> x.District_ID>=31&& x.District_ID<=54).ToList();
            ViewBag.street = db.STREET.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.district = db.DISTRICT.OrderByDescending(x => x.ID).Where(x => x.ID>=31 && x.ID<=54).ToList();
            ViewBag.user = db.USER.OrderByDescending(x => x.ID).ToList();
            ViewBag.status = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();

        }
    }
}