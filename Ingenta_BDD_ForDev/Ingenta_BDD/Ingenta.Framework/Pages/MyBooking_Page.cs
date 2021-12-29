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
    [TestFixture, Description("This is a page object for My Booking Page")]
   public class MyBooking_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public MyBooking_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
           
        }


        #region Object Repository

        By txtBookingRef = By.Id("ctl00_cphMain_txtBookingRef");
        By btnSaveAndClose = By.Id("ctl00_cphMain_ucRibbon_btnSaveAndClose");
        By ddlUser = By.Id("ctl00_cphMain_ddlUsers_DropDownList1");
        By tabBookingRef = By.CssSelector("table[id*='cphMain_grdRecentBookings']>tbody>tr");

        #endregion


        #region Functions        

        //Following function updates the selected booking reference
        public void updateBookingReference()
        {
            log.Info("Updating Booking Reference");

            string[] todayDate = DateTime.Now.ToString().Split(' ');

            wait.Until(ExpectedConditions.ElementExists(txtBookingRef));
            wait.Until(ExpectedConditions.ElementIsVisible(txtBookingRef));
            driver.FindElement(txtBookingRef).SendKeys(todayDate[0]);
        }

        //Following function saves and close the record
        public void clickSaveAndClose()
        {
            log.Info("Performing Save and Close Operation");

            wait.Until(ExpectedConditions.ElementExists(btnSaveAndClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveAndClose));
            Assert.AreEqual(true, driver.FindElement(btnSaveAndClose).Displayed);
            driver.FindElement(btnSaveAndClose).Click();
        }

        //Following function selects the user --> Currently not in use
        public void SelectingUser()
        {
            log.Info("Selecting the User");

            wait.Until(ExpectedConditions.ElementToBeClickable(ddlUser));
            IWebElement ddUser = driver.FindElement(ddlUser);
            SelectElement bookingSelectUser = new SelectElement(ddUser);
            bookingSelectUser.SelectByValue("94");
        }

        //Following function selects the first booking record of the company
        public void SelectingBookingReference()
        {
            log.Info("Selecting Booking Reference");

            int foundindex = 0;

            Boolean recFound = false;

            Thread.Sleep(5000);
            wait.Until(ExpectedConditions.ElementExists(tabBookingRef));

         
            int userRecordCnt = driver.FindElements(tabBookingRef).Count;

            IList<IWebElement> tdlist = driver.FindElements(By.CssSelector("table[id*='cphMain_grdRecentBookings']>tbody>tr"));

            if (tdlist[2].FindElements(By.TagName("input")).Count > 0)
            {
                Console.WriteLine("Found");

            }

            for (int recCnt = 1; recCnt < userRecordCnt; recCnt++)
            {
                if (driver.FindElements(tabBookingRef)[recCnt].FindElements(By.CssSelector("td:nth-child(2) input[type='image']")).Count > 0)
                {
                    log.Info("Warning Icon Present for Record:=" + recCnt);
                }
                else
                {
                   log.Info("Warning Icon Not Present for Record:=" + recCnt);

                    recFound = true;

                    Console.WriteLine(driver.FindElements(tabBookingRef)[recCnt].FindElement(By.CssSelector("td>a")).Text.ToString());

                    foundindex = recCnt;

                    break;
                }
            }

            if (recFound)
            {
                IWebElement eleBooking = driver.FindElements(tabBookingRef)[foundindex].FindElement(By.CssSelector("td>a"));

                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

                executor.ExecuteScript("arguments[0].style.border='1px solid  red'", eleBooking);

                executor.ExecuteScript("arguments[0].click();", eleBooking);

               
            }
            else
            {
                Assert.AreEqual(true, false);
            }

        }

       
      
    }

        #endregion

      


    }

