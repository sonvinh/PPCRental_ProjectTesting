using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental_Project.Models;
using FluentAssertions;

namespace PPCRental_Project.AcceptanceTests.Common
{
        public class AssertionCommand
        {
            public static void ViewListOfProject(IEnumerable<PROPERTY> viewproject, IEnumerable<string> expectedTitles)
            {
                viewproject.Select(x => x.PropertyName).Should().Contain(expectedTitles);
            }
            public static void ViewDetailProject(IEnumerable<PROPERTY> viewdetail, IEnumerable<string> expectedTitles)
            {
                viewdetail.Select(x => x.PropertyName).Should().Contain(expectedTitles);
            }
        }
}
