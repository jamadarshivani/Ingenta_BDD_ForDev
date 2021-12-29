using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class Companies_ExternalReferencesSteps
    {   
        [Then(@"External Reference details should be displayed")]
        public void ThenAllTheElementsShouldBeDisplayed()
        {
            Objects.poCompanyExternalReferences_Page.verifyExternalRefButton();
        }
    }
}
