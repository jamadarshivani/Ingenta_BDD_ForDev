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
    [TestFixture, Description("This is a page object for Login Page")]
   public class Login_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Login_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
           
        }


        #region Object Repository


        //By txtLoginUserName = By.CssSelector("input#ctlLogin_UserName");

        

        By txtLoginUserName = By.Id("ctlLogin_UserName");

        By txtLoginPassword = By.Name("ctlLogin$Password");

        By btnLoginSubmit = By.Id("ctlLogin_LoginButton");

        #endregion


        #region Functions        

        //Following function performs the login operation
        public void ingentaLogin(string username,string password)
        {
            log.Info("Performing login");
            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(txtLoginUserName));
            driver.FindElement(txtLoginUserName).SendKeys(username);
            driver.FindElement(txtLoginPassword).SendKeys(password);
            wait.Until(ExpectedConditions.ElementToBeClickable(btnLoginSubmit));
            driver.FindElement(btnLoginSubmit).SendKeys(Keys.Enter);
        }

        #endregion

    }
}
