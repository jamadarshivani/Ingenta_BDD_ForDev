﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Ingenta.Test.Feature.Company
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Company_Brands")]
    public partial class Company_BrandsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Company_Brands.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Company_Brands", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
#line 3
#line 4
 testRunner.Given("I am logged in Ingenta application and user is redirected to dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("I navigate to Companies from dashboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.And("I search for company as \"testcompany\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("I navigate to searched company", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I click on brands Tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1. Verifying brands tab details")]
        public virtual void _1_VerifyingBrandsTabDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. Verifying brands tab details", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 12
 testRunner.Then("all the elements of the brands tab should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2. Verifying new button functionality in brands")]
        public virtual void _2_VerifyingNewButtonFunctionalityInBrands()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. Verifying new button functionality in brands", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 15
 testRunner.When("I click new button in brands tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("New brand details should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3. Saving company details and manually entering the brand name")]
        public virtual void _3_SavingCompanyDetailsAndManuallyEnteringTheBrandName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3. Saving company details and manually entering the brand name", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 19
 testRunner.When("I click new button in brands tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.And("I enter the details under information tab of brands", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("I enter the brand name as \"test brand\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I click on save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("details under information tab of brands will be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("the tabs on the left menu will be enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4. Saving company details and selecting the brand name as comapany name")]
        public virtual void _4_SavingCompanyDetailsAndSelectingTheBrandNameAsComapanyName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4. Saving company details and selecting the brand name as comapany name", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 28
 testRunner.When("I click on cog button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("details under information tab of brands will be visible with company name same as" +
                    " the brand name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("the tabs on the left menu will be enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5. Verifying relationships button functionality")]
        public virtual void _5_VerifyingRelationshipsButtonFunctionality()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5. Verifying relationships button functionality", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 33
 testRunner.When("I click the first brand\'s cog button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("I click relationship tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("the relationship tab\'s elements should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("6. Verifying sales assignment button functionality")]
        public virtual void _6_VerifyingSalesAssignmentButtonFunctionality()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("6. Verifying sales assignment button functionality", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 38
 testRunner.When("I click the first brand\'s cog button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("I click sales assignment tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("the sales assignment tab\'s elements should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("7. Verifying company button functionality under view the brands")]
        public virtual void _7_VerifyingCompanyButtonFunctionalityUnderViewTheBrands()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("7. Verifying company button functionality under view the brands", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 43
 testRunner.When("I click the first brand\'s cog button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.And("I click company button in view brands tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("I should be able to see details of the company information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("8. Verifying view brand and detach the brand are visible")]
        public virtual void _8_VerifyingViewBrandAndDetachTheBrandAreVisible()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("8. Verifying view brand and detach the brand are visible", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 48
 testRunner.Then("view brand and detach the brand should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("9. Detaching and reassigning brands")]
        public virtual void _9_DetachingAndReassigningBrands()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("9. Detaching and reassigning brands", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 51
 testRunner.When("I click the first brand\'s pin button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.And("I select the new company in the new window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("I click on Detach and Reassign Brand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("the brand should be successfully be detached and new brand should be reassigned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
