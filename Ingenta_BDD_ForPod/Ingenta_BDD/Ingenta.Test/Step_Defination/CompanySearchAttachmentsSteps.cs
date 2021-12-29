using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanySearchAttachmentsSteps
    {
        [When(@"I navigate to attachments tab from History")]
        public void WhenINavigateToAttachmentsTab()
        {
            Objects.poCompanyHistory_Page.navigateToAttachmentsTabFromHistory();
        }
        
        [Then(@"Attachments tab details should be displayed")]
        public void ThenCompanyAttachmentsTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyAttachmentsTabDetails();
        }

        [When(@"I click new attachments button")]
        public void WhenIClickNewattachmentsButton()
        {
            Objects.poCompanyHistory_Page.clickNewAttachmentButton();
        }

        [Then(@"New attachment window should be displayed")]
        public void ThenNewattachmentWindowShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyAttachmentsPage();
        }

        [When(@"I upload a new attachment")]
        public void WhenIUploadANewattachment()
        {
            Objects.poCompanyHistory_Page.uploadAttachment();
        }

        [When(@"I save the attachment")]
        public void WhenISaveTheattachment()
        {
            Objects.poCompanyHistory_Page.clickSaveAttachment();
        }

        [When(@"I click on view attachment")]
        public void WhenIClickOnViewAttachment()
        {
            Objects.poCompanyHistory_Page.clickViewAttachment();
        }


        [When(@"I select the attachment")]
        public void WhenISelectTheattachment()
        {
            Objects.poCompanyHistory_Page.selectAttachment();
        }

        [When(@"I delete the attachment")]
        public void WhenIDeleteTheattachment()
        {
            Objects.poCompanyHistory_Page.deleteAttachment();
        }

        [Then(@"the attachment should be succesfully deleted\.")]
        public void ThenTheattachmentShouldBeSuccesfullyDeleted_()
        {
            Objects.poCompanyHistory_Page.verifyAttachmentIsDeleted();
        }

        [When(@"I edit this attachment")]
        public void WhenIEditThisattachment()
        {
            Objects.poCompanyHistory_Page.clickEditAttachment();
        }

        [When(@"I delete attachment from pop-up window")]
        public void WhenIDeleteattachmentFromPop_UpWindow()
        {
            Objects.poCompanyHistory_Page.deleteAttachmentFromNewWindow();
        }

        [Then(@"Uploaded attachment details should be displayed")]
        public void ThenUploadedattachmentDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHistory_Page.verifyAttachmentIsUploaded();
        }

        [Then(@"the attachment should be succesfully deleted in the previous window\.")]
        public void ThenTheattachmentShouldBeSuccesfullyDeletedInThePreviousWindow_()
        {
            Objects.poCompanyHistory_Page.verifyAttachmentIsDeletedPrevWindow();
        }


    }
}
