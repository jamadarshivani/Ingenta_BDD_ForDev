using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test
{
    [Binding]
    public class CompanySearchHeaderSectionSteps
    {
        [When(@"I click on Search Button available in the header")]
        public void WhenIClickOnSearchButtonAvailableInTheHeader()
        {
            Objects.poCompanySearch.clickSearchButtonInHeader();
        }
        
        [Then(@"Contact Management Screen with different search criterias should be displayed")]
        public void ThenContactManagementScreenWithDifferentSearchCriteriasShouldBeDisplayed()
        {
            Objects.poCompanySearch.verifySearchCriteria();
        }

        [Then(@"Contact Management Screen with different search criterias should be displayed for contacts")]
        public void ThenContactManagementScreenWithDifferentSearchCriteriasShouldBeDisplayedForContacts()
        {
            Objects.poCompanySearch.verifySearchCriteriaViaContacts();
        }



        [When(@"I click on Stationery Button available in the header")]
        public void WhenIClickOnStationeryButtonAvailableInTheHeader()
        {
            Objects.poCompanySearch.clickStationeryButtonInHeader();
        }

        [Then(@"Stationery popup should be displayed")]
        public void ThenStationeryPopupShouldBeDisplayed()
        {
            Objects.poCompanySearch.verifyStationeryPopupDetails();
        }

        [When(@"I click on active checkbox available in the header")]
        public void WhenIClickOnActiveCheckboxAvailableInTheHeader()
        {
            Objects.poCompanySearch.clickActiveCheckbox();
        }

        [Then(@"Active checkbox should be renamed to Inactive")]
        public void ThenActiveCheckboxShouleBeRenamedToInactive()
        {
            Objects.poCompanySearch.verifyActiveCheckboxFunctionality();
        }

        [When(@"I edit Market Name field in information")]
        public void WhenIEditMarketNameFieldInInformation()
        {
            Objects.poCompanyInformation_Page.editMarketName();
        }


        [Then(@"Save , Save and Close and Close buttons will be disabled")]
        public void ThenSaveSaveAndCloseAndCloseButtonsWillBeDisabled()
        {
            Objects.poCompanyInformation_Page.verifyButtonsDisabled();
        }


    }
}
