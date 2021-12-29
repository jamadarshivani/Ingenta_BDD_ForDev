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
    public class ContactDocuments_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactDocuments_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object Repository

        By ddlBookingConfTemplate = By.Id("ddlBookingConfTemplate");
        By ddlInvoiceTemplate = By.Id("ddlInvoiceTemplate");

        By btnSaveDoc = By.Id("btnSave");

        #endregion Object Repository

        #region Functions

        public void verifyDocumentsButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(ddlBookingConfTemplate).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlInvoiceTemplate).Enabled);
        }

        public void updateDocumentDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            IWebElement ddBookingTem = driver.FindElement(ddlBookingConfTemplate);
            SelectElement ddlBookingT = new SelectElement(ddBookingTem);
            ddlBookingT.SelectByText("New Order Acknowledgement");

            IWebElement ddInvTemp = driver.FindElement(ddlInvoiceTemplate);
            SelectElement ddlInvT = new SelectElement(ddInvTemp);
            ddlInvT.SelectByText("Invoice");

            driver.FindElement(btnSaveDoc).Click();
        }


        public void verifyDocumentDetailsAreUpdated()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            var bookingTempSelected = driver.FindElement(ddlBookingConfTemplate);
            var bSel = new SelectElement(bookingTempSelected);
            var bs = bSel.SelectedOption;
            string selectedBookingTemp = bs.Text;
            Assert.AreEqual("New Order Acknowledgement", selectedBookingTemp);

            var invoiceTempSelected = driver.FindElement(ddlInvoiceTemplate);
            var iSel = new SelectElement(invoiceTempSelected);
            var isc = iSel.SelectedOption;
            string selectedinvoiceTemp = isc.Text;
            Assert.AreEqual("Invoice", selectedinvoiceTemp);

        }

        #endregion Functions


    }
}
