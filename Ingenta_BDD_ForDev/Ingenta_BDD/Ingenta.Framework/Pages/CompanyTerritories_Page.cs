
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using Utility_Classes;


namespace Ingenta.Framework.Pages
{
    public class CompanyTerritories_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyTerritories_Page(IWebDriver driver, WebDriverWait wait)
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

        By tabTerritories = By.Id("iglbarMenu_1_Item_3");

        By btnNewTerritories = By.Id("FFCompanyTerritoryList_btnAddTerritory");
        By ddAdType = By.Id("ddlAdTypeType");
        By ddSalesTerritory = By.Id("ddlSalesTerritory");
        By btnDeleteTerritories = By.Id("FFCompanyTerritoryList_btnDeleteTerritory");
        By btnRequest = By.Id("ffListAssignment_btnRequest");

        By tableHeaderSalesTerritory = By.Id("FFCompanyTerritoryListxgrdTerritory_c_0_5");
        By tableHeaderAdTypeGroup = By.Id("FFCompanyTerritoryListxgrdTerritory_c_0_7");
        By tableHeaderWorldRegion = By.Id("FFCompanyTerritoryListxgrdTerritory_c_0_9");
        
        #endregion Object Repository

        #region Functions

        public void navigateToTerritoriesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabTerritories));
            driver.FindElement(tabTerritories).Click();
        }

        public void verifyTerritoriesTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewTerritories));            

            Assert.AreEqual(true, driver.FindElement(btnNewTerritories).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteTerritories).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSalesTerritory).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdTypeGroup).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderWorldRegion).Displayed);
            
        }
        public void clickOnNewButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewTerritories));
            driver.FindElement(btnNewTerritories).Click();
        }


        public void verifyNewTerritoriesDetails()
        {
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(ddAdType));
            Assert.AreEqual(true, driver.FindElement(ddAdType).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddSalesTerritory).Displayed);
        }

        #endregion Functions
    }
}
