using System.Collections.Generic;
using PPCRental_Project.Models;
using FluentAssertions;

namespace PPCRental_Project.AcceptanceTests.Support
{
    public class ReferenceProjectList : Dictionary<string, PROPERTY>
    {
        public PROPERTY GetById(string projectId)
        {
            return this[projectId.Trim()].Should().NotBeNull()
                                      .And.Subject.Should().BeOfType<PROPERTY>().Which;
        }
    }
}
