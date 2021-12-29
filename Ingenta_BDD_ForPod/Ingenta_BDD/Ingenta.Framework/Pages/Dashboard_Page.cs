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
    [TestFixture, Description("This is a page object for Dashboard Page")]
   public class Dashboard_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Dashboard_Page(IWebDriver driver, WebDriverWait wait)
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
        By btnSearch = By.Id("SEARCH");
        By btnBooking = By.Id("BOOKING");
        By btnInventory = By.Id("INVENTORY");
        By btnContacts = By.Id("CONTACT");
        By mnuMenu = By.Id("shortMenu");
        By mnuContact = By.Id("CONTACT");

        By tabCompanies = By.CssSelector("div#menuDiv > a#SEARCH");
        #endregion

        #region Functions       

        //Following function performs verification of panel buttons
        public void ingentaDashboardVerify()
        {
            log.Info("Verify user is on dashboard");
            Thread.Sleep(5000);
            DefaultWait<IWebDriver> dashboardwait = uf.fluentTimeout(driver, "minute", 1, 5);

            dashboardwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            uf.IsPageLoaded(driver);

            Console.WriteLine("After Login page is loaded");

            driver.SwitchTo().Frame(0);

            dashboardwait.Until(ExpectedConditions.ElementExists(linkDashboardPanel));          

            Console.WriteLine("Dashboard Panel Buttons Found");

            Console.WriteLine("Panel Button Title: " + driver.FindElements(linkDashboardPanel)[0].GetAttribute("title").ToString());


        }

        //Following function performs navigation to Company Page
        public void navigateToCompany()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            wait.Until(ExpectedConditions.ElementIsVisible(btnSearch));
            driver.FindElement(btnSearch).Click();

        }

        //Following function performs navigation to Contacts Page
        public void navigateToContacts()
        {
            log.Info("Navigate to Contacts");            
            wait.Until(ExpectedConditions.ElementIsVisible(btnContacts));
            driver.FindElement(btnContacts).Click();            
        }

        public void navigateToContactsFromMainMenu()
        {
            log.Info("Navigate to Contacts from Main Menu");
            wait.Until(ExpectedConditions.ElementIsVisible(mnuMenu));
            driver.FindElement(mnuMenu).Click();
            driver.FindElement(mnuContact).Click();                        
        }

        //Following function performs navigation to My Bookings Page
        public void navigateToMyBookings()
        {
            log.Info("Navigate to My Booking");                   
            wait.Until(ExpectedConditions.ElementExists(btnBooking));
            wait.Until(ExpectedConditions.ElementIsVisible(btnBooking));

            driver.FindElement(btnBooking).Click();

        }

        //Following function performs navigation to Inventory Page
        public void navigateToInventory()
        {
            log.Info("Navigate to Inventory");
            wait.Until(ExpectedConditions.ElementIsVisible(btnInventory));

            driver.FindElement(btnInventory).Click();
        }


        public void ClickCompanyFromMenu()
        {
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementExists(mnuMenu));
            wait.Until(ExpectedConditions.ElementIsVisible(mnuMenu));            
            driver.FindElement(mnuMenu).Click();

            wait.Until(ExpectedConditions.ElementExists(tabCompanies));
            wait.Until(ExpectedConditions.ElementIsVisible(tabCompanies));

            driver.FindElement(tabCompanies).Click();
        }
        #endregion

    }
}
