using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class IngentaCompanyHistorySteps
    {
       
        [When(@"I enter the Information details")]
        public void WhenIEnterTheInformationDetails()
        {
            Objects.poCompanyInformation_Page.enterCompanyInformation();
        }

        [When(@"I click on New Task button")]
        public void WhenIClickOnNewTaskButton()
        {
            Objects.poCompanyHistory_Page.ClickNewTask();
        }

        [When(@"I enter history details")]
        public void WhenIEnterHistoryDetails()
        {
            Objects.poCompanyHistory_Page.enterHistoryDetails();
        }

    }
}
