using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Contacts_LandingPageSteps
    {
        [When(@"I click on Contacts link from homepage")]
        public void WhenIClickOnContactsLinkFromHomepage()
        {
            Objects.poDashboard.navigateToContacts();
        }
        
        [Then(@"Contact Management screen will be displayed with the different search criterias")]
        public void ThenContactManagementScreenWillBeDisplayedWithTheDifferentSearchCriterias()
        {
            Objects.po_ContactsLandingPage.verifyContactLandingPageDetails();
        }

        [When(@"I click on Contacts link from main menu")]
        public void WhenIClickOnContactsLinkFromMainMenu()
        {
            Objects.poDashboard.navigateToContactsFromMainMenu();
        }

        [Given(@"I am logged in Ingenta application")]
        public void GivenIAmLoggedInIngentaApplication()
        {
            //Objects.poDashboard.navigateToContacts();
        }
    }
}
