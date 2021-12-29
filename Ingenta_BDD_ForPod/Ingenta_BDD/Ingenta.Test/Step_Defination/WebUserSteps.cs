using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class WebUserSteps
    {
        [Then(@"Website User details should be displayed")]
        public void ThenWebsiteUserDetailsShouldBeDisplayed()
        {
            Objects.poContactWebUser_Page.verifyWebUserButton();
        }

        [When(@"I click new web site users button")]
        public void WhenIClickNewWebSiteUsersButton()
        {
            Objects.poContactWebUser_Page.clickNewWebSiteUser();
        }

        [Then(@"New web site user details window should be displayed")]
        public void ThenNewWebSiteUserDetailsWindowShouldBeDisplayed()
        {
            Objects.poContactWebUser_Page.verifyNewWebSiteUserWindowDetails();
        }

        [When(@"I create new website user")]
        public void WhenICreateNewWebsiteUser()
        {
            Objects.poContactWebUser_Page.clickNewWebSiteUser();
            Objects.poContactWebUser_Page.enterWebSiteUserDetails();
            Objects.poContactWebUser_Page.clickSaveWebSiteUser();
        }

        [When(@"I create new website user with invalid data")]
        public void WhenICreateNewWebsiteUserWithInvalidData()
        {
            Objects.poContactWebUser_Page.clickNewWebSiteUser();
            Objects.poContactWebUser_Page.enterInvalidWebSiteUserDetails();
            Objects.poContactWebUser_Page.clickSaveWebSiteUser();
        }


        [Then(@"New website user should be created")]
        public void ThenNewWebsiteUserShouldBeCreated()
        {
            Objects.poContactWebUser_Page.verifyWebSiteUserIsCreated();
        }

        [Then(@"I should get an error message")]
        public void ThenIShouldGetAnErrorMessage()
        {
            Objects.poContactWebUser_Page.verifyErrorMessageForWebSiteUser();
            
        }

        [When(@"I close Web site user window")]
        public void WhenICloseWebSiteUserWindow()
        {
            Objects.poContactWebUser_Page.closeWebSiteUserWindow();
        }


        [Then(@"Web site user window should be closed")]
        public void ThenWebSiteUserWindowShouldBeClosed()
        {
            Objects.poContactWebUser_Page.verifyWebSiteUserWindowIsClosed();
        }



    }
}
