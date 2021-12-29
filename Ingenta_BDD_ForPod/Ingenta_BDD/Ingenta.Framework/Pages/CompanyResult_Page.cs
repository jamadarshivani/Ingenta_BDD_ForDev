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
    [TestFixture, Description("This is a page object for Company Result Page")]
   public class CompanyResult_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyResult_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
           
        }


        By tabContact = By.Id("iglbarMenu_0_Item_3");
        By lnkAnna = By.CssSelector("#FFCompanyContact_grdCompanyContacts_ctl00__1 > td");
        By tabHistory = By.Id("iglbarMenu_0_Item_1");
        By btnNewBooking = By.Id("FFHistory_ibtnAddBooking");

        #region Object Repository

        By btnInformation = By.Id("iglbarMenu_0_Item_0");

        By btnHierarchies = By.Id("iglbarMenu_0_Item_1");

        By btnHistory = By.Id("iglbarMenu_0_Item_2");

        By btnContacts = By.Id("iglbarMenu_0_Item_3");

        By btnBrands = By.Id("iglbarMenu_0_Item_4");

        By btnRelationships = By.Id("iglbarMenu_0_Item_5");

        By btnNotes = By.Id("iglbarMenu_0_Item_6");

        By btnExternalRef = By.Id("iglbarMenu_0_Item_7");

        By Attachements = By.Id("iglbarMenu_0_Item_8");

        By btnOpportunities = By.Id("iglbarMenu_1_Item_0");

        By btnResponsiblities = By.Id("iglbarMenu_1_Item_1");

        By btnSalesAssignment = By.Id("iglbarMenu_1_Item_2");

        By btnTerritories = By.Id("iglbarMenu_1_Item_3");

        By btnAdTemplates = By.Id("iglbarMenu_1_Item_4");

        By btnFinance = By.Id("iglbarMenu_2_Item_0");

        By btnLetterOfIntent = By.Id("iglbarMenu_2_Item_1");

        By btnElectronicsClassification = By.Id("iglbarMenu_3_Item_0");

        By btnCompanyInfo = By.Id("iglbarMenu_3_Item_1");

        By btnSave = By.Id("btnSave");

        By btnSaveAndClose = By.Id("btnSaveClose");

        By btnClose = By.Id("btnClose");
        #endregion


        #region Functions        

        //Following function performs navigation to Contacts Tab
        public void navigateToContactTab()
        {
            log.Info("Navigate to Contact tab");

            uf.switchToFrameByElement(driver,wait,"RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
          
            wait.Until(ExpectedConditions.ElementExists(tabContact));
      
            driver.FindElement(tabContact).Click();
            
        }

        //Following function performs selection of the specific contact
        public void enterCompanyInformation()
        {
            log.Info("Selecting  Contact : Anna");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(lnkAnna));
            driver.FindElements(lnkAnna)[0].Click();

            driver.SwitchTo().DefaultContent();

        }
        //Following function performs navigation to History Tab
        public void navigateToHistoryTab()
        {
            log.Info("Navigate to History tab");

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(tabHistory));

            driver.FindElement(tabHistory).Click();
         

        }

        //Following function performs clicking of New Booking button
        public void clickNewBooking()
        {
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNewBooking));
            driver.FindElement(btnNewBooking).Click();
            Thread.Sleep(2000);
        }

        public void selectContactAnna()
        {
            log.Info("Selecting  Contact : Anna");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(lnkAnna));
            driver.FindElements(lnkAnna)[0].Click();
            driver.SwitchTo().DefaultContent();
        }


        public void LeftTabsEnabled()
        {
            Assert.AreEqual(true, driver.FindElement(btnInformation).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnHierarchies).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnHistory).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnContacts).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnBrands).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnRelationships).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnNotes).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnExternalRef).Enabled);
            Assert.AreEqual(true, driver.FindElement(Attachements).Enabled);

            Assert.AreEqual(true, driver.FindElement(btnOpportunities).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnResponsiblities).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnSalesAssignment).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnTerritories).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnAdTemplates).Enabled);

            Assert.AreEqual(true, driver.FindElement(btnFinance).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnLetterOfIntent).Enabled);

            Assert.AreEqual(true, driver.FindElement(btnElectronicsClassification).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCompanyInfo).Enabled);

        }

        #endregion

    }
}
