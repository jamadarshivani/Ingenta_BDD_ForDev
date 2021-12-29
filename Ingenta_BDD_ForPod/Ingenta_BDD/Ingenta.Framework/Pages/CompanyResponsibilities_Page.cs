
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using Utility_Classes;


namespace Ingenta.Framework.Pages
{
    public class CompanyResponsibilities_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyResponsibilities_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Variables       
        #endregion Variables

        #region Object Repository

        By tabResponsibilities = By.Id("iglbarMenu_1_Item_1");
        By tabResponsibilitiesFromContacts = By.Id("iglbarMenu_0_Item_2");        

        By btnNewResponsibilities = By.Id("FFResponsibilityList_btnAddResponsibility");
        By btnDeleteREsponsibilities = By.Id("FFResponsibilityList_btnDeleteResponsibility");

        By tableTelephone = By.CssSelector("td.ig_5aac757b_r1.GridRow.UltraWebGridRow.ig_5aac757b_rc118.FormGridCellText > nobr");
        By tableLastName = By.CssSelector("td.ig_5aac757b_r1.GridRow.UltraWebGridRow.ig_5aac757b_rc15.FormGridCellText > nobr");
        By tableCompanyName = By.CssSelector("td.ig_5aac757b_r1.GridRow.UltraWebGridRow.ig_5aac757b_rc111.FormGridCellText > nobr");        
        By tableEmail = By.CssSelector("td.ig_5aac757b_r1.GridRow.UltraWebGridRow.ig_5aac757b_rc120.FormGridCellText > nobr");

        By tableHeaderEditButton = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_0");
        By tableHeaderRole = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_1");
        By tableHeaderName = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_2");
        By tableHeaderTelephone = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_3");
        By tableHeaderContactName = By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_4");
        By tableHeaderMedia= By.Id("FFResponsibilityListxgrdCompanyResponsibilities_c_0_5");


        By txtContactName = By.Id("txtContactName");
        By btnContactNameEllipsis = By.Id("ctlModalContact_btnModal");
        By ddUserName = By.Id("ddlUserName");
        By ddRole = By.Id("ddlRole");
        By ddMedia = By.Id("ddlMedium");

        By txtLastName = By.Id("Search_FieldSelect0_txtValue1");
        By txtCompanyNameEllipsis = By.Id("Search_FieldSelect2_txtValue1");
        By txtTelephone = By.Id("Search_FieldSelect3_txtValue1");
        By txtEmail = By.Id("Search_FieldSelect4_txtValue1");
        By btnSearch = By.Id("Search_GoButton");

        By btnViewThisOpportunity = By.CssSelector("input.ig_4f900e21_rcb1112.ResponsibilityTrans");
        By btnCancel = By.Id("btnCancel");
        By btnSave = By.Id("btnSave");
        By btnSelectContact = By.CssSelector("input.ig_5aac757b_rcb1112.SelectionSearch.btnOpenContact");

        By tableRole = By.CssSelector("td.ig_4f900e21_r1.GridRow.UltraWebGridRow.FormGridCellText:nth-child(2) > nobr");
        By tableName = By.CssSelector("td.ig_4f900e21_r1.GridRow.UltraWebGridRow.FormGridCellText:nth-child(3) > nobr");
        By tableContactName = By.CssSelector("td.ig_4f900e21_r1.GridRow.UltraWebGridRow.FormGridCellText:nth-child(5) > nobr");
        By tableMedia = By.CssSelector("td.ig_4f900e21_r1.GridRow.UltraWebGridRow.FormGridCellText:nth-child(6) > nobr");

        By tabRole = By.CssSelector("td.ig_4f900e21_r1.GridRow.UltraWebGridRow.FormGridCellText");
        By btnDeleteResponsibilities = By.Id("FFResponsibilityList_btnDeleteResponsibility");

        #endregion Object Repository

        #region Functions

        public void navigateToResponsibilitiesTab(string navigatedFrom)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            if (navigatedFrom == "Company")
            {
                wait.Until(ExpectedConditions.ElementExists(tabResponsibilities));
                driver.FindElement(tabResponsibilities).Click();
            }
            else
            {
                wait.Until(ExpectedConditions.ElementExists(tabResponsibilitiesFromContacts));
                driver.FindElement(tabResponsibilitiesFromContacts).Click();
            }

        }

        public void verifyResponsibilitiesTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewResponsibilities));

            Assert.AreEqual(true, driver.FindElement(btnNewResponsibilities).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteREsponsibilities).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderEditButton).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderTelephone).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderContactName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderMedia).Displayed);            
        }


        public void clickNewResponsibilityButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewResponsibilities).Click();
        }

        public void verifyNewResponsibilityButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");

            Assert.AreEqual(true, driver.FindElement(btnContactNameEllipsis).Displayed);

            var usernameSelected = driver.FindElement(ddUserName);
            var unSel = new SelectElement(usernameSelected);
            var uns = unSel.SelectedOption;
            string selectedUsername = uns.Text;
            Assert.AreEqual("David Beckham (Super User)", selectedUsername);
            Assert.AreEqual(true, driver.FindElement(ddRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddMedia).Displayed);
        }

        public void clickContactNameEllipsisButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");
              
            driver.FindElement(btnContactNameEllipsis).Click();
        }

        public void verifyContactNameEllipsisDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            Assert.AreEqual(true, driver.FindElement(txtLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanyNameEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTelephone).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtEmail).Displayed);
        }

        public void selectContactFromEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(btnSelectContact).Click();
        }

        public void selectRole()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Client Management");

        }

        public void selectMedia()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");

            SelectElement selectMedia = new SelectElement(driver.FindElement(ddMedia));
            selectMedia.SelectByText("Daily Gazette");
        }

        public void clickSaveButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");

            driver.FindElement(btnSave).Click();
        }

        public void verifyResponsibilityIsSavedSuccessfullyFromContact()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("Client Management", driver.FindElement(tableRole).Text);
            Assert.AreEqual("David Beckham (Super User)", driver.FindElement(tableName).Text);
            Assert.AreEqual("Mr Peter Pendlebury", driver.FindElement(tableContactName).Text);
            Assert.AreEqual("Daily Gazette", driver.FindElement(tableMedia).Text);
        }



        public void selectResponsibility()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(tabRole).Click();
        }

        public void verifyResponsibilityIsSavedSuccessfully(string CompanyOrContact)
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("Client Management", driver.FindElement(tableRole).Text);
            Assert.AreEqual("David Beckham (Super User)", driver.FindElement(tableName).Text);
            if(CompanyOrContact == "Contact")
                Assert.AreEqual("Mr Peter Pendlebury", driver.FindElement(tableContactName).Text);
            else
                Assert.AreEqual("Mr Michael Peter", driver.FindElement(tableContactName).Text);
            Assert.AreEqual("Daily Gazette", driver.FindElement(tableMedia).Text);
        }

        public void deleteResponsibility()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnDeleteResponsibilities).Click();
        }

        public void verifyResponsibilityIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            uf.IsElementPresent(driver, tabRole, 60);
        }


        public void searchTelephoneInEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(txtTelephone).SendKeys("011-2563247");
            driver.FindElement(btnSearch).Click();
        }

        public void searchEmailInEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(txtEmail).SendKeys("Micheal.peter@email.com");
            driver.FindElement(btnSearch).Click();
        }

        public void verifyTelephone()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            wait.Until(ExpectedConditions.ElementIsVisible(tableTelephone));
            Assert.AreEqual("011-2563247", driver.FindElement(tableTelephone).Text);
        }


        public void verifyEmail()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            wait.Until(ExpectedConditions.ElementIsVisible(tableEmail));
            Assert.AreEqual("Micheal.peter@email.com", driver.FindElement(tableEmail).Text);
        }

        public void clickViewThisResponsibilityButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnViewThisOpportunity).Click();
        }

        public void clickCancelButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.switchToFrameByName(driver, wait, "RadEditResponsibility1");

            driver.FindElement(btnCancel).Click();
        }


        public void searchLastNameInEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(txtLastName).SendKeys("Peter");
            driver.FindElement(btnSearch).Click();
        }

        public void searchCompanyNameInEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(txtCompanyNameEllipsis).SendKeys("TestCompany1234");
            driver.FindElement(btnSearch).Click();
        }


        public void verifyLastName()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");            
            Assert.AreEqual("Peter", driver.FindElement(tableLastName).Text);
        }

        public void verifyCompanyName()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyName));
            Assert.AreEqual("TestCompany1234", driver.FindElement(tableCompanyName).Text);
        }

        #endregion Functions
    }
}
