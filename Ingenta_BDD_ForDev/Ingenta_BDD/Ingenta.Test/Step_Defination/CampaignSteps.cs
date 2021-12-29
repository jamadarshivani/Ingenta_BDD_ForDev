using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CampaignSteps
    {
        [Then(@"Campaign tab details should be displayed")]
        public void ThenCampaignTabDetailsShouldBeDisplayed()
        {
            Objects.poContactCampaign_Page.verifyCampaignTabDetails();
        }

        [When(@"I click new campaign button")]
        public void WhenIClickNewCampaignButton()
        {
            Objects.poContactCampaign_Page.clickNewCampaign();
        }

        [Then(@"New campaign details window should be displayed")]
        public void ThenNewCampaignDetailsWindowShouldBeDisplayed()
        {
            Objects.poContactCampaign_Page.verifyNewCampaignDetails();
        }
        
        [When(@"I create new campaign")]
        public void WhenICreateNewCampaign()
        {
            Objects.poContactCampaign_Page.clickNewCampaign();
            Objects.poContactCampaign_Page.enterCampaignDetails();
            Objects.poContactCampaign_Page.saveCampaignDetails();
        }

        [Then(@"New campaign should be created")]
        public void ThenNewCampaignShouldBeCreated()
        {
            Objects.poContactCampaign_Page.verifyCampaignDetails();
        }


        [When(@"I click on close campaign")]
        public void WhenIClickOnCloseCampaign()
        {
            Objects.poContactCampaign_Page.closeCampaign();
        }

        [Then(@"Add campaign popup should be closed")]
        public void ThenAddCampaignPopupShouldBeClosed()
        {
            Objects.poContactCampaign_Page.verifyCampaignWindowIsClosed();
        }


    }
}
