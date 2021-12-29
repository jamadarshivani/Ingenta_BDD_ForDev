using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_HistorySteps
    {
        [When(@"I search for company as ""(.*)""")]
        public void WhenISearchForCompanyAs(string companyName)
        {
            Objects.poCompanySearch_Page.searchForCompany(companyName,"Company");
        }

        [Then(@"I should be navigated to the history tab")]
        public void ThenIShouldBeNavigatedToTheHistoryTab()
        {
            Objects.poCompanyHistory_Page.verifyHistoryPage();
        }

        [When(@"I click on the New Task button")]
        public void WhenIClickOnTheNewTaskButton()
        {
            Objects.poCompanyHistory_Page.navigateToNewTaskPage();
        }

        [Then(@"New Task details should be displayed")]
        public void ThenIShouldBeNavigatedToNewTaskPage()
        {
            Objects.poCompanyHistory_Page.verifyNewTaskButtonFunctionality("History");
        }

        [When(@"I click on the company ellipsis button")]
        public void WhenIClickOnTheCompanyEllipsisButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickCompanyEllipsis();
        }

        [Then(@"I should be able to see the company details pop-up")]
        public void ThenIShouldBeAbleToSeeTheCompanyDetailsPop_Up()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyCompanyEllipsisPopUp();
        }

        [When(@"I click on the contact ellipsis button")]
        public void WhenIClickOnTheContactEllipsisButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickContactEllipsis();
        }

        [Then(@"I should be able to see the contact details pop-up")]
        public void ThenIShouldBeAbleToSeeTheContactDetailsPop_Up()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyContactEllipsisPopUp();
        }

        [When(@"I enter the information under new task tab")]
        public void WhenIEnterTheInformationUnderNewTaskTab()
        {
            Objects.poCompanyHistoryNewTab_Page.enterNewTaskInformation("New");
        }

        [Then(@"all the details of the information tab should be saved successfully")]
        public void ThenAllTheDetailsOfTheInformationTabShouldBeSavedSuccessfully()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyInformationIsSavedSuccessfully();
        }

        [Then(@"save and save and close button will be disabled")]
        public void ThenSaveAndSaveAndCloseButtonWillBeDisabled()
        {
            Objects.poCompanyHistoryNewTab_Page.verifySaveSaveAndCloseButtonsAreDisabled();
        }
        [Then(@"delete,stationery and create booking button will be displayed")]
        public void ThenDeleteStationeryAndCreateBookingButtonWillBeDisplayed()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyDeleteStationeryCreateBookingAreDisplayed();
        }

        [Then(@"title should be combination of company Name , Contact Name and Subject")]
        public void ThenTitleShouldBeCombinationOfCompanyNameContactNameAndSubject()
        {
            Objects.poCompanyHistory_Page.verifyTitle();
        }        

        [When(@"I click the follow up calls button")]
        public void WhenIClickTheFollowUpCallsButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickFollowUpCalls();
        }

        [When(@"I enter the information under new task tab from follow up calls tab")]
        public void WhenIEnterTheInformationUnderNewTaskTabFromFollowUpCallsTab()
        {
            Objects.poCompanyHistoryNewTab_Page.enterInformationInNewWindow();
        }

        [When(@"I click on save button of new window")]
        public void WhenIClickOnSaveButtonOfNewWindow()
        {
            Objects.poCompanyHistoryNewTab_Page.clickSaveNewWindow();
        }

        [When(@"I click close button for follow up calls")]
        public void WhenIClickCloseButtonForFollowUpCalls()
        {
            Objects.poCompanyHistoryNewTab_Page.clickCloseNewWindow();
        }

        [When(@"I click close button for history tab")]
        public void WhenIClickCloseButtonForHistoryTab()
        {
            Objects.poCompanyHistoryNewTab_Page.clickClose();
        }

        [Then(@"I should be able to see the tasks successfully")]
        public void ThenIShouldBeAbleToSeeTheTasksSuccessfully()
        {
            Objects.poCompanyHistory_Page.verifyFollowUpCall();
        }

        [Then(@"I should see the note with date,name and post should be created successfully in contacts")]
        public void ThenIShouldSeeTheNoteWithDateNameAndPostShouldBeCreatedSuccessfully()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyCreatedNote();
        }

        [Then(@"I should see the error message under the editbox")]
        public void ThenIShouldSeeTheErrorMessageUnderTheEditbox()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyBlankMessageError();
        }

        [When(@"I click on notes button")]
        public void WhenIClickOnNotesButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickNotesTab();
        }

        [When(@"I select start date from date picker")]
        public void WhenISelectStartDateFromDatePicker()
        {
            Objects.poCompanyHistoryNewTab_Page.selectingDateForNotes();
        }

        [When(@"I click post button")]
        public void WhenIClickPostButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickPostNotesButton();
        }

        [When(@"I select the parent note")]
        public void WhenISelectTheParentNote()
        {
            Objects.poCompanyHistoryNewTab_Page.selectNote();
        }

        [Then(@"the delete note should be disabled")]
        public void ThenTheDeleteNoteShouldBeDisabled()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyDeleteButtonIsDisabled();
        }

        [When(@"I click delete note button")]
        public void WhenIClickDeleteNoteButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickDeleteButton();
        }

        [Then(@"the selected note should be deleted")]
        public void ThenTheSelectedNoteShouldBeDeleted()
        {
            Objects.poCompanyHistoryNewTab_Page.verifynoteIsDeleted();
        }

        [When(@"I select the starting date as ""(.*)""")]
        public void WhenISelectTheStartingDateAs(string startDate)
        {
            Objects.poCompanyHistoryNewTab_Page.selectStartDate(startDate);
        }

        [Then(@"created note should be displayed in notes grid")]
        public void ThenNoteShouldBeSeen()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyNoteIsSeen();
        }

        [Then(@"created note should not be displayed in notes grid")]
        public void ThenNoteShouldNotBeSeen()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyNoteIsNotSeen();
        }

        [When(@"I click on attachments button")]
        public void WhenIClickOnattachmentsButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickAttachments();
        }

        [Then(@"I should be navigated to the new attachment window")]
        public void ThenIShouldBeNavigatedToTheNewattachmentWindow()
        {
            Objects.poCompanyHistoryNewTab_AttachmentWindow.verifyAttachmentsPage();
        }        

        [When(@"I click on messages button")]
        public void WhenIClickOnMessagesButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickMessages();
        }

        [Then(@"I should be successfully navigated to the messages button")]
        public void ThenIShouldBeSuccessfullyNavigatedToTheMessagesButton()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyMessageTab();
        }

        [Then(@"I should be successfully navigated to create booking pop-up")]
        public void ThenIShouldBeSuccessfullyNavigatedToCreateBookingPop_Up()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyCreateBookingButtonFunctionality();
        }      

        [Then(@"I should be navigated to the stationery window")]
        public void ThenIShouldBeNavigatedToTheStationeryWindow()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyStationeryWindow();
        }

        [When(@"I click company button")]
        public void WhenIClickCompanyButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickCompanyButton();
        }
        
        [When(@"I Create New Task to be deleted")]
        public void WhenICreateNewTaskToBeDeleted()
        {
            Objects.poCompanyHistory_Page.navigateToNewTaskPage();
            Objects.poCompanyHistoryNewTab_Page.enterNewTaskInformation("Delete");
            //Objects.poCompanyFinance_Page.ClickSave();
            Objects.poCompanyFinance_Page.clickSaveAndClose();
        }


        [When(@"I navigate to created task")]
        public void WhenISelectCreatedTask()
        {
            Objects.poCompanyHistoryNewTab_Page.selectTaskToBeDeleted();
        }        

        [When(@"I click delete button")]
        public void WhenIClickDeleteButton()
        {
            Objects.poCompanyHistoryNewTab_Page.clickDeleteCallButton();
        }

        [Then(@"I should be able to see all the elements of the pending task")]
        public void ThenIShouldBeAbleToSeeAllTheElementsOfThePendingTask()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyPendingTaskElements();
        }

        [Then(@"I should be able to see all the elements of the user calendar")]
        public void ThenIShouldBeAbleToSeeAllTheElementsOfTheUserCalendar()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyUserCalendarElements();
        }

        [Then(@"the created task should be deleted")]
        public void ThenTheTaskWillBeDeleted()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyTaskIsDeleted();
        }

        [When(@"I click home button")]
        public void WhenIClickHomeButton()
        {
            Objects.poBookingDetails.ClickHomeButton();
        }

        [When(@"I click New Booking Button")]
        public void WhenIClickNewBookingButton()
        {
            Objects.poCompanyHistory_Page.navigateToNewBookingWindow();
        }

        [When(@"I enter the new booking details in a new window")]
        public void WhenIEnterTheNewBookingDetailsInANewWindow()
        {
            Objects.poCompanyHistoryNewTab_Page.enterBookingDetailsNewWindow();
        }

        [Then(@"the details of the new booking should be successfully visible in new window")]
        public void ThenTheDetailsOfTheNewBookingShouldBeSuccessfullyVisibleInNewWindow()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyBookingisCreatedNewWindow();
        }

        [Then(@"elements of new booking page should be visible")]
        public void ThenElementsOfNewBookingPageShouldBeVisible()
        {
            Objects.poCompanyHistoryNewTab_Page.verifyNewBookingButtonFunctionality();
        }
    }
}
