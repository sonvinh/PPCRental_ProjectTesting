using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;
using System.IO;

namespace PPCRental_Project.Areas.Admin.Controllers
{
    public class PropertyAdminController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();
        // GET: Admin/PropertyAdmin
        public ActionResult Index()
        {
            var p = db.PROPERTY.OrderByDescending(x => x.ID).ToList();
            return View(p);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            ViewBag.property_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.StreetName = db.STREET.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.WardName = db.WARD.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.District = db.DISTRICT.OrderByDescending(x => x.ID).Where(x => x.ID >= 31 && x.ID <= 54).ToList();
            ViewBag.UserName = db.USER.OrderByDescending(x => x.ID).ToList();
            ViewBag.ProJectStatus = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();

            return View(property);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var property = new PROPERTY();
            ViewBag.property_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.StreetName = db.STREET.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.WardName = db.WARD.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.District = db.DISTRICT.OrderByDescending(x => x.ID).Where(x => x.ID >= 31 && x.ID <= 54).ToList();
            return View(property);

        }

        [HttpPost]
        public ActionResult Create(PROPERTY p)
        {
            var property = new PROPERTY();
            property.PropertyName = p.PropertyName;
            property.Avatar = p.Avatar;
            property.PropertyType_ID = p.PropertyType_ID;
            property.Content = p.Content;
            property.Street_ID = p.Street_ID;
            property.Ward_ID = p.Ward_ID;
            property.District_ID = p.District_ID;
            property.UnitPrice = p.UnitPrice;
            property.Area = p.Area;
            property.BedRoom = p.BedRoom;
            property.BathRoom = p.BathRoom;
            property.PackingPlace = p.PackingPlace;
            property.UserID = p.UserID;
            property.Created_at = p.Created_at;
            property.Create_post = p.Create_post;
            property.Status_ID = p.Status_ID;
            property.Note = p.Note;
            property.Updated_at = p.Updated_at;
            property.Sale_ID = p.Sale_ID;
            db.PROPERTY.Add(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            db.PROPERTY.Remove(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(property);
        }



        [HttpPost]
        public ActionResult Edit(PROPERTY p)
        {
            ListAll();
            // Images

            var entity = db.PROPERTY.Find(p.ID);
            try
            {
                string s = Upava(p);
                string c = Upima(p);
                entity.PropertyName = p.PropertyName;
                entity.Avatar = s;
                entity.Images = c;
                entity.PropertyType_ID = p.PropertyType_ID;
                entity.Content = p.Content;
                entity.Street_ID = p.Street_ID;
                entity.Ward_ID = p.Ward_ID;
                entity.District_ID = p.District_ID;
                entity.UnitPrice = p.UnitPrice;
                entity.Area = p.Area;
                entity.BedRoom = p.BedRoom;
                entity.BathRoom = p.BathRoom;
                entity.PackingPlace = p.PackingPlace;
                entity.UserID = p.UserID;
                entity.Created_at = p.Created_at;
                entity.Create_post = p.Create_post;
                entity.Status_ID = p.Status_ID;
                entity.Note = p.Note;
                entity.Updated_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                entity.Sale_ID = (int)Session["UserID"];
                db.SaveChanges();
            }
            catch (Exception)
            {
                try
                {
                    string s = Upava(p);
                    entity.PropertyName = p.PropertyName;
                    entity.Avatar = s;
                    entity.PropertyType_ID = p.PropertyType_ID;
                    entity.Content = p.Content;
                    entity.Street_ID = p.Street_ID;
                    entity.Ward_ID = p.Ward_ID;
                    entity.District_ID = p.District_ID;
                    entity.UnitPrice = p.UnitPrice;
                    entity.Area = p.Area;
                    entity.BedRoom = p.BedRoom;
                    entity.BathRoom = p.BathRoom;
                    entity.PackingPlace = p.PackingPlace;
                    entity.UserID = p.UserID;
                    entity.Created_at = p.Created_at;
                    entity.Create_post = p.Create_post;
                    entity.Status_ID = p.Status_ID;
                    entity.Note = p.Note;
                    entity.Updated_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                    entity.Sale_ID = (int)Session["UserID"];

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    try
                    {
                        string c = Upima(p);
                        entity.Images = c;
                        entity.PropertyName = p.PropertyName;
                        entity.PropertyType_ID = p.PropertyType_ID;
                        entity.Content = p.Content;
                        entity.Street_ID = p.Street_ID;
                        entity.Ward_ID = p.Ward_ID;
                        entity.District_ID = p.District_ID;
                        entity.UnitPrice = p.UnitPrice;
                        entity.Area = p.Area;
                        entity.BedRoom = p.BedRoom;
                        entity.BathRoom = p.BathRoom;
                        entity.PackingPlace = p.PackingPlace;
                        entity.UserID = p.UserID;
                        entity.Created_at = p.Created_at;
                        entity.Create_post = p.Create_post;
                        entity.Status_ID = p.Status_ID;
                        entity.Note = p.Note;
                        entity.Updated_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                        entity.Sale_ID = (int)Session["UserID"];

                        db.SaveChanges();


                    }
                    catch (Exception)
                    {
                        entity.PropertyType_ID = p.PropertyType_ID;
                        entity.Content = p.Content;
                        entity.Street_ID = p.Street_ID;
                        entity.Ward_ID = p.Ward_ID;
                        entity.District_ID = p.District_ID;
                        entity.UnitPrice = p.UnitPrice;
                        entity.Area = p.Area;
                        entity.BedRoom = p.BedRoom;
                        entity.BathRoom = p.BathRoom;
                        entity.PackingPlace = p.PackingPlace;
                        entity.UserID = p.UserID;
                        entity.Created_at = p.Created_at;
                        entity.Create_post = p.Create_post;
                        entity.Status_ID = p.Status_ID;
                        entity.Note = p.Note;
                        entity.Updated_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                        entity.Sale_ID = (int)Session["UserID"];

                        db.SaveChanges();

                    }
                }
            }

            return RedirectToAction("Index", "PropertyAdmin");
        }

        private string Upava(PROPERTY p)
        {
            string filename = Path.GetFileNameWithoutExtension(p.ImageFile.FileName);
            string extension = Path.GetExtension(p.ImageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
            p.Avatar = "~/Images/" + filename;
            string s = p.Avatar;
            filename = Path.Combine(Server.MapPath("~/Images"), filename);
            p.ImageFile.SaveAs(filename);
            return s;
        }

        private string Upima(PROPERTY p)
        {
            string filename;
            string extension;
            string s = "";
            string b;
            foreach (var item in p.ImageFile2)
            {
                filename = Path.GetFileNameWithoutExtension(item.FileName);
                extension = Path.GetExtension(item.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                p.Images = "~/Images/" + filename;
                b = p.Images;
                s = string.Concat(s, b, ",");
                filename = Path.Combine(Server.MapPath("~/Images"), filename);
                item.SaveAs(filename);
            }

            return s;
        }
        public void ListAll()
        {   
            ViewBag.property_type = db.PROPERTY_TYPE.ToList();
            ViewBag.street = db.STREET.OrderBy(x => x.StreetName).ToList();
            ViewBag.ward = db.WARD.OrderBy(x => x.WardName).ToList();
            ViewBag.district = db.DISTRICT.OrderBy(x => x.DistrictName).ToList();
            ViewBag.user = db.USER.OrderBy(x => x.FullName).ToList();
            ViewBag.status = db.PROJECT_STATUS.OrderBy(x => x.Status_Name).ToList();

        }

        public JsonResult GetStreet(int District_id)
        {
            return Json(
            db.STREET.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.StreetName }).ToList(),
            JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWard(int District_id)
        {
            return Json(
            db.WARD.Where(s => s.District_ID == District_id)
            .Select(s => new { id = s.ID, text = s.WardName }).ToList(),
            JsonRequestBehavior.AllowGet);
        }
    }
}