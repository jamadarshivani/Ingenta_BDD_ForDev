using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_OpportunitiesSteps
    {
        [When(@"I navigate to opportunities Tab")]
        public void WhenINavigateToOpportunitiesTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToOpportunitiesTab();
        }

        [Then(@"I should be navigated to the opportunities tab")]
        public void ThenIShouldBeNavigatedToTheOpportunitiesTab()
        {
            Objects.poCompanyOpportunities_Page.verifyOpportunitiesTabDetails();
        }

        [When(@"I navigate to new opportunities tab")]
        public void WhenINavigateToNewOpportunitiesTab()
        {
            Objects.poCompanyOpportunities_Page.clickNewOpportunitiesButton();
        }

        [Then(@"I should be navigated to new opportunities tab")]
        public void ThenIShouldBeNavigatedToNewOpportunitiesTab()
        {
            Objects.poCompanyOpportunities_Page.verifyNewOpportunityButtonFunctionality();
        }

        [When(@"I enter opportunities information")]
        public void WhenIEnterOpportunitiesInformation()
        {
            Objects.poCompanyOpportunities_Page.enterOpportunityInformation();
        }

        [When(@"I save the details")]
        public void WhenISaveTheDetails()
        {
            Objects.poCompanyOpportunities_Page.clickSaveButton();
        }

        [Then(@"the details of the information should be saved and displayed")]
        public void ThenTheDetailsOfTheInformationShouldBeSavedAndDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyDetailsAreSavedSucessfully();
        }

        [When(@"I save and close")]
        public void WhenISaveAndClose()
        {
            Objects.poCompanyOpportunities_Page.clickSaveAndCloseButton();
        }

        [When(@"I select the created opportunity")]
        public void WhenISelectTheCreatedOpportunity()
        {
            Objects.poCompanyOpportunities_Page.editCreatedOpportunity();
        }

        [When(@"I select the Calender View quote opportunity")]
        public void WhenISelectTheCalenderViewQuoteOpportunity()
        {
            Objects.poCompanyOpportunities_Page.selectCalenderViewForQuoteInCompanyOpportunity();
        }


        [When(@"I select the created last opportunity")]
        public void WhenISelectTheCreatedLastOpportunity()
        {
            Objects.poCompanyOpportunities_Page.selectLastCreatedOpportunity();
        }


        [When(@"I select created test opportunity")]
        public void WhenISelectTheCreatedTestOpportunity()
        {
            Objects.poCompanyOpportunities_Page.selectCreatedTestOpportunityinPendleburyContact();
        }

        [When(@"I navigate to relations tab")]
        public void WhenINavigateToRelationsTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToRelationsTab();
        }

        [Then(@"all the details of the relations tab should be displayed")]
        public void ThenAllTheDetailsOfTheRelationsTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyRelationsTab();
        }

        [When(@"I navigate to competitor tab")]
        public void WhenINavigateToCompetitorTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToCompetitorTab();
        }


        [Then(@"all the details of the competitor tab should be displayed")]
        public void ThenAllTheDetailsOfTheCompetitorTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyCompetitorTab();
        }

        [When(@"I navigate to new competitor window")]
        public void WhenINavigateToNewCompetitorWindow()
        {
            Objects.poCompanyOpportunities_Page.clickNewCompetitorButton();
        }

        [Then(@"all the new competitor details should be displayed")]
        public void ThenAllTheNewCompetitorDetailsShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyNewOpportunityWindow();
        }

        [When(@"I enter the details of the new competitor")]
        public void WhenIEnterTheDetailsOfTheNewCompetitor()
        {
            Objects.poCompanyOpportunities_Page.enterNewCompetitorDetails("New");
        }

        [When(@"I create new competitor to be deleted")]
        public void WhenICreateNewCompetitorToBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.enterNewCompetitorDetails("Delete");
        }


        [When(@"I enter the details of the new reponsibility to be deleted")]
        public void WhenIEnterTheDetailsOfTheNewReponsibilityToBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.enterResponsibilityDetails("Delete");
        }


        [Then(@"I should be able to see the details of new competitor")]
        public void ThenIShouldBeAbleToSeeTheDetailsOfNewCompetitor()
        {
            Objects.companyOpportunities_Page.verifyNewCompetitorDetails();            
        }

        [When(@"I save the details for competitor in the new window")]
        public void WhenISaveTheDetailsForCompetitorInTheNewWindow()
        {
            Objects.poCompanyOpportunities_Page.saveDetailsInNewWindow();
        }

        [When(@"I select the created competitor")]
        public void WhenISelectTheCreatedCompetitor()
        {
            Objects.poCompanyOpportunities_Page.selectCreatedCompetitor();            
        }

        [When(@"I delete the competitor")]
        public void WhenIDeleteTheCompetitor()
        {
            Objects.poCompanyOpportunities_Page.deleteCompetitor();            
        }

        [Then(@"the selected competitor should be deleted")]
        public void ThenTheSelectedCompetitorShouldBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.verifyCompetitorIsDeleted();
        }


        [When(@"I navigate to reponsibility tab")]
        public void WhenINavigateToReponsibilityTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToResponsibilityTab();
        }

        [Then(@"all the details of the reponsibility tab should be displayed")]
        public void ThenAllTheDetailsOfTheReponsibilityTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyResponsibilityTab();
        }

        [When(@"I navigate to new responsibility tab")]
        public void WhenINavigateToNewResponsibilityTab()
        {
            Objects.poCompanyOpportunities_Page.clickNewResponsibilityButton();
        }


        [Then(@"all the details of the new responsibility tab should be displayed")]
        public void ThenAllTheDetailsOfTheNewResponsibilityTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyNewResponsibilityWindow();
        }

        [When(@"I enter the details of the new reponsibility")]
        public void WhenIEnterTheDetailsOfTheNewReponsibility()
        {
            Objects.poCompanyOpportunities_Page.enterResponsibilityDetails("New");
        }

        [When(@"I save the details for reponsibility in the new window")]
        public void WhenISaveTheDetailsForReponsibilityInTheNewWindow()
        {
            Objects.poCompanyOpportunities_Page.saveDetailsInNewWindow();
        }

        [Then(@"I should be able to see the details of new reponsibility")]
        public void ThenIShouldBeAbleToSeeTheDetailsOfNewReponsibility()
        {
            Objects.poCompanyOpportunities_Page.verifyResponsibilityDetails();
        }

        [When(@"I select the created reponsibility")]
        public void WhenISelectTheCreatedReponsibility()
        {
            Objects.poCompanyOpportunities_Page.selectCreatedResponsibility();
        }

        [When(@"I delete the reponsibility")]
        public void WhenIDeleteTheReponsibility()
        {
            Objects.poCompanyOpportunities_Page.deleteCreatedResponsiblity();
        }

        [Then(@"the selected reponsibility should be deleted")]
        public void ThenTheSelectedReponsibilityShouldBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.verifyResponsibilityIsDeleted();
        }

        [When(@"I navigate to media tab")]
        public void WhenINavigateToMediaTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToMediaTab();
        }

        [Then(@"all the details of the media tab should be displayed")]
        public void ThenAllTheDetailsOfTheMediaTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyMediaTab();
        }

        [When(@"I navigate to new media tab")]
        public void WhenINavigateToNewMediaTab()
        {
            Objects.poCompanyOpportunities_Page.clickNewMediaButton();
        }

        [Then(@"all the details of the new media tab should be displayed")]
        public void ThenAllTheDetailsOfTheNewMediaTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyNewMediaButtonFunctionality();
        }

        [When(@"I enter the details of the new media")]
        public void WhenIEnterTheDetailsOfTheNewMedia()
        {
            Objects.poCompanyOpportunities_Page.enterMediaDetails("New");
        }

        [When(@"I enter the details of the new media to be deleted")]
        public void WhenIEnterTheDetailsOfTheNewMediaToBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.enterMediaDetails("Delete");
        }


        [When(@"I save the details for media in the new window")]
        public void WhenISaveTheDetailsForMediaInTheNewWindow()
        {
            Objects.poCompanyOpportunities_Page.saveDetailsInNewWindow();
        }

        [Then(@"I should be able to see the details of new media")]
        public void ThenIShouldBeAbleToSeeTheDetailsOfNewMedia()
        {
            Objects.poCompanyOpportunities_Page.verifyMediaDetails();
        }

        [When(@"I select the created media")]
        public void WhenISelectTheCreatedMedia()
        {
            Objects.poCompanyOpportunities_Page.selectCreatedMedia();
        }

        [Then(@"the selected media should be deleted")]
        public void ThenTheSelectedMediaShouldBeDeleted()
        {
            Objects.poCompanyOpportunities_Page.verifyMediaIsDeleted();
        }


        [When(@"I delete the media")]
        public void WhenIDeleteTheMedia()
        {
            Objects.poCompanyOpportunities_Page.deleteMedia();
        }

        [When(@"I navigate to insertions tab")]
        public void WhenINavigateToInsertionsTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToInsertionsTab();
        }

        [Then(@"all the details of the insertions tab should be displayed")]
        public void ThenAllTheDetailsOfTheInsertionsTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyInsertionsTab();
        }

        [When(@"I click new booking button under insertions")]
        public void WhenIClickNewBookingButtonUnderInsertions()
        {
            Objects.poCompanyOpportunities_Page.clickNewBookingButton();
        }

        [Then(@"the new booking pop-up window details should be visible")]
        public void ThenTheNewBookingPop_UpWindowDetailsShouldBeVisible()
        {
            Objects.poCompanyOpportunities_Page.verifyNewBookingPopUp();
        }

        [Then(@"buyer and advertiser name should be set same as the company name")]
        public void ThenBuyerAndAdvertiserNameShouldBeSetSameAsTheCompanyName()
        {
            Objects.poCompanyOpportunities_Page.verifyBuyerAndAdvitiserName();
        }

        [When(@"I cancel bookings from the pop-up")]
        public void WhenICancelBookingsFromThePop_Up()
        {
            Objects.poCompanyOpportunities_Page.clickCancelBookingsButton();
        }

        [Then(@"the new booking pop-ups should be closed")]
        public void ThenTheNewBookingPop_UpsShouldBeClosed()
        {
            Objects.poCompanyOpportunities_Page.verifyCancelButtonFunctionality();
        }

        [When(@"I navigate to tasks tab")]
        public void WhenINavigateToTasksTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToTasksTab();
        }

        [When(@"I create new task in opportunites")]
        public void WhenICreateNewTaskInOpportunites()
        {
            Objects.poCompanyOpportunities_Page.clickNewTab();
            //Objects.poCompanyHistoryNewTab_Page.enterNewTaskInformation("Delete");
            Objects.poCompanyOpportunities_Page.enterNewTaskInformation();
            Objects.poCompanyOpportunities_Page.saveTaskInOpportunities();
        }


        [Then(@"Task should be created successfully in opportunites")]
        public void ThenTaskShouldBeCreatedSuccessfullyInOpportunites()
        {
            Objects.poCompanyOpportunities_Page.verifyTaskInOpportunitiesIsSavedSuccessfully();
        }


        [Then(@"all the details of the tasks tab should be displayed")]
        public void ThenAllTheDetailsOfTheTasksTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyTasksButtonFunctionality();
        }

        [When(@"I click on the New Task button for the selected opportunity")]
        public void WhenIClickOnTheNewTaskButtonForTheSelectedOpportunity()
        {
            Objects.poCompanyOpportunities_Page.clickNewTab();
        }

        [Then(@"New Task details should be displayed for the selected opportunity")]
        public void ThenNewTaskDetailsShouldBeDisplayedForTheSelectedOpportunity()
        {   
            Objects.poCompanyHistory_Page.verifyNewTaskButtonFunctionality("Opportunity");
        }

        [When(@"I enter the information under new task tab for the selected opportunity")]
        public void WhenIEnterTheInformationUnderNewTaskTabForTheSelectedOpportunity()
        {
            Objects.poCompanyHistoryNewTab_Page.enterNewTaskInformationNewWindow();
        }

        [When(@"I click on save button details for the selected opportunity")]
        public void WhenIClickOnSaveButtonDetailsForTheSelectedOpportunity()
        {
            Objects.poCompanyHistory_Page.ClickSave();
        }

        [Then(@"all the details of the information tab should be saved successfully for the selected opportunity")]
        public void ThenAllTheDetailsOfTheInformationTabShouldBeSavedSuccessfullyForTheSelectedOpportunity()
        {
            Objects.poCompanyHistory_Page.verifyInformationIsSavedSuccessfully();
        }

        [When(@"I navigate to notes tab under opportunities")]
        public void WhenINavigateToNotesTabUnderOpportunities()
        {
            Objects.poCompanyOpportunities_Page.navigateToNotesTab();
        }

        [When(@"I navigate to attachments tab under opportunities")]
        public void WhenINavigateToattachmentsTabUnderOpportunities()
        {
            Objects.poCompanyOpportunities_Page.navigateToAttachmentsTab();
        }

        [When(@"I navigate to sales assignment tab under opportunities")]
        public void WhenINavigateToSalesAssignmentTabUnderOpportunities()
        {
            Objects.poCompanyOpportunities_Page.navigateToSalesAssignmentTab();
        }


        [When(@"I navigate to quote tab")]
        public void WhenINavigateToQuoteTab()
        {
            Objects.poCompanyOpportunities_Page.navigateToQuoteTab();
        }

        [Then(@"all the details of the quote tab should be displayed")]
        public void ThenAllTheDetailsOfTheProposalTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteDetails();
        }

        [When(@"I navigate to new quote tab")]
        public void WhenINavigateToNewQuoteTab()
        {
            Objects.poCompanyOpportunities_Page.clickNewQuoteButton();
        }

        [Then(@"all the details of the new quote tab should be displayed")]
        public void ThenAllTheDetailsOfTheNewProposalTabShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyQuotePopUp();
        }

        [When(@"I create new quote")]
        public void WhenIEnterTheDetailsOfTheNewQuote()
        {
            Objects.poCompanyOpportunities_Page.enterQuoteDetails();
            Objects.poCompanyOpportunities_Page.clickSaveAndCloseButton();
        }

        [When(@"I click edit the quote button")]
        public void WhenIClickEditTheQuoteButton()
        {
            Objects.poCompanyOpportunities_Page.clickEditQuoteButton();
        }

        [Then(@"the details of the quote should be displayed successfully")]
        public void ThenTheDetailsOfTheQuoteShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteDetailsAreSaved();
        }

        [When(@"I select the created Quote")]
        public void WhenISelectTheCreatedQuote()
        {
            Objects.poCompanyOpportunities_Page.selectCreatedQuote();
        }


        [When(@"I delete the created quote")]
        public void WhenIDeleteTheCreatedTheQuote()
        {
            Objects.poCompanyOpportunities_Page.clickDeleteQuoteButton();
        }

        [Then(@"the quote should be deleted successfully")]
        public void ThenTheQuoteShouldBeDeletedSuccessfully()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteIsDeleted();
        }

        [When(@"I cancel the quote creation")]
        public void WhenICancelTheQuoteCreation()
        {
            Objects.poCompanyOpportunities_Page.clickCancelButton();
        }

        [When(@"I edit the quote")]
        public void WhenIEditTheQuote()
        {
            Objects.poCompanyOpportunities_Page.editQuote();
            Objects.poCompanyOpportunities_Page.clickApplyButton();
        }

        [Then(@"the quote should be edited successfully")]
        public void ThenTheQuoteShouldBeEditedSuccessfully()
        {
            Objects.poCompanyOpportunities_Page.verifyEditedQuote();
        }

        [When(@"I save and close the Quote tab")]
        public void WhenISaveAndCloseTheQuoteTab()
        {
            Objects.poCompanyOpportunities_Page.clickSaveAndCloseButton();
        }

        [When(@"I navigate to the created quote for calender view")]
        public void WhenINavigateToTheCreatedQuoteForCalenderView()
        {
            Objects.poCompanyOpportunities_Page.navigateToCalenderViewQuote();
        }


        [When(@"I navigate to the created quote")]
        public void WhenINavigateToTheCreatedQuote()
        {
            Objects.poCompanyOpportunities_Page.clickEditQuote();
        }

        [When(@"I click stationery button for the quote")]
        public void WhenIClickStationeryButtonForTheQuote()
        {
            Objects.poCompanyOpportunities_Page.clickStationeryButton();
        }

        [Then(@"the details of the stationery button should be displayed successfully")]
        public void ThenTheDetailsOfTheStationeryButtonShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanyOpportunities_Page.verifyStationeryButtonFunctionality();
        }

        [When(@"I click on Create Booking")]
        public void WhenIClickOnCreateBooking()
        {
            Objects.poCompanyOpportunities_Page.clickCreateBooking();
        }

        [Then(@"Qoute Booking details should be displayed")]
        public void ThenQuoteBookingDetailsShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteBookingDetails();
        }

        [When(@"I select issue available in the Quote booking grid for calender view")]
        public void WhenISelectIssueAvailableInTheQuoteBookingGridCalender()
        {
            Objects.poCompanyOpportunities_Page.selectQuoteBookingIssue("CalenderView");
        }


        [When(@"I select issue available in the Qoute booking grid for list view")]
        public void WhenISelectIssueAvailableInTheQuoteBookingGridList()
        {
            Objects.poCompanyOpportunities_Page.selectQuoteBookingIssue("ListView");
        }
        [Then(@"Qoute Issue details in list view should be displayed")]
        public void ThenQuoteIssueDetailsShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteBookingIssueDetails("List");
        }

        [When(@"I select issue available in Issue Selection grid")]
        public void WhenISelectIssueAvailableInIssueSelectionGrid()
        {
            Objects.poCompanyOpportunities_Page.selectIssueInIssueSelectionGrid();
        }

        [Then(@"Select Issue details should be enabled")]
        public void ThenSelectIssueDetailsShouldBeEnabled()
        {
            Objects.poCompanyOpportunities_Page.verifySelectIssueDetails();
        }

        [When(@"I apply issue details")]
        public void WhenIEnterIssueDetails()
        {
            Objects.poCompanyOpportunities_Page.enterIssueDetails();
        }

        [Then(@"Quote Issue details in calender view should be displayed")]
        public void ThenQuoteIssueDetailsInCalenderViewShouldBeDisplayed()
        {
            Objects.poCompanyOpportunities_Page.verifyQuoteBookingIssueDetails("Calender");
        }


        [Then(@"Next button should be enabled")]
        public void ThenNextButtonShouldBeEnabled()
        {
            Objects.poCompanyOpportunities_Page.verifyNextButton();
        }


    }
}
