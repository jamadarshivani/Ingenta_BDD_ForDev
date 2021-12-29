using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class ContactHeaderSectionSteps
    {
        [When(@"I click close stationery button")]
        public void WhenIClickCloseStationeryButton()
        {
            Objects.poContactHeaderSection_Page.clickCloseButton();
        }

        [Then(@"the stationery window will be closed")]
        public void ThenTheStationeryWindowWillBeClosed()
        {
            Objects.poContactHeaderSection_Page.verifyStationeryWindowIsClosed();
        }

        [When(@"I click Site Display Mode button")]
        public void WhenIClickSiteDisplayModeButton()
        {
            Objects.poContactSearch_Header.clickSiteDisplayMode();
        }

        [When(@"I click Booking Creation Mode button")]
        public void WhenIClickBookingCreationModeButton()
        {
            Objects.poContactSearch_Header.clickBookingCreationMode();
        }

        [When(@"I click Save Search Results button")]
        public void WhenIClickSaveSearchResultsButton()
        {
            Objects.poContactSearch_Header.clickSaveSearchResults();
        }

        [Then(@"Save Search Results Page details should be displayed successfully")]
        public void ThenSaveSearchResultsPageDetailsShouldBeDisplayedSuccessfully()
        {
            Objects.poContactSearch_Header.verifySaveSearchResultsButton();
        }

        [Then(@"Contact Management screen will be displayed with the different search criterias with run stationery report button")]
        public void ThenContactManagementScreenWillBeDisplayedWithTheDifferentSearchCriteriasWithRunStationeryReportButton()
        {
            Objects.poContactSearch_Header.verifyContactManagementWithStationeryReportButton();
        }

        [When(@"I save the save search results")]
        public void WhenISaveTheSaveSearchResults()
        {
            Objects.poContactSearch_Header.clickSaveButton();
        }

        [When(@"I save the cancel search results")]
        public void WhenISaveTheCancelSearchResults()
        {
            Objects.poContactSearch_Header.clickCancelButton();
        }

        [When(@"I click stationery report button")]
        public void WhenIClickStationeryReportButton()
        {
            Objects.poContactSearch_Header.clickStationeryReportButton();
        }

        [Then(@"stationery report details should be displayed in new window")]
        public void ThenStationeryReportDetailsShouldBeDisplayedInNewWindow()
        {
            Objects.poContactSearch_Header.verifyStationeryReportButton();
        }

        [When(@"I close the stationery report window")]
        public void WhenICloseTheStationeryReportWindow()
        {
            Objects.poContactSearch_Header.closeStationeryReportWindow();
        }

        [Then(@"Contact Management screen will be displayed with the different search criterias with run stationery report button in the previous window")]
        public void ThenContactManagementScreenWillBeDisplayedWithTheDifferentSearchCriteriasWithRunStationeryReportButtonInThePreviousWindow()
        {
            Objects.poContactSearch_Header.verifyContactManagementPageInPreviousWindow();
        }

        [When(@"I click Open Search Results button")]
        public void WhenIClickOpenSearchResultsButton()
        {
            Objects.poContactSearch_Header.clickOpenSearchResultsButton();
        }

        [Then(@"Open Search Results button details should be displayed successfully")]
        public void ThenOpenSearchResultsButtonDetailsShouldBeDisplayedSuccessfully()
        {
            Objects.poContactSearch_Header.verifyOpenSearchResultsButton();
        }

        [When(@"I click on cancel Open Search Results button")]
        public void WhenIClickOnCancelOpenSearchResultsButton()
        {
            Objects.poContactSearch_Header.clickCancelOpenSearchResultsButton();
        }



    }
}
