using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Contacts_SearchContactSteps
    {

        [When(@"I navigate to Contacts from dashboard")]
        public void WhenINavigateToContactsFromDashboard()
        {
            Objects.poDashboard.navigateToContacts();
        }

        [Then(@"Contact Information tab details should be displayed")]
        public void ThenContactInformationTabDetailsShouldBeDisplayed()
        {
            Objects.poContactInformation_Page.verifyContactTabDetails();
        }


        [When(@"I search for Contact ""(.*)"" by last name")]
        public void WhenISearchForContactByLastName(string contact)
        {
            Objects.searchContact.searchForContact(contact, "LastName");
        }

        [When(@"I search for Contact ""(.*)"" by first name")]
        public void WhenISearchForContactByFirstName(string contact)
        {
            Objects.searchContact.searchForContact(contact, "FirstName");
        }

        [When(@"I search for Contact ""(.*)"" by job title")]
        public void WhenISearchForContactByJobTitle(string contact)
        {
            Objects.searchContact.searchForContact(contact, "JobTitle");
        }

        [When(@"I search for Contact ""(.*)"" by E-Mail")]
        public void WhenISearchForContactByE_Mail(string contact)
        {
            Objects.searchContact.searchForContact(contact, "E-Mail");
        }

        [When(@"I search for Contact ""(.*)"" by Telephone")]
        public void WhenISearchForContactByTelephone(string contact)
        {
            Objects.searchContact.searchForContact(contact, "Telephone");
        }

        [When(@"I search for Contact ""(.*)"" by Company")]
        public void WhenISearchForContactByCompany(string contact)
        {
            Objects.searchContact.searchForContact(contact, "Company");
        }

        [When(@"I search for Contact ""(.*)"" by PostalCode")]
        public void WhenISearchForContactByPostalCode(string contact)
        {
            Objects.searchContact.searchForContact(contact, "PostalCode");
        }

        [When(@"I search for Contact ""(.*)"" by country")]
        public void WhenISearchForContactByCountry(string contact)
        {
            Objects.searchContact.searchForContact(contact, "Country");
        }

        [When(@"I search for ""(.*)"" contacts")]
        public void WhenISearchForContacts(string activeInactiveContacts)
        {
            Objects.searchContact.searchForContact(activeInactiveContacts, activeInactiveContacts);
        }


        [When(@"I Click on Search button and select the first record from the search result")]
        public void WhenIClickOnSearchButtonAndSelectTheFirstRecordFromTheSearchResult()
        {
            Objects.searchContact.SearchContactaAndSelectRecordFromGrid();
        }

        [Then(@"Contact screen will be displayed with the different elements")]
        public void ThenContactScreenWillBeDisplayedWithTheDifferentElements()
        {
            Objects.searchContact.VerifyContactDetailsFields();
        }

        [Then(@"""(.*)"" Contact should be displayed in the result")]
        public void ThenContactShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "LastName");
        }

        [Then(@"all the contacts having ""(.*)"" as first name should be displayed in the result")]
        public void ThenAllTheContactsHavingAsFirstNameShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "FirstName");
        }

        [Then(@"all the contacts having ""(.*)"" as Job Title should be displayed in the result")]
        public void ThenAllTheContactsHavingAsPostalCodeShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "JobTitle");
        }

        [Then(@"all the contacts having ""(.*)"" as E-Mail address should be displayed in the result")]
        public void ThenAllTheContactsHavingAsE_MailAddressShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "E-Mail");
        }

        [Then(@"all the contacts having ""(.*)"" as telphone number should be displayed in the result")]
        public void ThenAllTheContactsHavingAsTelphoneNumberShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "Telephone");
        }

        [Then(@"all the contacts having ""(.*)"" as Company should be displayed in the result")]
        public void ThenAllTheContactsHavingAsCompanyShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "Company");
        }

        [Then(@"all the contacts having ""(.*)"" as postalcode should be displayed in the result")]
        public void ThenAllTheContactsHavingAsPostalcodeShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "PostalCode");
        }

        [Then(@"all the contacts having ""(.*)"" as country should be displayed in the result")]
        public void ThenAllTheContactsHavingAsCountryShouldBeDisplayedInTheResult(string contact)
        {
            Objects.searchContact.verifySearchedContact(contact, "Country");
        }

        [Then(@"all the ""(.*)"" contacts should be displayed in the result")]
        public void ThenAllTheContactsShouldBeDisplayedInTheResult(string activeInactiveContacts)
        {
            Objects.searchContact.verifySearchedContact(activeInactiveContacts, activeInactiveContacts);
        }



    }

}
