
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using Utility_Classes;


namespace Ingenta.Framework.Pages
{
    public class CompanyUserForms_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyUserForms_Page(IWebDriver driver, WebDriverWait wait)
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

        By tabUserForms = By.Id("iglbarMenu_3_Item_0");
        By tabPriceUserForm = By.Id("iglbarMenu_1_Item_0");
        

        By btnSaveUserForms = By.Id("ucDemographics_btnSave");
        By btnResetUserFormst = By.Id("ucDemographics_btnReset");
        By btnDeleteUserFormst = By.Id("ucDemographics_btnDelete");

        By btnElectronicsClassfication = By.Id("iglbarMenu_3_Item_0");
        By hdrElectronicsClassfication = By.Id("ucDemographics_lblDemographics");
        By tbHeading = By.Id("ucDemographics_QUESTION2");
        By tbTelephone = By.Id("ucDemographics_QUESTION3");
        By txtDesc = By.Id("ucDemographics_QUESTION5");
        
        By btnSave = By.Id("ucDemographics_btnSave");
        By btnReset = By.Id("ucDemographics_btnReset");
        By btnDelete = By.Id("ucDemographics_btnDelete");

        #endregion Object Repository

        #region Functions

        public void navigateToUserFormsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabUserForms));
            driver.FindElement(tabUserForms).Click();
        }

        public void verifyUserFormsTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveUserForms));

            Assert.AreEqual(true, driver.FindElement(btnSaveUserForms).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnResetUserFormst).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteUserFormst).Displayed);
        }



        public void navigateToElectronicsClassification()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnElectronicsClassfication).Click();
        }

        public void navigateToPriceUserForm()
        {   
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(tabPriceUserForm).Click();
        }

        public void verifyElectronicsClassificationTab(string ElectronicOrPrice)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            if (ElectronicOrPrice == "Electronic")
            {
                Assert.AreEqual("Electronics Classification", driver.FindElement(hdrElectronicsClassfication).Text);
                Assert.AreEqual(true, driver.FindElement(tbHeading).Enabled);
                Assert.AreEqual(true, driver.FindElement(tbTelephone).Enabled);
            }
            else
            {
                Assert.AreEqual("Price", driver.FindElement(hdrElectronicsClassfication).Text);
                Assert.AreEqual(true, driver.FindElement(tbHeading).Enabled);
                Assert.AreEqual(true, driver.FindElement(tbTelephone).Enabled);
                Assert.AreEqual(true, driver.FindElement(txtDesc).Displayed);
            }

         
        }

        public void enterElectronicClassificationDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(tbHeading).Clear();
            driver.FindElement(tbHeading).SendKeys("User Form heading");
            driver.FindElement(tbTelephone).Clear();
            driver.FindElement(tbTelephone).SendKeys("123344566");
        }


        public void clickResetButton()
        {
            driver.FindElement(btnReset).Click();
        }

        public void enterAdditionalTelephoneDetails()
        {
            driver.FindElement(tbTelephone).SendKeys("788");

        }

        public void clickSaveButton()
        {
            driver.FindElement(btnSave).Click();
        }

        public void verifyElectronicClassificationDetails()
        {
            Assert.AreEqual("User Form heading", driver.FindElement(tbHeading).GetAttribute("value"));
            Assert.AreEqual("123344566", driver.FindElement(tbTelephone).GetAttribute("value"));
        }

        public void clickDeleteButton()
        {
            driver.FindElement(btnDelete).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
        }

        public void verifyDetailsAreCleared()
        {
            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(tbHeading));
            Assert.AreEqual("", driver.FindElement(tbHeading).GetAttribute("value"));
            Assert.AreEqual("", driver.FindElement(tbTelephone).GetAttribute("value"));
        }


        #endregion Functions
    }
}

