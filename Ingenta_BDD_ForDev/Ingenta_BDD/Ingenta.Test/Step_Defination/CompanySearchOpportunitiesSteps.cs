using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test
{
    [Binding]
    public class CompanySearchOpportunitiesSteps
    {
        [When(@"I navigate to Opportunities tab")]
        public void WhenINavigateToOpportunitiesTab()
        {
            Objects.companyOpportunities_Page.navigateToOpportunitiesTab("Company");
        }
        
        [Then(@"Opportunities tab details should be displayed")]
        public void ThenCompanyOpportunitiesTabDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyOpportunitiesTabDetails();
        }

        [When(@"I navigate to opportunites tab from contact")]
        public void WhenINavigateToOpportunitesTabFromContact()
        {
            Objects.companyOpportunities_Page.navigateToOpportunitiesTab("Contact");
        }

        [When(@"I click on new opportunities")]
        public void WhenIClickOnNewOpportunities()
        {
            Objects.companyOpportunities_Page.clickNewOpportunitiesButton();
        }

        [Then(@"Opportunity details should be displayed")]
        public void ThenOpportunityDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewOpportunityButtonFunctionality();
        }


        [When(@"I Create new Opportunity")]
        public void WhenICreateNewOpportunity()
        {
            Objects.companyOpportunities_Page.clickNewOpportunitiesButton();
            Objects.companyOpportunities_Page.enterOpportunityInformation();
            Objects.companyOpportunities_Page.clickSaveButton();
        }

        [Then(@"Created opportunity should be displayed")]
        public void ThenCreatedOpportunityShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyDetailsAreSavedSucessfully();
        }

        [When(@"I navigate to Relations tab")]
        public void WhenINavigateToRelationsTab()
        {
            Objects.companyOpportunities_Page.navigateToRelationsTab();
        }

        [Then(@"Relations tab details should be displayed")]
        public void ThenRelationsTabDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyRelationsTab();
        }

        [Then(@"Competitor tab details should be displayed")]
        public void ThenCompetitorTabDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyCompetitorTab();
        }

        [When(@"I Click on new competitor button")]
        public void WhenIClickOnNewCompetitorButton()
        {
            Objects.companyOpportunities_Page.clickNewCompetitorButton();
        }

        [Then(@"New Competitor details should be displayed")]
        public void ThenNewCompetitorDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewOpportunityWindow();
        }

        [When(@"I create new competitor")]
        public void WhenICreateNewCompetitor()
        {
            Objects.companyOpportunities_Page.deleteAllCompetitors();
            Objects.companyOpportunities_Page.clickNewCompetitorButton();
            Objects.companyOpportunities_Page.enterNewCompetitorDetails("New");
            Objects.companyOpportunities_Page.saveDetailsInNewWindow();
        }

        [Then(@"New competitor should be displayed")]
        public void ThenNewCompetitorShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewCompetitorDetails(); 
        }

        [When(@"I edit competitor")]
        public void WhenIEditCompetitor()
        {
            Objects.companyOpportunities_Page.editCompetitor();
        }

        [Then(@"competitor details should be displayed")]
        public void ThenCompetitorDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyCompetitorDetails();
        }

        [When(@"I click on cancel button")]
        public void WhenIClickOnCancelButton()
        {
            Objects.companyOpportunities_Page.clickCancelCompetitor();
        }

        [Then(@"competitor window should be closed")]
        public void ThenCompetitorWindowShouldBeClosed()
        {
            Objects.companyOpportunities_Page.verifyCompetitorWindowIsClosed();
        }

        [When(@"I create new competitor\tto be deleted")]
        public void WhenICreateNewCompetitorToBeDeleted()
        {
            Objects.companyOpportunities_Page.clickNewCompetitorButton();
            Objects.companyOpportunities_Page.enterNewCompetitorDetails("ToBeDeleted");
            Objects.companyOpportunities_Page.saveDetailsInNewWindow();
        }                
        
        [Then(@"Reponsibility tab details should be displayed")]
        public void ThenReponsibilityTabDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyResponsibilityTab();
        }

        [When(@"I Click on new reponsibility button")]
        public void WhenIClickOnNewReponsibilityButton()
        {
            Objects.companyOpportunities_Page.clickNewResponsibilityButton();
        }

        [Then(@"New Reponsibility details should be displayed")]
        public void ThenNewReponsibilityDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewResponsibilityWindow();
        }

        [When(@"I create new responsibility")]
        public void WhenICreateNewResponsibility()
        {
            Objects.companyOpportunities_Page.clickNewResponsibilityButton();
            Objects.companyOpportunities_Page.enterResponsibilityDetails("New");
            Objects.companyOpportunities_Page.saveNewResponsibility();
        }

        [Then(@"New responsibility should be displayed")]
        public void ThenNewResponsibilityShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyResponsibilityDetails();
        }


        [When(@"I create new reponsibility to be deleted")]
        public void WhenICreateNewReponsibilityToBeDeleted()
        {
            Objects.companyOpportunities_Page.clickNewResponsibilityButton();
            Objects.companyOpportunities_Page.enterResponsibilityDetails("Delete");
            Objects.companyOpportunities_Page.saveNewResponsibility();
        }  

        [Then(@"Media tab details should be displayed")]
        public void ThenMediaTabDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyMediaTab();
        }

        [When(@"I Click on new media button")]
        public void WhenIClickOnNewMediaButton()
        {
            Objects.companyOpportunities_Page.clickNewMediaButton();
        }

        [Then(@"New Media details should be displayed")]
        public void ThenNewMediaDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewMediaButtonFunctionality();
        }

        [When(@"I create new media")]
        public void WhenICreateNewMedia()
        {
            Objects.companyOpportunities_Page.deleteAllCreatedMedias();
            Objects.companyOpportunities_Page.clickNewMediaButton();
            Objects.companyOpportunities_Page.enterMediaDetails("New");
            Objects.companyOpportunities_Page.saveDetailsInNewWindow();
        }

        [Then(@"New media should be displayed")]
        public void ThenNewMediaShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyMediaDetails();
        }

        [When(@"I create new media to be deleted")]
        public void WhenICreateNewMediaToBeDeleted()
        {
            Objects.companyOpportunities_Page.clickNewMediaButton();
            Objects.companyOpportunities_Page.enterMediaDetails("Delete");
            Objects.companyOpportunities_Page.saveDetailsInNewWindow();
        }

        [When(@"I click new booking button in insertions")]
        public void WhenIClickNewBookingButtonInInsertions()
        {
            Objects.companyOpportunities_Page.clickNewBookingButton();
        }
        [Then(@"the new booking pop-up window details should be displayed")]
        public void ThenTheNewBookingPop_UpWindowDetailsShouldBeDisplayed()
        {
            Objects.companyOpportunities_Page.verifyNewBookingPopUp();
        }
    }
}
