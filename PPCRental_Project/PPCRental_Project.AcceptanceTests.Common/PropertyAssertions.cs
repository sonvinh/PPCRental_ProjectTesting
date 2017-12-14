using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental_Project.Models;
using FluentAssertions;

namespace PPCRental_Project.AcceptanceTests.Common
{
    public class PropertyAssertions
    {
        public static void FoundPropertyShouldMatchTitles(IEnumerable<PROPERTY> foundProperty, IEnumerable<string> expectedTitles)
        {
            foundProperty.Select(x => x.PropertyName).Should().Contain(expectedTitles);
        }

        
        public static void HomeScreenShouldShow(IEnumerable<PROPERTY> ShownName, IEnumerable<string> expected)
        {
            ShownName.Select(b => b.PropertyName).Should().Contain(expected);
        }
    }
}
