using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_BrandsSteps
    {
        [When(@"I click on brands Tab")]
        public void WhenIClickOnBrandsTab()
        {
            Objects.poCompanyBrands_Page.navigateToBrandsTab();
        }

        [Then(@"all the elements of the brands tab should be visible")]
        public void ThenAllTheElementsOfTheBrandsTabShouldBeVisible()
        {
            Objects.poCompanyBrands_Page.verifyBrandsTabFunctionality();
        }

        [When(@"I click new button in brands tab")]
        public void WhenIClickNewButtonInBrandsTab()
        {
            Objects.poCompanyBrands_Page.clickNewBrandsButton();
        }

        [Then(@"New brand details should be displayed")]
        public void ThenIShouldBeAbleToSeeTheElementsUnderNewButtonOfBrandsTab()
        {
            Objects.poCompanyBrands_Page.verifyNewBrandsButtonFunctionality();
        }

        [When(@"I enter the details under information tab of brands")]
        public void WhenIEnterTheDetailsUnderInformationTabOfBrands()
        {
            Objects.poCompanyBrands_Page.enterBrandDetails();
        }

        [When(@"I enter the brand name as ""(.*)""")]
        public void WhenIEnterTheBrandNameAs(string companyName)
        {
            Objects.poCompanyBrands_Page.enterCompanyName(companyName);
        }

        [Then(@"details under information tab of brands will be visible")]
        public void ThenDetailsUnderInformationTabOfBrandsWillBeVisible()
        {
            Objects.poCompanyBrands_Page.verifyBrandsInformation();
        }

        [Then(@"the tabs on the left menu will be enabled")]
        public void ThenTheTabsOnTheLeftMenuWillBeEnabled()
        {
            Objects.poCompanyBrands_Page.verifyUserFormCompanyBrandsAreEnabled();
        }


        [When(@"I select the same as company name checkbox for brand name")]
        public void WhenISelectTheSameAsCompanyNameCheckboxForBrandName()
        {
            Objects.poCompanyBrands_Page.selectBrandNameAsCompanyName();
        }

        [When(@"I click on save and close button")]
        public void WhenIClickOnSaveAndCloseButton()
        {
            Objects.poCompanyBrands_Page.clickSaveAndCloseButton();
        }

        [When(@"I click on cog button")]
        public void WhenIClickOnCogButton()
        {
            Objects.poCompanyBrands_Page.clickCogButton();
        }

        [Then(@"details under information tab of brands will be visible with company name same as the brand name")]
        public void ThenDetailsUnderInformationTabOfBrandsWillBeVisibleWithCompanyNameSameAsTheBrandName()
        {
            Objects.poCompanyBrands_Page.verifyBrandIsCreatedSuccessfully();
        }

        [When(@"I click the first brand's cog button")]
        public void WhenIClickTheFirstBrandSCogButton()
        {
            Objects.poCompanyBrands_Page.clickFirstCogButton();
        }

        [When(@"I click relationship tab")]
        public void WhenIClickRelationshipTab()
        {
            Objects.poCompanyBrands_Page.clickRelationshipTab();
        }

        [When(@"I click sales assignment tab")]
        public void WhenIClickSalesAssignmentTab()
        {
            Objects.poCompanyBrands_Page.clickSalesAssignmentsTab();
        }

        [When(@"I click company button in view brands tab")]
        public void WhenIClickCompanyButtonInViewBrandsTab()
        {
            Objects.poCompanyBrands_Page.clickCompanyButton();
        }

        [Then(@"the relationship tab's elements should be visible")]
        public void ThenTheRelationshipTabSElementsShouldBeVisible()
        {
            Objects.poCompanyBrands_Page.verifyRelationshipsTab();
        }

        [Then(@"view brand and detach the brand should be visible")]
        public void ThenViewBrandAndDetachTheBrandShouldBeVisible()
        {
            Objects.poCompanyBrands_Page.verifyRowAndPinButton();
        }

        [Then(@"the sales assignment tab's elements should be visible")]
        public void ThenTheSalesAssignmentTabSElementsShouldBeVisible()
        {
            Objects.poCompanyBrands_Page.verifySalesAssignmentTab();
        }

        [When(@"I click the first brand's pin button")]
        public void WhenIClickTheFirstBrandSPinButton()
        {
            Objects.poCompanyBrands_Page.clickFirstPinButton();
        }

        [When(@"I select the new company in the new window")]
        public void WhenISelectTheNewCompanyInTheNewWindow()
        {
            Objects.poCompanyBrands_Page.assignCompanyNameInNewWindow();
        }

        [When(@"I click on Detach and Reassign Brand")]
        public void WhenIClickOnDetachAndReassignBrand()
        {
            Objects.poCompanyBrands_Page.clickDetachAndReassignButton();
        }

        [Then(@"the brand should be successfully be detached and new brand should be reassigned")]
        public void ThenTheBrandShouldBeSuccessfullyBeDetachedAndNewBrandShouldBeReassigned()
        {
            Objects.poCompanyBrands_Page.verifyNewBrandIsAssigned();
        }

    }
}
