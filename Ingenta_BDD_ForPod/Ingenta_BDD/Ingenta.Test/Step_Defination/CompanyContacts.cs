using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyContactsSteps
    {
        [When(@"I navigate to contacts tab")]
        public void WhenIClickOnContactsTab()
        {
            Objects.poCompanyContacts_Page.navigateToContactsTab();
        }

        [Then(@"New contact record should be created")]
        public void ThenNewContactRecordShouldBeCreated()
        {
            Objects.poCompanyContacts_Page.verifyNewContactIsCreated();
        }

        [When(@"I click on New button in contacts tab")]
        public void WhenIClickOnNewButtonInContactsTab()
        {
            Objects.poCompanyContacts_Page.clickNew();
        }

        [Then(@"Company Contacts tab details should be displayed")]
        public void ThenCompanyContactsTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanyContacts_Page.verifyContactTabDetails();
        }

        [When(@"I enter contact details")]
        public void WhenIEnterContactDetails()
        {
            Objects.poCompanyContacts_Page.enterContactDetails();
        }

        [Then(@"contact should be saved with name field should be generated automatically")]
        public void ThenContactShouldBeSavedWithNameFieldShouldBeGeneratedAutomatically()
        {            
            Objects.poCompanyContacts_Page.navigateToInformationTab();
            Objects.poCompanyContacts_Page.verifySavedContactDetails();
        }

        [When(@"I click on active button")]
        public void WhenIClickOnActiveButton()
        {
            Objects.poCompanyContacts_Page.clickActive();
        }

        [Then(@"contact should be inactive")]
        public void ThenContactShouldBeInactive()
        {
            Objects.poCompanyContacts_Page.verifyContactStatus();
        }

        [Then(@"contact should be active")]
        public void ThenContactShouldBeActive()
        {
            Objects.poCompanyContacts_Page.verifyContactStatus();
        }

        [When(@"I click on company button available in the header page")]
        public void WhenIClickOnCompanyButtonAvailableInTheHeaderPage()
        {
            Objects.poCompanyContacts_Page.clickCompanyAvailableInHeader();
        }

        [Then(@"I should get redirected to company information page")]
        public void ThenIShouldBeRedirectedToCompanyInformationPage()
        {
            Objects.poCompanyFinance_Page.verifyInformationPage();
        }



    }
}
