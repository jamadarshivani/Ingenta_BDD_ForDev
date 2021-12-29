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
    [TestFixture, Description("This is a page object for New Bookings Page")]
   public class NewBooking_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();
       
        public NewBooking_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
           
        }


        #region Object Repository
             
        By txtLoginUserName = By.CssSelector("input#ctlLogin_UserName");

        By txtLoginPassword = By.CssSelector("input#ctlLogin_Password");

        By btnLoginSubmit = By.CssSelector("input#ctlLogin_LoginButton");

        By rowMedia = By.CssSelector("table#ctl00_cphMain_grdMedia > tbody > tr ");

        By columnData = By.TagName("td");

        By tagInput = By.TagName("input");

        By ddSection = By.Id("ctl00_cphMain_ddlReqSection_DropDownList1");

        By ddAddSize = By.Id("ctl00_cphMain_ddlAdSize_DropDownList1");

        By tabInsertion = By.Id("ctl00_cphMain_btnTabInsertions");

        By insertionRecord = By.Id("ctl00_cphMain_ffIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_chkIsSelected");

        By tabMaterial = By.Id("ctl00_cphMain_btnTabMaterial");

        By tabFinance = By.Id("ctl00_cphMain_btnTabFinance");

        By tabPayment = By.Id("ctl00_cphMain_btnTabPayment");

        By btnNext = By.CssSelector("input.linkButton.nextline");


        #endregion


        #region Functions        

        //Following function performs the login operation
        public void ingentaLogin(IWebDriver driver)
        {
            log.Info("Performing login");

            wait.Until(ExpectedConditions.ElementIsVisible(txtLoginUserName));
            driver.FindElement(txtLoginUserName).SendKeys("bobby");

            driver.FindElement(txtLoginPassword).SendKeys("tyer");

            driver.FindElement(btnLoginSubmit).Click();

        }

        public void switchToNewBookingWindow()
        {
            log.Info("Switching to New Booking Window");

            String parentWindow = driver.CurrentWindowHandle;
            IList<string> handles = driver.WindowHandles;
            int windowCount = handles.Count();
            Console.WriteLine("windowCount  : " + windowCount);
            Thread.Sleep(1000);
          
            foreach (String windowHandle in handles)
            {
                if (!windowHandle.Equals(parentWindow))
                {
                    driver.SwitchTo().Window(windowHandle);
                    driver.Manage().Window.Maximize();
                    if (uf.waitForInvisibleElementPresent(driver, txtLoginUserName, 15))
                    {
                       ingentaLogin(driver);
                    }

                    break;
                }
            }

        }

        //Following function selects the media from table
        public void selectMedia(string value)
        {
            log.Info("Selecting the media");

            wait.Until(ExpectedConditions.ElementExists(rowMedia));
            wait.Until(ExpectedConditions.ElementToBeClickable(rowMedia));

            IList<IWebElement> tableRow = driver.FindElements(rowMedia).ToList();

            Boolean flag = false;

            foreach (var item in tableRow)
            {
                IList<IWebElement> tablecolumn = item.FindElements(columnData).ToList();

                foreach (var column in tablecolumn)
                {                   
                    if (column.Text.Equals(value))
                    {
                        flag = true;
                        Thread.Sleep(1000);
                        item.FindElements(columnData)[0].FindElement(tagInput).Click();
                        break;
                    }

                }
                if (flag)
                {
                    break;
                }

            }
            if (!flag)
            {
                Assert.Fail("Element not found with value: " + value);
            }
        }

        private void waitUnitlSelectOptionsPopulated(SelectElement dropdown, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount, IWebElement ele)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(2);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            dropdown = new SelectElement(ele);
            ingentaIDefaultWait.Until(driver => dropdown.Options.Count > 0);
        }

        //Following function performs navigation to Add Details Tab
        public void gotoAddDetails()
        {
            log.Info("Navigating to add details page");

            uf.IsPageLoaded(driver);
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            wait.Until(ExpectedConditions.ElementIsVisible(ddSection));
            wait.Until(ExpectedConditions.ElementExists(ddSection));

            SelectElement section = new SelectElement(driver.FindElement(ddSection));
            waitUnitlSelectOptionsPopulated(section, ingentaIDefaultWait, 1, driver.FindElement(ddSection));

            section.SelectByText("Body");
            Thread.Sleep(1000);

            wait.Until(ExpectedConditions.ElementExists(ddAddSize));
            wait.Until(ExpectedConditions.ElementIsVisible(ddAddSize));
            
            SelectElement adSize = new SelectElement(driver.FindElement(ddAddSize));
            waitUnitlSelectOptionsPopulated(adSize, ingentaIDefaultWait, 4, driver.FindElement(ddAddSize));
            adSize = new SelectElement(driver.FindElement(ddAddSize));
            adSize.SelectByText("Full Page");

            ingentaIDefaultWait.Until(d => !driver.FindElement(By.Id("ctl00_cphMain_txtColumns_textBox1")).GetAttribute("value").Equals(null));
            ingentaIDefaultWait.Until(d => !driver.FindElement(By.Id("ctl00_cphMain_txtHeight_textBox1")).GetAttribute("value").Equals(null));

        }

        //Following function performs navigation to Insertion Tab
        public void gotoInsertionTab()
        {
            log.Info("Navigate to Insertion tab");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(tabInsertion));

            driver.FindElement(tabInsertion).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(insertionRecord));
            driver.FindElement(insertionRecord).Click();
            
        }

        //Following function performs navigation to Material Tab
        public void gotoMaterialtab()
        {
            log.Info("Navigate to Material tab");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(tabMaterial));
            wait.Until(ExpectedConditions.ElementExists(tabMaterial));
            driver.FindElement(tabMaterial).Click();
        }

        //Following function performs navigation to Finance Tab
        public void gotoFinanceTab()
        {
            log.Info("Navigate to Finance tab");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(tabFinance));
            wait.Until(ExpectedConditions.ElementExists(tabFinance));
            driver.FindElement(tabFinance).Click();
        }

        //Following function performs navigation to Payment Tab
        public void gotoPaymentTab()
        {
            log.Info("Navigate to Payement tab");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(tabPayment));
            wait.Until(ExpectedConditions.ElementIsVisible(tabPayment));
            driver.FindElement(tabPayment).Click();
          
        }

        //Following function clicks the next button
        public void clickNext()
        {
            uf.IsPageLoaded(driver);            
            wait.Until(ExpectedConditions.ElementExists(btnNext));
            wait.Until(ExpectedConditions.ElementIsVisible(btnNext));
            driver.FindElement(btnNext).Click();
        }

        #endregion

    }
}
