using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test
{
    [Binding]
    public class CompanySearchAdTemplatesSteps
    {
        [When(@"I navigate to Ad Templates tab")]
        public void WhenINavigateToAdTemplatesTab()
        {
            Objects.companyAdTemplates_Page.navigateToAdTemplatesTab();
        }
        
        [Then(@"Company Ad Templates tab details should be displayed")]
        public void ThenCompanyAdTemplatesTabDetailsShouldBeDisplayed()
        {
            Objects.companyAdTemplates_Page.verifyAdTemplatesTabDetails();
        }

        [When(@"I click on Ad Template new button")]
        public void WhenIClickOnAdTemplateNewButton()
        {
            Objects.companyAdTemplates_Page.clickNewTemplate();
        }

        [Then(@"all the elements should be displayed")]

        public void ThenAllTheElementsShouldBeDisplayed()
        {
            Objects.companyAdTemplates_Page.verifyNewTemplateDetails();
        }

    }
}
