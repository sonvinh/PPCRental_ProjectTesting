using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PPCRental_Project.Models;
using PPCRental_Project.Controllers;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.AcceptanceTests.Support;
using FluentAssertions;
using PPCRental_Project;

namespace PPCRental_Project.AcceptanceTests.Drivers.Project
{
    public class ProjectDriver
    {
        
        private readonly CatalogContext _context;

        //public ProjectDriver(SearchResultState result)
        //{
        //    _result = result;
        //}

        public ProjectDriver(CatalogContext context)
        {
            _context = context;
        }

        public void InsertProjecttoDB(Table givenProjects)
        {
            using (var db = new K21T3_Team1_PPC3129Entities())
            {
                foreach (var row in givenProjects.Rows)
                {
                    var property = new PROPERTY
                    {
                        PropertyName = row["PropertyName"],
                        Avatar = row["Avarta"],
                        Images = row["Images"],
                        Content = row["Content"],
                        PropertyType_ID = int.Parse(row["PropertyType"]),
                        Street_ID = int.Parse(row["Street"]),
                        Ward_ID = int.Parse(row["Ward"]),
                        District_ID = int.Parse(row["District"]),
                        Price = int.Parse(row["Price"]),
                        UnitPrice = row["UnitPrice"],
                        Area = row["Area"],
                        BedRoom = int.Parse(row["BedRoom"]),
                        BathRoom = int.Parse(row["BathRoom"]),
                        PackingPlace = int.Parse(row["PackingPlace"]),
                        UserID = int.Parse(row["UserID"]),
                        Created_at = Convert.ToDateTime(row["Create_at"]),
                        Create_post = Convert.ToDateTime(row["Create_post"]),
                        Status_ID = int.Parse(row["Status"]),
                        Note = row["Note"],
                        Updated_at = Convert.ToDateTime(row["Update_at"]),
                        Sale_ID = int.Parse(row["Sale_ID"])
                    };

                    _context.ReferenceProject.Add(
                        givenProjects.Header.Contains("Id") ? row["Id"] : property.PropertyName,
                        property);

                    db.PROPERTY.Add(property);
                }

                db.SaveChanges();
            }
        }


        //public void Navigate(string mail, string pass)
        //{           
        //    //var pro = _context.ReferenceProject.GetById(mail);
        //    //using (var controller = new AgencyController())
        //    //{
        //    //    //_result.ActionResult = controller.Login(mail, pass);
        //    //    _result.ActionResult = controller.Index(pro.ID);
        //    //}
        //    var controller = new AgencyController();
        //    _result.ActionResult = controller.Login(mail, pass);
          

           

        //}


        //public void ShowList(Table expectednameList)
        //{
        //    //Arrange
        //    var expected = expectednameList.Rows.Select(x => x["PropertyName"]);

        //    var ShownName = _result.ActionResult.Model<IEnumerable<PROPERTY>>();

        //    //Assert
        //    PropertyAssertions.HomeScreenShouldShow(ShownName, expected);
        //}
    }
}
