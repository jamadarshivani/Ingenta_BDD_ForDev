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
using AutoIt;

namespace Ingenta.Framework.Pages
{
    public class CompanyHistoryNewTab_AttachementWindow
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyHistoryNewTab_AttachementWindow(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object Repository

        By txtAttachement = By.Id("txtAttachment");
        By ddlAttachmentType = By.Id("ddlAttachmentType");
        By btnChooseFile = By.Id("fupAttachment");
        By btnSaveAttachement = By.ClassName("toolbarPanel");

        #endregion Object Repository

        #region Functions

        public void verifyAttachmentsPage()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            Assert.AreEqual(true, driver.FindElement(txtAttachement).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAttachmentType).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnChooseFile).Displayed);
        }

        public void uploadAttachment()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement attachementType = new SelectElement(driver.FindElement(ddlAttachmentType));
            attachementType.SelectByText(".xls");
            AutoItX.Send("{TAB}");
            AutoItX.Send("{TAB}");
            Thread.Sleep(2000);
            AutoItX.Send("{TAB}");

            IWebElement browseButton;
            string uploadFilePath = Environment.CurrentDirectory + "\\Upload\\Documents\\" + "TestXLSFile.xls";
            browseButton = driver.FindElement(btnChooseFile);
            uf.uploadfile(browseButton, uploadFilePath);
        }

        public void clickSaveAttachement()
        {
            driver.SwitchTo().DefaultContent();
            driver.FindElements(btnSaveAttachement)[0].Click();
        }

        #endregion Functions
    }
}
