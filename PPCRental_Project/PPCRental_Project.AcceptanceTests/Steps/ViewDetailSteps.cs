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
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    class ViewDetailSteps
    {

        private IWebDriver driver = new FirefoxDriver();
        [Given(@"I'm in PPC Main Page")]
        public void GivenIMInPPCMainPage()
        {
            driver.Navigate().GoToUrl("http://localhost:61656/Home/Index");
            Thread.Sleep(1000);
        }

        [When(@"I click button view detail")]
        public void WhenIClickButtonViewDetail()
        {
            driver.Navigate().GoToUrl("http://localhost:61656/Project/Detail/2");
            Thread.Sleep(1000);
        }

        [Then(@"I will see View Detail Of Project Page '(.*)'")]
        public void ThenIWillSeeViewDetailOfProjectPage(string expectedTitles)
        {
            var expectedResult = expectedTitles.Split(',').Select(x => x.Trim('\''));
            driver.SwitchTo().DefaultContent();

            var viewdetail = from row in driver.FindElements(By.XPath("//div[contains(@id,'detail-header')]/p"))
                             let Name = row.Text
                             select new PROPERTY { PropertyName = Name };

            AssertionCommand.ViewDetailProject(viewdetail, expectedResult);

        }

    }
}
