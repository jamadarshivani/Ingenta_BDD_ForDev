using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Contacts Landing Page")]
    public class Contacts_SearchContact
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Contacts_SearchContact(IWebDriver driver, WebDriverWait wait)
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
        By btnOpenSelection = By.Id("Search_SearchBar_btnOpenResults");
        By txtLastName = By.Id("Search_FieldSelect0_txtValue1");
        By txtFirstName = By.Id("Search_FieldSelect2_txtValue1");
        By txtJobTitle = By.Id("Search_FieldSelect3_txtValue1");
        By txtEmail = By.Id("Search_FieldSelect4_txtValue1");
        By txtTelephone = By.Id("Search_FieldSelect5_txtValue1");
        By txtContactName = By.Id("Search_FieldSelect6_txtValue1");
        By txtPostCode = By.Id("Search_FieldSelect7_txtValue1");
        By ddCountry = By.Id("Search_FieldSelect8_lstValues1");
        By chkActive = By.Id("Search_FieldSelect9_checkBox");
        By btnSearch = By.XPath("//*[@id='Search_GoButton']");
        By btnOpenRecord = By.Id("SearchxresultsGrid_rc_0_0");
        By btnSearchGo = By.Id("Search_GoButton");
        By lnkContactRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By txtCompanyName = By.Id("Search_FieldSelect6_txtValue1");
        By buttonActiveInactive = By.Id("btnPersonStatus");
        #endregion

        #region Functions

        //below method will verify landing Page Details of Contacts
        public void SearchContactaAndSelectRecordFromGrid()
        {
            try
            {
                log.Info("Search Contacts and Select Record from Grid");
                driver.SwitchTo().DefaultContent();
                uf.switchToFrameByElement(driver, wait, "RightPane");
                uf.switchToFrameByElement(driver, wait, "ifrSelection");

                wait.Until(ExpectedConditions.ElementExists(btnSearch));
                wait.Until(ExpectedConditions.ElementIsVisible(btnSearch));
                driver.FindElement(btnSearch).Click();

                wait.Until(ExpectedConditions.ElementIsVisible(btnOpenRecord));
                driver.FindElement(btnOpenRecord).Click();

            }
            catch (Exception ex)
            {
                log.Info(ex.Message + "\n");
                log.Info(ex.StackTrace);
                Assert.Fail("Test Failed...");
            }
        }

        public void VerifyContactDetailsFields()
        {
            try
            {
                log.Info("Verify Contact Details Fields");
                driver.SwitchTo().DefaultContent();
                uf.switchToFrameByElement(driver, wait, "RightPane");
                uf.switchToFrameByElement(driver, wait, "ifrSelection");

                wait.Until(ExpectedConditions.ElementExists(btnSearch));
                wait.Until(ExpectedConditions.ElementIsVisible(btnSearch));
                driver.FindElement(btnSearch).Click();

                wait.Until(ExpectedConditions.ElementIsVisible(btnOpenRecord));
                driver.FindElement(btnOpenRecord).Click();

            }
            catch (Exception ex)
            {
                log.Info(ex.Message + "\n");
                log.Info(ex.StackTrace);
                Assert.Fail("Test Failed...");
            }
        }

        public void searchForContact(string searchText, string searchBy)
        {

            switch (searchBy)
            {

                case "LastName":
                    {
                        log.Info("Searching contact by LastName");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtLastName));
                        driver.FindElement(txtLastName).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;


                case "FirstName":
                    {
                        log.Info("Searching contact by FirstName");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtFirstName));
                        driver.FindElement(txtFirstName).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;
                case "JobTitle":
                    {
                        log.Info("Searching contact by JobTtile");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtJobTitle));
                        driver.FindElement(txtJobTitle).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "E-Mail":
                    {
                        log.Info("Searching contact by E - Mail");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtEmail));
                        driver.FindElement(txtEmail).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Telephone":
                    {
                        log.Info("Searching contact by Telephone");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtTelephone));
                        driver.FindElement(txtTelephone).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;
                case "Company":
                    {
                        log.Info("Searching contact by Company Name");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));
                        driver.FindElement(txtCompanyName).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "PostalCode":
                    {
                        log.Info("Searching contact by Postal Code");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(txtPostCode));
                        driver.FindElement(txtPostCode).SendKeys(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Country":
                    {
                        log.Info("Searching contact by Country");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(ddCountry));
                        IWebElement ddCountry1 = driver.FindElement(ddCountry);
                        SelectElement country = new SelectElement(ddCountry1);
                        country.SelectByText(searchText);
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Active":
                    {
                        log.Info("Search the active Contacts");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(chkActive));
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

                case "Inactive":
                    {
                        log.Info("Search In Active Contacts");
                        uf.switchToFrameByElement(driver, wait, "ifrSelection");
                        wait.Until(ExpectedConditions.ElementIsVisible(chkActive));
                        driver.FindElement(chkActive).Click();
                        driver.FindElement(btnSearchGo).Click();
                    }
                    break;

            }
        }

        public void verifySearchedContact(string searchText, string searchBy)
        {
            switch (searchBy)
            {
                case "LastName":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[4].Text.Trim());
                    break;
                case "FirstName":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[5].Text.Trim());
                    break;
                case "JobTitle":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[7].Text.Trim());
                    break;
                case "E-Mail":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[19].Text.Trim());
                    break;
                case "Telephone":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[17].Text.Trim());
                    break;
                case "Company":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[10].Text.Trim());
                    break;
                case "PostalCode":
                    Assert.AreEqual(searchText, driver.FindElements(lnkContactRecord)[14].Text.Trim());
                    break;
                case "Country":
                    Assert.AreEqual(true, (driver.FindElements(lnkContactRecord).Count > 0));
                    break;
                case "Active":
                    openContact();
                    driver.SwitchTo().DefaultContent();
                    uf.switchToFrameByElement(driver, wait, "RightPane");
                    uf.switchToFrameByElement(driver, wait, "ifrDetail");
                    Assert.AreEqual("Active", driver.FindElement(buttonActiveInactive).GetAttribute("value").ToString());
                    break;
                case "Inactive":
                    openContact();
                    driver.SwitchTo().DefaultContent();
                    uf.switchToFrameByElement(driver, wait, "RightPane");
                    uf.switchToFrameByElement(driver, wait, "ifrDetail");
                    Assert.AreEqual("Inactive", driver.FindElement(buttonActiveInactive).GetAttribute("value").ToString());
                    break;
            }
        }

        public void openContact()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("SearchxresultsGrid_r_0")));
            driver.FindElements(lnkContactRecord)[0].Click();
        }

        #endregion

    }
}
