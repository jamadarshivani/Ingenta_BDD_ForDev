using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility_Classes;
using AutoIt;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Inventory Ad Type Web(Residency) Page")]
   public class AddTypeWeb_Page
    {
        // This is to configure logger mechanism for Utilities.Config
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public AddTypeWeb_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository       

        By ingentaInventoryWaitGif = By.CssSelector("div.inv_wait>img");

        By ingentaLoginUsernameText = By.CssSelector("input#ctlLogin_UserName");

        By ingentaLoginPasswordText = By.CssSelector("input#ctlLogin_Password");

        By ingentaLoginSubmitBtn = By.CssSelector("input#ctlLogin_LoginButton");

        By ingentaDashboardPanelBtns = By.CssSelector("div#pnlButtons>a");

        By ingentaRecentBookingUsernameDrop = By.CssSelector("select[id*='cphMain_ddlUsers_DropDownList1']");

        By ingentaRecentBookingUserTable = By.CssSelector("table[id*='cphMain_grdRecentBookings']>tbody>tr");

        By ingentaBookingPageMainTable = By.CssSelector("table[id*='cphMain_tblSummaryHead']>tbody>tr>td");

        By ingentaBookingPageCompanyDetailsPopup = By.CssSelector("div[id^='RadWindowWrapper'][id$='CompanyPopup']");

        By ingentaBookingPageCompanyDetailsPopupForm = By.CssSelector("form#frmCompany");

        By ingentaBookingPageCompanyInformationName = By.CssSelector("input#ucCompanyDetail_txtCompanyName");

        By ingentaBookingPageCompanyInformationMktName = By.CssSelector("input#ucCompanyDetail_txtMarketName");

        By ingentaBookingPageCompanyDetailsPopupClose = By.CssSelector("a[title='Close']");

        By ingentaContactManagementFormLastNameTxt = By.CssSelector("input[id^='Search'][id$='txtValue1']");

        By ingentaContactManagementFormSearchBtn = By.CssSelector("input#Search_GoButton");

        By ingentaContactManagementAfterSearchTbl = By.CssSelector("table#G_SearchxresultsGrid>tbody>tr");

        By ingentaInventoryMediaGroupDropDown = By.CssSelector("select[id*='ddlMediumGroup'][id$='DropDownList1']");

        By ingentaInventoryMediaDropDown = By.CssSelector("select[id*='lbMedia'][id$='ListBox1']");

        By ingentaInventoryMediaSectionDropDown = By.CssSelector("select[id*='lbGlobalSection_ListBox1']");

        By ingentaInventoryPlacementDropDown = By.CssSelector("select[id*='lbGlobalInventory_ListBox1']");

        By ingentaInventoryPeriodDropDown = By.CssSelector("select[id*='ucBkingPeriod_ddlPeriod']");

        By ingentaInventoryPagesRadio = By.CssSelector("input[id*='rblInventoryView_1']");

        By ingentaInventoryAdSizeDropDown = By.CssSelector("select[id*='ddlAdSize_DropDownList1']");

        By ingentaInventoryGetInventoryBtn = By.CssSelector("input[id*='btnGetInventory']");

        By ingentaInventoryInPageViewSection = By.CssSelector("div.InvPageViewRowHeaders>div");

        By ingentaInventoryInPageViewOuterRight = By.CssSelector("div#outerright>div>div");

        By ingentaInventoryCartTab = By.CssSelector("li#tabs-li-cart>a");

        By ingentaInventoryCartContentTbl = By.CssSelector("table[id*='ucCart_grdCartContents']>tbody>tr");

        By ingentaInventoryDeleteCartRow = By.CssSelector("input[id*='btnDeleteAdRow']");

        By btnNewSearch = By.Id("ctl00_cphMain_btnNewSearch");

        By ddAddType = (By.CssSelector("[id*='srch02_ddlAdType_DropDownList1']"));

        By ddMediaGroup = By.CssSelector("[id*='srch02_ddlMediumGroup_DropDownList1']");

        By lstMedia = By.CssSelector("[id*='srch02_lbMedia_ListBox1']");

        By lstMediaSection = By.CssSelector("[id*='srch02_lbGlobalSection_ListBox1']");

        By lstInventory = By.CssSelector("[id*='srch02_lbGlobalInventory_ListBox1']");

        By ddPeriod = By.CssSelector("[id*='srch02_ucBkingPeriod_ddlPeriod']");

        By rdoInventory = By.CssSelector("[id*='srch02_rblInventoryView_0']");

        By ddAddSize = By.CssSelector("[id*='srch02_ddlAdSize_DropDownList1']");

        By btnGetInventory = By.CssSelector("[id*='srch02_btnGetInventory']");

        By tableMatrix = By.CssSelector("table[id*='ucMatrixViewDetails_GridView1']");

        By rowMatrix = By.CssSelector("table[id*='ucMatrixViewDetails_GridView1']>tbody>tr");

        By lnkAddToCart = By.CssSelector("ul#ctl00_cphMain_srch02_ucMatrixViewDetails_menu > li");


        #endregion


        #region Functions      
      
        public void switchToDefaultContent()
        {            
            driver.SwitchTo().DefaultContent();
        }

        //Following function performs verification of panel buttons
        public void ingentaDashboardVerify()
        {
            log.Info("Verifying the Dashboard");

            DefaultWait<IWebDriver> dashboardwait = uf.fluentTimeout(driver, "minute", 1, 5);

            dashboardwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            uf.IsPageLoaded(driver);

            Console.WriteLine("After Login page is loaded");

            switchToFrame(0);

            uf.IsElementPresent(driver, ingentaDashboardPanelBtns, 60);

            Console.WriteLine("Dashboard Panel Buttons Found");

            Console.WriteLine("Panel Button Title: " + driver.FindElements(ingentaDashboardPanelBtns)[0].GetAttribute("title").ToString());

        }

        public void switchToFrame(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        //Following function performs selection of available green cells from matrix
        public void matrixViewOperation(IWebDriver driver, string recordValue)
        {

            DefaultWait<IWebDriver> matrixviewwait = uf.fluentTimeout(driver, "minute", 1, 5);
            matrixviewwait.Timeout = TimeSpan.FromMinutes(1);
            matrixviewwait.PollingInterval = TimeSpan.FromSeconds(1);
            matrixviewwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            matrixviewwait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            Console.WriteLine("Gif Count:" + driver.FindElements(ingentaInventoryWaitGif).Count);

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            int counter = 0;

            wait.Until(ExpectedConditions.ElementExists(tableMatrix));
            wait.Until(ExpectedConditions.ElementIsVisible(tableMatrix));
            IList<IWebElement> totalMatrixRow = driver.FindElements(rowMatrix).ToList();

            Console.WriteLine("Matrix row count: " + totalMatrixRow.Count());

            Actions action = new Actions(driver);

            foreach (var row in totalMatrixRow)
            {
                // select range for record 1
                if (row.GetAttribute("title").Equals(recordValue))
                {
                    Console.WriteLine("Record 1:  " + row.GetAttribute("title"));

                    matrixviewwait.Until(d => row.FindElements(By.TagName("td"))[0].Enabled);

                    IList<IWebElement> totalMatrixColumn = row.FindElements(By.TagName("td"));
                                     
                        foreach (var column in totalMatrixColumn)
                        {
                            Thread.Sleep(1000);
                            if (column.GetAttribute("class").Equals("textcell selectable available"))
                            {
                                if (counter == 0)
                                {
                                    AutoIt.AutoItX.Send("{CTRLDOWN}");
                                }

                                if (counter <= 6)
                                {
                                    column.Click();
                                }

                                if (counter == 6)
                                {
                                    AutoIt.AutoItX.Send("{CTRLUP}");

                                    action.ContextClick(column).Build().Perform();

                                    Thread.Sleep(3000);
                                    wait.Until(ExpectedConditions.ElementToBeClickable(lnkAddToCart));
                                    IWebElement addToCart = driver.FindElements(lnkAddToCart)[0].FindElement(By.TagName("a"));
                                    action.MoveToElement(addToCart).DoubleClick().Build();
                                    action.Perform();

                                    if (driver.FindElements(By.Id("ctl00_cphMain_ctl00")).Count > 0)
                                    {
                                        Console.WriteLine("Style:" + driver.FindElement(By.Id("ctl00_cphMain_ctl00")).GetAttribute("style").ToString());

                                        matrixviewwait.Until(d => driver.FindElement(By.Id("ctl00_cphMain_ctl00")).GetAttribute("style").ToString().Equals("display: block;"));

                                        matrixviewwait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

                                        matrixviewwait.Until(d => driver.FindElement(By.Id("ctl00_cphMain_ctl00")).GetAttribute("style").Equals("display: none;"));
                                    }

                                    break;

                                }

                                counter++;
                            }

                        }
                    if (counter == 6)
                    {
                        break;
                    }

                }


            }

        }

        //Following function performs verification of deleted cart items
        public void verifyDeleteCartItem()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ctl00_cphMain_ctl00")));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryCartTab));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryCartTab));

            driver.FindElement(ingentaInventoryCartTab).Click();

            ingentaIDefaultWait.Until(ExpectedConditions.ElementIsVisible(ingentaInventoryCartContentTbl));

            ingentaIDefaultWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(ingentaInventoryDeleteCartRow));
            Thread.Sleep(2000);

            IList<IWebElement> deleteCartBtn = driver.FindElements(ingentaInventoryDeleteCartRow);

            Console.WriteLine("cart count :" + deleteCartBtn.Count);

            for (int rowcnt = 0; rowcnt < deleteCartBtn.Count(); rowcnt++)
            {
                ingentaIDefaultWait.Until(d => driver.FindElements(ingentaInventoryDeleteCartRow).Count > 0);

                deleteCartBtn = driver.FindElements(ingentaInventoryDeleteCartRow);

                deleteCartBtn[0].Click();

                ingentaIDefaultWait.Until(ExpectedConditions.AlertIsPresent());

                IAlert delalert = driver.SwitchTo().Alert();

                delalert.Accept();

                waitHardCode5Sec();
            }
        }

        //Following function navigates to search bar
        public void clickOnSearch()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(btnNewSearch));

            driver.FindElement(btnNewSearch).Click();
        }

        //Following function performs the search operation
        public void inventorySearch()
        {
            log.Info("Selecting Ad Type Web (residency) and Adding it to the cart");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

           

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(btnNewSearch));

            driver.FindElement(btnNewSearch).Click();

            ingentaIDefaultWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(ddAddType)); //Wait until Add type Dropdown Exist

            SelectElement addTypegroupdrop = new SelectElement(driver.FindElement(ddAddType));

            addTypegroupdrop.SelectByValue("WEB");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ddMediaGroup)); //Wait until Media Group Dropdown Exist

            SelectElement mediagroupdrop = new SelectElement(driver.FindElement(ddMediaGroup));

            mediagroupdrop.SelectByValue("WEB");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(lstMedia));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(lstMedia));

            uf.isJavaScriptActive(driver);

            uf.isJqueryActive(driver);

            SelectElement mediadrop = new SelectElement(driver.FindElement(lstMedia));

            waitUnitlSelectOptionsPopulated(mediadrop, ingentaIDefaultWait, 2);

            Actions selmultival = new Actions(driver);

            mediadrop.SelectByValue("EDLOL");

            selmultival.KeyDown(OpenQA.Selenium.Keys.Control).Build().Perform();

            mediadrop.SelectByValue("NAP");

            selmultival.KeyUp(OpenQA.Selenium.Keys.Control).Build().Perform();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(lstMediaSection));

            SelectElement mediasectiondrop = new SelectElement(driver.FindElement(lstMediaSection));

            waitUnitlSelectOptionsPopulated(mediasectiondrop, ingentaIDefaultWait, 5);

            waitHardCode5Sec();

            mediasectiondrop.SelectByValue("ROS");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(lstInventory));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(lstInventory));

            SelectElement inventoryplacementdrop = new SelectElement(driver.FindElement(lstInventory));

            waitUnitlSelectOptionsPopulated(inventoryplacementdrop, ingentaIDefaultWait, 1);

            waitHardCode5Sec();

            inventoryplacementdrop.SelectByValue("158");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ddPeriod));

            SelectElement inventoryperiodrop = new SelectElement(driver.FindElement(ddPeriod));

            waitUnitlSelectOptionsPopulated(inventoryperiodrop, ingentaIDefaultWait, 8);

            waitHardCode5Sec();

            inventoryperiodrop.SelectByValue("ONEMONTH");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            if (!driver.FindElement(rdoInventory).Selected)
                driver.FindElement(rdoInventory).Click();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ddAddSize));

            SelectElement inventoryadsizedrop = new SelectElement(driver.FindElement(ddAddSize));

            inventoryadsizedrop.SelectByValue("TOPB");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(btnGetInventory));

            driver.FindElement(btnGetInventory).Click();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            matrixViewOperation(driver, "www.houseandgarden.com - Run of Site");

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            Thread.Sleep(1000);

            uf.isJqueryActive(driver);

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("ctl00_cphMain_ctl00")));

            matrixViewOperation(driver, "www.bridesmagazine.com - Run of Site");
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

        private void waitUntilInPageViewRowPopulated(IList<IWebElement> InPageViewRow, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(driver => InPageViewRow.Count == itemcount);
        }
        #endregion

    }
}
