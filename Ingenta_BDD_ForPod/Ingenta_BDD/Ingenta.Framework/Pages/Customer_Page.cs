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
    [TestFixture, Description("This is a page object for Customer Page")]
    public class Customer_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Customer_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By ingentaModalBuyerCompanybutton = By.Id("ctl00_cphMain_ucCustomer_ctlModalBuyerCompany_btnModal");

        By ingentaCustomerAddCustomerButton = By.CssSelector("table[id='G_SearchxresultsGrid']>tbody>tr>td input");

        By ingentaCustomerCompanyNameTextBox = By.Name("Search$FieldSelect0$txtValue1");

        By ingentaCustomerSearchButton = By.Id("Search_GoButton");

        By ingentaCustomerContactNameTextBox = By.Id("Search_FieldSelect0_txtValue1");

        By ingentaModalBuyerCustomerContactNameTextBox = By.Id("ctl00_cphMain_ucCustomer_ctlModalBuyerContact_btnModal");

        By ingentaInventoryWaitGif = By.CssSelector("div.inv_wait>img");

        By ingentaCustomerSaveAndCloseBtn = By.CssSelector("input[name*='btnStandaloneSaveAndClose']");

        By ingentaInventoryProceedToBookingButton = By.Name("ctl00$cphMain$ucCart$btnProceedToCheckout");


        #endregion

        #region Reusable Function


        public void switchToFrame(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public void waitHardCode5Sec()
        {
            Thread.Sleep(5000);
        }

        public void waitHardCode10Sec()
        {
            Thread.Sleep(10000);
        }

        public void switchToFrameByName(string name)
        {
            Thread.Sleep(2000);

            int countFrame = driver.FindElements(By.TagName("iframe")).Count();
            Console.WriteLine("count of frame before:: " + name + ": " + countFrame);

            driver.SwitchTo().Frame(name);
        }




        private void waitUnitlSelectOptionsPopulated(SelectElement dropdown, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(driver => dropdown.Options.Count == itemcount);
        }

        #endregion

        #region Functions

        //Following function performs clicking of Modal Buyer Company Button
        public void ClickModalBuyerCompanyButton()
        {
            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            waitHardCode10Sec();

            switchToFrameByName("popBookingParties");

            IWebElement customersaveandclosebtn = driver.FindElement(ingentaCustomerSaveAndCloseBtn);

            exe.ExecuteScript("arguments[0].style.border='1px solid  red'", customersaveandclosebtn);

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaModalBuyerCompanybutton));

            int count = driver.FindElements(ingentaModalBuyerCompanybutton).Count();

            Console.WriteLine("count  : " + count);

            driver.FindElement(ingentaModalBuyerCompanybutton).Click();
        }

        //Following function selects Modal Buyer Company Button
        public void SelectModalBuyerCompany()
        {
            log.Info("Selecting Modal Buyer Company");

            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);

            waitHardCode10Sec();

            driver.SwitchTo().DefaultContent();

            switchToFrameByName("radOpenModalCallerCtl");

            switchToFrameByName("ifrContent");

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaCustomerCompanyNameTextBox));

            driver.FindElement(ingentaCustomerCompanyNameTextBox).Click();

            driver.FindElement(ingentaCustomerCompanyNameTextBox).SendKeys("Duis Limited");

            driver.FindElement(ingentaCustomerSearchButton).Click();

            customerwait.Until(ExpectedConditions.ElementExists(ingentaCustomerAddCustomerButton));

            customerwait.Until(ExpectedConditions.ElementIsVisible(ingentaCustomerAddCustomerButton));

            IWebElement addcustomerbtn = driver.FindElement(ingentaCustomerAddCustomerButton);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            exe.ExecuteScript("arguments[0].style.border='1px solid  red'", addcustomerbtn);

            addcustomerbtn.Click();

        }

        //Following function performs clicking of Modal Buyer Contact Button
        public void ClickModalBuyerContactButton()
        {
            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);

            waitHardCode10Sec();
            driver.SwitchTo().DefaultContent();

            switchToFrameByName("RightPane");

            switchToFrameByName("popBookingParties");

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaModalBuyerCustomerContactNameTextBox));

            driver.FindElement(ingentaModalBuyerCustomerContactNameTextBox).Click();
        }

        //Following function selects Modal Buyer Contact Button
        public void SelectModalBuyerContact()
        {
            log.Info("Selecting Modal Buyer Contact");

            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            waitHardCode10Sec();

            driver.SwitchTo().DefaultContent();

            switchToFrameByName("radOpenModalCallerCtl");

            switchToFrameByName("ifrContent");

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaCustomerContactNameTextBox));

            driver.FindElement(ingentaCustomerContactNameTextBox).Click();

            driver.FindElement(ingentaCustomerContactNameTextBox).SendKeys("Nieves");

            driver.FindElement(ingentaCustomerSearchButton).Click();

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaCustomerAddCustomerButton));

            IWebElement addcontactbtn = driver.FindElement(ingentaCustomerAddCustomerButton);

            exe.ExecuteScript("arguments[0].style.border='1px solid  red'", addcontactbtn);

            addcontactbtn.Click();
        }

        //Following function saves and close the record
        public void ClickSaveAndClose()
        {
            log.Info("Click and Save the Record");

            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 1, 5);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            customerwait.Timeout = TimeSpan.FromMinutes(1);
            customerwait.PollingInterval = TimeSpan.FromSeconds(10);
            customerwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            customerwait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();

            switchToFrameByName("RightPane");

            Thread.Sleep(1000);

            switchToFrameByName("popBookingParties");

            IWebElement customersaveandclosebtn = driver.FindElement(ingentaCustomerSaveAndCloseBtn);

            exe.ExecuteScript("arguments[0].style.border='1px solid  red'", customersaveandclosebtn);

            customerwait.Until(ExpectedConditions.ElementExists(ingentaCustomerSaveAndCloseBtn));

            customerwait.Until(ExpectedConditions.ElementIsVisible(ingentaCustomerSaveAndCloseBtn));

            customersaveandclosebtn.Click();

        }

        //Following function performs navigation to Booking Page
        public void ClickProceedToBooking()
        {
            log.Info("Performing Proceed to Booking");
            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            waitHardCode10Sec();

            driver.SwitchTo().DefaultContent();

            switchToFrameByName("RightPane");

            customerwait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryProceedToBookingButton));

            exe.ExecuteScript("arguments[0].click();", driver.FindElement(ingentaInventoryProceedToBookingButton));

        }

        #endregion

    }
}