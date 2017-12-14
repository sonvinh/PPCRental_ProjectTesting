using PPCRental_Project.Models;
using TechTalk.SpecFlow;

namespace PPCRental_Project.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new K21T3_Team1_PPC3129Entities())
            {
                //db.OrderLines.RemoveRange(db.OrderLines);
                //db.Orders.RemoveRange(db.Orders);
                db.PROPERTY.RemoveRange(db.PROPERTY);
                db.SaveChanges();
            }
        }
    }
}
