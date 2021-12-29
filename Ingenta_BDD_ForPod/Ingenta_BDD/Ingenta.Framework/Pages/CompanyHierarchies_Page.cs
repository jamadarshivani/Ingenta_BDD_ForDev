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
    public class CompanyHierarchies_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyHierarchies_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By tabHierarchies = By.Id("iglbarMenu_0_Item_1");
        By btnSaveAndClose = By.Id("btnSaveClose");
        By btnSave = By.Id("btnSave");
        By btnOverride = By.Id("btnOverride");
        By btnCreateNewHierarchy = By.Id("_btnToTop");
        By btnMove = By.Id("_btnToSelected");
        By btnReportLevel = By.Id("_btnReportLevel");
        By ddHierarchy = By.Id("_ddCompanyHierarchy");
        By txtUltimateParent = By.Id("_txtUltParent");
        By txtCompany = By.XPath("//*[@id='_treeHierarchy']/input[1]");
        By txtCompanyName = By.Id("x:1205292394.2:mkr:dtnContent");

        By btnCompany = By.Id("_btnDetails");

        By ddHierarchyType = By.Id("ddlHierarchyType");
        By ddRelationShip = By.Id("ddlRelationship");
        By txtSearch = By.Id("txtSearchText");
        By btnFind = By.Id("btnFind");
        By txtMultiline = By.Id("wdtHierarchyTree");
        By btnDetails = By.Id("btnDetails");
        By btnSelect = By.Id("btnSelect");

        #endregion

        #region Functions
        //Following function performs navigation to Hierarchies Tab
        public void navigateToHierarchiesTab()
        {
            log.Info("Navigate to Hierarchies tab");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabHierarchies));
            driver.FindElement(tabHierarchies).Click();
        }

        public void ClickSave()
        {
            log.Info("Save Record");
            wait.Until(ExpectedConditions.ElementExists(btnSave));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));
            Assert.AreEqual(true, driver.FindElement(btnSave).Displayed);
            driver.FindElement(btnSave).Click();
            Thread.Sleep(2000);

        }

        public void clickOverride()
        {
            if (uf.IsElementDisplayed(driver, btnOverride))
            {
                log.Info("Click on override");
                wait.Until(ExpectedConditions.ElementExists(btnOverride));
                wait.Until(ExpectedConditions.ElementIsVisible(btnOverride));
                Assert.AreEqual(true, driver.FindElement(btnOverride).Displayed);
                driver.FindElement(btnOverride).Click();
            }
        }

        public void ClickCreateNewHierarchy()
        {
            log.Info("Click on Create New Hierarchy");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            log.Info("Click on Create New Hierarchy");
            wait.Until(ExpectedConditions.ElementExists(btnCreateNewHierarchy));
            wait.Until(ExpectedConditions.ElementIsVisible(btnCreateNewHierarchy));
            Assert.AreEqual(true, driver.FindElement(btnCreateNewHierarchy).Displayed);
            driver.FindElement(btnCreateNewHierarchy).Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        public void verifyHierarchiesDetails()
        {
            log.Info("Verifying Hierarchies tab details");

            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementExists(btnCreateNewHierarchy));

            Assert.AreEqual(true, driver.FindElement(btnCreateNewHierarchy).Displayed);            
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnMove), driver));            
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(btnReportLevel).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(txtUltimateParent).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true, driver.FindElement(ddHierarchy).Displayed);
            Assert.AreEqual(true.ToString().ToUpper(), driver.FindElement(txtCompany).GetAttribute("readonly").Trim().ToUpper());
            Assert.AreEqual(true, driver.FindElement(btnCompany).Displayed);
        }

        public void clickCreateNewAndOk()
        {
            log.Info("Create new button clicked");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementExists(btnCreateNewHierarchy));
            wait.Until(ExpectedConditions.ElementIsVisible(btnCreateNewHierarchy));
            driver.FindElement(btnCreateNewHierarchy).Click();
            driver.SwitchTo().Alert().Accept();
        }

        public void verifyUltimateParent(string companyName)
        {
            log.Info("Verifying Ultimate Parent");
            wait.Until(ExpectedConditions.ElementExists(txtUltimateParent));
            Thread.Sleep(2000);
            Assert.AreEqual(companyName, driver.FindElement(txtUltimateParent).GetAttribute("value"));
        }

        public void verifyCompanyText(string companyName)
        {
            log.Info("Verifying Ultimate Parent");
            wait.Until(ExpectedConditions.ElementExists(txtCompanyName));
            Assert.AreEqual(companyName, driver.FindElement(txtCompanyName).Text);
        }

        public void verifyStateOfCreateNewButton()
        {
            log.Info("Verifying Create New Buttton State");
            wait.Until(ExpectedConditions.ElementExists(btnCreateNewHierarchy));
            Assert.AreEqual(false, driver.FindElement(btnCreateNewHierarchy).Enabled);
        }

        public void verifyStateOfMoveButton()
        {
            log.Info("Verifying Move Buttton State");
            wait.Until(ExpectedConditions.ElementExists(btnMove));
            Assert.AreEqual(true, driver.FindElement(btnMove).Enabled);
        }


        public void clickMove()
        {
            wait.Until(ExpectedConditions.ElementExists(btnMove));
            driver.FindElement(btnMove).Click();
        }


        public void verifyCompanySearchByHierarchyDetails()
        {
            log.Info("Verifying Company Search By Hierarchy Page Details");
            uf.switchToFrameByName(driver, wait, "popSearchByHierarchy");

            wait.Until(ExpectedConditions.ElementExists(ddHierarchyType));

            Assert.AreEqual(false, driver.FindElement(ddHierarchyType).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddRelationShip).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFind).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtMultiline).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDetails).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSelect).Displayed);
        }

        #endregion

    }
}
