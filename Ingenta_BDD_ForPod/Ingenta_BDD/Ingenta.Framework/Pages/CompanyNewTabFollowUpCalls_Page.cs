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
    public class CompanyNewTabFollowUpCalls_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyNewTabFollowUpCalls_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object repository
       

        By btnNewFollowUpCalls = By.Id("ucFollowupCallList_btnAddFollowupTask");


        #endregion Object repository


        #region Functions

        public void clickNewFollowUpCallsbtn()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnNewFollowUpCalls).Click();

            
        }

        #endregion Functions
    }
}
