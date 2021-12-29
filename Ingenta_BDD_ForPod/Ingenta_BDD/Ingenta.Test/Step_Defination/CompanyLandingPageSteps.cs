using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyLandingPageSteps
    {
        [When(@"I click Company link from menu option")]
        public void WhenIClickCompanyLinkFromMenuOption()
        {
            Objects.poDashboard.ClickCompanyFromMenu();
        }

        [Then(@"search company page details should be displayed")]
        public void ThenSearchCompanyPageDetailsShouldBeDisplayed()
        {
            Objects.poCompanySearch_Page.verifySearchPageElements();
        }

        [When(@"I select the company option from search for dropdown")]
        public void WhenISelectTheCompanyOptionFromSearchForDropdown()
        {
            Objects.poCompanySearch_Page.selectSearchForDropdown();
        }


        [Then(@"the company option should be selected successfully")]
        public void ThenTheCompanyOptionShouldBeSelectedSuccessfully()
        {
            Objects.poCompanySearch_Page.verifySearchForDropDown();
        }
    }
}
