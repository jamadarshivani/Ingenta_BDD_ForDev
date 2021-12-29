using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class IngentaCompanyFinanceSteps
    {

        [When(@"I click on New company button")]
        public void WhenIClickOnNewButton()
        {
            Objects.poCompanySearch.navigateToNewCompanyCreation();
        }

        [When(@"I click new contact button")]
        public void WhenIClickNewContactButton()
        {
            Objects.poCompanySearch.navigateToNewCompanyCreation();
        }
        
        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            Objects.poCompanyFinance_Page.ClickSave();
        }

        [When(@"I navigate to Finance Tab")]
        public void WhenINavigateToFinanceTab()
        {
            Objects.poCompanyFinance_Page.navigateToFinanceTab();
        }

        [When(@"I enter Finance details")]
        public void WhenIEnterFinanceDetails()
        {
            Objects.poCompanyFinance_Page.enterFinanceDetails("Test");
        }

        [Then(@"Finance details should be saved")]
        public void ThenFinanceDetailsShouldBeSaved()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
