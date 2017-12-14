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
    [Binding, Scope(Tag = "automated")]
    public class FilterProjectSteps
    {
        private readonly SearchDriver _projectDriver;

        public FilterProjectSteps(SearchDriver driver) { _projectDriver = driver; }

        [When(@"I input Chuong My into Filter '(.*)'")]
        public void WhenIInputChuongMyIntoFilter(int p0)
        {
            _projectDriver.Search(p0);
        }
        
        [Then(@"I should see list projects")]
        public void ThenIShouldSeeListProjects(Table table)
        {
            _projectDriver.ShowList(table);
        }
    }
}
