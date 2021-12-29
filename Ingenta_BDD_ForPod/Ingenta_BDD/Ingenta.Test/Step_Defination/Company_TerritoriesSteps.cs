using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_TerritoriesSteps
    {
        [When(@"I navigate to Territories tab")]
        public void WhenINavigateToTerritoriesTab()
        {
            Objects.poCompanyTerritories_Page.navigateToTerritoriesTab();
        }

        [Then(@"Company Territories tab details should be displayed")]
        public void ThenCompanyTerritoriesTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanyTerritories_Page.verifyTerritoriesTabDetails();
        }

        [When(@"I click on new button in territories tab")]
        public void WhenIClickOnNewButtonInTerritoriesTab()
        {
            Objects.poCompanyTerritories_Page.clickOnNewButton();
        }


        [Then(@"all the elements in new territories should be displayed")]
        public void ThenAllTheElementsInNewTerritoriesShouldBeDisplayed()
        {
            Objects.poCompanyTerritories_Page.verifyNewTerritoriesDetails();
        }
    }
}
