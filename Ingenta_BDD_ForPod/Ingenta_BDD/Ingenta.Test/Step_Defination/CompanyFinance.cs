using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanyFinanceSteps
    {

        [When(@"I click on New button")]
        public void WhenIClickOnNewButton()
        {
            Objects.poCompanySearch.navigateToNewCompanyCreation();
        }

        [When(@"I click on Information tab")]
        public void WhenIClickOnInformationTab()
        {
            Objects.poCompanyFinance_Page.navigateToInformationTabInSales();
        }

        [When(@"I save and close information details")]
        public void WhenISaveAndCloseInformationDetails()
        {
            Objects.poCompanyFinance_Page.clickSaveAndCloseAfterSearcj();
        }

        [Then(@"Data will be saved and Contact Management screen should be displayed\.")]
        public void ThenDataWillBeSavedAndContactManagementScreenShouldBeDisplayed_()
        {
            Objects.poCompanySearch.verifyContactManagementScreen();
        }

        [Then(@"I close the information details")]
        public void ThenICloseTheInformationDetails()
        {
            Objects.poCompanyInformation_Page.ClickClose();
        }


        [When(@"I enter mandatory Information details")]
        public void WhenIEnterMandatoryInformationDetails()
        {
            Objects.poCompanyInformation_Page.enterMandartoryCompanyInformation();
        }


        [When(@"I navigate to Finance Tab")]
        public void WhenINavigateToFinanceTab()
        {
            Objects.poCompanyFinance_Page.navigateToFinanceTab();
        }

        //[When(@"I click on New Task button")]
        //public void WhenIClickOnNewTaskButton()
        //{
        //    //Objects.poCompanyFinance_Page.ClickNewTask();
        //}


        [When(@"I enter Finance details with tax registration no as ""(.*)""")]
        public void WhenIEnterFinanceDetailsWithTaxRegistrationNoAs(string taxRegNo)
        {
            Objects.poCompanyFinance_Page.enterFinanceDetails(taxRegNo);
        }



        [Then(@"Finance details should be saved")]
        public void ThenFinanceDetailsShouldBeSaved()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I navigate to Finance tab")]
        public void NavigateToFinanceTab()
        {
            Objects.poCompanyFinance_Page.navigateToFinanceTab();
        }

        [When(@"I navigate back to Finance tab")]
        public void WhenINavigateBackToFinanceTab()
        {
            Objects.poCompanyFinance_Page.navigateBackToFinanceTab();
        }


        [Then(@"Company Search Finance details should be displayed")]
        public void ThenCompanySearchFinanceDetailsShouldBeDisplayed()
        {
            Objects.poCompanyFinance_Page.verifyCompanySearchFinanceDetails();
        }


        [Then(@"Finance details should be displayed")]
        public void ThenFinanceDetailsShouldBeDisplayed()
        {
            Objects.poCompanyFinance_Page.verifyFinancePageDetails();
        }

        [Then(@"verfiy the finance details are saved with tax registration no as ""(.*)"" and New button is enabled")]
        public void ThenVerfiyTheFinanceDetailsAreSavedWithTaxRegistrationNoAsAndNewButtonIsEnabled(string txtRegNo)
        {
            Objects.poCompanyFinance_Page.verifyFinanceDetails(txtRegNo);
        }


        [When(@"I click on New button in finance details screen")]
        public void WhenIClickOnNewButtonInFinanceDetailsScreen()
        {
            Objects.poCompanyFinance_Page.ClickNew();
        }

        [Then(@"New window pop up should be opened with New Sales Account Details")]
        public void ThenNewWindowPopUpShouldBeOpenedWithNewSalesAccountDetails()
        {
            Objects.poCompanyFinance_Page.VerifyNewSalesAccountDetails();
        }


        [When(@"I enter sales account details ""(.*)""")]
        public void WhenIEnterSalesAccountDetails(string autoGenerateSalesAccCode)
        {
            Objects.poCompanyFinance_Page.enterSalesAccountDetails(autoGenerateSalesAccCode);
        }

        [When(@"I edit sales account details")]
        public void WhenIEditSalesAccountDetails()
        {
            Objects.poCompanyFinance_Page.editSalesAccountDetails();
        }


        //[When(@"I click on save and close button")]
        //public void WhenIClickOnSaveAndCloseButton()
        //{
        //    Objects.poCompanyFinance_Page.clickSaveAndClose();
        //}


        [When(@"I navigate to Address/Contact tab")]
        public void WhenINavigateToAddressContactTab()
        {
            Objects.poCompanyFinance_Page.navigateToAddress_Contact_Tab();
        }

        [When(@"I enter Address/Contact details")]
        public void WhenIEnterAddressContactDetails()
        {
            Objects.poCompanyFinance_Page.enterAddress_Contact_Details();
        }

        [Then(@"Address tab fields will be displayed")]
        public void ThenAddressTabFieldsWillBeDisplayed()
        {
            Objects.poCompanyFinance_Page.verifyAddressTabFields();
        }


        [When(@"I click on copy address button")]
        public void WhenIClickOnCopyAddressButton()
        {
            Objects.poCompanyFinance_Page.clickCopyAddress();
        }

        [Then(@"address will be copied which was entered in Company Information page")]
        public void ThenAddressWillBeCopiedWhichWasEnteredInCompanyInformationPage()
        {
            Objects.poCompanyFinance_Page.verifyCopiedAddress();
        }

        [When(@"I navigate to schedule tab")]
        public void WhenINavigateToScheduleTab()
        {
            Objects.poCompanyFinance_Page.navigateToSchedulesTab();
        }


        [When(@"I enter schedule details")]
        public void WhenIEnterScheduleDetails()
        {
            Objects.poCompanyFinance_Page.enterSchedulesDetails();
        }


        [When(@"I save the information details available in schedules tab")]
        public void WhenIClickOnSaveButtonAvailableInSchedulesTab()
        {
            Objects.poCompanyFinance_Page.ClickSave();
        }

        [Then(@"Details in all three tabs should be saved successfully ""(.*)""")]
        public void ThenDetailsInAllThreeTabsShouldBeSavedSuccessfully(string addressText)
        {
            Objects.poCompanyFinance_Page.verifyDetailsOfInfomationInSales();
            Objects.poCompanyFinance_Page.navigateToAddress_Contact_Tab();
            Objects.poCompanyFinance_Page.verifyDetailsOfAddressInSales(addressText);
            Objects.poCompanyFinance_Page.navigateToSchedulesTab();
            Objects.poCompanyFinance_Page.verifyDetailsSchedulesInSales();
        }


        [Then(@"Sales account code should be automatically generated")]
        public void ThenSalesAccountCodeShouldBeAutomaticallyGenerated()
        {
            Objects.poCompanyFinance_Page.verifySalesAccCodeAutoGenerated();
        }


        [When(@"I click on close button to close the Sales account popup")]
        public void WhenIClickOnCloseButtonToCloseTheSalesAccountPopup()
        {
            Objects.poCompanyFinance_Page.clickClose();
        }


        [When(@"I click on Sales account from the sales accounts grid")]
        public void WhenIClickOnSalesAccountFromTheSalesAccountsGrid()
        {
            Objects.poCompanyFinance_Page.selectSalesAccount();
        }

        [When(@"I click on first Sales account from the sales accounts grid")]
        public void WhenIClickOnFirstSalesAccountFromTheSalesAccountsGrid()
        {
            Objects.poCompanyFinance_Page.selectFirsSalesAccount();
        }

        [When(@"I delete all the sales accounts")]
        public void WhenIDeleteAllTheSalesAccounts()
        {
            Objects.poCompanyFinance_Page.deleteAllSalesAccounts();
        }



        [When(@"I click on edit button")]
        public void WhenIClickOnEditButton()
        {
            Objects.poCompanyFinance_Page.clickEdit();
        }

        [Then(@"the edited sales account should be saved successfully\.")]
        public void ThenTheEditedSalesAccountShouldBeSavedSuccessfully_()
        {
            Objects.poCompanyFinance_Page.verifyEditedSalesAccDetails();
        }

        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {
            Objects.poCompanyFinance_Page.clickDelete();
        }


        [Then(@"edit and delete button should be disabled")]
        public void ThenEditAndDeleteButtonShouldBeDisabled()
        {
            Objects.poCompanyFinance_Page.verifyEditAndDeleteButtonDisabled();
        }



    }
}
