using System;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Company_RelationshipsSteps
    {
        [When(@"I click new relationship button")]
        public void WhenIClickNewRelationshipButton()
        {
            Objects.poCompanyRelationship_Page.clickNewRelationshipButton();
        }
        
        [Then(@"all the elements of the new relationship tab should be visible")]
        public void ThenAllTheElementsOfTheNewRelationshipTabShouldBeVisible()
        {
            Objects.poCompanyRelationship_Page.verifyNewRelationshipButtonFunctionality();
        }

        [When(@"I select relationship type as linked")]
        public void WhenISelectRelationshipTypeAsLinked()
        {
            Objects.poCompanyRelationship_Page.clickLinkedRelationshipRB();
        }

        [When(@"I enter the details for the linked relationship")]
        public void WhenIEnterTheDetailsForTheLinkedRelationship()
        {
            Objects.poCompanyRelationship_Page.enterDetailsforLinkedRelationship();
        }

        [When(@"I select relationship type as owner")]
        public void WhenISelectRelationshipTypeAsOwner()
        {
            Objects.poCompanyRelationship_Page.clickAllRelationshipRB();
        }

        [When(@"I save the created relationship")]
        public void WhenISaveTheCreatedRelationship()
        {
            Objects.poCompanyHistory_Page.ClickSave();
        }

        [Then(@"the created linked relationship should be succesfully visible")]
        public void ThenTheCreatedLinkedRelationshipShouldBeSuccesfullyVisible()
        {
            Objects.poCompanyRelationship_Page.verifyCreatedLinkedRelationship();
        }

        [When(@"I enter the details for the owner relationship")]
        public void WhenIEnterTheDetailsForTheOwnerRelationship()
        {
            Objects.poCompanyRelationship_Page.enterDetailsforOwnerRelationship();
        }

        [Then(@"the created owner relationship should be succesfully visible")]
        public void ThenTheCreatedOwnerRelationshipShouldBeSuccesfullyVisible()
        {
            Objects.poCompanyRelationship_Page.verifyCreatedOwnerRelationship("Company");
        }

        [Then(@"the start date of existing relationships should be greater than or equal to the present date should be visible")]
        public void ThenTheStartDateOfExistingRelationshipsShouldBeGreaterThanOrEqualToThePresentDateShouldBeVisible()
        {
            Objects.poCompanyRelationship_Page.verifyingCurrentAndFutureRadioButtonFunctionality();
        }
       
        [When(@"I select all radio button")]
        public void WhenISelectAllRadioButton()
        {
            Objects.poCompanyRelationship_Page.clickAllRadioButton();
        }

        [Then(@"all the existing relationships should be visible")]
        public void ThenAllTheExistingRelationshipsShouldBeVisible()
        {
            Objects.poCompanyRelationship_Page.verifyingAllRadioButtonFunctionality();
        }

        [When(@"I click on edit this relationship button")]
        public void WhenIClickOnEditThisRelationshipButton()
        {
            Objects.poCompanyRelationship_Page.clickViewThisRelationshipButton();
        }

        [Then(@"all the elements the created relationship should be visible")]
        public void ThenAllTheElementsTheCreatedRelationshipShouldBeVisible()
        {
            Objects.poCompanyRelationship_Page.verifyEditRelationButtonFunctionality();
        }

        [When(@"I click sales assignment button")]
        public void WhenIClickSalesAssignmentButton()
        {
            Objects.poCompanyRelationship_Page.navigateToSalesAssignment();
        }

        [Then(@"details of the sales assignment should be displayed successfully under relationship")]
        public void ThenDetailsOfTheSalesAssignmentShouldBeDisplayedSuccessfullyUnderRelationship()
        {
            Objects.poCompanyRelationship_Page.verifySalesAssignmentDetails();
        }


        [When(@"I navigate to relationship tab")]
        public void WhenINavigateToRelationshipTab()
        {
            Objects.companyRelationship_Page.navigateToRelationshipTab("Company");
        }

        [Then(@"Company relationship tab details should be displayed")]
        public void ThenCompanyRelationshipTabDetailsShouldBeDisplayed()
        {
            Objects.companyRelationship_Page.verifyCompanyRelationshipTabDetails();
        }

        [When(@"I navigate to relationship tab from contact")]
        public void WhenINavigateToRelationshipTabFromContact()
        {
            Objects.companyRelationship_Page.navigateToRelationshipTab("Contact");
        }

        [When(@"I create new owner relationship")]
        public void WhenICreateNewOwnerRelationship()
        {            
            Objects.companyRelationship_Page.clickNewRelationshipButton();
            Objects.companyRelationship_Page.enterDetailsforOwnerRelationship();
            Objects.poCompanyHistory_Page.ClickSave();
        }

        [When(@"I create new linked relationship")]
        public void WhenICreateNewLinkedRelationship()
        {
            Objects.companyRelationship_Page.clickNewRelationshipButton();
            Objects.companyRelationship_Page.clickLinkedRelationshipRB();
            Objects.companyRelationship_Page.enterDetailsforLinkedRelationship();
            Objects.poCompanyHistory_Page.ClickSave();
        }

        [Then(@"Created Linked relationship should be displayed")]
        public void ThenCreatedLinkedRelationshipShouldBeDisplayed()
        {
            Objects.companyRelationship_Page.verifyCreatedLinkedRelationship();
        }

        [Then(@"Created owner relationship should be displayed")]
        public void ThenCreatedOwnerRelationshipShouldBeDisplayed()
        {
            Objects.companyRelationship_Page.verifyCreatedOwnerRelationship("Company");
        }

        [Then(@"Created contact owner relationship should be displayed")]
        public void ThenCreatedContactOwnerRelationshipShouldBeDisplayed()
        {
            Objects.companyRelationship_Page.verifyCreatedOwnerRelationship("Contact");
        }

        [Then(@"Only those relationships should be displayed which have start date in past but end date is a future date")]
        public void ThenOnlyThoseRelationshipsShouldBeDisplayedWhichHaveStartDateInPastButEndDateIsAFutureDate()
        {
            Objects.companyRelationship_Page.verifyingCurrentAndFutureRadioButtonFunctionality();
        }
        

        [Then(@"all the existing relationships should be displayed")]
        public void ThenAllTheExistingRelationshipsShouldBeDisplayed()
        {
            Objects.companyRelationship_Page.verifyingAllRadioButtonFunctionality();
        }        

        [When(@"I navigate to Sales Assignnment tab from relationship")]
        public void WhenINavigateToSalesAssignnmentTabFromRelationship()
        {
            Objects.poCompanySalesAssignment_Page.navigateToSalesAssignmentsTab("Relationship");
        }

        [When(@"I Select Sales Assignment to be deleted")]
        public void WhenISelectSalesAssignmentToBeDeleted()
        {
            Objects.companyRelationship_Page.selectSalesAssignment();
        }


        [When(@"I create future sales assignment")]
        public void WhenICreateFutureSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.deleteSalesAssignmentBeforeCreatingContactRelationShip();

            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsCurrentFuture("Current");
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();

            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsCurrentFuture("Future");
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();
        }


        [When(@"I Delete Sales Assignment")]
        public void WhenIDeleteSalesAssignment()
        {
            Objects.companyRelationship_Page.deleteSalesAssignment();
        }

        [Then(@"Selected Sales assignment should be deleted")]
        public void ThenSelectedSalesAssignmentShouldBeDeleted()
        {
            Objects.companyRelationship_Page.verifyAssignmentIsDeleted();
        }


        [When(@"I edit Sales Assignment")]
        public void WhenIEditSalesAssignment()
        {
            Objects.companyRelationship_Page.editAssignment();
        }


        [Then(@"Selected Sales assignment should be displayed")]
        public void ThenSelectedSalesAssignmentShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifyEditAssignmentButtonFunctionality();
        }


        [When(@"I select all radio button in Sales Assignemnts")]
        public void WhenISelectAllRadioButtonInSalesAssignemnts()
        {
            Objects.poCompanySalesAssignment_Page.selectAllAssignments();
        }

        [When(@"I select current radio button in Sales Assignemnts")]
        public void WhenISelectCurrentRadioButtonInSalesAssignemnts()
        {
            Objects.poCompanySalesAssignment_Page.selectCurrentSalesAssignmentRadioButton();
        }


        [When(@"I create new sales assignment")]
        public void WhenICreateNewSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.deleteSalesAssignmentBeforeCreatingContactRelationShip();
            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsCurrentFuture("Current");
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();
        }

        [When(@"I create current and past sales assignment")]
        public void WhenICreateCurrentAndPastSalesAssignment()
        {
            Objects.poCompanySalesAssignment_Page.deleteSalesAssignmentBeforeCreatingContactRelationShip();

            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsCurrentFuture("Past");
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();

            Objects.poCompanySalesAssignment_Page.clickNewSalesAssignmentButton();
            Objects.poCompanySalesAssignment_Page.enterSalesAssignmentDetailsCurrentFuture("Current");
            Objects.poCompanySalesAssignment_Page.saveSalesAssignmentDetails();
            Objects.poCompanySalesAssignment_Page.closeAssignmentDetailsWindow();
        }

        [Then(@"Sales assignment details should be displayed")]
        public void ThenSalesAssignmentDetailsShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesAssignmentDetails();
        }


        [Then(@"Only current and future assignments for the selected media should be displayed in the grid\.")]
        public void ThenOnlyCurrentAndFutureAssignmentsForTheSelectedMediaWillBeDisplayedInTheGrid_()
        {
            Objects.companyRelationship_Page.verifyingCurrentRadioButtonFunctionalitySalesAssignments();
        }



    }
}
