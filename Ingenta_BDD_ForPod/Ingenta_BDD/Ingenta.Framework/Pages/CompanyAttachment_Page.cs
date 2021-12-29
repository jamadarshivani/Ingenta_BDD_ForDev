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
    public class CompanyAttachment_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyAttachment_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By btnAttachement = By.Id("iglbarMenu_0_Item_8");

        By btnNewAttachement = By.Id("ucAttachment_btnNewAttachment");

        //New Attachement
        
        By tbAttachementName = By.Id("txtAttachment");
        By ddAttachementType = By.Id("ddlAttachmentType");
        By btnSendAttachement = By.Id("fupAttachment");
        By btnSaveAttachement = By.Id("LinkButton1");
        By btnDeleteAttachement = By.Id("ucAttachment_pnlDelete");

        By btnDelete = By.Id("ucAttachment_btnDelete");

        By gridTitle = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(4)");
        By gridType = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(5)");
        By gridFileName = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(6)");
        By gridAddedBy = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(7)");
        By gridCreated = By.CssSelector("table#G_ucAttachmentxgrdAttachments > thead > tr > th:nth-child(8)");




        #endregion Object Repository


        #region Functions

        public void navigateToAttachmentsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnAttachement));
            driver.FindElement(btnAttachement).Click();
        }

        public void verifyAttachmentsButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewAttachement).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteAttachement).Displayed);

            Assert.AreEqual("Title", driver.FindElement(gridTitle).Text);
            Assert.AreEqual("Type", driver.FindElement(gridType).Text);
            Assert.AreEqual("File Name", driver.FindElement(gridFileName).Text);
            Assert.AreEqual("Added By", driver.FindElement(gridAddedBy).Text);
            Assert.AreEqual("Created", driver.FindElement(gridCreated).Text);

        }

        #endregion Functions

    }
}
