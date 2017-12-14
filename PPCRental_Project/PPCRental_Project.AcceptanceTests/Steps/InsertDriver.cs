using PPCRental_Project.AcceptanceTests.Drivers.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace PPCRental_Project.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class InsertDriver
    {
        private readonly ProjectDriver _inserDriver;

        public InsertDriver(ProjectDriver driver) { _inserDriver = driver; }

        [Given(@"the following project")]
        public void GivenTheFollowingProject(Table givenProjects)
        {
            _inserDriver.InsertProjecttoDB(givenProjects);
        }

    }
}
