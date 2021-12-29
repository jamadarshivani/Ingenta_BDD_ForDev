using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_InformationSteps
    {
        [When(@"I click on search button in the header")]
        public void WhenIClickOnSearchButtonInTheHeader()
        {
            Objects.poCompanyInformation_Page.clickHeaderSearchButton();
        }
        
        [Then(@"the company details should be displayed succesfully")]
        public void ThenTheCompanyTableShouldBeDisplayedSuccesfully()
        {
            Objects.poCompanyInformation_Page.verifySearchCriteria();
        }

        [When(@"I click on stationery button in the header")]
        public void WhenIClickOnStationeryButtonInTheHeader()
        {
            Objects.poCompanyInformation_Page.clickStationeryButtonInHeader();
        }

        [Then(@"the stationery details should be displayed successfully")]
        public void ThenTheStationeryDetailsShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanyInformation_Page.verifyStationeryPopupDetails();
        }

        [When(@"I click on active/inactive button in the header of company")]
        public void WhenIClickOnActiveInactiveButtonInTheHeaderOfCompany()
        {
            Objects.poCompanyInformation_Page.clickActiveCheckboxOfCompany();
        }

        [When(@"I click on active/inactive button in the header")]
        public void WhenIClickOnActiveInactiveButtonInTheHeader()
        {
            Objects.poCompanyInformation_Page.clickActiveCheckbox();
        }


        [Then(@"the button should be displayed as active or inactive as expected")]
        public void ThenTheButtonShouldBeDisplayedAsActiveOrInactiveAsExpected()
        {
            Objects.poCompanyInformation_Page.verifyActiveCheckboxFunctionality();
        }

        [Then(@"the button should be displayed as active or inactive as expected of company")]
        public void ThenTheButtonShouldBeDisplayedAsActiveOrInactiveAsExpectedofCompany()
        {
            Objects.poCompanyInformation_Page.verifyActiveCheckboxFunctionalityOfCompany();
        }

        [Then(@"Company Information page details should be displayed successfully")]
        public void ThenInformationPageDetailsShouldBeDisplayedSuccessfully()
        {
            Objects.poContactInformation_Page.verifyContactTabDetails();
        }

        [When(@"I save the information details")]
        public void WhenISaveTheInformationDetails()
        {
            Objects.poCompanyFinance_Page.ClickSave();
        }

        [When(@"I navigate to reponsibilities tab")]
        public void WhenINavigateToReponsibilitiesTab()
        {
            Objects.poCompanyContacts_Page.navigateToResponsibilitiesTab();
        }

        [Then(@"I should be navigated to the reponsibility tab")]
        public void ThenIShouldBeNavigatedToTheReponsibilityTab()
        {
            Objects.poCompanyContacts_Page.verifyResponsibilitiesTabDetails();
        }

        [When(@"I navigate to Relationships tab")]
        public void WhenINavigateToRelationshipsTab()
        {
            Objects.poCompanyContacts_Page.navigateToRelationshipsTab();
        }

        [Then(@"I should be navigated to the Relationships tab")]
        public void ThenIShouldBeNavigatedToTheRelationshipsTab()
        {
            Objects.poCompanyContacts_Page.verifyRelationshipsTab();
        }

        [Then(@"I should be navigated to the Opportunities tab")]
        public void ThenIShouldBeNavigatedToTheOpportunitiesTab()
        {
            Objects.poCompanyContacts_Page.verifyOpportunitiesTab();
        }

        [When(@"I navigate to Notes tab")]
        public void WhenINavigateToNotesTab()
        {
            Objects.poCompanyContacts_Page.navigateToNotesTab();
        }

        [Then(@"I should be navigated to the Notes tab")]
        public void ThenIShouldBeNavigatedToTheNotesTab()
        {
            Objects.poCompanyContacts_Page.verifyNotesTab();
        }

        [When(@"I navigate to Attachments tab")]
        public void WhenINavigateToAttachmentsTab()
        {
            Objects.poCompanyContacts_Page.navigateToAttachmentsTab();
        }

        [Then(@"I should be navigated to the Attachements tab")]
        public void ThenIShouldBeNavigatedToTheAttachementsTab()
        {
            Objects.poCompanyContacts_Page.verifyAttachmentsButtonFunctionality();
        }

        [When(@"I navigate to External References tab")]
        public void WhenINavigateToExternalReferencesTab()
        {
            Objects.poCompanyContacts_Page.navigateToExternalReference();
        }

        [Then(@"I should be navigated to the External References tab")]
        public void ThenIShouldBeNavigatedToTheExternalReferencesTab()
        {
            Objects.poCompanyContacts_Page.verifyExternalRefButton();
        }

        [When(@"I navigate to Documents tab")]
        public void WhenINavigateToDocumentsTab()
        {
            Objects.poCompanyContacts_Page.navigateToDocuments();
        }

        [Then(@"I should be navigated to the Documents tab")]
        public void ThenIShouldBeNavigatedToTheDocumentsTab()
        {
            Objects.poContactDocuments_Page.verifyDocumentsButtonFunctionality();
        }

        [When(@"I navigate to Web User tab")]
        public void WhenINavigateToWebUserTab()
        {
            Objects.poCompanyContacts_Page.navigateToWebUser();
        }

        [Then(@"I should be navigated to the Web User tab")]
        public void ThenIShouldBeNavigatedToTheWebUserTab()
        {
            Objects.poContactWebUser_Page.verifyWebUserButton();
        }

        [When(@"I navigate to Campaign tab")]
        public void WhenINavigateToCampaignTab()
        {
            Objects.poCompanyContacts_Page.navigateToCampaign();
        }

        [Then(@"I should be navigated to the Campaign tab")]
        public void ThenIShouldBeNavigatedToTheCampaignTab()
        {
            Objects.poContactCampaign_Page.verifyCampaignTabDetails();
        }


    }
}
