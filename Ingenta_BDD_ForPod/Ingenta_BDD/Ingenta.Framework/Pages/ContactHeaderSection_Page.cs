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
    public class ContactHeaderSection_Page
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactHeaderSection_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By btnClose = By.Id("btnclose");

        By btnNewTask = By.Id("FFHistory_ibtnAddCall");

        By btnContact = By.Id("btnContact");
        By btnNewBooking = By.Name("FFHistory$ibtnAddBooking");
        By btnInventory = By.Id("FFHistory_ibtnInventorySelection");
        By btnRefresh = By.Id("FFHistory_ibtnRefresh");
        By dtStartingFrom = By.Id("FFHistory_ffdcShowHistoryFrom_dteDate_input");
        By ddFilterGroup = By.Id("FFHistory_ddlFilterBy");
        By colType = By.Id("FFHistoryxgrdHistory_c_0_7");
        By colStartDate = By.Id("FFHistoryxgrdHistory_c_0_8");
        By colSubject = By.Id("FFHistoryxgrdHistory_c_0_9");
        By colStatus = By.Id("FFHistoryxgrdHistory_c_0_10");
        By colName = By.Id("FFHistoryxgrdHistory_c_0_11");


        #endregion

        #region Functions

        public void clickCloseButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);
            driver.FindElement(btnClose).Click();
        }

        public void verifyStationeryWindowIsClosed()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewTask).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNewBooking).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnInventory).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnRefresh).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStartingFrom).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddFilterGroup).Displayed);

            Assert.AreEqual("Type", driver.FindElement(colType).Text);
            Assert.AreEqual("Start Date/Time", driver.FindElement(colStartDate).Text);
            Assert.AreEqual("Subject", driver.FindElement(colSubject).Text);
            Assert.AreEqual("Status", driver.FindElement(colStatus).Text);
            Assert.AreEqual("Name", driver.FindElement(colName).Text);
        }

        #endregion

    }
}

