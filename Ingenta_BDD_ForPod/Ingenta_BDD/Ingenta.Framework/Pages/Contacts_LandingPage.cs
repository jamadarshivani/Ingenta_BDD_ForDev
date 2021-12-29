using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Contacts Landing Page")]
    public class Contacts_LandingPage
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Contacts_LandingPage(IWebDriver driver, WebDriverWait wait)
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
        By txtCompanyName = By.Id("Search_FieldSelect6_txtValue1");
        By txtPostCode = By.Id("Search_FieldSelect7_txtValue1");
        By ddCountry = By.Id("Search_FieldSelect8_lstValues1");
        By chkActive = By.Id("Search_FieldSelect9_checkBox");
        By btnSearch = By.Id("Search_GoButton");

        #endregion

        #region Functions

        //below method will verify landing Page Details of Contacts
        public void verifyContactLandingPageDetails()
        {
            try
            {
                log.Info("Verify Contacts Landing Page");
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
            catch (Exception ex)
            {
                log.Info(ex.Message + "\n");
                log.Info(ex.StackTrace);
                Assert.Fail("Test Failed...");
            }
        }

        #endregion

    }
}
