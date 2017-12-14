﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PPCRental_Project.AcceptanceTests.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ViewListOfProject")]
    [NUnit.Framework.CategoryAttribute("automated")]
    public partial class ViewListOfProjectFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ViewListOfProject.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ViewListOfProject", "\tI want to view list of project", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Avarta",
                        "Images",
                        "PropertyType",
                        "Content",
                        "Street",
                        "Ward",
                        "District",
                        "Price",
                        "UnitPrice",
                        "Area",
                        "BedRoom",
                        "BathRoom",
                        "PackingPlace",
                        "UserID",
                        "Create_at",
                        "Create_post",
                        "Status",
                        "Note",
                        "Update_at",
                        "Sale_ID"});
            table1.AddRow(new string[] {
                        "PIS Top Apartment",
                        "1.9SC_9220-watermark.jpg",
                        "a17584387317552326.jpg,AvatarNone17100766117552327.png,images1709523917552328.jpg" +
                            ",",
                        "1",
                        "The surrounding neighborhood is very much localized with a great number of local " +
                            "shops.",
                        "748",
                        "2",
                        "2",
                        "10000",
                        "VND",
                        "120m2",
                        "3",
                        "2",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "3",
                        "Done",
                        "2017-11-23",
                        "2"});
            table1.AddRow(new string[] {
                        "ViLa Q7",
                        "DSC_1103-watermark.jpg",
                        "images172300301.jpg",
                        "2",
                        "Brand new apartments with unbelievable river and city view, completely renovated " +
                            "and tastefully furnished.",
                        "750",
                        "3",
                        "2",
                        "70000",
                        "VND",
                        "120m2",
                        "3",
                        "4",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "3",
                        "Done",
                        "2017-11-23",
                        "2"});
            table1.AddRow(new string[] {
                        "PIS Serviced Apartment – Style",
                        "DSC_4173-watermark.jpg",
                        "a - Copy17095239.jpg,images (1) - Copy17095242.jpg,images17095242.jpg,",
                        "3",
                        "The well equipped kitchen is opened on a cozy living room and a dining area with " +
                            "table and chairs..",
                        "749",
                        "4",
                        "2",
                        "30000",
                        "VND",
                        "130m2",
                        "2",
                        "3",
                        "1",
                        "4",
                        "2017-11-09",
                        "2017-11-09",
                        "3",
                        "Done",
                        "2017-11-23",
                        "3"});
            table1.AddRow(new string[] {
                        "Vinhomes Central Park L2 – Duong’s Apartment",
                        "galaxy-9-3-watermark-1.jpg",
                        "images1702244617042862.jpg,",
                        "2",
                        "Vinhomes Central Park is a new development that is in the heart of everything tha" +
                            "t Ho Chi Minh has to offer.",
                        "755",
                        "33",
                        "3",
                        "110000",
                        "VND",
                        "150m2",
                        "4",
                        "2",
                        "1",
                        "1",
                        "2017-11-09",
                        "2017-11-09",
                        "3",
                        "Done",
                        "2017-11-23",
                        "3"});
            table1.AddRow(new string[] {
                        "Saigon Pearl Ruby Block",
                        "DSC_7895-watermark.jpg",
                        "images17423697317334243.jpg,PIS_4622-Edit17463610217334244.jpg,",
                        "1",
                        "Studio apartment at central of CBD, nearby Ben Thanh market, Bui Vien Backpacker " +
                            "Area, 23/9 park…",
                        "758",
                        "35",
                        "3",
                        "30000",
                        "VND",
                        "130m2",
                        "3",
                        "5",
                        "1",
                        "4",
                        "2017-11-09",
                        "2017-11-09",
                        "3",
                        "Done",
                        "2017-11-23",
                        "2"});
#line 7
 testRunner.Given("the following project", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ViewListofProject")]
        public virtual void ViewListofProject()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ViewListofProject", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 17
 testRunner.When("I input \'lythihuyenchau@gmail.com\' and \'123456\' into Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName"});
            table2.AddRow(new string[] {
                        "PIS Top Apartment"});
            table2.AddRow(new string[] {
                        "ViLa Q7"});
            table2.AddRow(new string[] {
                        "Vinhomes Central Park L2 – Duong’s Apartment"});
#line 18
 testRunner.Then("I should see my own projects", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
