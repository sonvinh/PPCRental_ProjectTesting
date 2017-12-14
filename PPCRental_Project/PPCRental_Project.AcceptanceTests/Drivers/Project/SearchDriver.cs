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
    
    public class SearchDriver
    {
        private readonly SearchResultState _result;

        public SearchDriver(SearchResultState result)
        {
            _result = result;
        }

        public void Navigate(string mail, string pass)
        {
            //var pro = _context.ReferenceProject.GetById(mail);
            //using (var controller = new AgencyController())
            //{
            //    //_result.ActionResult = controller.Login(mail, pass);
            //    _result.ActionResult = controller.Index(pro.ID);
            //}
            var controller = new AccountController();
            _result.ActionResult = controller.Login(mail, pass);

           
        }

        public void Search(int searchTerm) 
        {
            var controller = new ProjectController();
            _result.ActionResult = controller.Search(searchTerm,0,0,0,0,0);
        }

        public void ListPro()
        {
            var controllerIndex = new AccountController();
            _result.ActionResult = controllerIndex.ViewDetail();
        }

        public void ShowList(Table expectednameList)
        {
            //Arrange
            var expected = expectednameList.Rows.Select(x => x["PropertyName"]);

            var ShownName = _result.ActionResult.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.HomeScreenShouldShow(ShownName, expected);
        }
    }
}
