using Ingenta.Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Companies Finance Page")]
    public class CompanyFinance_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        string verifySalesAccountCode = "";
        Utility_Functions uf = new Utility_Functions();

        public CompanyFinance_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        int noOfSalesAcc = 0;

        #region Object Repository

        By tabFinance = By.Id("iglbarMenu_2_Item_0");
        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By tabAddress_Contact = By.Id("iglbarMenu_0_Item_1");
        By tabSchedules = By.Id("iglbarMenu_0_Item_2");
        By btnSaveAndClose = By.Id("btnSaveClose");
        By btnClose = By.Id("btnClose");
        By btnSave = By.Id("btnSave");
        By tblSalesAccount = By.CssSelector("table[id*='G_ucFinanceDetailxdgrdSalesAccounts']>tbody>tr");
        By rwSalesAccount = By.Id("ucFinanceDetailxdgrdSalesAccounts_r_1");
        By firstRowSalesAccount = By.Id("ucFinanceDetailxdgrdSalesAccounts_r_0");
        By salesAccountRow = By.CssSelector("table#G_ucFinanceDetailxdgrdSalesAccounts > tbody > tr");
        By ddBookingStatus = By.Id("ddlBookingStatus");
        By ddMarkSchedule = By.Id("ddlActive");


        By txtTaxRegNumber = By.Id("ucFinanceDetail_txtTaxRegistration");
        By txtTaxExemptionNumber = By.Id("ucFinanceDetail_txtTaxExemption");
        By txtRegistrationNumber = By.Id("ucFinanceDetail_txtRegistrationNumber");
        By ddlTaxStatus = By.Id("ucFinanceDetail_ddlTaxStatus");
        By ddlCurrency = By.Id("ucFinanceDetail_ddlCurrency");
        By ddlRateCard = By.Id("ucFinanceDetail_ddlRateCard");
        By ddlConsOpt = By.Id("ucFinanceDetail_ddlConsOpt");
        By ddlInvoiceLevel = By.Id("ucFinanceDetail_ddlInvoiceLevel");
        By chkCustomerRef = By.Id("ucFinanceDetail_chkCustRefMandatory");
        By chkAccrueAgencyCommission = By.Id("ucFinanceDetail_chkAccrueAgencyCommission");

        By titleInformation = By.Id("ucCompanyDetail_lblInfo");

        By btnNew = By.Id("ucFinanceDetail_btnNewAccount");
        By btnEdit = By.Id("ucFinanceDetail_btnEdtAccount");
        By btnDelete = By.Id("ucFinanceDetail_btnDelAccount");
        By grdSales = By.Id("ucFinanceDetail_divSalesAccounts");
        By tableHeaderSalesAccount = By.Id("ucFinanceDetailxdgrdSalesAccounts_c_0_1");
        By tableHeaderSalesLedger = By.Id("ucFinanceDetailxdgrdSalesAccounts_c_0_2");


        #region New Sales Account objects

        By chkAvailable = By.Id("ucSalesInformation_chkAvailable");
        By ddSalesLedger = By.Id("ucSalesInformation_ddlSalesLedger");
        By chkGlobalAcc = By.Id("ucSalesInformation_chkGlobalAccount");
        By ddGlobalAcc = By.Id("ucSalesInformation_ddlGlobalAccounts");
        By txtSalesAccCode = By.Id("ucSalesInformation_txtAccCode");
        By txtSalesAcc = By.Id("ucSalesInformation_txtSalesAccount");
        By chkGenerateAuto = By.Id("ucSalesInformation_chkAccCodeGeneration");


        By txtSortName = By.Id("ucSalesInformation_txtSortName");
        By txtCreditLimit = By.Id("ucSalesInformation_txtCreditLimit");
        By txtAvailableBal = By.Id("ucSalesInformation_txtAvailableBalance");
        By txtBookingLimit = By.Id("ucSalesInformation_txtBookingLimit");
        By ddAccStatus = By.Id("ucSalesInformation_ddlAccountStatus");
        By ddStatusReason = By.Id("ucSalesInformation_ddlAccStatusReason");
        By txtReasonDetail = By.Id("ucSalesInformation_txtStatusReason");


        By chkCreditReferTo = By.Id("ucSalesInformation_chkCreditRefer");
        By ddCreditReferTo = By.Id("ucSalesInformation_ddlReferUser");
        By ddCreditControler = By.Id("ucSalesInformation_ddlCreditController");
        By ddDefaultSchedule = By.Id("ucSalesInformation_ddlDefaultSchedule");
        By ddCreditTerm = By.Id("ucSalesInformation_ddlCreditTerm");
        By ddTransactionDispatchMethod = By.Id("ucSalesInformation_ddlInvoiceDespatchMethod");



        #endregion


        #region Address/Contact

        By btnCopyAddress = By.Id("ucSalesAddress_btnCopyAddress");
        By txtAddress1 = By.Id("ucSalesAddress_txtAddressline1");
        By txtAddress2 = By.Id("ucSalesAddress_txtAddressline2");
        By txtAddress3 = By.Id("ucSalesAddress_txtAddressline3");
        By txtAddress4 = By.Id("ucSalesAddress_txtAddressline4");

        By txtTown = By.Id("ucSalesAddress_txtTown");
        By txtPostalCode = By.Id("ucSalesAddress_txtPostalCode");
        By txtCountryRegion = By.Id("ucSalesAddress_txtCountryRegion");
        By ddlCountry = By.Id("ucSalesAddress_ddlCountry");
        By ddlSalesAccProvince = By.Id("ucSalesAddress_ddlSalesAccountProvince");
        By txtCreditContactTitle = By.Id("ucSalesAddress_txtCreditContactTitle");


        By txtCreditContactName = By.Id("ucSalesAddress_txtCreditContactName");
        By txtCreditContactTel = By.Id("ucSalesAddress_txtCreditContactTelephone");
        By txtCreditContactFax = By.Id("ucSalesAddress_txtCreditContactFax");
        By txtCreditContactEmail = By.Id("ucSalesAddress_txtCreditContactEmail");



        #endregion

        #endregion

        #region Functions
        //Following function performs navigation to Finance Tab
        public void navigateToFinanceTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabFinance));
            driver.FindElement(tabFinance).Click();
        }

        public void navigateBackToFinanceTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabFinance));
            driver.FindElement(tabFinance).Click();
        }

        public void navigateToAddress_Contact_Tab()
        {
            log.Info("Navigate to Address / Contact tab");
            wait.Until(ExpectedConditions.ElementExists(tabAddress_Contact));
            driver.FindElement(tabAddress_Contact).Click();
        }

        public void navigateToSchedulesTab()
        {
            log.Info("Navigate to Schedules tab");
            wait.Until(ExpectedConditions.ElementExists(tabSchedules));
            driver.FindElement(tabSchedules).Click();
        }

        public void enterFinanceDetails(string taxRegNumber)
        {
            log.Info("Finance Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(txtTaxRegNumber));
            driver.FindElement(txtTaxRegNumber).SendKeys(taxRegNumber);
            driver.FindElement(txtTaxExemptionNumber).SendKeys("EXMP12345");
            driver.FindElement(txtRegistrationNumber).SendKeys("REG12345");

            IWebElement ddTax = driver.FindElement(ddlTaxStatus);
            SelectElement TaxStatus = new SelectElement(ddTax);
            TaxStatus.SelectByText("Standard Tax Rate");

            IWebElement ddCurr = driver.FindElement(ddlCurrency);
            SelectElement Currency = new SelectElement(ddCurr);
            Currency.SelectByText("US Dollars");

            IWebElement ddlOverrideConsolidation = driver.FindElement(ddlConsOpt);
            SelectElement overrideConsolidation = new SelectElement(ddlOverrideConsolidation);
            overrideConsolidation.SelectByText("By Booking");

            IWebElement ddlInvoiceLevels = driver.FindElement(ddlInvoiceLevel);
            SelectElement invoiceLevel = new SelectElement(ddlInvoiceLevels);
            invoiceLevel.SelectByText("Simple");

            driver.FindElement(chkCustomerRef).Click();
            //driver.FindElement(chkAccrueAgencyCommission).Click();
        }

        public void enterSchedulesDetails()
        {
            log.Info("Schedules Details");

            uf.switchToFrameByName(driver, wait, "ifrPages");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementToBeClickable(ddBookingStatus));

            IWebElement ddBookingSt = driver.FindElement(ddBookingStatus);
            SelectElement TaxStatus = new SelectElement(ddBookingSt);
            TaxStatus.SelectByText("Confirmed");

            IWebElement ddMarkSc = driver.FindElement(ddMarkSchedule);
            SelectElement MarkSchedule = new SelectElement(ddMarkSc);
            MarkSchedule.SelectByText("Active");

            //Clicking the save button in schedule tab
            driver.FindElement(btnSave).Click();
        }

        public void navigateToInformationTabInSales()
        {
            driver.SwitchTo().DefaultContent();
            log.Info("Navigate Information Tab in New Sales Account");
            uf.switchToFrameByName(driver, wait, "iframeAccountPage");
            wait.Until(ExpectedConditions.ElementExists(tabInformation));
            driver.FindElement(tabInformation).Click();
        }

        public void ClickSave()
        {

            log.Info("Save Record");
            wait.Until(ExpectedConditions.ElementExists(btnSave));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));
            driver.FindElement(btnSave).Click();

        }

        public void ClickNew()
        {
            log.Info("New Button Clicked");
            wait.Until(ExpectedConditions.ElementExists(btnNew));
            wait.Until(ExpectedConditions.ElementIsVisible(btnNew));
            driver.FindElement(btnNew).Click();
            uf.SwitchToNewWindow(driver);
            uf.switchToFrameByElement(driver, wait, "iframeAccountPage");

        }

        public void clickClose()
        {

            log.Info("Close Button Clicked");
            wait.Until(ExpectedConditions.ElementExists(btnClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnClose));
            driver.FindElement(btnClose).Click();
            uf.SwitchToNewWindow(driver);

        }

        public void clickSaveAndClose()
        {

            log.Info("Save and Close Button Clicked");
            wait.Until(ExpectedConditions.ElementExists(btnSaveAndClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveAndClose));
            driver.FindElement(btnSaveAndClose).Click();

            Thread.Sleep(3000);
            uf.SwitchToNewWindow(driver);


        }

        public void clickSaveAndCloseAfterSearcj()
        {
            log.Info("Save and Close Button Clicked");
            wait.Until(ExpectedConditions.ElementExists(btnSaveAndClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveAndClose));
            driver.FindElement(btnSaveAndClose).Click();
        }

        public void clickEdit()
        {

            log.Info("Edit Button Clicked");
            wait.Until(ExpectedConditions.ElementExists(btnEdit));
            wait.Until(ExpectedConditions.ElementIsVisible(btnEdit));
            driver.FindElement(btnEdit).Click();

            uf.SwitchToNewWindow(driver);
            uf.switchToFrameByElement(driver, wait, "iframeAccountPage");

        }

        public void clickDelete()
        {

            if (noOfSalesAcc > 0)
            {
                log.Info("Delete Button Clicked");
                wait.Until(ExpectedConditions.ElementExists(btnDelete));
                wait.Until(ExpectedConditions.ElementIsVisible(btnDelete));
                driver.FindElement(btnDelete).Click();
            }

        }

        //below method will verify that after saving the finance tab system will be redirected to Information Tab
        public void verifyInformationPage()
        {
            log.Info("Verify Information Page");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Assert.AreEqual(true, driver.FindElement(titleInformation).Displayed);

        }

        public void verifyFinanceDetails(string taxRegNo)
        {

            log.Info("Verify Finance Details are saved correctly!!");

            wait.Until(ExpectedConditions.ElementExists(txtTaxRegNumber));
            wait.Until(ExpectedConditions.ElementIsVisible(txtTaxRegNumber));

            Assert.AreEqual(taxRegNo, driver.FindElement(txtTaxRegNumber).GetAttribute("value"));
            Assert.AreEqual(true, driver.FindElement(btnNew).Enabled);

        }

        public void verifyFinancePageDetails()
        {

            log.Info("Finance Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(txtTaxRegNumber));

            Assert.AreEqual(true, driver.FindElement(txtTaxRegNumber).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTaxExemptionNumber).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtRegistrationNumber).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddlTaxStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCurrency).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlConsOpt).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddlInvoiceLevel).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkCustomerRef).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnNew).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnEdit).Enabled);

            Assert.AreEqual(false, driver.FindElement(btnDelete).Enabled);
            Assert.AreEqual(true, driver.FindElement(grdSales).Displayed);


        }

        public void verifyCompanySearchFinanceDetails()
        {
            log.Info("Company Search Finance Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(txtTaxRegNumber));

            Assert.AreEqual(true, driver.FindElement(txtTaxRegNumber).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTaxExemptionNumber).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtRegistrationNumber).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlTaxStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCurrency).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlConsOpt).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlInvoiceLevel).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkCustomerRef).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnEdit).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDelete).Displayed);

            Assert.AreEqual(true, driver.FindElement(tableHeaderSalesAccount).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSalesLedger).Displayed);


        }

        public void verifyEditedSalesAccDetails()
        {

            log.Info("Verifying Edited Sales Acc Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(txtSalesAcc));

            Assert.AreEqual("SLACC1234567", driver.FindElement(txtSalesAcc).GetAttribute("value"));

        }

        public void VerifyNewSalesAccountDetails()
        {

            log.Info("New Sales Account Details");

            wait.Until(ExpectedConditions.ElementIsVisible(chkAvailable));
            Assert.AreEqual(true, driver.FindElement(chkAvailable).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddSalesLedger).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkGlobalAcc).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddGlobalAcc).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSalesAccCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSalesAcc).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkGenerateAuto).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSortName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCreditLimit).Displayed);
            Assert.AreEqual(false, driver.FindElement(txtAvailableBal).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtBookingLimit).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddAccStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddStatusReason).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtReasonDetail).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkCreditReferTo).Displayed);
            Assert.AreEqual(false, driver.FindElement(ddCreditReferTo).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddCreditControler).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddDefaultSchedule).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCreditTerm).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddTransactionDispatchMethod).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnSave).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAndClose).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnClose).Enabled);

        }

        public void enterSalesAccountDetails(string autoGenerateSalesAccCode)
        {
            log.Info("Sales Account Details entry");

            IWebElement ddlSalesLed = driver.FindElement(ddSalesLedger);
            SelectElement salesLedger = new SelectElement(ddlSalesLed);

            Random generator = new Random();
            String r = generator.Next(0, 9999).ToString("D6");

            salesLedger.SelectByText("Sales 1");
            verifySalesAccountCode = "SLS1234" + r;

            if (autoGenerateSalesAccCode == "DoNotAutoGenerateSalesAccountCode")
                driver.FindElement(txtSalesAccCode).SendKeys(verifySalesAccountCode);

            driver.FindElement(txtSalesAcc).SendKeys("SLACC1234");
            driver.FindElement(txtSortName).SendKeys("SLA");

            driver.FindElement(txtCreditLimit).SendKeys("3000");

            //Available text box is disabled
            //driver.FindElement(txtAvailableBal).SendKeys("2000");

            IWebElement ddlAccStatus = driver.FindElement(ddAccStatus);
            SelectElement accStatus = new SelectElement(ddlAccStatus);
            accStatus.SelectByText("Open");

            IWebElement ddlStatusRn = driver.FindElement(ddStatusReason);
            SelectElement statusReason = new SelectElement(ddlStatusRn);
            statusReason.SelectByText("New Account");

            Thread.Sleep(2000);
            uf.IsPageLoaded(driver);

            driver.FindElement(chkCreditReferTo).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(ddCreditReferTo));

            IWebElement ddCreditRefTo = driver.FindElement(ddCreditReferTo);
            SelectElement creditReferTo = new SelectElement(ddCreditRefTo);
            creditReferTo.SelectByText("TESTUSER");

            wait.Until(ExpectedConditions.ElementToBeClickable(ddDefaultSchedule));

            IWebElement ddDefaultSch = driver.FindElement(ddDefaultSchedule);
            SelectElement defaultSchedulte = new SelectElement(ddDefaultSch);
            defaultSchedulte.SelectByText("Invoice at Month End");

            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(ddCreditTerm));
            wait.Until(ExpectedConditions.ElementToBeClickable(ddCreditTerm));

            IWebElement ddlCreditTerm = driver.FindElement(ddCreditTerm);
            SelectElement creditTerm = new SelectElement(ddlCreditTerm);
            creditTerm.SelectByText("60 Days");

            IWebElement ddTranDisp = driver.FindElement(ddTransactionDispatchMethod);
            SelectElement transDispMethd = new SelectElement(ddTranDisp);
            transDispMethd.SelectByText("E-Mail");
        }

        public void editSalesAccountDetails()
        {

            log.Info("Edit Sales Account Details entry");

            //
            //IWebElement ddlSalesLed = driver.FindElement(ddSalesLedger);
            //SelectElement salesLedger = new SelectElement(ddlSalesLed);

            driver.FindElement(txtSalesAcc).Clear();
            driver.FindElement(txtSalesAcc).SendKeys("SLACC1234567");

            driver.FindElement(txtSortName).Clear();
            driver.FindElement(txtSortName).SendKeys("TEST");

            driver.FindElement(txtCreditLimit).Clear();
            driver.FindElement(txtCreditLimit).SendKeys("4000");

            //driver.FindElement(chkCreditReferTo).Click();

            //wait.Until(ExpectedConditions.ElementToBeClickable(ddCreditReferTo));

            //IWebElement ddCreditRefTo = driver.FindElement(ddCreditReferTo);
            //SelectElement creditReferTo = new SelectElement(ddCreditRefTo);
            //creditReferTo.SelectByText("TESTUSER");

            //wait.Until(ExpectedConditions.ElementToBeClickable(ddDefaultSchedule));

            //IWebElement ddDefaultSch = driver.FindElement(ddDefaultSchedule);
            //SelectElement defaultSchedulte = new SelectElement(ddDefaultSch);
            //defaultSchedulte.SelectByText("Invoice at Month End");

            //Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.ElementIsVisible(ddCreditTerm));
            //wait.Until(ExpectedConditions.ElementToBeClickable(ddCreditTerm));

            //IWebElement ddlCreditTerm = driver.FindElement(ddCreditTerm);
            //SelectElement creditTerm = new SelectElement(ddlCreditTerm);
            //creditTerm.SelectByText("60 Days");

            //IWebElement ddTranDisp = driver.FindElement(ddTransactionDispatchMethod);
            //SelectElement transDispMethd = new SelectElement(ddTranDisp);
            //transDispMethd.SelectByText("E-Mail");

        }

        public void enterAddress_Contact_Details()
        {
            log.Info("Address/ Contact Details entry");

            driver.FindElement(txtAddress1).SendKeys("Manual Address Line 1");
            driver.FindElement(txtAddress2).SendKeys("Casio Ltd.");
            driver.FindElement(txtAddress3).SendKeys("2Progression Business Park");
            driver.FindElement(txtAddress4).SendKeys("Chicago");
            driver.FindElement(txtTown).SendKeys("Chicago");
            driver.FindElement(txtPostalCode).SendKeys("642350");
            driver.FindElement(txtCountryRegion).SendKeys("Texus");

            IWebElement ddCountryT = driver.FindElement(ddlCountry);
            SelectElement Country = new SelectElement(ddCountryT);
            Country.SelectByText("United States");

            //To avoid the failure of test

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "iframeAccountPage");
            wait.Until(ExpectedConditions.ElementExists(tabAddress_Contact));
            driver.FindElement(tabAddress_Contact).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(txtCreditContactTitle));
            driver.FindElement(txtCreditContactTitle).SendKeys("John Paul");
            driver.FindElement(txtCreditContactName).SendKeys("999999999");
            driver.FindElement(txtCreditContactTel).SendKeys("999999999");
            driver.FindElement(txtCreditContactFax).SendKeys("999999999");
            driver.FindElement(txtCreditContactEmail).SendKeys("john.paul@email.com");


        }

        public void clickCopyAddress()
        {
            log.Info("Copy Address button clicked");
            wait.Until(ExpectedConditions.ElementExists(btnCopyAddress));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCopyAddress));
            driver.FindElement(btnCopyAddress).Click();

        }

        public void verifyCopiedAddress()
        {
            log.Info("Verifying copied address from information page");
            wait.Until(ExpectedConditions.ElementExists(btnCopyAddress));
            wait.Until(ExpectedConditions.ElementIsVisible(btnCopyAddress));

            Assert.AreEqual("234, Progress Business Park", driver.FindElement(txtAddress1).GetAttribute("value"));
            Assert.AreEqual("Chicago", driver.FindElement(txtAddress2).GetAttribute("value"));
            Assert.AreEqual("United States", driver.FindElement(txtAddress3).GetAttribute("value"));
            Assert.AreEqual("Address 4", driver.FindElement(txtAddress4).GetAttribute("value"));
            Assert.AreEqual("Chicago", driver.FindElement(txtTown).GetAttribute("value"));
            Assert.AreEqual("642350", driver.FindElement(txtPostalCode).GetAttribute("value"));

            var mySelectElm = driver.FindElement(ddlCountry);
            var mySelect = new SelectElement(mySelectElm);
            var option = mySelect.SelectedOption;
            Assert.AreEqual("United States", option.Text);
        }

        public void verifyAddressTabFields()
        {

            log.Info("Address Tab Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(btnCopyAddress));

            Assert.AreEqual(true, driver.FindElement(btnCopyAddress).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtAddress1).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtAddress2).Displayed);


            Assert.AreEqual(true, driver.FindElement(txtAddress3).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtAddress4).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTown).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCountryRegion).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddlSalesAccProvince).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCreditContactTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCreditContactName).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtCreditContactTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCreditContactFax).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCreditContactEmail).Displayed);
        }

        public void verifyDetailsOfInfomationInSales()
        {
            log.Info("Verifying Information details");
            Assert.AreEqual(Objects.poCompanyFinance_Page.verifySalesAccountCode, driver.FindElement(txtSalesAccCode).GetAttribute("value"));

        }

        public void verifyDetailsOfAddressInSales(string addressText)
        {

            log.Info("Verifying Address details");
            Assert.AreEqual(addressText, driver.FindElement(txtAddress1).GetAttribute("value"));

        }

        public void verifyDetailsSchedulesInSales()
        {

            log.Info("Verifying Schedules details");

        }

        public void verifySalesAccCodeAutoGenerated()
        {

            log.Info("Verifying Sales Account Code is auto generated");
            Assert.IsNotEmpty(txtSalesAccCode.ToString());

        }

        public void selectSalesAccount()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tblSalesAccount));
            int salesAccountRecord = driver.FindElements(tblSalesAccount).Count;

            driver.FindElement(rwSalesAccount).Click();

        }

        public void selectFirsSalesAccount()
        {

            noOfSalesAcc = driver.FindElements(salesAccountRow).Count();

            wait.Until(ExpectedConditions.ElementIsVisible(tblSalesAccount));
            if (noOfSalesAcc > 0)
                driver.FindElement(firstRowSalesAccount).Click();

        }


        public void deleteAllSalesAccounts()
        {

            noOfSalesAcc = driver.FindElements(salesAccountRow).Count();
            for (int i = 0; i < noOfSalesAcc; i++)
            {
                driver.FindElement(firstRowSalesAccount).Click();
                wait.Until(ExpectedConditions.ElementExists(btnDelete));
                wait.Until(ExpectedConditions.ElementIsVisible(btnDelete));
                driver.FindElement(btnDelete).Click();

                navigateToFinanceTab();
            }
        }

        
        public void verifyEditAndDeleteButtonDisabled()
        {

            log.Info("Verify Edid and Delete button are disabled after deleting the sales accounts");
            wait.Until(ExpectedConditions.ElementExists(btnEdit));
            wait.Until(ExpectedConditions.ElementIsVisible(btnEdit));

            Assert.AreEqual(false, driver.FindElement(btnEdit).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnDelete).Enabled);
        }
        #endregion

    }
}