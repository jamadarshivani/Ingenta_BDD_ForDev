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
    [TestFixture, Description("This is a page object for Inventory Release Page")]
    public class InventoryRelease_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public InventoryRelease_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
         }


        #region Object Repository

        By ingentaDashboardPanelBtns = By.CssSelector("div#pnlButtons>a");
        By ingentaBookingIDTxt = By.CssSelector("input[id*='cphMain_txtBookingID_textBox1']");
        By ingentaRecentBookingUsernameDrop = By.CssSelector("select[id*='cphMain_ddlUsers_DropDownList1']");
        By ingentaRecentBookingUserTable = By.CssSelector("table[id*='cphMain_grdRecentBookings']>tbody>tr");
        By ingentaBookingLineTbl = By.CssSelector("table[id*='cphMain_grdLines']>tbody>tr");
        By ingentaBookingInsertionTab = By.CssSelector("input[id*='cphMain_btnTabInsertions']");
        By ingentaBookingInsertionChgStatus = By.CssSelector("input[id*='cphMain_btnChangeStatus']");
        By ingentaBookingInsertionSelectAll = By.CssSelector("input[id*='chkSelectAll']");
        By ingentaBookingStatusDropDown = By.CssSelector("select[id*='cphMain_ddlChangeInsertStatus_DropDownList1']");
        By ingentaBookingStatChangeApplyBtn = By.CssSelector("input[id*='cphMain_btnApplyStatus']");
        By ingentaBookingBackToEditLine = By.CssSelector("input[id*='cphMain_ucRibbon_btnPrevious']");


        #endregion

        #region Reusable Function


        public void switchToFrame(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public void waitHardCode2Sec()
        {
            Thread.Sleep(2000);
        }
        public void waitHardCode5Sec()
        {
            Thread.Sleep(5000);
        }

        public void waitHardCode10Sec()
        {
            Thread.Sleep(10000);
        }

        private void waitUnitlSelectOptionsPopulated(SelectElement dropdown, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(driver => dropdown.Options.Count == itemcount);
        }

        public void switchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }


        #endregion

        #region Functions


        public void ingentaInventoryRelease(IWebDriver driver)
        {
            log.Info("Releasing Ingenta Inventory");


            ingentaDashboardVerify(driver);

            ingentaDashboardMyBookingVerify(driver);

            switchToFrame(0);

            ingentaInitiateInventoryCancellation();

        }

        //Following function performs verification of panel buttons
        public void ingentaDashboardVerify(IWebDriver driver)
        {
            log.Info("Verifying Ingenta Dashboard");

            DefaultWait<IWebDriver> dashboardwait = uf.fluentTimeout(driver, "minute", 1, 5);

            dashboardwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            uf.IsPageLoaded(driver);

            Console.WriteLine("After Login page is loaded");

            switchToFrame(0);

            uf.IsElementPresent(driver, ingentaDashboardPanelBtns, 60);

            Console.WriteLine("Dashboard Panel Buttons Found");

            Console.WriteLine("Panel Button Title: " + driver.FindElements(ingentaDashboardPanelBtns)[0].GetAttribute("title").ToString());

        }

        //Following function performs navigates to the referenced booking ID
        public bool verifyRecentBooking(IWebDriver driver, IWebElement bookingID)
        {
            log.Info("Verifying Recent Booking");

            DefaultWait<IWebDriver> recentbookingwait = uf.fluentTimeout(driver, "minute", 1, 5);

            bookingID.Click();

            uf.IsPageLoaded(driver);

            switchToDefaultContent();

            recentbookingwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            Console.WriteLine("Navigated to Booking Page");

            waitHardCode5Sec();

            return true;
        }

        //Following function performs verification of navigation to My Bookings page
        public void ingentaDashboardMyBookingVerify(IWebDriver driver)
        {
            log.Info("Verifying My Booking in Dashboard");

            DefaultWait<IWebDriver> mybookingwait = uf.fluentTimeout(driver, "minute", 1, 5);

            driver.FindElements(ingentaDashboardPanelBtns)[0].Click();

            uf.IsPageLoaded(driver);

            switchToDefaultContent();

            mybookingwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            Console.WriteLine("Navigated to My Booking Page");

            waitHardCode2Sec();

            switchToFrame(0);

            mybookingwait.Until(ExpectedConditions.ElementExists(ingentaBookingIDTxt));

            mybookingwait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingIDTxt));

            IWebElement bookingID = verifyRecentBookingsUserTable(driver);

            verifyRecentBooking(driver, bookingID);
        }

        //Following function initiates cancellation or release of booked items
        public void ingentaInitiateInventoryCancellation()
        {
            log.Info("Cancelling Inventory");

            int totaleditlines = 0;

            DefaultWait<IWebDriver> bookinglinewait = uf.fluentTimeout(driver, "minute", 1, 5);

            bookinglinewait.Until(ExpectedConditions.ElementExists(ingentaBookingLineTbl));

            bookinglinewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingLineTbl));

            if (driver.FindElements(ingentaBookingLineTbl).Count > 0)
            {

                totaleditlines = (driver.FindElements(ingentaBookingLineTbl).Count);

                Console.WriteLine("Total Edit Lines: " + (totaleditlines - 1));

                for (int editlinerow = 1; editlinerow < totaleditlines; editlinerow++)
                {

                    // Calling Edit Booking Line 

                    igentaEditBookingLine(driver, editlinerow);

                    ingentaCancelBooking(driver, editlinerow, totaleditlines);
                }
            }

        }

        //Following function performs navigation to individual booking line
        public void igentaEditBookingLine(IWebDriver driver, int editlinerow)
        {
            log.Info("Editing Booking Line");

            DefaultWait<IWebDriver> bookinglinewait = uf.fluentTimeout(driver, "minute", 1, 5);

            bookinglinewait.Until(ExpectedConditions.ElementExists(ingentaBookingLineTbl));

            bookinglinewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingLineTbl));

            if (driver.FindElements(ingentaBookingLineTbl).Count > 0)
            {
                Console.WriteLine("Records Present in Booking Edit Line");

                IWebElement editline = driver.FindElements(ingentaBookingLineTbl)[editlinerow].FindElement(By.CssSelector("td:nth-child(2) a"));

                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

                executor.ExecuteScript("arguments[0].style.border='1px solid  red'", editline);

                executor.ExecuteScript("arguments[0].click();", editline);
            }
            else
            {
                Assert.AreEqual(true, false);
            }

            waitHardCode2Sec();
        }

        //Following function performs cancellation or release of booked items
        public void ingentaCancelBooking(IWebDriver driver, int editlinerow, int totaleditlines)
        {
            log.Info("Cancelling Booking");

            DefaultWait<IWebDriver> cancelbookingewait = uf.fluentTimeout(driver, "minute", 1, 5);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingInsertionTab));

            cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingInsertionTab));

            cancelbookingewait.Until(ExpectedConditions.ElementToBeClickable(ingentaBookingInsertionTab));

            IWebElement insertiontab = driver.FindElement(ingentaBookingInsertionTab);

            executor.ExecuteScript("arguments[0].style.border='1px solid  red'", insertiontab);

            executor.ExecuteScript("arguments[0].click();", insertiontab);

            waitHardCode5Sec();

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingInsertionTab));

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingInsertionChgStatus));

            cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingInsertionChgStatus));

            cancelbookingewait.Until(ExpectedConditions.ElementToBeClickable(ingentaBookingInsertionChgStatus));

            IWebElement chgstatus = driver.FindElement(ingentaBookingInsertionChgStatus);

            executor.ExecuteScript("arguments[0].style.border='1px solid  red'", chgstatus);

            executor.ExecuteScript("arguments[0].click();", chgstatus);

            waitHardCode5Sec();

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingInsertionSelectAll));

            cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingInsertionSelectAll));

            cancelbookingewait.Until(ExpectedConditions.ElementToBeClickable(ingentaBookingInsertionSelectAll));

            IWebElement selectall = driver.FindElement(ingentaBookingInsertionSelectAll);

            executor.ExecuteScript("arguments[0].style.border='1px solid  red'", selectall);

            executor.ExecuteScript("arguments[0].click();", selectall);

            waitHardCode5Sec();

            uf.IsPageLoaded(driver);

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingStatusDropDown));

            cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingStatusDropDown));

            SelectElement insertstatuslist = new SelectElement(driver.FindElement(ingentaBookingStatusDropDown));

            Console.WriteLine(insertstatuslist.Options.Count);

            insertstatuslist.SelectByValue("CANC");

            cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingStatChangeApplyBtn));

            cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingStatChangeApplyBtn));

            cancelbookingewait.Until(ExpectedConditions.ElementToBeClickable(ingentaBookingStatChangeApplyBtn));

            IWebElement applyBtn = driver.FindElement(ingentaBookingStatChangeApplyBtn);

            executor.ExecuteScript("arguments[0].style.border='1px solid  red'", applyBtn);

            executor.ExecuteScript("arguments[0].click();", applyBtn);

            waitHardCode5Sec();

            if (editlinerow == (totaleditlines - 1))
            {
                // Last Edit Line Record thus no need to click back button

                Console.WriteLine("Last Editline Record Reached");
            }
            else
            {
                // Click on Back button to navigate back to Edit line Records

                cancelbookingewait.Until(ExpectedConditions.ElementExists(ingentaBookingBackToEditLine));

                cancelbookingewait.Until(ExpectedConditions.ElementIsVisible(ingentaBookingBackToEditLine));

                cancelbookingewait.Until(ExpectedConditions.ElementToBeClickable(ingentaBookingBackToEditLine));

                IWebElement backBtn = driver.FindElement(ingentaBookingBackToEditLine);

                executor.ExecuteScript("arguments[0].style.border='1px solid  red'", backBtn);

                executor.ExecuteScript("arguments[0].click();", backBtn);

                waitHardCode2Sec();
            }
        }

        //Following function returns reference of the first booking ID in the user table
        public IWebElement verifyRecentBookingsUserTable(IWebDriver driver)
        {
            log.Info("Verifying Recent Bookings User Table");
                      
            uf.IsElementPresent(driver, ingentaRecentBookingUsernameDrop, 60);
                        
            waitHardCode5Sec();

            uf.IsElementPresent(driver, ingentaRecentBookingUserTable, 60);

            Console.WriteLine("Recent Booking User table No. of Records :" + (driver.FindElements(ingentaRecentBookingUserTable).Count - 1));

            int userRecordCnt = driver.FindElements(ingentaRecentBookingUserTable).Count;

            for (int recCnt = 1; recCnt < userRecordCnt; recCnt++)
            {
                Console.WriteLine(driver.FindElements(ingentaRecentBookingUserTable)[recCnt].FindElement(By.CssSelector("td>a")).Text.ToString());
            }

            return driver.FindElements(ingentaRecentBookingUserTable)[1].FindElement(By.CssSelector("td>a"));
        }
        

        #endregion

    }
}
