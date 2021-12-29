using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test
{
    [Binding]
    public class CompanySearchExternalReferencesSteps
    {
        [When(@"I navigate to External Refrences tab")]
        public void WhenINavigateToExternalRefrencesTab()
        {
            Objects.companyExternalReferences_Page.navigateToExternalReference();
        }
        
        [Then(@"External references details should be displayed")]
        public void ThenExternalReferencesDetailsShouldBeDisplayed()
        {
            Objects.companyExternalReferences_Page.verifyExternalRefTabDetails();
        }
    }
}
