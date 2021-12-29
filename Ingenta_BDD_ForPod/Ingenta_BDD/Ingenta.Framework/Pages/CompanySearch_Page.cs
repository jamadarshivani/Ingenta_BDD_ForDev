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
    [TestFixture, Description("This is a page object for Company Search Page")]
    public class CompanySearch_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();
        string companyName = "TestCompany1234";
        public CompanySearch_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;

        }


        #region Object Repository

        By ddSearchFor = By.Id("Search_SearchBar_List");
        By btnNew = By.Id("Search_SearchBar_btnUser");
        By btnSiteDisplayMode = By.Id("Search_SearchBar_btnOpenSite");
        By btnSaveResults = By.Id("Search_SearchBar_btnSaveResults");
        By btnOpenResults = By.Id("Search_SearchBar_btnOpenResults");

        By txtCompanySearch = By.Id("Search_FieldSelect0_txtValue1");
        By btnSearchGo = By.Id("Search_GoButton");
        By lnkCompanyRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By tabAttachments = By.Id("iglbarMenu_0_Item_8");
        By txtPostalCode = By.Id("Search_FieldSelect5_txtValue1");

        By txtTown = By.Id("Search_FieldSelect4_txtValue1");
        By txtTel = By.Id("Search_FieldSelect6_txtValue1");
        By ddCountry = By.Id("Search_FieldSelect7_lstValues1");
        By ddCompanyType = By.Id("Search_FieldSelect8_lstValues1");        
        By ddCountryViaContacts = By.Id("Search_FieldSelect8_lstValues1");
        By chkActive = By.Id("Search_FieldSelect9_checkBox");
        By buttonActiveInactive = By.Id("btnActiveInActive");

        By ingentaCompanyNewButton = By.Id("Search_SearchBar_btnUser");
        By noOfRowsCompanySearched = By.XPath("//table[@id='SearchxresultsGrid_main'//tr");

        By btnSearchInHeader = By.Id("btnSelection");
        By btnStationeryInHeader = By.Id("btnStationery");
        By btnActiveInActive = By.Id("btnActiveInActive");

        //Stationery Popup Details
        By btnclose = By.Id("btnclose");
        By ddLetter = By.Id("lstLetter");
        By btnEmail = By.Id("lbtnSend");
        By btnSaveAsPDF = By.Id("btnSaveAsPDF");

        //
        By contactName = By.CssSelector("table#FFCompanyContact_grdCompanyContacts_ctl00 > tbody > tr > td:nth-child(6)");


        By tableHeaderCompany = By.Id("SearchxresultsGrid_c_0_3");
        By tableHeaderSiteId = By.Id("SearchxresultsGrid_c_0_4");
        By tableHeaderTel = By.Id("SearchxresultsGrid_c_0_5");
        By tableHeaderAdd1 = By.Id("SearchxresultsGrid_c_0_7");

        By tableHeaderAdd2 = By.Id("SearchxresultsGrid_c_0_8");
        By tableHeaderSTown = By.Id("SearchxresultsGrid_c_0_11");
        By tableHeaderRegion = By.Id("SearchxresultsGrid_c_0_12");
        By tableHeaderPostCode = By.Id("SearchxresultsGrid_c_0_13");

        By tableHeaderCountry = By.Id("SearchxresultsGrid_c_0_14");
        By tableHeaderCompanyType = By.Id("SearchxresultsGrid_c_0_15");
        By tableHeaderAgencyType = By.Id("SearchxresultsGrid_c_0_16");
        

        By tableHeaderLastName = By.Id("SearchxresultsGrid_c_0_4");
        By tableHeaderFirstName = By.Id("SearchxresultsGrid_c_0_5");
        By tableHeaderJobTitle = By.Id("SearchxresultsGrid_c_0_7");
        By tableHeaderContactCompany = By.Id("SearchxresultsGrid_c_0_10");

        By tableHeaderContactSiteId = By.Id("SearchxresultsGrid_c_0_11");
        By tableHeaderLocation = By.Id("SearchxresultsGrid_c_0_13");
        By tableHeaderPostalCode = By.Id("SearchxresultsGrid_c_0_14");
        By tableHeaderContactTel = By.Id("SearchxresultsGrid_c_0_17");
        By tableHeaderFax = By.Id("SearchxresultsGrid_c_0_18");
        By tableHeaderEmail = By.Id("SearchxresultsGrid_c_0_19");
        


        By titleContactManagementScreen = By.Id("Search_SearchBar_labTitle");

        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By cbIsActive = By.Id("Search_FieldSelect9_checkBox");
        By btnSaveSeachResults = By.Id("Search_SearchBar_btnSaveResults");

        By tableSearchCompany = By.Id("tdQuery");
        By txtTelephone = By.Id("Search_FieldSelect6_txtValue1");
        By btnStationeryReport = By.Id("Search_SearchBar_btnStationery");
        #endregion

        #region Functions        

        //Following function searches for the company
        public void searchForCompany(string searchText, string searchBy)
        {

            switch (searchBy)
            {
                case "Company":
                    {
                        log.Info("Search the company : " + searchText);
                        driver.SwitchTo().DefaultContent();
                        uf.switchToFrameByElement(driver, wait, "RightPane");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtCompanySearch));
                        driver.FindElement(txtCompanySearch).Clear();
                        driver.FindElement(txtCompanySearch).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;
                case "Town":
                    {
                        log.Info("Search the company by town : " + searchText);
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtTown));
                        driver.FindElement(txtTown).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;
                case "PostalCode":
                    {
                        log.Info("Search the company by Postal Code: " + searchText);
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtPostalCode));
                        driver.FindElement(txtPostalCode).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;


                case "Country":
                    {
                        log.Info("Search the company by Country: " + searchText);
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(ddCountry));
                        IWebElement ddlCountry = driver.FindElement(ddCountry);
                        SelectElement countries = new SelectElement(ddlCountry);
                        countries.SelectByText("United States");
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;


                case "TelephoneNumber":
                    {
                        log.Info("Search the company by Telephone Number: " + searchText);
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtTel));
                        driver.FindElement(txtTel).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "CompanyType":
                    {
                        log.Info("Search the company by CompanyType: " + searchText);

                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(ddCountry));
                        IWebElement ddlCompanyType = driver.FindElement(ddCompanyType);
                        SelectElement companyType = new SelectElement(ddlCompanyType);
                        companyType.SelectByText("Advertiser");
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Active":
                    {
                        log.Info("Search the active companies");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(chkActive));
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Inactive":
                    {
                        log.Info("Search In Active companies");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(chkActive));
                        driver.FindElement(chkActive).Click();
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

            }
        }
        
        //Below function opens the first booking record of the company
        public void openCompanyRecord()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SearchxresultsGrid_r_0")));
            driver.FindElements(lnkCompanyRecord)[0].Click();
            //driver.SwitchTo().DefaultContent();
        }

        public void verifyContactManagementScreen()
        {

            log.Info("Verifying Search Criteria");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");
            wait.Until(ExpectedConditions.ElementIsVisible(titleContactManagementScreen));
            Assert.AreEqual("Contact Management", driver.FindElement(titleContactManagementScreen).Text);
            //driver.SwitchTo().DefaultContent();
        }        

        public void clickSearchButtonInHeader()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnSearchInHeader));
            driver.FindElement(btnSearchInHeader).Click();            
        }
        
        public void clickStationeryButtonInHeader()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnStationeryInHeader));
            driver.FindElement(btnStationeryInHeader).Click();
        }

        public void clickActiveCheckbox()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnActiveInActive));
            driver.FindElement(btnActiveInActive).Click();
        }        

        public void verifyStationeryPopupDetails()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(btnclose));

            Assert.AreEqual(true, driver.FindElement(btnclose).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddLetter).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnEmail).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);
        }

        public void verifyActiveCheckboxFunctionality()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnActiveInActive));
            Assert.AreEqual("Inactive", driver.FindElement(btnActiveInActive).GetAttribute("value").ToString());
        }
        
        public void navigateToAttachmentsTab()
        {
            log.Info("Navigate to Attachments tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabAttachments));
            driver.FindElement(tabAttachments).Click();
        }

        public void verifySearchCriteria()
        {

            log.Info("Verifying Search Criteria");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            wait.Until(ExpectedConditions.ElementIsVisible(ddSearchFor));

            Assert.AreEqual(true, driver.FindElement(ddSearchFor).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSiteDisplayMode).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSaveResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOpenResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanySearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCompanyType).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearchGo).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCompany).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSiteId).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdd1).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdd2).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderRegion).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCompanyType).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAgencyType).Displayed);
        }

        public void verifySearchCriteriaViaContacts()
        {

            log.Info("Verifying Search Criteria");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            wait.Until(ExpectedConditions.ElementIsVisible(ddSearchFor));

            Assert.AreEqual(true, driver.FindElement(ddSearchFor).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSiteDisplayMode).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSaveResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOpenResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanySearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCountryViaContacts).Displayed);            
            Assert.AreEqual(true, driver.FindElement(chkActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearchGo).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderFirstName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderJobTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderContactCompany).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderLocation).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderContactTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderFax).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderEmail).Displayed);
            
        }

        public void navigateToNewCompanyCreation()
        {

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            //uf.switchToFrameByElement(driver, wait, "ifrSelection");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyNewButton));
            driver.FindElement(ingentaCompanyNewButton).Click();
            driver.SwitchTo().DefaultContent();
        }

        public void verifySearchedCompany(string searchText, string searchBy)
        {
            switch (searchBy)
            {
                case "Company":
                    StringAssert.Contains(searchText, driver.FindElements(lnkCompanyRecord)[3].Text);
                    break;
                case "PostalCode":
                    Assert.AreEqual(searchText, driver.FindElements(lnkCompanyRecord)[13].Text.Trim());
                    break;
                case "Town":
                    Assert.AreEqual(searchText, driver.FindElements(lnkCompanyRecord)[11].Text.Trim());
                    break;
                case "TelephoneNumber":
                    Assert.AreEqual(searchText, driver.FindElements(lnkCompanyRecord)[5].Text.Trim());
                    break;
                case "Country":
                    Assert.AreEqual(searchText, driver.FindElements(lnkCompanyRecord)[14].Text.Trim());
                    break;
                case "CompanyType":
                    Assert.AreEqual(searchText, driver.FindElements(lnkCompanyRecord)[15].Text.Trim());
                    break;
                case "Active":
                    openCompanyRecord();
                    driver.SwitchTo().DefaultContent();
                    uf.switchToFrameByElement(driver, wait, "RightPane");
                    uf.switchToFrameByElement(driver, wait, "ifrDetail");
                    Assert.AreEqual("Active", driver.FindElement(buttonActiveInactive).GetAttribute("value").ToString());
                    break;
                case "Inactive":
                    openCompanyRecord();
                    driver.SwitchTo().DefaultContent();
                    uf.switchToFrameByElement(driver, wait, "RightPane");
                    uf.switchToFrameByElement(driver, wait, "ifrDetail");
                    Assert.AreEqual("Inactive", driver.FindElement(buttonActiveInactive).GetAttribute("value").ToString());
                    break;
            }
        }

        public void verifyNonExistingSearchedCompany()
        {

            int rowCount = driver.FindElements(By.XPath("//table[@id='SearchxresultsGrid_main']/tbody/tr")).Count;

            Assert.That(rowCount - 1, Is.EqualTo(0));
        }

        public int GetNumberOfRowsInTable(string tableId)
        {
            ReadOnlyCollection<IWebElement> table = driver.FindElements(By.Id(tableId));

            return table
                .Select(webElement => webElement.FindElements(By.XPath("//tr")))
                .Select(rows => rows.Count)
                .FirstOrDefault();
        }

        public void verifySearchPageElements()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));
            bool txtCN = driver.FindElement(txtCompanyName).Displayed;
            Assert.AreEqual(txtCN, true);

            bool txtTwn = driver.FindElement(txtTown).Displayed;
            Assert.AreEqual(txtTwn, true);

            bool txtPC = driver.FindElement(txtPostalCode).Displayed;
            Assert.AreEqual(txtPC, true);

            bool txtTele = driver.FindElement(txtTelephone).Displayed;
            Assert.AreEqual(txtTele, true);

            bool ddCoun = driver.FindElement(ddCountry).Displayed;
            Assert.AreEqual(ddCoun, true);

            bool ddCT = driver.FindElement(ddCompanyType).Displayed;
            Assert.AreEqual(ddCT, true);

            bool cbIA = driver.FindElement(cbIsActive).Displayed;
            Assert.AreEqual(cbIA, true);

            bool btnSrch = driver.FindElement(btnSearchGo).Displayed;
            Assert.AreEqual(btnSrch, true);
        }

        public void companySearch()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");
            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));
            driver.FindElement(txtCompanyName).SendKeys(companyName);
            driver.FindElement(btnSearchGo).Click();
        }

        public void verifySearchPage()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyNewButton));
            bool tabSC = driver.FindElement(tableSearchCompany).Displayed;
            Assert.AreEqual(tabSC, true);
        }


        public void selectSearchForDropdown()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");
            wait.Until(ExpectedConditions.ElementIsVisible(ddSearchFor));

            SelectElement selectSearchFor = new SelectElement(driver.FindElement(ddSearchFor));
            selectSearchFor.SelectByText("Company");
        }

        public void verifySearchForDropDown()
        {

            var searchForSelected = driver.FindElement(ddSearchFor);
            var sfSel = new SelectElement(searchForSelected);
            var sfs = sfSel.SelectedOption;
            string selectedSearchFor = sfs.Text;
            Assert.AreEqual("Company", selectedSearchFor);

        }

        public void verifySearchPageElementsWithSearchResultButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));
            bool txtCN = driver.FindElement(txtCompanyName).Displayed;
            Assert.AreEqual(txtCN, true);

            bool txtTwn = driver.FindElement(txtTown).Displayed;
            Assert.AreEqual(txtTwn, true);

            bool txtPC = driver.FindElement(txtPostalCode).Displayed;
            Assert.AreEqual(txtPC, true);

            bool txtTele = driver.FindElement(txtTelephone).Displayed;
            Assert.AreEqual(txtTele, true);

            bool ddCoun = driver.FindElement(ddCountry).Displayed;
            Assert.AreEqual(ddCoun, true);

            bool ddCT = driver.FindElement(ddCompanyType).Displayed;
            Assert.AreEqual(ddCT, true);

            bool cbIA = driver.FindElement(cbIsActive).Displayed;
            Assert.AreEqual(cbIA, true);

            bool btnSrch = driver.FindElement(btnSearchGo).Displayed;
            Assert.AreEqual(btnSrch, true);

            Assert.AreEqual(true, driver.FindElement(btnStationeryReport).Displayed);
        }

        #endregion


    }
}

