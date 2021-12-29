using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_AdTemplatesSteps
    {

        [When(@"I click on new button of Ad Template")]
        public void WhenIClickOnNewButtonOfAdTemplate()
        {
            Objects.poCompanyAdTemplates_Page.clickOnNewButton();
        }

        [Then(@"all the elements should be displayed for new ad templates window")]

        public void ThenAllTheElementsShouldBeDisplayed()
        {
            Objects.poCompanyAdTemplates_Page.verifyNewTemplateDetails();
        }


        [When(@"I create new template")]
        public void WhenIcreateNewTemplate()
        {
            Objects.poCompanyAdTemplates_Page.clickOnNewButton();
            Objects.poCompanyAdTemplates_Page.enterAllDetailsInAdTemplates();
            Objects.poCompanyAdTemplates_Page.fileUpload();
            Objects.poCompanyAdTemplates_Page.saveAdTemplate();
        }

        [Then(@"the ad template should be created successfully")]


        public void ThenAllThedetailsShouldBeSaved()
        {
            Objects.poCompanyAdTemplates_Page.verifyAdTemplateDetails();

        }


        [When(@"I edit the ad template details")]
        public void WhenIEditTheAdTemplateDetails()
        {
            // Objects.poCompanyAdTemplates_Page.clickOnEditButton();
            Objects.poCompanyAdTemplates_Page.selectTemplate();
            Objects.poCompanyAdTemplates_Page.editAdTemplateWindow();
            Objects.poCompanyAdTemplates_Page.fileUpload();
            Objects.poCompanyAdTemplates_Page.saveAdTemplate();
        }

        [Then(@"the edited ad template should be saved successfully")]
        public void ThenTheEditedAdTemplateShouldBeSavedSuccessfully()
        {
            Objects.poCompanyAdTemplates_Page.verifyEditDetailsInAdTemplate();
        }



        [When(@"I select any created template")]
        public void WhenISelectAnyCreatedTemplate()
        {
            Objects.poCompanyAdTemplates_Page.selectTemplate();
        }



        [When(@"I close the ad template window")]
        public void WhenICloseTheAdTemplateWindow()
        {

            Objects.poCompanyAdTemplates_Page.clickOnCloseButton();
        }

        [Then(@"Ad Template window should be closed successfully")]
        public void ThenAdTemplateWindowShouldBeClosed()
        {
            Objects.poCompanyAdTemplates_Page.AdTemplateWindowIsClosed();
        }


        [Then(@"Thumbnail should be clickable")]
        public void ThenThumbnailShouldBeClickable()
        {
            Objects.poCompanyAdTemplates_Page.verifyThumbanailIsClickable();
        }

        

        

    }
}
