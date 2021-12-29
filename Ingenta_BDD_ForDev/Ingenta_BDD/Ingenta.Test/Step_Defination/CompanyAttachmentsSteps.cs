using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyAttachmentsSteps
    {

        [When(@"I navigate to Attachments Tab")]
        public void WhenIClickOnAttachmentsTab()
        {
            Objects.poCompanyAttachment_Page.navigateToAttachmentsTab();
        }


        [Then(@"all the elements of the attachment tab should be visible")]
        public void ThenAllTheElementsOfTheAttachmentTabShouldBeVisible()
        {
            Objects.poCompanyAttachment_Page.verifyAttachmentsButtonFunctionality();
        }

    }
}
