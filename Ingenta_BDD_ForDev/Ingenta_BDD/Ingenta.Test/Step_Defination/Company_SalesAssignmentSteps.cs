using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_SalesAssignmentSteps
    {
        [When(@"I navigate to Sales Assignnment tab")]
        public void WhenINavigateToSalesAssignnmentTab()
        {
            Objects.poCompanySalesAssignment_Page.navigateToSalesAssignnment();
        }
        
        [Then(@"Company Sales Assignnment tab details should be displayed")]
        public void ThenCompanySalesAssignnmentTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesAssignmentButtonFunctionality();            
        }

        [Then(@"Contact Sales Assignnment tab details should be displayed")]
        public void ContactSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.verifyOpportunitiesSalesAssignmentViaContact();
        }

        [When(@"I navigate to new Sales Assignment Window")]
        public void WhenINavigateToNewSalesAssignmentWindow()
        {
            Objects.poCompanySalesAssignment_Page.deleteAllSalesAssignmentsBeforeCreatingNew();
            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
        }

        [When(@"I enter the details of the new Sales Assignment to be verified")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentToBeVerified()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsToBeVerified();
        }


        [When(@"I navigate to new Sales Assignment Window again")]
        public void WhenINavigateToNewSalesAssignmentWindowAgain()
        {
            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
        }


        [Then(@"all the details of the new sales assignment window should be displayed")]
        public void ThenAllTheDetailsOfTheNewSalesAssignmentWindowShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifyNewSalesAssignmentButton();
        }

        [When(@"I enter the details of the new Sales Assignment")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetails("New");
        }

        [When(@"I enter the details of the new Sales Assignment to be deleted")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentToBeDeleted()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetails("Delete");
        }

        [When(@"I select the sales assignment as all")]
        public void WhenISelectTheSalesAssignmentAsAll()
        {
            Objects.poCompanySalesAssignment_Page.selectAllRadioButton();
        }

        [When(@"I select the sales assignment as current")]
        public void WhenISelectTheSalesAssignmentAsCurrent()
        {
            Objects.poCompanySalesAssignment_Page.selectCurrentRadioButton();
        }


        [When(@"I save the details of the Sales Assignment")]
        public void WhenISaveTheDetailsOfTheSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
        }

        [Then(@"details of the sales assignment should be displayed successfully")]
        public void ThenDetailsOfTheSalesAssignmentShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesAssignmentDetails();
        }

        [Then(@"the assignment already exists pop-up should be displayed")]
        public void ThenTheAssignmentAlreadyExistsPop_UpShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifyAssignmentExistsErrorMessage();
        }

        [When(@"I navigate to new Sales Assignment Window after saving the details")]
        public void WhenINavigateToNewSalesAssignmentWindowAfterSavingTheDetails()
        {
            Objects.poCompanySalesAssignment_Page.newSalesAssignmentWindow();
        }

        [Then(@"Only current and future assignments for the selected media will be displayed in the grid\.")]
        public void ThenOnlyCurrentAndFutureAssignmentsForTheSelectedMediaWillBeDisplayedInTheGrid_()
        {
            Objects.poCompanySalesAssignment_Page.verifyingCurrentRadioButtonFunctionalitySalesAssignments();
        }

        [Then(@"All the assignments for the selected media should be displayed in the grid\.")]
        public void ThenAllTheAssignmentsForTheSelectedMediaShouldBeDisplayedInTheGrid_()
        {
            Objects.poCompanySalesAssignment_Page.verifyingAllRadioButtonFunctionalitySalesAssignments();
        }


        [When(@"I close the sales assignment window")]
        public void WhenICloseTheSalesAssignmentWindow()
        {
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();
        }

        [When(@"I enter the details of the new Sales Assignment with different media group")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentWithDifferentMediaGroup()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsWithDiffMediaGroup();
        }


        [Then(@"details of both the sales assignment should be displayed successfully")]
        public void ThenDetailsOfBothTheSalesAssignmentShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.verifySecondSalesAssignment();
        }


        [When(@"I enter the details of the new Sales Assignment along with Media details")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentAlongWithMediaDetails()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsWithMedia();
        }

        [Then(@"details of the sales assignment and media should be displayed successfully")]
        public void ThenDetailsOfTheSalesAssignmentAndMediaShouldBeDisplayedSuccessfully()
        {
            Objects.poCompanySalesAssignment_Page.verifyAssignmentDetailsWithMedia();
        }

        [When(@"I save and close the details of the Sales Assignment")]
        public void WhenISaveAndCloseTheDetailsOfTheSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.clickSaveAndCloseButton();
        }

        [When(@"I enter the details of the new Sales Assignment along with Media details with different sales person")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentAlongWithMediaDetailsWithDifferentSalesPerson()
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsWithDifferentUser();
        }

        [Then(@"details of the sales assignment and media should be displayed successfully with updated sales person")]
        public void ThenDetailsOfTheSalesAssignmentAndMediaShouldBeDisplayedSuccessfullyWithUpdatedSalesPerson()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesPersonIsChanged();
        }

        [When(@"I edit the selected sales assignment")]
        public void WhenIEditTheSelectedSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.clickEditSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.editSalesAssignment();
        }

        [Then(@"the updates to sales assignment should saved successfully")]
        public void ThenTheUpdatesToSalesAssignmentShouldSavedSuccessfully()
        {
            Objects.poCompanySalesAssignment_Page.verifyUpdatedSalesAssignment();
        }

        [When(@"I select the created sales assignment")]
        public void WhenISelectTheCreatedSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.selectSalesAssignment();
        }

        [Then(@"the sales assignment should be deleted successfully")]
        public void ThenTheSalesAssignmentShouldBeDeletedSuccessfully()
        {
            Objects.poCompanySalesAssignment_Page.verifyDeleteButtonFunctionality();
        }


        [When(@"I delete the selected sales assignment")]
        public void WhenIDeleteTheSelectedSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.deleteSalesAssignment();
        }

        [When(@"I enter the details of the new Sales Assignment with ""(.*)""")]
        public void WhenIEnterTheDetailsOfTheNewSalesAssignmentWith(string selectedDate)
        {
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsWithStartDate(selectedDate);
        }


    }
}
