using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CreatingCompanySteps
    {
        [When(@"I enter ""(.*)"" in company name text field")]
        public void WhenIEnterInCompanyNameTextField(string companyName)
        {
            Objects.poCompanyInformation_Page.createNewCompanyInformation(companyName);
        }

      
        [When(@"I select the company type from the pop-up as ""(.*)""")]
        public void WhenISelectTheCompanyTypeFromThePop_UpAs(string companyName)
        {
            Objects.poCompanyInformation_Page.SelectCompanyType(companyName);
            
        }
        [Then(@"company type pop up should be displayed with company type dropdown")]
        public void ThenCompanyTypePopUpShouldBeDisplayedWithCompanyTypeDropdown()
        {
            Objects.poCompanyInformation_Page.verifyCompanyTypePopUpIsVisible();
        }



        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            Objects.poCompanyInformation_Page.clickSearchButton();
        }
        
        [When(@"I click on select button")]
        public void WhenIClickOnSelectButton()
        {
            Objects.poCompanyInformation_Page.clickSelectButton();
        }
        
        [When(@"I click on Cancel button")]
        public void WhenIClickOnCancelButton()
        {
            Objects.poCompanyInformation_Page.clickCancelButton();
        }
        
        [When(@"I click on Override button")]
        public void WhenIClickOnOverrideButton()
        {
            Objects.poCompanyInformation_Page.clickOverrideButton();
        }
        
        [Then(@"I should see the search,select,cancel and override buttons")]
        public void ThenIShouldSeeTheSearchSelectCancelAndOverrideButtons()
        {
            Objects.poCompanyInformation_Page.verifySaveFuntionality();
        }
        
        [Then(@"I should be navigated to the search company page")]
        public void ThenIShouldBeNavigatedToTheSearchCompanyPage()
        {
            Objects.poCompanySearch_Page.verifySearchPage();
        }
        
        [Then(@"I should be able to see the matching tables")]
        public void ThenIShouldBeAbleToSeeTheMatchingTables()
        {
            Objects.poCompanyInformation_Page.verifyCompanyMatchesGridDisplayed();
        }
        

        [When(@"I click OK button in the dropdown")]
        public void WhenIClickOKButtonInTheDropdown()
        {
            Objects.poCompanyInformation_Page.PressOkButtonFromDD();
        }

        [When(@"I close the drop down")]
        public void WhenICloseTheDropDown()
        {
            Objects.poCompanyInformation_Page.closePopUp();
        }

        [Then(@"I should see the company type pop-up")]
        public void ThenIShouldSeeTheCompanyTypePop_Up()
        {
            Objects.poCompanyInformation_Page.verifyCompanyTypePopup();
        }


        [When(@"I enter the Information details for a new company")]
        public void WhenIEnterTheInformationDetailsForANewCompany()
        {
            Objects.poCompanyInformation_Page.enterCompanyInformation();
        }

        [When(@"I enter the tax registration number")]
        public void WhenIEnterTheTaxRegistrationNumber()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"save,save and close and close button should be enabled")]
        public void ThenSaveSaveAndCloseAndCloseButtonShouldBeEnabled()
        {
            Objects.poCompanyInformation_Page.verifyCancelButtonFuntionality();
        }

        [Then(@"search button should be disabled")]
        public void ThenSearchButtonShouldBeDisabled()
        {
            Objects.poCompanyInformation_Page.verifySearchButtonDisabled();
        }

        [Then(@"possible matches grid will be dismissed")]
        public void ThenPossibleMatchesGridWillBeDismissed()
        {
            Objects.poCompanyInformation_Page.verifyCompanyMatchesGridDisplayed();
        }

        [Then(@"save,save and close, close and active button should be disabled")]
        public void ThenSaveSaveAndCloseCloseAndActiveButtonShouldBeDisabled()
        {
            Objects.poCompanyInformation_Page.verifyOverrideButtonFuntionality();
        }

        [Then(@"search and stationery button should be enabled")]
        public void ThenSearchAndStationeryButtonShouldBeEnabled()
        {
            Objects.poCompanyInformation_Page.verifySearchStationeryButtonEnabled();
        }

        [Then(@"tabs on the left should be enabled")]
        public void ThenTabsOnTheLeftShouldBeEnabled()
        {
            Objects.poCompanyResult_Page.LeftTabsEnabled();
        }
                
        [When(@"I enter the tax registration number as ""(.*)""")]
        public void WhenIEnterTheTaxRegistrationNumberAs(string TaxRegNo)
        {
            Objects.poCompanyInformation_Page.EnterTaxRegNumber(TaxRegNo);
        }

        [Then(@"stationary button should be displayed")]
        public void ThenStationaryButtonShouldBeDisplayed()
        {
            Objects.poCompanyInformation_Page.verifyStationaryButtonIsDisplayed();
        }

        [When(@"I click on Home button")]
        public void WhenIClickOnHomeButton()
        {
            Objects.poBookingDetails.ClickHomeButton();
        }

        [When(@"I click on override button if exists")]
        public void WhenIClickOnOverrideButtonIfExists()
        {
            Objects.poCompanyInformation_Page.ClickOverrideButtonIfExists();
        }

        [When(@"I enter the Information details for a new company with Name as ""(.*)""")]
        public void WhenIEnterTheInformationDetailsForANewCompanyWithNameAs(string companyName)
        {
            Objects.poCompanyInformation_Page.enterCompanyName(companyName);
        }


        [Then(@"company name should be saved successfully as ""(.*)""\.")]
        public void ThenCompanyNameShouldBeSavedSuccessfullyAs_(string companyName)
        {
            Objects.poCompanyInformation_Page.verifyCompanyName(companyName);
        }

        [Then(@"I should be able to see details of the company information page")]
        public void ThenIShouldBeAbleToSeeDetailsOfTheCompanyInformationPage()
        {
            Objects.poCompanyInformation_Page.verifyInformationPageIsLoaded();
        }

        [Then(@"the company type name should be displayed as ""(.*)""")]
        public void ThenTheCompanyTypeNameShouldBeDisplayedAs(string companyType)
        {
            Objects.poCompanyInformation_Page.verifyCompanyType(companyType);
        }

        [Then(@"company details should be saved successfully")]
        public void ThenCompanyDetailsShouldBeSavedSuccessfully()
        {
            Objects.poCompanyInformation_Page.verifySavedComapnyDetails();
        }

        [When(@"I search for company")]
        public void WhenISearchForCompany()
        {
            Objects.poCompanySearch.companySearch();

            Objects.poCompanySearch.openCompanyRecord();
        }

        [When(@"I edit company information")]
        public void WhenIEditCompanyInformation()
        {
            Objects.poCompanyInformation_Page.editCompanyInformation();
        }

        [Then(@"edited fields should be saved successfully\.")]
        public void ThenEditedFieldsShouldBeSavedSuccessfully_()
        {
            Objects.poCompanyInformation_Page.verifyUpdatedCompanyInformation();
        }

        [When(@"I set CCCTY flag in User Preference Default to ""(.*)""")]
        public void WhenISetCCCTYFlagInUserPreferenceDefaultTo(string CCCTYConfig)
        {
            Objects.poCompanyInformation_Page.setCCCTYConfiguration(CCCTYConfig);
        }

        [When(@"I navigate to History Tab from company")]
        public void WhenINavigateToHistoryTabFromCompany()
        {
            Objects.poCompanyHistory_Page.navigateToHistoryTab();
        }



    }
}
