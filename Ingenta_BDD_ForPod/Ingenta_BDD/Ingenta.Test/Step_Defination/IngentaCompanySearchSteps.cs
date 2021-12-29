using Ingenta.Framework.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class IngentaCompanySearchSteps
    {
        [Given(@"I am logged in Ingenta application and user is redirected to dashboard")]
        public void GivenIAmLoggedInIngentaApplication()
        {
            Objects.poDashboard.ingentaDashboardVerify();
        }


        [When(@"I navigate to Companies from dashboard")]
        public void WhenIClickOnCompanyLinkFromDashboard()
        {
            Objects.poDashboard.navigateToCompany();
        }
        
        [When(@"I select ""(.*)"" from contact tab")]
        public void WhenISelectFromContactTab(string p0)
        {
            Objects.poCompanyResult.navigateToContactTab();
            Objects.poCompanyResult.selectContactAnna();
            Objects.poCompanyResult.navigateToHistoryTab();
        }

        [When(@"Click on New booking from history tab")]
        public void WhenClickOnNewBookingFromHistoryTab()
        {
            Objects.poCompanyResult.clickNewBooking();
        }

        [Then(@"New booking windows gets open")]
        public void ThenNewBookingWindowsGetsOpen()
        {
            // Assert to be added here
        }

        [When(@"I select media ""(.*)""")]
        public void WhenISelectMedia(string mediaName)
        {
            Objects.poNewBooking.switchToNewBookingWindow();

            Objects.poNewBooking.selectMedia(mediaName);
        }

        [When(@"Fill up require details on add details tab")]
        public void WhenFillUpRequireDetailsOnAddDetailsTab()
        {
            Objects.poNewBooking.gotoAddDetails();
            
        }

        [When(@"Select next available issue from insertion tab")]
        public void WhenSelectNextAvailableIssueFromInsertionTab()
        {
            Objects.poNewBooking.gotoInsertionTab();
         
        }

        [When(@"Navigate through Material, Finance and Payment tabs with no action")]
        public void WhenNavigateThroughMaterialFinanceAndPaymentTabsWithNoAction()
        {
            Objects.poNewBooking.gotoMaterialtab();

            Objects.poNewBooking.gotoFinanceTab();

            Objects.poNewBooking.gotoPaymentTab();
        }

        [When(@"Click on Next buttton")]
        public void WhenClickOnNextButtton()
        {
            Objects.poNewBooking.clickNext();
        }
        

        [When(@"I update Booking refrence field with today's date")]
        public void WhenIUpdateBookingRefrenceFieldWithTodaySDate()
        {
            Objects.poMyBooking.updateBookingReference();

            Objects.poMyBooking.clickSaveAndClose();
        }

        [When(@"I click save and close button")]
        public void WhenIClickSaveAndCloseButton()
        {
            Objects.poCompanyFinance_Page.clickSaveAndClose();
        }


    }
}
