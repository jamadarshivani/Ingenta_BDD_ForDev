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
    public class CompanyExternalReferences_Page
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyExternalReferences_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By tabExternalReferences = By.Id("iglbarMenu_0_Item_7");

        By btnSave = By.Id("FFExternalSourceList_btnSave");
        By tableHeaderSource = By.Id("FFExternalSourceListxgrdExternalSource_c_0_1");
        By tableHeaderExtRef = By.Id("FFExternalSourceListxgrdExternalSource_c_0_2");
        

        By gridDynamics = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(1) > td:nth-child(2)");
        By gridSalesForce = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(2) > td:nth-child(2)");
        By gridIntegerationX = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(3) > td:nth-child(2)");
        By gridChaseLockBox = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(4) > td:nth-child(2)");
        By gridLGA = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(5) > td:nth-child(2)");
        By gridDFP = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > tbody > tr:nth-child(6) > td:nth-child(2)");
        By gridSource = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > thead > tr > th:nth-child(2)");
        By gridExternalReference = By.CssSelector("table#G_FFExternalSourceListxgrdExternalSource > thead > tr > th:nth-child(3)");


        #endregion Object Repository

        #region Functions
        public void navigateToExternalReference()
        {

            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(tabExternalReferences));
            wait.Until(ExpectedConditions.ElementToBeClickable(tabExternalReferences));
            driver.FindElement(tabExternalReferences).Click();
        }

        public void verifyExternalRefTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));

            Assert.AreEqual(true, driver.FindElement(btnSave).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSource).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderExtRef).Displayed);        
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

        #endregion Functions
    }
}

