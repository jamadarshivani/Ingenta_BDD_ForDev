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
    public class ContactCampaign_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactCampaign_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }
        int noOfCampaignsCount = 0;

        #region Object Repository


        #endregion Object Repository

        By cbSuspendCampaignProcessing = By.Id("FFContactCampaignList_chkSuspendCampaigns");
        By btnNewCampaign = By.Id("FFContactCampaignList_btnAddCampaign");

        By btnSaveCampaign = By.Id("btnSave");
        By btnCloseCampaign = By.Id("btnClose");
        By ddlMedia = By.Id("ddlMedium");
        By ddlCampaign = By.Id("ddlCampaign");
        By dtStartDate = By.Id("ffdcStartDate_iwdcDate_input");

        By headingCampaign = By.Id("FFContactCampaignList_lblCampaign");


        By gridName = By.CssSelector("th#FFContactCampaignListxgrdCampaign_c_0_2 > nobr");
        By gridCampaignStartDate = By.CssSelector("th#FFContactCampaignListxgrdCampaign_c_0_3 > nobr");
        By gridSequence = By.CssSelector("th#FFContactCampaignListxgrdCampaign_c_0_4 > nobr");
        By gridNextScheduleDate = By.CssSelector("th#FFContactCampaignListxgrdCampaign_c_0_5 > nobr");
        By gridComment = By.CssSelector("th#FFContactCampaignListxgrdCampaign_c_0_6 > nobr");

        By campaignRow = By.CssSelector("table#G_FFContactCampaignListxgrdCampaign > tbody > tr");

        #region Functions

        public void verifyCampaignTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(cbSuspendCampaignProcessing).Enabled);

            Assert.AreEqual("Name", driver.FindElement(gridName).Text);
            Assert.AreEqual("Campaign Start Date", driver.FindElement(gridCampaignStartDate).Text);
            Assert.AreEqual("Sequence", driver.FindElement(gridSequence).Text);
            Assert.AreEqual("Next Schedule Date", driver.FindElement(gridNextScheduleDate).Text);
            Assert.AreEqual("Comment", driver.FindElement(gridComment).Text);
            
        }


        public void clickNewCampaign()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementToBeClickable(btnNewCampaign));

            driver.FindElement(btnNewCampaign).Click();
        }

        public void verifyNewCampaignDetails()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();            
            wait.Until(ExpectedConditions.ElementToBeClickable(btnSaveCampaign));

            Assert.AreEqual(true, driver.FindElement(btnSaveCampaign).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCloseCampaign).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCloseCampaign).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlMedia).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCampaign).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStartDate).Displayed);
        }

        public void enterCampaignDetails()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementToBeClickable(ddlMedia));

            SelectElement selectedMedia = new SelectElement(driver.FindElement(ddlMedia));
            selectedMedia.SelectByText("Brides Magazine");
        }


        public void saveCampaignDetails()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementToBeClickable(btnSaveCampaign));
            driver.FindElement(btnSaveCampaign).Click();
        }



        public void verifyCampaignDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfCampaignsCount = driver.FindElements(campaignRow).Count();

            string campaignGridRows = "";
            for (int i = 0; i < noOfCampaignsCount; i++)
            {
                campaignGridRows = "tr#FFContactCampaignListxgrdCampaign_r_" + i + "> td:nth-child(3) > nobr";
                By mediaGridR = By.CssSelector(campaignGridRows);
                if (driver.FindElement(mediaGridR).Text == "Test Campaign")
                {
                    Assert.AreEqual("Test Campaign", driver.FindElement(mediaGridR).Text);
                }
            }
        }

        public void closeCampaign()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCloseCampaign));
            driver.FindElement(btnCloseCampaign).Click();
        }

        public void verifyCampaignWindowIsClosed()
        {
            log.Info("Verifying Campaign Window is closed");
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(headingCampaign).Displayed);
        }

        #endregion Functions

    }
}
