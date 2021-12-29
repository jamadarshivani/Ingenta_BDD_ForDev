using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanySearchBrandsSteps
    {
        [When(@"I navigate to brands tab")]
        public void WhenINavigateToBrandsTab()
        {
            Objects.companyBrands_Page.navigateToBrandsTab();
        }
        
        [Then(@"Company brands tab details should be displayed")]
        public void ThenCompanyBrandsTabDetailsShouldBeDisplayed()
        {
            Objects.companyBrands_Page.verifyBrandsTabFunctionality();
        }
    }
}
