using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using PPCRental_Project.Models;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.AcceptanceTests.Drivers.Project;

namespace PPCRental_Project.AcceptanceTests.Steps
{
     [Binding, Scope(Tag="automated")]
    class ViewListOfProject
    {
       //private IWebDriver driver = new FirefoxDriver();
        private readonly SearchDriver _projectDriver;


        public ViewListOfProject(SearchDriver driver) { _projectDriver = driver; }


        //[Given(@"the following project")]
        //public void GivenTheFollowingProject(Table givenProjects)
        //{
        //    _projectDriver.InsertProjecttoDB(givenProjects);
        //}

        [When(@"I input '(.*)' and '(.*)' into Login page")]
        public void WhenIInputAndIntoLoginPage(string email, string password)
        {
            _projectDriver.Navigate(email, password);

            _projectDriver.ListPro();
        }

        [Then(@"I should see my own projects")]
        public void ThenIShouldSeeMyOwnProjects(Table expectedList)
        {
            _projectDriver.ShowList(expectedList);

            
        }

    }
}
