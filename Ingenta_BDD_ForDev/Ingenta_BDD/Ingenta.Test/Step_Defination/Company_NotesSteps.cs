using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_NotesSteps
    {
        [When(@"I navigate to notes tab")]
        public void WhenINavigateToNotesTab()
        {
            Objects.poCompanyNotes_Page.navigateToNotesTab();
        }

        [When(@"I navigate to notes tab from contacts")]
        public void WhenINavigateToNotesTabFromContacts()
        {
            Objects.poCompanyNotes_Page.navigateToNotesFromContacts();
        }


        [Then(@"all the elements of notes tab should be displayed")]
        public void ThenAllTheElementsShouldBeDisplayed()
        {
            Objects.poCompanyNotes_Page.verifyNotesTab();
        }

        [When(@"I enter the text in note section")]
        public void WhenIEnterTheTextInNoteSection()
        {
            Objects.poCompanyNotes_Page.enterNotes();
        }

        [When(@"I click on post button")]
        public void WhenIClickOnPostButton()
        {
            Objects.companyNotes_Page.clickPostButton();
        }

        [Then(@"note is posted successfully in the grid")]
        public void ThenNoteIsPostedSuccessfullyInTheGrid()
        {
            Objects.poCompanyNotes_Page.verifyCreatedNoteOnGrid();
        }

        [When(@"I navigate to a created contact")]
        public void WhenINavigateToACreatedContact()
        {
            Objects.poCompanyContacts_Page.navigateToExistingContact();
        }

        [Then(@"I should see the note with date,name and post should be created successfully under notes tab")]
        public void ThenIShouldSeeTheNoteWithDateNameAndPostShouldBeCreatedSuccessfullyUnderNotesTab()
        {
            Objects.poCompanyNotes_Page.verifyCreatedNoteDetails();
        }

        [Then(@"Notes tab details should be displayed")]
        public void ThenNotesTabDetailsShouldBeDisplayed()
        {
            Objects.companyNotes_Page.verifyNotesTab();
        }


    }
}
