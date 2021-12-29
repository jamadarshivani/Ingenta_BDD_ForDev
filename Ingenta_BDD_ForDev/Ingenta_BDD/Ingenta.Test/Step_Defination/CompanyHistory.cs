using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyHistorySteps
    {
        [When(@"I navigate to searched contact")]
        public void WhenINavigateToSearchedContact()
        {
            Objects.searchContact.openContact();
        }

        [When(@"I navigate to History Tab from Contacts")]
        public void WhenINavigateToHistoryTabFromContacts()
        {
            Objects.poCompanyHistory_Page.navigateToHistoryTab("Contacts");
        }

        [When(@"I navigate to Inventory")]
        public void WhenINavigateToInventory()
        {
            Objects.poCompanyHistory_Page.ClickInventory();
        }

        [When(@"Inventory details should be displayed")]
        public void WhenInventoryDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.VerifyInventoryDetails();
        }


        [When(@"I create new task with mandatory fields")]
        public void WhenICreateNewTaskWithMandatoryFields()
        {            
            Objects.poCompanyHistory_Page.ClickNewTask();
            Objects.poCompanyHistory_Page.enterNewTaskInformationWithMandatoryDetails();
            Objects.poCompanyFinance_Page.ClickSave();            
        }

        [When(@"I create a new booking from history tab")]
        public void WhenICreateANewBookingFromHistoryTab()
        {
            Objects.poCompanyResult.clickNewBooking();
            Objects.poCompanyHistory_Page.enterBookingDetailsNewWindow();
        }

        [Then(@"New booking details should be displayed")]
        public void ThenNewBookingDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyBookingisCreatedNewWindow();
        }

        [Then(@"Deleted task should not be displayed")]
        public void ThenDeletedTaskShouldNotBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyTaskIsDeleted();
        }


        [When(@"click view this call button")]
        public void WhenClickViewThisCallButton()
        {
            Objects.poCompanyHistory_Page.clickViewThisCall();
        }

        [When(@"I delete the task")]
        public void WhenIDeleteTheTask()
        {
            Objects.poCompanyHistory_Page.clickDeleteCallButton();
        }

        [Then(@"Pending task details should be displayed")]
        public void ThenPendingTaskDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyPendingTaskElements();
        }

        [Then(@"User Calender details should be displayed")]
        public void ThenUserCalendDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyUserCalendarElements();
        }

        [When(@"I navigate to Home Page")]
        public void WhenINavigateToHomePage()
        {
            Objects.poBookingDetails.ClickHomeButton();
        }

        [When(@"I click contact button")]
        public void WhenIClickContactButton()
        {
            Objects.poCompanyHistory_Page.clickContactButtonInHeader();
        }

        [When(@"I click stationery button")]
        public void WhenIClickStationeryButton()
        {
            Objects.poCompanyHistory_Page.ClickStationeryButton();
        }

        [Then(@"Stationery details should be displayed")]
        public void ThenStationeryDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyStationeryWindow();
        }

        [Then(@"Task should be created successfully")]
        public void ThenTaskShouldBeCreatedSuccessfully()
        {
            Objects.poCompanyHistory_Page.verifyInformationIsSavedSuccessfully();
        }

        [Then(@"save and save and close button should be disabled")]
        public void ThenSaveAndSaveAndCloseButtonShouldBeDisabled()
        {
            Objects.poCompanyHistory_Page.verifySaveSaveAndCloseButtonsAreDisabled();
        }

        [Then(@"delete,stationery and create booking button should be displayed")]
        public void ThenDeleteStationeryAndCreateBookingButtonShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyDeleteStationeryCreateBookingAreDisplayed();
        }

        [Then(@"task and user forms tabs should be enabled")]
        public void ThenTaskAndUserFormsTabsShouldBeEnabled()
        {
            Objects.poCompanyHistory_Page.verifyTaskAndUserFormTabsAreEnabled();
        }

        [When(@"I navigate to History Tab")]
        public void WhenINavigateToHistoryTab()
        {
            Objects.poCompanyHistory_Page.navigateToHistoryTab("Company");
        }

        [When(@"I create new task")]
        public void WhenICreateNewTask()
        {
            Objects.poCompanyHistory_Page.ClickNewTask();
            Objects.poCompanyHistory_Page.enterNewTaskInformation();
            Objects.poCompanyFinance_Page.ClickSave();
        }

        [When(@"I click create booking button")]
        public void WhenIClickCreateBookingButton()
        {
            Objects.poCompanyHistory_Page.navigateToCreateBookingFromNewTask();
        }

        [When(@"I enter the new booking details")]
        public void WhenIEnterTheNewBookingDetails()
        {
            Objects.poCompanyHistory_Page.enterBookingDetails();
        }

        [Then(@"the details of the new booking should be successfully visible")]
        public void ThenTheDetailsOfTheNewBookingShouldBeSuccessfullyVisible()
        {
            Objects.poCompanyHistory_Page.verifyBookingisCreated();
        }

        [Then(@"Create booking popup should be displayed")]
        public void ThenCreateBookingPopupShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyCreateBookingButtonFunctionality();
        }

        [When(@"I navigate to messages")]
        public void WhenINavigateToMessages()
        {
            Objects.poCompanyHistory_Page.navigateToMessages();
        }

        [Then(@"Messages details should be displayed")]
        public void ThenMessagesDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyMessageTab();
        }

        [When(@"I navigate to notes")]
        public void WhenINavigateToNotes()
        {
            Objects.companyNotes_Page.navigateToNotesTabFromHistory();
        }

        [Then(@"I should see the note with date,name and post should be created successfully")]
        public void ThenIShouldSeeTheNoteWithDateNameAndPostShouldBeCreatedSuccessfully()
        {
            Objects.companyNotes_Page.verifyCreatedNoteOnGrid();
        }

        [When(@"I select the created note")]
        public void WhenISelectTheCreatedNote()
        {
            Objects.companyNotes_Page.selectNote();
        }        
        
        [When(@"I enter a reply note")]
        public void WhenIEnterAReplyNote()
        {
            Objects.companyNotes_Page.createReplyNote();
        }

        [When(@"I click reply button")]
        public void WhenIClickReplyButton()
        {
            Objects.companyNotes_Page.clickReplyButton();
        }

        [Then(@"Error message should be displayed under editbox")]
        public void ThenErrorMessageShouldBeDisplayedUnderEditbox()
        {
            Objects.companyNotes_Page.verifyBlankMessageError();
        }

        [Then(@"I should see that a reply note has been successfully created")]
        public void ThenIShouldSeeThatAReplyNoteHasBeenSuccessfullyCreated()
        {
            Objects.companyNotes_Page.verifyReplyNoteIsCreated();
        }

        [When(@"I create a note")]
        public void WhenICreateANote()
        {
            Objects.companyNotes_Page.enterNotes();
        }

        [Then(@"Notes details should be displayed")]
        public void ThenNotesDetailsShouldBeDisplayed()
        {
            Objects.companyNotes_Page.verifyNotesTab();
        }

        [When(@"I navigate to follow up calls")]
        public void WhenINavigateToFollowUpCalls()
        {
            Objects.poCompanyHistory_Page.clickFollowUpCalls();
        }

        [When(@"I click the new follow up calls button")]
        public void WhenIClickTheNewFollowUpCallsButton()
        {
            Objects.poCompanyHistory_Page.clickNewFollowUpCallsbtn();
        }

        [Then(@"Task window details should be displayed")]
        public void ThenTaskWindowDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyNewTaskInfoPageDetails();
        }

        [When(@"I close the Task window")]
        public void WhenICloseTheTaskWindow()
        {
            Objects.poCompanyHistory_Page.closeNewTaskWindow();
        }

        [Then(@"Task window should be closed")]
        public void ThenTaskWindowShouldBeClosed()
        {
            Objects.poCompanyHistory_Page.verifyTaskWindowIsClosed();
        }

        [When(@"I click on New Task button")]
        public void WhenIClickOnNewTaskButton()
        {
            Objects.poCompanyHistory_Page.ClickNewTask();
        }

        [Then(@"Task Information details should be displayed")]
        public void ThenTaskInformationDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyTaskInfoPageDetails("Task");
        }


        [When(@"I enter history details")]
        public void WhenIEnterHistoryDetails()
        {
            Objects.poCompanyHistory_Page.enterHistoryDetails();
        }

        [Then(@"History details should be saved")]
        public void ThenHistoryDetailsShouldBeSaved()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"History details should be displayed")]
        public void ThenHistoryDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyHistoryPageDetails();
        }

        [When(@"I click close button")]
        public void WhenIClickCloseButton()
        {
            Objects.poCompanyHistory_Page.clickCloseButton();
            Objects.poCompanyHistory_Page.noOfCallsBeforeDeleting();
        }

        [When(@"I click close button for company history")]
        public void WhenIClickCloseButtonForCompanyHistory()
        {
            Objects.poCompanyHistory_Page.clickCloseButton();            
        }

        [Then(@"I should get redirected to contact history page")]
        public void ThenIShouldGetRedirectedToContactHistoryPage()
        {
            Objects.poCompanyHistory_Page.verifyContactHistoryTitle();
        }

        [When(@"I select the start date of task as a ""(.*)""")]
        public void WhenISelectTheStartDateOfTaskAsA(string selectedDate)
        {
            Objects.poCompanyHistory_Page.selectStartingFromDate(selectedDate);
        }

        [When(@"I click refresh button")]
        public void WhenIClickRefreshButton()
        {
            Objects.poCompanyHistory_Page.clickRefreshButton();
        }

        [Then(@"the tasks till present date should be visible")]
        public void ThenTheTasksTillPresentDateShouldBeVisible()
        {
            Objects.poCompanyHistory_Page.verifyTasksAreVisible();
        }

        [When(@"I navigate to new inventory window")]
        public void WhenINavigateToNewInventoryWindow()
        {
            Objects.poCompanyHistory_Page.clickInventoryButton();
        }

        [Then(@"all the details of the inventory window should be displayed successfully")]
        public void ThenAllTheDetailsOfTheInventoryWindowShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanyHistory_Page.verifyNewInventoryWindow();
        }

    }
}
