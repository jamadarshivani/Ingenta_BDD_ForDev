using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyHierarchySteps
    {
        [When(@"I navigate to Hierarchy tab")]
        public void WhenIClickOnHierarchyTab()
        {
            Objects.poCompanyHierarchies_Page.navigateToHierarchiesTab();
        }

        [Then(@"Hierarchy details should be displayed")]
        public void ThenHierarchyDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHierarchies_Page.verifyHierarchiesDetails();
        }

        [When(@"I click on create new button and click on Ok button in popup")]
        public void WhenIClickOnCreateNewButtonAndClickOnOkButtonInPopup()
        {
            Objects.poCompanyHierarchies_Page.clickCreateNewAndOk();
        }

        [Then(@"Current company name should be displayed in ultimate parent field")]
        public void ThenCurrentCompanyNameShouldBeDisplayedInUltimateParentField()
        {
            Objects.poCompanyHierarchies_Page.verifyUltimateParent(Objects.poCompanyInformation_Page.verifyCompanyNameText);            
        }

        [Then(@"Current company name should be displayed in company text box")]
        public void ThenCurrentCompanyNameShouldBeDisplayedInCompanyTextBox()
        {
            Objects.poCompanyHierarchies_Page.verifyCompanyText(Objects.poCompanyInformation_Page.verifyCompanyNameText);
        }
        [Then(@"create new button should be disabled")]
        public void ThenCreateNewButtonShouldBeDisabled()
        {
            Objects.poCompanyHierarchies_Page.verifyStateOfCreateNewButton();
        }

        [Then(@"move button should be enabled")]
        public void ThenMoveButtonShouldBeEnabled()
        {
            Objects.poCompanyHierarchies_Page.verifyStateOfMoveButton();
        }

        [When(@"I click on move button")]
        public void WhenIClickOnMoveButton()
        {
            Objects.poCompanyHierarchies_Page.clickMove();
        }


        [Then(@"company search by hierarchy popup details should be displayed")]
        public void ThenCompanySearchByHierarchyPopupDetailsShouldBeDisplayed()
        {
            Objects.poCompanyHierarchies_Page.verifyCompanySearchByHierarchyDetails();
        }


    }
}
