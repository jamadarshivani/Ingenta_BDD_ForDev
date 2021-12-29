using Ingenta.Framework.Utils;
using System;
using TechTalk.SpecFlow;

namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class DocumentsSteps
    {
        [Then(@"Documents tab details should be displayed")]
        public void ThenDocumentsTabDetailsShouldBeDisplayed()
        {
            Objects.poContactDocuments_Page.verifyDocumentsButtonFunctionality();
        }

        [When(@"I update the document details")]
        public void WhenIUpdateTheDocumentDetails()
        {
            Objects.poContactDocuments_Page.updateDocumentDetails();
        }

        [Then(@"Documents details should be updated")]
        public void ThenDocumentsDetailsShouldBeUpdated()
        {
            Objects.poContactDocuments_Page.verifyDocumentDetailsAreUpdated();
        }


    }
}
