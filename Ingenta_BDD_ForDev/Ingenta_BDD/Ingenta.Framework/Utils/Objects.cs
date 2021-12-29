using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ingenta.Framework.Pages;

namespace Ingenta.Framework.Utils
{
    public class Objects
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public Objects(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public static Login_Page poLogin { get; set; }
        public static Dashboard_Page poDashboard { get; set; }
        public static CompanySearch_Page poCompanySearch { get; set; }
        public static CompanyResult_Page poCompanyResult { get; set; }
        public static MyBooking_Page poMyBooking { get; set; }
        public static NewBooking_Page poNewBooking { get; set; }
        public static AddTypeWeb_Page poAddTypeWeb { get; set; }
        public static BookingDetails_Page poBookingDetails { get; set; }
        public static InventoryDisplay_Page poInventoryDisplay { get; set; }
        public static Cart_Page poCartPage { get; set; }
        public static Customer_Page poCustomer { get; set; }
        public static InventoryEvent_Page poInventoryEvent { get; set; }
        public static InventoryRelease_Page poInventoryRelease { get; set; }
        public static CompanyInformation_Page poCompanyInformation_Page { get; set; }
        public static CompanyHierarchies_Page poCompanyHierarchies_Page { get; set; }
        public static CompanyContacts_Page poCompanyContacts_Page { get; set; }
        public static CompanyFinance_Page poCompanyFinance_Page { get; set; }
        public static CompanyHistory_Page poCompanyHistory_Page { get; set; }        
        public static Contacts_LandingPage po_ContactsLandingPage { get; set; }
        public static Contacts_SearchContact searchContact { get; set; }
        public static CompanyBrands_Page companyBrands_Page { get; set; }
        public static CompanyRelationship_Page companyRelationship_Page { get; set; }
        public static CompanyNotes_Page companyNotes_Page { get; set; }
        public static CompanyExternalReferences_Page companyExternalReferences_Page { get; set; }
        public static CompanyOpportunities_Page companyOpportunities_Page { get; set; }
        public static CompanyResponsibilities_Page companyResponsibilities_Page { get; set; }        
        public static CompanyTerritories_Page companyTerritories_Page { get; set; }
        public static CompanyAdTemplates_Page companyAdTemplates_Page { get; set; }
        public static CompanyUserForms_Page companyUserForms { get; set; }


        //Neerav Code

        public static SelectedContact_Page poSelectedContact_Page { get; set; }

        public static CompanyResult_Page poCompanyResult_Page { get; set; }

        public static CompanySearch_Page poCompanySearch_Page { get; set; }

        public static CompanyBrands_Page poCompanyBrands_Page { get; set; }

        public static CompanyRelationship_Page poCompanyRelationship_Page { get; set; }

        public static CompanySalesAssignment_Page poCompanySalesAssignment_Page { get; set; }

        public static CompanyNotes_Page poCompanyNotes_Page { get; set; }

        public static CompanyAttachment_Page poCompanyAttachment_Page { get; set; }

        public static CompanyOpportunities_Page poCompanyOpportunities_Page { get; set; }

        public static CompanyResponsibilities_Page poCompanyResponsibilities_Page { get; set; }

        public static CompanyTerritories_Page poCompanyTerritories_Page { get; set; }

        public static CompanyAdTemplates_Page poCompanyAdTemplates_Page { get; set; }

        public static CompanyUserForms_Page poCompanyUserForms_Page { get; set; }

        public static CompanyHistoryNewTab_Page poCompanyHistoryNewTab_Page { get; set; }

        public static CompanyNewTabFollowUpCalls_Page poCompanyNewTabFollowUpCalls_Page { get; set; }

        public static CompanyHistoryNewTab_AttachementWindow poCompanyHistoryNewTab_AttachmentWindow { get; set; }

        public static CompanyExternalReferences_Page poCompanyExternalReferences_Page { get; set; }

        public static ContactInformation_Page poContactInformation_Page { get; set; }

        public static ContactDocuments_Page poContactDocuments_Page { get; set; }

        public static ContactWebUser_Page poContactWebUser_Page { get; set; }

        public static ContactCampaign_Page poContactCampaign_Page { get; set; }

        public static ContactHeaderSection_Page poContactHeaderSection_Page { get; set; }

        public static ContactSearch_Header poContactSearch_Header { get; set; }

        //Neerav Code

        public void ObjectInitialisation()
        {
            poLogin = new Login_Page(driver, wait);
            poDashboard = new Dashboard_Page(driver, wait);
            poCompanySearch = new CompanySearch_Page(driver, wait);
            poCompanyResult = new CompanyResult_Page(driver, wait);
            poMyBooking = new MyBooking_Page(driver, wait);
            poNewBooking = new NewBooking_Page(driver, wait);
            poAddTypeWeb = new AddTypeWeb_Page(driver, wait);
            poBookingDetails = new BookingDetails_Page(driver, wait);
            poInventoryDisplay = new InventoryDisplay_Page(driver, wait);
            poCartPage = new Cart_Page(driver, wait);
            poCustomer = new Customer_Page(driver, wait);
            poInventoryEvent = new InventoryEvent_Page(driver, wait);
            poInventoryRelease = new InventoryRelease_Page(driver, wait);
            poCompanyInformation_Page = new CompanyInformation_Page(driver, wait);
            poCompanyHierarchies_Page = new CompanyHierarchies_Page(driver, wait);
            poCompanyContacts_Page = new CompanyContacts_Page(driver, wait);
            poCompanyFinance_Page = new CompanyFinance_Page(driver, wait);
            poCompanyHistory_Page = new CompanyHistory_Page(driver, wait);
            po_ContactsLandingPage = new Contacts_LandingPage(driver, wait);
            searchContact = new Contacts_SearchContact(driver, wait);
            companyBrands_Page = new CompanyBrands_Page(driver, wait);
            companyRelationship_Page = new CompanyRelationship_Page(driver, wait);
            companyNotes_Page = new CompanyNotes_Page(driver, wait);
            companyExternalReferences_Page = new CompanyExternalReferences_Page(driver, wait);
            companyOpportunities_Page = new CompanyOpportunities_Page(driver, wait);
            companyResponsibilities_Page = new CompanyResponsibilities_Page(driver, wait);            
            companyTerritories_Page = new CompanyTerritories_Page(driver, wait);
            companyAdTemplates_Page = new Pages.CompanyAdTemplates_Page(driver, wait);
            companyUserForms = new CompanyUserForms_Page(driver, wait);
            poCompanySearch_Page = new CompanySearch_Page(driver, wait);
            poCompanyBrands_Page = new CompanyBrands_Page(driver, wait);
            poCompanyRelationship_Page = new CompanyRelationship_Page(driver, wait);
            poCompanySalesAssignment_Page = new CompanySalesAssignment_Page(driver, wait);
            poCompanyNotes_Page = new CompanyNotes_Page(driver, wait);
            poCompanyAttachment_Page = new CompanyAttachment_Page(driver, wait);
            poCompanyOpportunities_Page = new CompanyOpportunities_Page(driver, wait);
            poCompanyResponsibilities_Page = new CompanyResponsibilities_Page(driver, wait);
            poCompanyTerritories_Page = new CompanyTerritories_Page(driver, wait);
            poCompanyAdTemplates_Page = new CompanyAdTemplates_Page(driver, wait);
            poCompanyUserForms_Page = new CompanyUserForms_Page(driver, wait);
            poCompanyHistoryNewTab_Page = new CompanyHistoryNewTab_Page(driver, wait);
            poCompanyNewTabFollowUpCalls_Page = new CompanyNewTabFollowUpCalls_Page(driver, wait);
            poCompanyHistoryNewTab_AttachmentWindow = new CompanyHistoryNewTab_AttachementWindow(driver, wait);
            poCompanyExternalReferences_Page = new CompanyExternalReferences_Page(driver, wait);
            poContactInformation_Page = new ContactInformation_Page(driver, wait);
            poContactDocuments_Page = new ContactDocuments_Page(driver, wait);
            poContactWebUser_Page = new ContactWebUser_Page(driver, wait);
            poContactCampaign_Page = new ContactCampaign_Page(driver, wait);
            poContactSearch_Header = new ContactSearch_Header(driver, wait);
            poCompanyResult_Page = new CompanyResult_Page(driver,wait);
        }

    }
}
