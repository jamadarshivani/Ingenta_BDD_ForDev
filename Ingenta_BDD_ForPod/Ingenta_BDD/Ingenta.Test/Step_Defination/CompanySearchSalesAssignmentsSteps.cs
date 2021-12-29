using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test
{
    [Binding]
    public class CompanySearchSalesAssignmentsSteps
    {
        [When(@"I navigate to Sales Assignments tab")]
        public void WhenINavigateToSalesAssignmentsTab()
        {
            Objects.poCompanySalesAssignment_Page.navigateToSalesAssignmentsTab("Company");
        }
        
        [Then(@"Sales Assignments tab details should be displayed")]
        public void ThenCompanySalesAssignmentsTabDetailsShouldBeDisplayed()
        {
            Objects.poCompanySalesAssignment_Page.verifySalesAssignmentsTabDetails();
        }
    }
}
