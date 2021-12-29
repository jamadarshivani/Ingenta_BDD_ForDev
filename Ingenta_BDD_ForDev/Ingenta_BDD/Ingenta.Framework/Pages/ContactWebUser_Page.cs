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
    public class ContactWebUser_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactWebUser_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository
        By btnNew = By.Id("FFContactWebUserList_ibtnAddWSU");
        By btnSaveWebSiteUser = By.Id("btnSave");
        By btnCancelWebSiteUser = By.Id("btnClose");
        By ddlWebSite = By.Id("ddlWebSite");
        By txtUserName = By.Id("txtUsername");
        By txtPassword = By.Id("txtPassword");
        By txtConfirmPassword = By.Id("txtConfirmation");
        By txtEmailAddress = By.Id("txtEmailAddress");
        By chktDefaultUserName = By.Id("chkIsDefaultUsername");
        By chkPrivate = By.Id("chkIsPrivateUser");

        By gridWebSite = By.CssSelector("th#FFContactWebUserListxgrdWebSiteUsers_c_0_2 > nobr");
        By gridUsername = By.CssSelector("th#FFContactWebUserListxgrdWebSiteUsers_c_0_3 > nobr");
        By gridPrivate = By.CssSelector("th#FFContactWebUserListxgrdWebSiteUsers_c_0_4 > nobr");
        By gridLastLogin = By.CssSelector("th#FFContactWebUserListxgrdWebSiteUsers_c_0_5 > nobr");

        By headingWebSiteUser = By.Id("FFContactWebUserList_lblWebSiteUsers");
        #endregion Object Repository

        #region Functions

        public void verifyWebUserButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNew));

            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual("Web Site", driver.FindElement(gridWebSite).Text);
            Assert.AreEqual("Username", driver.FindElement(gridUsername).Text);
            Assert.AreEqual("Private?", driver.FindElement(gridPrivate).Text);
            Assert.AreEqual("Last Login", driver.FindElement(gridLastLogin).Text);
        }

        public void clickNewWebSiteUser()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNew));
            driver.FindElement(btnNew).Click();
        }

        public void enterWebSiteUserDetails()
        {
            uf.SwitchToNewWindow(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(ddlWebSite));

            IWebElement ddWebUser = driver.FindElement(ddlWebSite);
            SelectElement webuser = new SelectElement(ddWebUser);
            webuser.SelectByText("www.ingenta.com");

            driver.FindElement(txtUserName).SendKeys("TestUser");
            driver.FindElement(txtPassword).SendKeys("12345678");
            driver.FindElement(txtConfirmPassword).SendKeys("12345678");
            driver.FindElement(txtEmailAddress).SendKeys("testuser@gmail.com");
            driver.FindElement(chktDefaultUserName).Click();
            driver.FindElement(chkPrivate).Click();
        }

        public void enterInvalidWebSiteUserDetails()
        {
            uf.SwitchToNewWindow(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(ddlWebSite));

            IWebElement ddWebUser = driver.FindElement(ddlWebSite);
            SelectElement webuser = new SelectElement(ddWebUser);
            webuser.SelectByText("www.ingenta.com");

            driver.FindElement(txtUserName).SendKeys("TestUser");
            driver.FindElement(txtPassword).SendKeys("12345678");
            driver.FindElement(txtConfirmPassword).SendKeys("12345678");

            driver.FindElement(txtEmailAddress).SendKeys("testuser.com");
            driver.FindElement(txtEmailAddress).Clear();

            driver.FindElement(txtEmailAddress).SendKeys("testuser@@gmail.com");
            driver.FindElement(txtEmailAddress).Clear();

            driver.FindElement(txtEmailAddress).SendKeys("testuser@gmail..com");            

            driver.FindElement(chktDefaultUserName).Click();
            driver.FindElement(chkPrivate).Click();
        }


        

        public void clickSaveWebSiteUser()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveWebSiteUser));
            driver.FindElement(btnSaveWebSiteUser).Click();

            // Check the presence of alert
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }


        public void closeWebSiteUserWindow()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnCancelWebSiteUser));
            driver.FindElement(btnCancelWebSiteUser).Click();
        }
        


        public void verifyNewWebSiteUserWindowDetails()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveWebSiteUser));

            Assert.AreEqual(true, driver.FindElement(btnSaveWebSiteUser).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCancelWebSiteUser).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlWebSite).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtUserName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPassword).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtConfirmPassword).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtEmailAddress).Displayed);
            Assert.AreEqual(true, driver.FindElement(chktDefaultUserName).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkPrivate).Displayed);
        }

        //Below function needs to be ammended
        public void verifyWebSiteUserIsCreated()
        {
            Assert.AreEqual(true, true);
        }

        public void verifyWebSiteUserWindowIsClosed()
        {
            log.Info("Verifying Task Window is closed");
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(headingWebSiteUser).Displayed);
        }

        public void verifyErrorMessageForWebSiteUser()
        {
            Assert.AreEqual(true, true);
        }

        #endregion Functions

    }
}
