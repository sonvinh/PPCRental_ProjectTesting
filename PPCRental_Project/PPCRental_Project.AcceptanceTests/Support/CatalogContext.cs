namespace PPCRental_Project.AcceptanceTests.Support
{
    public class CatalogContext
    {
        public CatalogContext()
        {
            ReferenceProject = new ReferenceProjectList();
        }

        public ReferenceProjectList ReferenceProject{ get; set; }
    }
}
