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

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Inventory Ad Type Display Page")]
   public class InventoryDisplay_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public InventoryDisplay_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
           
        }


        #region Object Repository 


        By ingentaInventoryAddToCartBtn = By.CssSelector("input[id*='btnPageViewAddToCart']");

        By ingentaInventoryCartTab = By.CssSelector("li#tabs-li-cart>a");

        By ingentaInventoryCartContentTbl = By.CssSelector("table[id*='ucCart_grdCartContents']>tbody>tr");

        By ingentaInventoryDeleteCartRow = By.CssSelector("input[id*='btnDeleteAdRow']");      
      
        By ingentaInventoryPagesRadio = By.CssSelector("input[id*='rblInventoryView_1']");

        By ingentaDashboardPanelBtns = By.CssSelector("div#pnlButtons>a");
        By ingentaInventoryMediaGroupDropDown = By.CssSelector("select[id*='ddlMediumGroup'][id$='DropDownList1']");
        By ingentaInventoryWaitGif = By.CssSelector("div.inv_wait>img");
        By ingentaInventoryMediaDropDown = By.CssSelector("select[id*='lbMedia'][id$='ListBox1']");
        By ingentaInventoryMediaSectionDropDown = By.CssSelector("select[id*='lbGlobalSection_ListBox1']");
        By ingentaInventoryPlacementDropDown = By.CssSelector("select[id*='lbGlobalInventory_ListBox1']");
        By ingentaInventoryRangeCalendar = By.CssSelector("input[id*='ucBkingPeriod_dteRangeFrom_iwdcDate_input']");
        By ingentaInventoryPeriodDropDown = By.CssSelector("select[id*='ucBkingPeriod_ddlPeriod']");
        By ingentaInventoryAdSizeDropDown = By.CssSelector("select[id*='ddlAdSize_DropDownList1']");
        By ingentaInventoryGetInventoryBtn = By.CssSelector("input[id*='btnGetInventory']");
        By ingentaInventoryInPageViewSection = By.CssSelector("div.InvPageViewRowHeaders>div");
        By ingentaInventoryInPageViewOuterRight = By.CssSelector("div#outerright>div>div");



        #endregion


        #region Functions      
        #region Reusable Function


        public void performscroll(int blockrow)
        {
            Console.WriteLine("Scroll Size: " + driver.FindElements(By.CssSelector("div.InvPageViewRow>div.Scroll")).Count);

            IWebElement ele_scroll = driver.FindElements(By.CssSelector("div.InvPageViewRow>div.Scroll"))[(blockrow + 1) + 1].FindElement(By.CssSelector("div>img"));

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].style.border='1px solid  red'", ele_scroll);

            executor.ExecuteScript("arguments[0].click();", ele_scroll);
           
        }

        public void switchToDefaultContent()
        {
            driver.SwitchTo().DefaultContent();
        }

        public void switchToFrame(int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public void waitHardCode5Sec()
        {
            Thread.Sleep(5000);
        }

        public void waitHardCode2Sec()
        {
            Thread.Sleep(2000);
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

        private void waitUntilBlockClickDone(int blocknum, DefaultWait<IWebDriver> ingentaIDefaultWait, String blockdate)
        {
            Console.WriteLine("Block Date: " + blockdate);

            waitHardCode5Sec();

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));                     

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));           
            
            ingentaIDefaultWait.Until(d => driver.FindElements(ingentaInventoryInPageViewSection)[blocknum].FindElements(By.CssSelector("div.RowHeader div.SlotDate>div")).Count > 0);

            IWebElement leftBlock = driver.FindElements(ingentaInventoryInPageViewSection)[blocknum].FindElement(By.CssSelector("div.RowHeader div.SlotDate>div"));
            
            //Highlight left Block Element from which date needs to be checked                                

            Console.WriteLine("Left Block " + (blocknum + 1) + "Date: " + leftBlock.Text.ToString());

            ingentaIDefaultWait.Until(d => leftBlock.Text.Equals(blockdate));

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].style.border='2px solid  red'", leftBlock);
        }

        #endregion

        //Following function checks the first available block from the initial five blocks
        public int checkforblockavaibility(int blockrow, int scrollcase, IWebElement OuterRightRow, int totalFirstRowBlockCount, DefaultWait<IWebDriver> ingentaIDefaultWait)
        {
            int blockid = -1, totalscrollreq = 0, scrollcnt = 0;

            if (scrollcase == 0)
            {
                if (OuterRightRow.FindElements(By.CssSelector("div.page.unselectable")).Count < 5)
                    blockid = 0;
                else
                    blockid = -1;
            }
            else
            {
                // Scroll will be performed and block index will be returned

                totalscrollreq = totalFirstRowBlockCount / 5;

                Console.WriteLine("Total Scroll Required: " + totalscrollreq);

                do
                {
                    Console.WriteLine("Driver Title Inside Loop" + driver.Title.ToString());
                                      
                    ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(OuterRightRow));

                    IList<IWebElement> selectable = OuterRightRow.FindElements(By.CssSelector("div.page.selectable"));

                    if (selectable.Count == 0)
                    {
                        Console.WriteLine("if Block for Unselectable");

                        performscroll(blockrow);

                        scrollcnt++;

                        blockid = 0;
                    }
                    else
                    {
                        Console.WriteLine("Else Block for Unselectable");

                        blockid = 0;

                        break;
                    }
                }
                while (scrollcnt < totalscrollreq);
            }

            return blockid;
        }

        //Following function performs verification of panel buttons
        public void ingentaDashboardVerify()
        {
            DefaultWait<IWebDriver> dashboardwait = uf.fluentTimeout(driver, "minute", 1, 5);

            dashboardwait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            uf.IsPageLoaded(driver);

            Console.WriteLine("After Login page is loaded");

            switchToFrame(0);

            uf.IsElementPresent(driver, ingentaDashboardPanelBtns, 60);

            Console.WriteLine("Dashboard Panel Buttons Found");

            Console.WriteLine("Panel Button Title: " + driver.FindElements(ingentaDashboardPanelBtns)[0].GetAttribute("title").ToString());

        }

        //Following function performs addition of items to the cart from the inventory for the ad type Display
        public void ingentaInventoryManagement()
        {
            log.Info("Selecting Ad Type Display and Adding it to the cart");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            driver.FindElements(ingentaDashboardPanelBtns)[4].Click();

            uf.IsPageLoaded(driver);

            switchToDefaultContent();

            ingentaIDefaultWait.Until(ExpectedConditions.TitleIs("ad DEPOT"));

            Console.WriteLine("Navigated to Inventory Management Page");

            waitHardCode5Sec();

            switchToFrame(0);

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaGroupDropDown)); //Wait until Media Group Dropdown Exist

            SelectElement mediagroupdrop = new SelectElement(driver.FindElement(ingentaInventoryMediaGroupDropDown));

            mediagroupdrop.SelectByValue("NEWS");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaDropDown));

            ingentaIDefaultWait.Until(d => driver.FindElement(ingentaInventoryMediaDropDown).Displayed);

            IWebElement selingentaInventoryMediaDropDown = driver.FindElement(ingentaInventoryMediaDropDown);

            ingentaIDefaultWait.Until(d => selingentaInventoryMediaDropDown.Enabled);

            SelectElement mediadrop = new SelectElement(selingentaInventoryMediaDropDown);

            waitUnitlSelectOptionsPopulated(mediadrop, ingentaIDefaultWait, 4);

            Actions selmultival = new Actions(driver);

            mediadrop.SelectByValue("GAZE");

            selmultival.KeyDown(OpenQA.Selenium.Keys.Control).Build().Perform();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            mediadrop.SelectByValue("PLAN");

            selmultival.KeyUp(OpenQA.Selenium.Keys.Control).Build().Perform();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaSectionDropDown));

            SelectElement mediasectiondrop = new SelectElement(driver.FindElement(ingentaInventoryMediaSectionDropDown));

            waitUnitlSelectOptionsPopulated(mediasectiondrop, ingentaIDefaultWait, 8);

            waitHardCode5Sec();

            mediasectiondrop.SelectByValue("NEWS");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryPlacementDropDown));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryPlacementDropDown));

            SelectElement inventoryplacementdrop = new SelectElement(driver.FindElement(ingentaInventoryPlacementDropDown));

            waitUnitlSelectOptionsPopulated(inventoryplacementdrop, ingentaIDefaultWait, 5);

            waitHardCode5Sec();

            inventoryplacementdrop.SelectByValue("110");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            driver.FindElement(ingentaInventoryRangeCalendar).Clear();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryPeriodDropDown));

            SelectElement inventoryperiodrop = new SelectElement(driver.FindElement(ingentaInventoryPeriodDropDown));

            waitUnitlSelectOptionsPopulated(inventoryperiodrop, ingentaIDefaultWait, 8);

            inventoryperiodrop.SelectByValue("TWOWEEKS");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            if (!driver.FindElement(ingentaInventoryPagesRadio).Selected)
                driver.FindElement(ingentaInventoryPagesRadio).Click();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryAdSizeDropDown));

            SelectElement inventoryadsizedrop = new SelectElement(driver.FindElement(ingentaInventoryAdSizeDropDown));

            waitUnitlSelectOptionsPopulated(inventoryadsizedrop, ingentaIDefaultWait, 4);

            inventoryadsizedrop.SelectByValue("QP");

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryGetInventoryBtn));

            driver.FindElement(ingentaInventoryGetInventoryBtn).Click();

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryInPageViewSection));

            waitUntilInPageViewRowPopulated(driver.FindElements(ingentaInventoryInPageViewSection), ingentaIDefaultWait, 2);

            waitHardCode5Sec();

            // Operate - InPageView Click for Both the Rows

            for (int rowcnt = 0; rowcnt < 2; rowcnt++)
            {
                IWebElement rightblock = driver.FindElements(ingentaInventoryInPageViewOuterRight)[rowcnt];

                inPageViewOuterRightBlockClick(rowcnt, rightblock, ingentaIDefaultWait);

                bool addtocart = addBlockItemToCart(ingentaIDefaultWait, rowcnt);

                ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));
            }

         

        }
        
        private void waitUntilInPageViewRowPopulated(IList<IWebElement> InPageViewRow, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(driver => InPageViewRow.Count == itemcount);
        }

        //Following function selects the first available block from the initial five blocks
        public void inPageViewOuterRightBlockClick(int blockrow, IWebElement OuterRightRow, DefaultWait<IWebDriver> ingentaIDefaultWait)
        {

            Console.WriteLine("Total Blocks " + OuterRightRow.FindElements(By.CssSelector("div.page.selectable")).Count);

            int validblock;

            int totalFirstRowBlockCount = OuterRightRow.FindElements(By.CssSelector("div.page.selectable")).Count;

            if (totalFirstRowBlockCount < 5)
            {
                // No Scroll Required

                validblock = checkforblockavaibility(blockrow, 0, OuterRightRow, totalFirstRowBlockCount, ingentaIDefaultWait);
            }
            else
            {
                // Scroll Required Check 

                validblock = checkforblockavaibility(blockrow, 1, OuterRightRow, totalFirstRowBlockCount, ingentaIDefaultWait);

                if (validblock != -1)
                {
                    Console.WriteLine("Valid Block Found");

                    String blockdate = OuterRightRow.FindElements(By.CssSelector("div.page.selectable"))[validblock].FindElement(By.CssSelector("div.pagetitle.right")).Text.ToString();

                    IWebElement blockele = OuterRightRow.FindElements(By.CssSelector("div.page.selectable"))[validblock];

                    OuterRightRow.FindElements(By.CssSelector("div.page.selectable"))[validblock].Click();

                    waitHardCode2Sec();

                    ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

                    waitUntilBlockClickDone(blockrow, ingentaIDefaultWait, blockdate);
                }
                else
                {
                    Console.WriteLine("No Time Slot Available to Select");
                }
            }
        }

        //Following function adds the block to the cart
        public Boolean addBlockItemToCart(DefaultWait<IWebDriver> ingentaIDefaultWait, int rowcnt)
        {
            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementIsVisible(ingentaInventoryAddToCartBtn));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryAddToCartBtn));

            driver.FindElement(ingentaInventoryAddToCartBtn).Click();

            ingentaIDefaultWait.Until(d => driver.FindElements(By.Id("acart"))[0].Text.ToString().Contains((rowcnt+1)+" item"));

            return true;
        }

        //Following function performs verification of removed items from the cart
        public void verifyDeleteCartItem()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryCartTab));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryCartTab));

            driver.FindElement(ingentaInventoryCartTab).Click();

            ingentaIDefaultWait.Until(ExpectedConditions.ElementIsVisible(ingentaInventoryCartContentTbl));

            IList<IWebElement> deleteCartBtn = driver.FindElements(ingentaInventoryDeleteCartRow);

            for (int rowcnt = 0; rowcnt < deleteCartBtn.Count; rowcnt++)
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

        #endregion

    }
}
