using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanySearchUserFormsSteps
    {
        [When(@"I navigate to Electronics Classification UserForms tab")]
        public void WhenINavigateToElectronicsClassificationUserFormsTab()
        {
            Objects.companyUserForms.navigateToUserFormsTab();
        }
        
        [Then(@"Electronic Classification UserForms tab details should be displayed")]
        public void ThenElectronicClassificationUserFormsTabDetailsShouldBeDisplayed()
        {
            Objects.companyUserForms.verifyUserFormsTabDetails();
        }
    }
}
