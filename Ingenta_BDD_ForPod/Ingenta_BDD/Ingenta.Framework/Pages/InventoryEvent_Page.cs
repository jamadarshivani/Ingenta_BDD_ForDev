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
    [TestFixture, Description("This is a page object for Inventory Ad Type Event Page")]
    public class InventoryEvent_Page
    {
        
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public InventoryEvent_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

       
        #region Object Repository

        By btnNewSearch = By.Id("ctl00_cphMain_btnNewSearch");

        By ingentaInventoryAdTypeDropDown = (By.CssSelector("[id*='srch03_ddlAdType_DropDownList1']"));

        By ingentaInventoryMediaGroupDropDown = By.CssSelector("[id*='srch03_ddlMediumGroup_DropDownList1']");

        By ingentaInventoryMediaDropDown = By.CssSelector("[id*='srch03_lbMedia_ListBox1']");

        By ingentaInventoryMediaSectionDropDown = By.CssSelector("[id*='srch03_lbMediumSection_ListBox1']");

        By ingentaInventoryPlacementDropDown = By.CssSelector("[id*='srch03_lbMediumInventory_ListBox1']");

        By ingentaInventoryPeriodDropDown = By.CssSelector("[id*='srch03_ucBkingPeriod_ddlPeriod']");

        By ingentaInventoryPagesRadio = By.Id("ctl00_cphMain_srch03_rblInventoryView_2");

        By ingentaInventoryAdSizeDropDown = By.CssSelector("[id*='srch03_ddlAdSize_DropDownList1']");

        By ingentaInventoryGetInventoryBtn = By.CssSelector("[id*='srch03_btnGetInventory']");

        By ingentaInventoryWaitGif = By.CssSelector("div.inv_wait>img");

        By ingentaInventoryAddToCartbutton = By.CssSelector("[title |= 'Add to cart']");

        By ingentaInventoryCartButton = By.Id("acart");

        By ingentaInventoryCartContentTbl = By.CssSelector("table[id*='ucCart_grdCartContents']>tbody>tr");

        By ingentaInventoryDeleteCartRow = By.CssSelector("input[id*='btnDeleteAdRow']");


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


        public void addSearchTwice()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(By.Id("ctl00_cphMain_btnNewSearch")));

            driver.FindElement(By.Id("ctl00_cphMain_btnNewSearch")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.Id("ctl00_cphMain_btnNewSearch")).Click();
        }



        //Following function selects the ad type drop down
        public void SelectAdType()
        {
            log.Info("Selecting Ad Type");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            
            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryAdTypeDropDown));

            SelectElement adtypedropdown = new SelectElement(driver.FindElement(ingentaInventoryAdTypeDropDown));

            adtypedropdown.SelectByValue("EVENT");
        }

        //Following function selects the media group drop down
        public void SelectMediaGroup()
        {
            log.Info("Selecting Media Group");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaGroupDropDown)); //Wait until Media Group Dropdown Exist

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryMediaGroupDropDown));

            uf.isJavaScriptActive(driver);

            uf.isJqueryActive(driver);

            SelectElement mediagroupdrop = new SelectElement(driver.FindElement(ingentaInventoryMediaGroupDropDown));

            waitUnitlSelectOptionsPopulated(mediagroupdrop, ingentaIDefaultWait, 12);

            mediagroupdrop.SelectByValue("EV");

        }

        //Following function selects the media multi-select list box
        public void SelectMedia()
        {
            log.Info("Selecting Media");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaDropDown));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryMediaDropDown));

            uf.isJavaScriptActive(driver);

            uf.isJqueryActive(driver);

            SelectElement mediadrop = new SelectElement(driver.FindElement(ingentaInventoryMediaDropDown));

            waitUnitlSelectOptionsPopulated(mediadrop, ingentaIDefaultWait, 1);

            mediadrop.SelectByValue("HGSHO");
        }

        //Following function selects the section multi-select list box
        public void SelectSection()
        {
            log.Info("Selecting Section");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryMediaSectionDropDown));

            SelectElement mediasectiondrop = new SelectElement(driver.FindElement(ingentaInventoryMediaSectionDropDown));

            waitUnitlSelectOptionsPopulated(mediasectiondrop, ingentaIDefaultWait, 3);

            waitHardCode5Sec();

            mediasectiondrop.SelectByValue("HH");
        }

        //Following function selects the inventory multi-select list box
        public void SelectInventoryPlacement()
        {
            log.Info("Selecting Inventory Placement");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryPlacementDropDown));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryPlacementDropDown));

            SelectElement inventoryplacementdrop = new SelectElement(driver.FindElement(ingentaInventoryPlacementDropDown));

            waitUnitlSelectOptionsPopulated(inventoryplacementdrop, ingentaIDefaultWait, 3);

            waitHardCode5Sec();

            inventoryplacementdrop.SelectByValue("300");

        }

        //Following function selects the period drop down
        public void SelectPeriod()
        {
            log.Info("Selecting Period");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryPeriodDropDown));

            SelectElement inventoryperiodrop = new SelectElement(driver.FindElement(ingentaInventoryPeriodDropDown));

            waitUnitlSelectOptionsPopulated(inventoryperiodrop, ingentaIDefaultWait, 8);

            waitHardCode5Sec();

            inventoryperiodrop.SelectByValue("SIXMONTHS");
        }

        //Following function selects the ad size drop down
        public void SelectAdSize()
        {
            log.Info("Selecting Ad Size");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();
            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryAdSizeDropDown));

            SelectElement inventoryadsizedrop = new SelectElement(driver.FindElement(ingentaInventoryAdSizeDropDown));

            waitUnitlSelectOptionsPopulated(inventoryadsizedrop, ingentaIDefaultWait, 4);

            inventoryadsizedrop.SelectByValue("EBSML");
        }

        //Following function fetches the available inventory
        public void ClickGetInventory()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode10Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryGetInventoryBtn));

            driver.FindElement(ingentaInventoryGetInventoryBtn).Click();
        }

        //Following function adds items to the cart
        public void AddItemsToCart()
        {
            log.Info("Adding Items to Cart");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));
            
            int count = driver.FindElements(ingentaInventoryAddToCartbutton).Count();
            for (int i = 0; i < 1; i++)
            {
                IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;


                ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryAddToCartbutton));
                exe.ExecuteScript("arguments[0].click();", driver.FindElement(ingentaInventoryAddToCartbutton));
            }
        }

        //Following function navigates to the cart tab
        public void GoToCart()
        {
            log.Info("Navigate to Cart Tab");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            ingentaIDefaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(ingentaInventoryWaitGif));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementExists(ingentaInventoryCartButton));
            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryCartButton));
            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
            exe.ExecuteScript("arguments[0].click();", driver.FindElement(ingentaInventoryCartButton));

            ingentaIDefaultWait.Until(ExpectedConditions.ElementIsVisible(ingentaInventoryCartContentTbl));

            IList<IWebElement> deleteCartBtn = driver.FindElements(ingentaInventoryDeleteCartRow);

            ingentaIDefaultWait.Until(d => driver.FindElements(ingentaInventoryDeleteCartRow).Count > 0); 
                           
        }
        #endregion
    }
}