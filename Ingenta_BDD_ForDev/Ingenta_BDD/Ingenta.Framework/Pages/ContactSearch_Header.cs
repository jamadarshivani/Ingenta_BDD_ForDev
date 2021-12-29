using AutoIt;
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
    public class ContactSearch_Header
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactSearch_Header(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By btnSiteDisplayMode = By.Id("Search_SearchBar_btnOpenSite");
        By btnSaveSeachResults = By.Id("Search_SearchBar_btnSaveResults");
        By btnBookingCreationMode = By.Id("Search_SearchBar_btnCreateOrder");
        By txtDataDescription = By.Id("txtDataDescription");
        By txtDataDataGroup = By.Id("txtDataDataGroup");
        By btnOpenResults = By.Id("Search_SearchBar_btnOpenResults");

        By btnStationeryReport = By.Id("Search_SearchBar_btnStationery");
        By ddSearchFor = By.Id("Search_SearchBar_List");
        By btnNew = By.Id("Search_SearchBar_btnUser");
        By btnOpenSelection = By.Id("Search_SearchBar_btnOpenResults");
        By txtLastName = By.Id("Search_FieldSelect0_txtValue1");
        By txtFirstName = By.Id("Search_FieldSelect2_txtValue1");
        By txtJobTitle = By.Id("Search_FieldSelect3_txtValue1");
        By txtEmail = By.Id("Search_FieldSelect4_txtValue1");
        By txtTelephone = By.Id("Search_FieldSelect5_txtValue1");
        By txtCompanyName = By.Id("Search_FieldSelect6_txtValue1");
        By txtPostCode = By.Id("Search_FieldSelect7_txtValue1");
        By ddCountry = By.Id("Search_FieldSelect8_lstValues1");
        By chkActive = By.Id("Search_FieldSelect9_checkBox");
        By btnSearch = By.Id("Search_GoButton");

        By btnSave = By.Id("lbtnDataSave");
        By btnCancel = By.Id("lbtnDataCancel");

        By ddlSelectLetter = By.Id("lstLetter");
        By btnSaveAsPDF = By.Id("btnSaveAsPDF");
        By btnCloseStatitonery = By.Id("btnclose");

        By btnCancelOpenSearchResults = By.CssSelector("a.ToolbarText > span");

        By gridId = By.CssSelector("table#G_gridResults > thead > tr > th:nth-child(2) > nobr");
        By gridSaved = By.CssSelector("table#G_gridResults > thead > tr > th:nth-child(3)> nobr");
        By gridDescription = By.CssSelector("table#G_gridResults > thead > tr > th:nth-child(4) > nobr");
        By gridSearchFor = By.CssSelector("table#G_gridResults > thead > tr > th:nth-child(5) > nobr");
        By gridUser = By.CssSelector("table#G_gridResults > thead > tr > th:nth-child(6) > nobr");

        #endregion Object Repository


        #region Functions

        public void clickSiteDisplayMode()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnSiteDisplayMode).Click();
        }

        public void clickSaveSearchResults()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnSaveSeachResults).Click();
        }

        public void clickBookingCreationMode()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnBookingCreationMode).Click();
        }

        public void verifySaveSearchResultsButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            By txtDataDescription = By.Id("txtDataDescription");
            By txtDataDataGroup = By.Id("txtDataDataGroup");

            Assert.AreEqual(true, driver.FindElement(txtDataDescription).Enabled);
            Assert.AreEqual("Contacts Search", driver.FindElement(txtDataDescription).GetAttribute("value"));
            Assert.AreEqual(true, driver.FindElement(txtDataDataGroup).Enabled);
        }

        public void verifyContactManagementWithStationeryReportButton()
        {

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            Assert.AreEqual(true, driver.FindElement(ddSearchFor).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOpenSelection).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtFirstName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtJobTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtEmail).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTelephone).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanyName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnStationeryReport).Displayed);
        }

        public void clickSaveButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnSave).Click();
        }

        public void clickCancelButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnCancel).Click();
        }

        public void clickStationeryReportButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            driver.FindElement(btnStationeryReport).Click();
        }

        public void verifyStationeryReportButton()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            Assert.AreEqual(true, driver.FindElement(ddlSelectLetter).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCloseStatitonery).Enabled);
        }

        public void closeStationeryReportWindow()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(btnCloseStatitonery).Click();
        }

        public void verifyContactManagementPageInPreviousWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            Assert.AreEqual(true, driver.FindElement(ddSearchFor).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOpenSelection).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtFirstName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtJobTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtEmail).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTelephone).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanyName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearch).Displayed);
        }

        public void clickOpenSearchResultsButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");
            driver.FindElement(btnOpenResults).Click();
        }

        public void verifyOpenSearchResultsButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(btnCancelOpenSearchResults).Displayed);

            Assert.AreEqual("ID", driver.FindElement(gridId).Text);
            Assert.AreEqual("Saved", driver.FindElement(gridSaved).Text);
            Assert.AreEqual("Description", driver.FindElement(gridDescription).Text);
            Assert.AreEqual("Search For", driver.FindElement(gridSearchFor).Text);
            Assert.AreEqual("User", driver.FindElement(gridUser).Text);
        }

        public void clickCancelOpenSearchResultsButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnCancelOpenSearchResults).Click();
        }

        #endregion Functions



    }
}
