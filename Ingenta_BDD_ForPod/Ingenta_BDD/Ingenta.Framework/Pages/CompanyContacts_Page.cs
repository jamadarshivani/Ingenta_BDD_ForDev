using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Companies Hierarchies Page")]
    public class CompanyContacts_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyContacts_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object Repository
        By btnNew = By.Id("FFCompanyContact_ibtnAddContact");
        By tabContacts = By.Id("iglbarMenu_0_Item_3");

        By btnActive = By.Id("btnPersonStatus");
        By btnCompany = By.Id("btnCompany");
        By txtName = By.Id("ucContactDetail_txtName");
        By pageHeading = By.Id("lblPageHeading");
        By buttonStationery = By.Id("btnStationery");

        By txtTitle = By.Id("ucContactDetail_txtHonorific");
        By txtInitials = By.Id("ucContactDetail_txtInitials");

        By txtFirstName = By.Id("ucContactDetail_txtFirstName");
        By txtLastName = By.Id("ucContactDetail_txtLastName");

        By txtTel = By.Id("ucContactDetail_txtTelephone");
        By chkTelPrivacy = By.Id("ucContactDetail_chkPrvTel");

        By txtFax = By.Id("ucContactDetail_txtFax");
        By chkFaxPrivacy = By.Id("ucContactDetail_chkPrvFax");

        By txtEmail = By.Id("ucContactDetail_txtEmail");
        By chkEmailReadReceipt = By.Id("ucContactDetail_chkReadReceipt");
        By chkEmailPrivacy = By.Id("ucContactDetail_chkPrvEml");

        By txtMobile = By.Id("ucContactDetail_txtMobile");
        By chkMobPrivacy = By.Id("ucContactDetail_chkPrvMob");

        By txtFacebook = By.Id("ucContactDetail_txtFaceBookURL");
        By txtTwitter = By.Id("ucContactDetail_txtTwitterURL");

        By txtLinkedIn = By.Id("ucContactDetail_txtLinkedInURL");
        By txtBlog = By.Id("ucContactDetail_txtBLOGURL");
        By ddFunction = By.Id("ucContactDetail_ddlJobFunction");
        By txtPosition = By.Id("ucContactDetail_txtJobTitle");


        By ddStatus = By.Id("ucContactDetail_ddlPersonStatus");
        By txtCompany = By.Id("ucContactDetail_txtCompanyName");
        By txtAddress = By.Id("ucContactDetail_txtAddress");
        By txtPostCode = By.Id("ucContactDetail_txtPostcode");
        By chkPostCodePrivacy = By.Id("ucContactDetail_chkIsPrivate");

        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By contactName = By.CssSelector("table#FFCompanyContact_grdCompanyContacts_ctl00 > tbody > tr > td:nth-child(6)");
        By tblCompanyContacts = By.Id("FFCompanyContact_grdCompanyContacts_ctl00");


        //Neerav Code
        By btnNewContact = By.Id("FFCompanyContact_ibtnAddContact");
        By tbTitle = By.Id("ucContactDetail_txtHonorific");
        By tbInitials = By.Id("ucContactDetail_txtInitials");
        By tbFirstName = By.Id("ucContactDetail_txtFirstName");
        By tbLastName = By.Id("ucContactDetail_txtLastName");
        By tbTelephone = By.Id("ucContactDetail_txtTelephone");
        By cbTelephonePrivacy = By.Id("ucContactDetail_chkPrvTel");
        By tbFax = By.Id("ucContactDetail_txtFax");
        By cbFaxPrivacy = By.Id("ucContactDetail_chkPrvFax");
        By tbEmail = By.Id("ucContactDetail_txtEmail");
        By cbReadReceipt = By.Id("ucContactDetail_chkReadReceipt");
        By cbEmailPrivacy = By.Id("ucContactDetail_chkPrvEml");
        By tbCell = By.Id("ucContactDetail_txtMobile");
        By cbCellPrivacy = By.Id("ucContactDetail_chkPrvMob");
        By tbFacebook = By.Id("ucContactDetail_txtFaceBookURL");
        By tbTwitter = By.Id("ucContactDetail_txtTwitterURL");
        By tbLinkedIn = By.Id("ucContactDetail_txtLinkedInURL");
        By tbBlog = By.Id("ucContactDetail_txtBLOGURL");
        By ddJobFunction = By.Id("ucContactDetail_ddlJobFunction");
        By tbPosition = By.Id("ucContactDetail_txtJobTitle");
        By btnSave = By.Id("btnSave");
        By btnActiveInactive = By.Id("btnPersonStatus");
        By btnHistory = By.Id("iglbarMenu_0_Item_1");
        By btnResponsiblities = By.Id("iglbarMenu_0_Item_2");
        By btnRelationships = By.Id("iglbarMenu_0_Item_3");
        By btnOpportunities = By.Id("iglbarMenu_0_Item_4");
        By btnNotes = By.Id("iglbarMenu_0_Item_5");
        By btnAttachements = By.Id("iglbarMenu_0_Item_6");
        By btnWebUser = By.Id("iglbarMenu_0_Item_7");
        By btnCampaign = By.Id("iglbarMenu_0_Item_8");
        By btnExternalRef = By.Id("iglbarMenu_0_Item_9");
        By btnDocuments = By.Id("iglbarMenu_0_Item_10");
        By cbShowInactive = By.Id("FFCompanyContact_chkShowInactive");
        By btnNewResponsibilities = By.Id("FFResponsibilityList_btnAddResponsibility");
        By btnDeleteResponsibilities = By.Id("FFResponsibilityList_btnDeleteResponsibility");

        By tableHeaderEditButton = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_0");
        By tableHeaderRole = By.CssSelector("th#FFResponsibilityListxgrdCompanyResponsibilities_c_0_1 > nobr");
        By tableHeaderName = By.CssSelector("th#FFResponsibilityListxgrdCompanyResponsibilities_c_0_2 > nobr");
        By tableHeaderTelephone = By.CssSelector("th#FFResponsibilityListxgrdCompanyResponsibilities_c_0_3 > nobr");
        By tableHeaderContactName = By.CssSelector("th#FFResponsibilityListxgrdCompanyResponsibilities_c_0_4 > nobr");
        By tableHeaderMedia = By.CssSelector("th#FFResponsibilityListxgrdCompanyResponsibilities_c_0_5 > nobr");

        By btnNewRelationship = By.Id("FFRelationshipList_btnAddRelationship");
        By btnDeleteRelationship = By.Id("FFRelationshipList_btnDeleteRelationship");

        By gridRole = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_3");
        By gridCompany = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_5");
        By gridLinkedName = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_6");
        By gridBrandRel = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_7");
        By gridStartDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_18");
        By gridEndDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_19");
        By rbCurrent = By.Id("FFRelationshipList_rblRelationshipsDateControl_0");
        By rbAllSA = By.Id("FFRelationshipList_rblRelationshipsDateControl_1");

        By gridName = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(3)");
        By gridDate = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(4)");
        By gridContact = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(5)");
        By gridRating = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(6)");
        By gridEstimatedValue = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(8)");
        By gridEstimatedCloseValue = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(9)");
        By gridCloseProbability = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(10)");

        By btnPostNote = By.Id("Notes_btnPost");
        By rowNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trNote");
        By btnReply = By.Id("Notes_btnReply");
        By tbDateStartingFrom = By.Id("Notes_ucStartDate_ucDateChooser_iwdcDate_input");
        By btnDeleteNotes = By.Id("Notes_btnDelete");

        By gridDateNotes = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(2)");
        By gridNameNotes = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(3)");
        By gridPosts = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(4)");

        By gridCreatedPost = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(4)");

        By btnNewAttachement = By.Id("ucAttachment_btnNewAttachment");
        By btnDeleteAttachement = By.Id("ucAttachment_pnlDelete");

        By gridTitle = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(4)");
        By gridType = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(5)");
        By gridFileName = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(6)");
        By gridAddedBy = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(7)");
        By gridCreated = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(8)");

        By gridDynamics = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(1) > td:nth-child(2)");
        By gridSalesForce = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(2) > td:nth-child(2)");
        By gridIntegerationX = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(3) > td:nth-child(2)");
        By gridChaseLockBox = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(4) > td:nth-child(2)");
        By gridLGA = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(5) > td:nth-child(2)");
        By gridDFP = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(6) > td:nth-child(2)");
        By gridSource = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > thead > tr > th:nth-child(2)");
        By gridExternalReference = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > thead > tr > th:nth-child(3)");

        By imgContact = By.CssSelector("td.gridRowImg.gridRowContact");
        //

        #endregion

        #region Functions
        //Following function performs navigation to Contacts Tab
        public void navigateToContactsTab()
        {
            log.Info("Navigate to Contacts tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabContacts));
            driver.FindElement(tabContacts).Click();
        }

        public void clickNew()
        {
            log.Info("New Button Clicked");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementExists(btnNew));
            wait.Until(ExpectedConditions.ElementIsVisible(btnNew));
            driver.FindElement(btnNew).Click();
        }

        public void verifyContactTabDetails()
        {
            log.Info("Verifying Contacts Tab Details");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(txtName));

            Assert.AreEqual("true", driver.FindElement(txtName).GetAttribute("readonly"));
            Assert.AreEqual(true, driver.FindElement(txtTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtInitials).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtFirstName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkPostCodePrivacy).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtFax).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkFaxPrivacy).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtEmail).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkEmailReadReceipt).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkEmailPrivacy).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtFacebook).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTwitter).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLinkedIn).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtBlog).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompany).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtAddress).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddFunction).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostCode).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddStatus).Displayed);
        }

        public void enterContactDetails()
        {

            log.Info("Entering Contact Details");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(txtName));

            driver.FindElement(txtTitle).SendKeys("Mr");
            driver.FindElement(txtInitials).SendKeys("T.");
            driver.FindElement(txtFirstName).SendKeys("Michael");

            driver.FindElement(txtLastName).SendKeys("Peter");
            driver.FindElement(chkPostCodePrivacy).Click();

            driver.FindElement(txtTel).SendKeys("011-2563247");
            driver.FindElement(chkTelPrivacy).Click();

            driver.FindElement(txtFax).SendKeys("011-2563247");
            driver.FindElement(chkFaxPrivacy).Click();

            driver.FindElement(txtEmail).SendKeys("Micheal.peter@email.com");
            driver.FindElement(chkEmailPrivacy).Click();
            driver.FindElement(chkEmailReadReceipt).Click();

            driver.FindElement(txtMobile).SendKeys("9876543210");
            driver.FindElement(chkMobPrivacy).Click();

            driver.FindElement(txtFacebook).SendKeys("www.facebook.com/micheal.peter");
            driver.FindElement(txtTwitter).SendKeys("www.twitter.com/micheal.peter");
            driver.FindElement(txtLinkedIn).SendKeys("www.linkedin.com/micheal.peter");

            driver.FindElement(txtBlog).SendKeys("Test Blog");

            IWebElement ddlFunction = driver.FindElement(ddFunction);
            SelectElement function = new SelectElement(ddlFunction);
            function.SelectByText("Direct marketing");

            driver.FindElement(txtPosition).SendKeys("Marketing Head");

            IWebElement ddlStatus = driver.FindElement(ddStatus);
            SelectElement status = new SelectElement(ddlStatus);
            status.SelectByText("Main Contact");

        }

        public void verifySavedContactDetails()
        {
            log.Info("Verifying Saved Contact Details");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(txtName));

            string strNameAndTitle = driver.FindElement(txtTitle).GetAttribute("value") + " " + driver.FindElement(txtFirstName).GetAttribute("value") + " " + driver.FindElement(txtLastName).GetAttribute("value");

            Assert.AreEqual(strNameAndTitle, driver.FindElement(txtName).GetAttribute("value"));
            Assert.AreEqual(strNameAndTitle, driver.FindElement(pageHeading).Text);
            Assert.AreEqual(true, driver.FindElement(buttonStationery).Displayed);

        }

        public void navigateToInformationTab()
        {
            log.Info("Navigate to Information tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabInformation));
            driver.FindElement(tabInformation).Click();

        }

        public void clickActive()
        {
            log.Info("Active Button Clicked");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnActive));
            wait.Until(ExpectedConditions.ElementIsVisible(btnActive));
            driver.FindElement(btnActive).Click();

        }

        public void verifyContactStatus()
        {

            log.Info("Verifying Contact Status");
            wait.Until(ExpectedConditions.ElementExists(btnActive));
            wait.Until(ExpectedConditions.ElementIsVisible(btnActive));

            if (driver.FindElement(btnActive).GetAttribute("value") == "Inactive")
                Assert.AreEqual("Inactive", driver.FindElement(btnActive).GetAttribute("value"));
            else
                Assert.AreEqual("Active", driver.FindElement(btnActive).GetAttribute("value"));


        }

        public void clickCompanyAvailableInHeader()
        {

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnCompany).Click();

        }

        public void verifyNewContactIsCreated()
        {
            log.Info("Verifying New Contact Creation");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            //wait.Until(ExpectedConditions.ElementExists(tblCompanyContacts));

            Assert.AreEqual("Michael", driver.FindElement(contactName).Text);



        }

        //Neerav Code

        #region Functions

        public void navigateToExistingContact()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(imgContact).Click();
        }

        public void navigateToHistoryTab()
        {
            log.Info("Navigate to History tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnHistory));

            driver.FindElement(btnHistory).Click();
        }

        public void navigateToResponsibilitiesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnResponsiblities));
            driver.FindElement(btnResponsiblities).Click();
        }

        public void navigateToRelationshipsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnRelationships));
            driver.FindElement(btnRelationships).Click();
        }

        public void verifyResponsibilitiesTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewResponsibilities));

            Assert.AreEqual(true, driver.FindElement(btnNewResponsibilities).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteResponsibilities).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderEditButton).Displayed);
            Assert.AreEqual("Role", driver.FindElement(tableHeaderRole).Text);
            Assert.AreEqual("Name", driver.FindElement(tableHeaderName).Text);
            Assert.AreEqual("Telephone", driver.FindElement(tableHeaderTelephone).Text);
            Assert.AreEqual("Contact Name", driver.FindElement(tableHeaderContactName).Text);
            Assert.AreEqual("Media", driver.FindElement(tableHeaderMedia).Text);
        }

        public void verifyRelationshipsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewRelationship).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnDeleteRelationship).Enabled);
            Assert.AreEqual(true, driver.FindElement(rbCurrent).Enabled);
            Assert.AreEqual(true, driver.FindElement(rbAllSA).Enabled);

            Assert.AreEqual("Role", driver.FindElement(gridRole).Text);
            Assert.AreEqual("Company", driver.FindElement(gridCompany).Text);
            Assert.AreEqual("LinkedName", driver.FindElement(gridLinkedName).Text);
            Assert.AreEqual("Brand", driver.FindElement(gridBrandRel).Text);
            Assert.AreEqual("Start Date", driver.FindElement(gridStartDate).Text);
            Assert.AreEqual("End Date", driver.FindElement(gridEndDate).Text);
        }

        public void navigateToOpportunitiesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnOpportunities));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnOpportunities));
            driver.FindElement(btnOpportunities).Click();
        }

        public void verifyOpportunitiesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            Assert.AreEqual("Name", driver.FindElement(gridName).Text);
            Assert.AreEqual("Date", driver.FindElement(gridDate).Text);
            Assert.AreEqual("Contact", driver.FindElement(gridContact).Text);
            Assert.AreEqual("Rating", driver.FindElement(gridRating).Text);
            Assert.AreEqual("Estimated Value", driver.FindElement(gridEstimatedValue).Text);
            Assert.AreEqual("Estimated Close Date", driver.FindElement(gridEstimatedCloseValue).Text);
            Assert.AreEqual("Close Probability", driver.FindElement(gridCloseProbability).Text);
        }

        public void navigateToNotesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNotes));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnNotes));
            driver.FindElement(btnNotes).Click();
        }

        public void verifyNotesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnPostNote).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnReply).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnDeleteNotes).Enabled);
            Assert.AreEqual(true, driver.FindElement(tbDateStartingFrom).Displayed);
            Assert.AreEqual("Date", driver.FindElement(gridDateNotes).Text);
            Assert.AreEqual("Name", driver.FindElement(gridNameNotes).Text);
            Assert.AreEqual("Posts", driver.FindElement(gridPosts).Text);
        }

        public void navigateToAttachmentsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnAttachements));
            driver.FindElement(btnAttachements).Click();
        }

        public void verifyAttachmentsButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewAttachement).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteAttachement).Displayed);
            Assert.AreEqual("Title", driver.FindElement(gridTitle).Text);
            Assert.AreEqual("Type", driver.FindElement(gridType).Text);
            Assert.AreEqual("File Name", driver.FindElement(gridFileName).Text);
            Assert.AreEqual("Added By", driver.FindElement(gridAddedBy).Text);
            Assert.AreEqual("Created", driver.FindElement(gridCreated).Text);

        }

        public void navigateToExternalReference()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnExternalRef));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnExternalRef));
            driver.FindElement(btnExternalRef).Click();
        }

        public void verifyExternalRefButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual("Source", driver.FindElement(gridSource).Text);
            Assert.AreEqual("External Reference", driver.FindElement(gridExternalReference).Text);
            Assert.AreEqual("DYNAMICS", driver.FindElement(gridDynamics).Text);
            Assert.AreEqual("SALESFORCE", driver.FindElement(gridSalesForce).Text);
            Assert.AreEqual("Integration X", driver.FindElement(gridIntegerationX).Text);
            Assert.AreEqual("Chase Lock Box", driver.FindElement(gridChaseLockBox).Text);
            Assert.AreEqual("LGA", driver.FindElement(gridLGA).Text);
            Assert.AreEqual("DFP", driver.FindElement(gridDFP).Text);

        }

        public void navigateToDocuments()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnDocuments));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDocuments));
            driver.FindElement(btnDocuments).Click();
        }

        public void navigateToWebUser()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnWebUser));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnWebUser));
            driver.FindElement(btnWebUser).Click();
        }

        public void navigateToCampaign()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnCampaign));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCampaign));
            driver.FindElement(btnCampaign).Click();
        }

        #endregion Functions

        //

        #endregion
    }
}
