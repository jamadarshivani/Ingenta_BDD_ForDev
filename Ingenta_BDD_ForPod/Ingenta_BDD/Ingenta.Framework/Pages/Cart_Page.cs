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
    [TestFixture, Description("This is a page object for Cart Page")]

    public class Cart_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public Cart_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By ingentaInventoryDeleteItemFromCartbutton = By.CssSelector("input.linkButton.delete");

        By ingentaInventoryCustomerbutton = By.Name("ctl00$cphMain$ucCart$btnCustomer");

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

        //Following function performs deletion of items from the cart
        public void DeleteItemsFromCart()
        {
            log.Info("Deleting the item from the Cart");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);

            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(10);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            waitHardCode5Sec();

            ingentaIDefaultWait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryDeleteItemFromCartbutton));

            //try
            //{// use wait for alert is present
                driver.FindElement(ingentaInventoryDeleteItemFromCartbutton).Click();
            //}
            //catch (Exception e)
            //{
            //}

            waitHardCode5Sec();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

        }

        //Following function performs navigation to Customer Pop-Up window
        public void ProceedToCustomerTab()
        {
            DefaultWait<IWebDriver> customerwait = uf.fluentTimeout(driver, "minute", 2, 5);
            customerwait.Timeout = TimeSpan.FromMinutes(1);
            customerwait.PollingInterval = TimeSpan.FromSeconds(10);
            customerwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            customerwait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

            IList<IWebElement> deleteCartBtn = driver.FindElements(ingentaInventoryDeleteCartRow);

            customerwait.Until(d => driver.FindElements(ingentaInventoryDeleteCartRow).Count==5);

            customerwait.Until(ExpectedConditions.ElementExists(ingentaInventoryCustomerbutton));
            customerwait.Until(ExpectedConditions.ElementToBeClickable(ingentaInventoryCustomerbutton));

            IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;

            exe.ExecuteScript("arguments[0].click();", driver.FindElement(ingentaInventoryCustomerbutton));
        }
        

        #endregion

    }
}
