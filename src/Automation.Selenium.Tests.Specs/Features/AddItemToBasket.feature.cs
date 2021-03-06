﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Automation.Selenium.Tests.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddItemToBasketFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddItemToBasket.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add item to basket", "As a customer\r\nI want to add items to my basket\r\nSo that I can checkout", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Add item to basket")))
            {
                Automation.Selenium.Tests.Specs.Features.AddItemToBasketFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Adding an item to basket")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add item to basket")]
        public virtual void AddingAnItemToBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding an item to basket", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am on an item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I add the item to the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Message",
                        "ItemCount",
                        "BasketTotal"});
            table1.AddRow(new string[] {
                        "This item was added to your Basket",
                        "1",
                        "£15.00"});
#line 9
 testRunner.Then("I should see the following", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify my shopping bag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add item to basket")]
        public virtual void VerifyMyShoppingBag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify my shopping bag", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I am on an item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
  testRunner.And("I add the item to the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("I navigate to \"Bag\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total Quantity",
                        "Sub Total"});
            table2.AddRow(new string[] {
                        "1",
                        "£15.00"});
#line 17
 testRunner.Then("I should see the following details", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
