using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_UserFormsSteps
    {
        [When(@"I navigate to Electronics Classification tab")]
        public void WhenINavigateToElectronicsClassificationTab()
        {
            Objects.poCompanyUserForms_Page.navigateToElectronicsClassification();
        }

        [When(@"I navigate to Price UserForm tab")]
        public void NavigateToPriceUserForm()
        {
            Objects.poCompanyUserForms_Page.navigateToPriceUserForm();
        }


        [Then(@"Company Electronics Classification tab details should be displayed")]
        public void ThenCompanyElectronicsClassificationTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanyUserForms_Page.verifyElectronicsClassificationTab("Electronic");
        }

        [Then(@"Price User Form tab details should be displayed")]
        public void ThenPriceUserFormsTabDetails()
        {
            Objects.poCompanyUserForms_Page.verifyElectronicsClassificationTab("Price");
        }

        [When(@"I create Electronics Classification")]
        public void WhenIEnterTheDetailsForTheElectronicsClassification()
        {
            Objects.poCompanyUserForms_Page.enterElectronicClassificationDetails();
            Objects.poCompanyUserForms_Page.clickSaveButton();
        }

        [Then(@"the details for electronics classification should be saved successfully")]
        public void ThenTheDetailsForElectronicsClassificationShouldBeSavedSuccessfully()
        {
            Objects.poCompanyUserForms_Page.verifyElectronicClassificationDetails();
        }

        [When(@"I enter additional telephone details")]
        public void WhenIEnterAdditionalTelephoneDetails()
        {
            Objects.poCompanyUserForms_Page.enterAdditionalTelephoneDetails();
        }

        [When(@"I reset the details for the electronics classification")]
        public void WhenIResetTheDetailsForTheElectronicsClassification()
        {
            Objects.poCompanyUserForms_Page.clickResetButton();
        }

        [When(@"I delete the electronics classification details")]
        public void WhenIDeleteTheElectronicsClassificationDetails()
        {
            Objects.poCompanyUserForms_Page.clickDeleteButton();
        }

        [Then(@"the saved details for the electronics classification should be cleared successfully")]
        public void ThenTheSavedDetailsForTheElectronicsClassificationShouldBeClearedSuccessfully()
        {
            Objects.poCompanyUserForms_Page.verifyDetailsAreCleared();
        }




    }
}
