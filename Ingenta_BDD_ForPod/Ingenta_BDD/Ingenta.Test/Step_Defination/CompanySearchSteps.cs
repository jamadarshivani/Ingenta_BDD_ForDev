using Ingenta.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace Ingenta.Test.Step_Defination
{
    [Binding]
    public class CompanySearchSteps
    {

        [When(@"I navigate to Company from dashboard")]
        public void WhenINavigateToCompanyFromDashboard()
        {
            Objects.poDashboard.navigateToCompany();
        }

        [When(@"I navigate to attachments tab")]
        public void WhenINavigateToAttachmentsTab()
        {
            Objects.poCompanySearch.navigateToAttachmentsTab();
        }


        [When(@"I search for ""(.*)"" companies")]
        public void WhenISearchForCompanies(string activeInactiveCompanies)
        {
            Objects.poCompanySearch.searchForCompany(activeInactiveCompanies, activeInactiveCompanies);
        }

        [Then(@"all the ""(.*)"" companies should be displayed in the result")]
        public void ThenAllTheCompaniesShouldBeDisplayedInTheResult(string activeInactiveCompanies)
        {
            Objects.poCompanySearch.verifySearchedCompany(activeInactiveCompanies, activeInactiveCompanies);
        }

        [When(@"I search for company ""(.*)"" by company type")]
        public void WhenISearchForCompanyByCompanyType(string companyType)
        {
            Objects.poCompanySearch.searchForCompany(companyType, "CompanyType");
        }

        [Then(@"all the companies having ""(.*)"" as company type should be displayed in the result")]
        public void ThenAllTheCompaniesHavingAsCompanyTypeShouldBeDisplayedInTheResult(string companyType)
        {
            Objects.poCompanySearch.verifySearchedCompany(companyType, "CompanyType");
        }


        [When(@"I search for company ""(.*)"" by country")]
        public void WhenISearchForCompanyByCountry(string countryName)
        {
            Objects.poCompanySearch.searchForCompany(countryName, "Country");
        }

        [Then(@"all the companies having ""(.*)"" as country should be displayed in the result")]
        public void ThenAllTheCompaniesHavingAsCountryShouldBeDisplayedInTheResult(string countryName)
        {
            Objects.poCompanySearch.verifySearchedCompany(countryName, "Country");
        }


        [When(@"I search for company ""(.*)"" by telephone number")]
        public void WhenISearchForCompanyByTelephoneNumber(string telephoneNumber)
        {
            Objects.poCompanySearch.searchForCompany(telephoneNumber, "TelephoneNumber");
        }

        [Then(@"all the companies having ""(.*)"" as telephone number should be displayed in the result")]
        public void ThenAllTheCompaniesHavingAsTelephoneNumberShouldBeDisplayedInTheResult(string telephoneNumber)
        {
            Objects.poCompanySearch.verifySearchedCompany(telephoneNumber, "TelephoneNumber");
        }


        [When(@"I search for company ""(.*)"" by postal code")]
        public void WhenISearchForCompanyByPostalCode(string postalCode)
        {
            Objects.poCompanySearch.searchForCompany(postalCode, "PostalCode");
        }


        [Then(@"all the companies having ""(.*)"" as postal code should be displayed in the result")]
        public void ThenAllTheCompaniesHavingAsPostalCodeShouldBeDisplayedInTheResult(string postalCode)
        {
            Objects.poCompanySearch.verifySearchedCompany(postalCode, "PostalCode");
        }


        [When(@"I search for company ""(.*)"" by last name")]
        public void WhenISearchForCompanyByLastName(string companyName)
        {
            //pending
        }

        [When(@"I search for company ""(.*)"" by town")]
        public void WhenISearchForCompanyByTown(string townName)
        {
            Objects.poCompanySearch.searchForCompany(townName, "Town");
        }

        [Then(@"all the companies having ""(.*)"" as town should be displayed in the result")]
        public void ThenAllTheCompaniesHavingAsTownShouldBeDisplayedInTheResult(string townName)
        {
            Objects.poCompanySearch.verifySearchedCompany(townName, "Town");
        }

        [Then(@"I navigate to company search record page")]
        public void ThenINavigateToCompanySearchRecordPage()
        {
            // Assert to be added here
        }

        [When(@"I search for company ""(.*)""")]
        public void WhenISearchForCompany(string companyName)
        {
            Objects.poCompanySearch.searchForCompany(companyName, "Company");
            //Objects.poCompanySearch.openCompanyRecord();
        }

        [When(@"I close the information details")]
        public void WhenICloseTheInformationDetails()
        {
            Objects.poCompanyInformation_Page.ClickClose();
        }

        [Then(@"Confirmation popup should be displayed")]
        public void ThenConfirmationPopupShouldBeDisplayed()
        {
            Objects.poCompanyInformation_Page.verifyConfirmationPopup();
        }


        [When(@"I dismiss confirmation popup")]
        public void WhenIDismissConfirmationPopup()
        {
            Objects.poCompanyInformation_Page.DismissPopUp();
        }


        [When(@"I Accept confirmation popup")]
        public void WhenIAcceptConfirmationPopup()
        {
            Objects.poCompanyInformation_Page.AcceptPopUp();
        }


        [When(@"I navigate to searched company")]
        public void WhenINavigateToSearchedCompany()
        {
            Objects.poCompanySearch.openCompanyRecord();
        }

        [When(@"I Click text in “Email” text box\.")]
        public void WhenIClickTextInEmailTextBox_()
        {
            Objects.poCompanyInformation_Page.clickTextInEmailTextBox();
        }


        [When(@"I verify email popup functionality")]
        public void WhenIVerifyEmailPopupFunctionality()
        {
            Objects.poCompanyInformation_Page.verifyEmailPopUpFunctionality();
            Objects.poCompanyInformation_Page.enterSubject();
            Objects.poCompanyInformation_Page.browseFile();

            Objects.poCompanyInformation_Page.verifyEmailPopUpFunctionality();
            Objects.poCompanyInformation_Page.enterMailBody();
            Objects.poCompanyInformation_Page.cutButtonFunctionality();
            Objects.poCompanyInformation_Page.pasteButtonFunctionality();
            Objects.poCompanyInformation_Page.copyPasteButtonFunctionality();
            Objects.poCompanyInformation_Page.printButtonFunctionality();
            //Commented below function as Spelling Check popup is not popping up
            Objects.poCompanyInformation_Page.spellCheckingButtonFunctionality();
            Objects.poCompanyInformation_Page.FontSizeFormatingFuncationality();
            Objects.poCompanyInformation_Page.JustifyFunctionality();
            Objects.poCompanyInformation_Page.IndentFunctionality();
            Objects.poCompanyInformation_Page.BoldItalicUnderlineFunctionality();
            Objects.poCompanyInformation_Page.InsertNewTableDetails();
            Objects.poCompanyInformation_Page.WordCountFunctionality();
            Objects.poCompanyFinance_Page.verifyInformationPage();
        }



        [When(@"I click on To button in Email Popup")]
        public void WhenIClickOnToButtonInEmailPopup()
        {
            Objects.poCompanyInformation_Page.clickToButton();
        }


        [Then(@"Email Address Book details popup should be displayed")]
        public void ThenEmailAddressBookDetailsPopupShouldBeDisplayed()
        {
            Objects.poCompanyInformation_Page.verifyEmailAddressBookDetails();
        }


        [Then(@"Email details popup should be displayed")]
        public void ThenEmailDetailsPopupShouldBeDisplayed()
        {
            Objects.poCompanyInformation_Page.verifyEmailPopupDetails();
        }



        [Then(@"all the companies starting with the text ""(.*)"" should be displayed in the result")]
        public void ThenAllTheCompaniesStartingWithTheTextShouldBeDisplayedInTheResult(string companyName)
        {
            Objects.poCompanySearch.verifySearchedCompany("Company", companyName);
        }


        [Then(@"Nothing should be displayed in the result")]
        public void ThenNothingShouldBeDisplayedInTheResult()
        {
            Objects.poCompanySearch.verifyNonExistingSearchedCompany();
        }


        [Then(@"""(.*)"" company should be displayed in the result")]
        public void ThenCompanyShouldBeDisplayedInTheResult(string companyName)
        {
            Objects.poCompanySearch.verifySearchedCompany("Company", companyName);
        }


        [Then(@"I Navigate to above search company record page")]
        public void ThenINavigateToAboveSearchCompanyRecordPage()
        {
            // Assert to be added here
        }

        [When(@"I select ""(.*)"" from contact tab")]
        public void WhenISelectFromContactTab(string p0)
        {
            Objects.poCompanyResult.navigateToContactTab();
            Objects.poCompanyResult.enterCompanyInformation();
            Objects.poCompanyResult.navigateToHistoryTab();
        }

        [When(@"Click on New booking from history tab")]
        public void WhenClickOnNewBookingFromHistoryTab()
        {
            Objects.poCompanyResult.clickNewBooking();
        }

        [Then(@"New booking windows gets open")]
        public void ThenNewBookingWindowsGetsOpen()
        {
            // Assert to be added here
        }

        [When(@"I select media ""(.*)""")]
        public void WhenISelectMedia(string mediaName)
        {
            Objects.poNewBooking.switchToNewBookingWindow();

            Objects.poNewBooking.selectMedia(mediaName);
        }

        [When(@"Fill up require details on add details tab")]
        public void WhenFillUpRequireDetailsOnAddDetailsTab()
        {
            Objects.poNewBooking.gotoAddDetails();

        }

        [When(@"Select next available issue from insertion tab")]
        public void WhenSelectNextAvailableIssueFromInsertionTab()
        {
            Objects.poNewBooking.gotoInsertionTab();

        }

        [When(@"Navigate through Material, Finance and Payment tabs with no action")]
        public void WhenNavigateThroughMaterialFinanceAndPaymentTabsWithNoAction()
        {
            Objects.poNewBooking.gotoMaterialtab();

            Objects.poNewBooking.gotoFinanceTab();

            Objects.poNewBooking.gotoPaymentTab();
        }

        [When(@"Click on Next buttton")]
        public void WhenClickOnNextButtton()
        {
            Objects.poNewBooking.clickNext();
        }

        [Then(@"I successfully arrive at Booking summary screen")]
        public void ThenISuccessfullyArriveAtBookingSummaryScreen()
        {
            // Assert to be added here 
        }

        [When(@"I update Booking refrence field with today's date")]
        public void WhenIUpdateBookingRefrenceFieldWithTodaySDate()
        {
            Objects.poMyBooking.updateBookingReference();

            Objects.poMyBooking.clickSaveAndClose();
        }

        [When(@"I search for the company")]
        public void WhenISearchForTheCompany()
        {
            Objects.poCompanySearch.companySearch();
        }

        [Then(@"search company page details should be displayed with run stationery button")]
        public void ThenSearchCompanyPageDetailsShouldBeDisplayedWithRunStationeryButton()
        {
            Objects.poCompanySearch.verifySearchPageElementsWithSearchResultButton();
        }

        [Then(@"Booking refrence gets updated successfully")]
        public void ThenBookingRefrenceGetsUpdatedSuccessfully()
        {
            // Assert to be added here  
        }

    }
}
