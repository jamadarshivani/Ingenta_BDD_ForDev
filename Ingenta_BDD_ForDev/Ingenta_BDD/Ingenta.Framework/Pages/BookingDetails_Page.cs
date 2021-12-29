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
    [TestFixture, Description("This is a page object for Booking Details Page")]
    public class BookingDetails_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();
        string[] todayDate;

        public BookingDetails_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;

        }

        #region Object Repository

        By linkDashboardPanel = By.CssSelector("div#pnlButtons>a");

        By tbBookingRef  = By.Id("ctl00_cphMain_txtBookingRef");

        By btnSaveAndClose = By.Id("ctl00_cphMain_ucRibbon_btnSaveAndClose");

        //By btnHome = By.CssSelector("input[name='ctl07']");
        By btnHome = By.Name("ctl08");

        #endregion OR

        #region Functions

        //Following function updates the specific booking reference
        public void UpdateBookingRef()
        {
            todayDate = DateTime.Today.ToString().Split(' ');
            wait.Until(ExpectedConditions.ElementExists(tbBookingRef));

            driver.FindElement(tbBookingRef).Clear();
            
            driver.FindElement(tbBookingRef).SendKeys(todayDate[0] + " scenario 2 example booking");
        }

        //Following function saves and close the record
        public void ClickSaveAndClose()
        {
            log.Info("Save And Close the Record");

            driver.FindElement(btnSaveAndClose).Click();

            Thread.Sleep(2000);
        }

        //Following function performs navigation to Home Page
        public void ClickHomeButton()
        { 
            driver.SwitchTo().DefaultContent();
            driver.FindElement(btnHome).Click();                       
            DefaultWait<IWebDriver> dashboardwait = uf.fluentTimeout(driver, "minute", 1, 5);
            dashboardwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));
            uf.IsPageLoaded(driver);           
            driver.SwitchTo().Frame(0);
            dashboardwait.Until(ExpectedConditions.ElementExists(linkDashboardPanel));
            Console.WriteLine("Dashboard Panel Buttons Found");
        }

        #endregion Functions
    }
}
