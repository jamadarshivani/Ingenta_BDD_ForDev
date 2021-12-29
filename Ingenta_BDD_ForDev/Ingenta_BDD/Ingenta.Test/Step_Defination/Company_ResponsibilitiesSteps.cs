using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_ResponsibilitiesSteps
    {

        [When(@"I navigate to Responsibilities tab")]
        public void WhenINavigateToResponsibilitiesTab()
        {
            Objects.companyResponsibilities_Page.navigateToResponsibilitiesTab("Company");
        }

        [Then(@"Company Responsibilities tab details should be displayed")]
        public void ThenCompanyResponsibilitiesTabDetailsShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilitiesTabDetails();
        }

        [When(@"I navigate to new responsibility pop-up")]
        public void WhenINavigateToNewResponsibilityPop_Up()
        {
            Objects.companyResponsibilities_Page.clickNewResponsibilityButton();
        }

        [Then(@"new responsibility pop-up details should be displayed")]
        public void ThenNewResponsibilityPop_UpDeta()
        {
            Objects.companyResponsibilities_Page.verifyNewResponsibilityButtonFunctionality();
        }

        [When(@"I click contact name ellipsis button")]
        public void WhenIClickContactNameEllipsisButton()
        {
            Objects.companyResponsibilities_Page.clickContactNameEllipsisButton();
        }

        [Then(@"all the details of the contact name ellipsis should be displayed")]
        public void ThenAllTheDetailsOfTheContactNameEllipsisShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyContactNameEllipsisDetails();
        }

        [When(@"I search for last name in contact ellipsis")]
        public void WhenISearchForLastNameInContactEllipsis()
        {
            Objects.companyResponsibilities_Page.searchLastNameInEllipsis();
        }
        
        [Then(@"the search result with same last name should be displayed")]
        public void ThenTheSearchResultWithSameLastNameShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyLastName();
        }

        [When(@"I search for company name in contact ellipsis")]
        public void WhenISearchForCompanyNameInContactEllipsis()
        {
            Objects.companyResponsibilities_Page.searchCompanyNameInEllipsis();
        }

        [Then(@"the search result with same company name should be displayed")]
        public void ThenTheSearchResultWithSameCompanyNameShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyCompanyName();
        }
        
            

        [When(@"I search for Telephone in contact ellipsis")]
        public void WhenISearchForTelephoneInContactEllipsis()
        {
            Objects.companyResponsibilities_Page.searchTelephoneInEllipsis();
        }

        [Then(@"the search result with same telephone should be displayed")]
        public void ThenTheSearchResultWithSameTelephoneShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyTelephone();
        }


        [When(@"I search for email in contact ellipsis")]
        public void WhenISearchForEmailInContactEllipsis()
        {
            Objects.companyResponsibilities_Page.searchEmailInEllipsis();
        }

        [Then(@"the search result with same email should be displayed")]
        public void ThenTheSearchResultWithSameEmailShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyEmail();
        }

        [When(@"I view this responsibility button")]
        public void WhenIViewThisResponsibilityButton()
        {
            Objects.companyResponsibilities_Page.clickViewThisResponsibilityButton();
        }

        [When(@"I cancel the responsibility button")]
        public void WhenICancelTheResponsibilityButton()
        {
            Objects.companyResponsibilities_Page.clickCancelButton();
        }

        [When(@"I select the contact name from ellipsis")]
        public void WhenISelectTheContactNameFromEllipsis()
        {
            Objects.companyResponsibilities_Page.selectContactFromEllipsis();
        }

        [When(@"I enter the details of the responsibility from the pop-up window")]
        public void WhenIEnterTheDetailsOfTheResponsibilityFromThePop_UpWindow()
        {
            Objects.companyResponsibilities_Page.selectRole();
            Objects.companyResponsibilities_Page.selectMedia();
        }

        [When(@"I save the responsibility from the pop-up window")]
        public void WhenISaveTheResponsibilityFromThePop_UpWindow()
        {
            Objects.companyResponsibilities_Page.clickSaveButton();
        }

        [Then(@"the details of the responsibility should be saved successfully")]
        public void ThenTheDetailsOfTheResponsibilityShouldBeSavedSuccessfully()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilityIsSavedSuccessfully("Contact");
        }

        [Then(@"Details of company responsibility should be saved successfully")]
        public void ThenTheDetailsOfCompanyResponsibilityShouldBeSavedSuccessfully()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilityIsSavedSuccessfully("Company");
        }

        [When(@"I select the responsibility")]
        public void WhenISelectTheResponsibility()
        {
            Objects.companyResponsibilities_Page.selectResponsibility();
        }

        [When(@"I delete the selected responsibility")]
        public void WhenIDeleteTheSelectedResponsibility()
        {
            Objects.companyResponsibilities_Page.deleteResponsibility();
        }

        [Then(@"the responsibility will be deleted")]
        public void ThenTheResponsibilityWillBeDeleted()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilityIsDeleted();
        }


        //

        [When(@"I navigate to Responsibilities tab from contact")]
        public void WhenINavigateToResponsibilitiesTabFromContact()
        {
            Objects.companyResponsibilities_Page.navigateToResponsibilitiesTab("Contact");
        }

        [Then(@"Contact Responsibilities tab details should be displayed")]
        public void ThenContactResponsibilitiesTabDetailsShouldBeDisplayed()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilitiesTabDetails();
        }

        [When(@"I create responsibility")]
        public void WhenICreateResponsibility()
        {
            //Objects.companyResponsibilities_Page.clickContactNameEllipsisButton();
            //Objects.companyResponsibilities_Page.selectContactFromEllipsis();
            Objects.companyResponsibilities_Page.selectRole();
            Objects.companyResponsibilities_Page.selectMedia();
            Objects.companyResponsibilities_Page.clickSaveButton();
        }        

        [Then(@"the responsibility should be deleted")]
        public void ThenTheResponsibilityShouldBeDeleted()
        {
            Objects.companyResponsibilities_Page.verifyResponsibilityIsDeleted();
        }
        //

    }
}
