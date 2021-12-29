
using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using Utility_Classes;


namespace Ingenta.Framework.Pages
{
    public class CompanyAdTemplates_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyAdTemplates_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Variables       
        #endregion Variables

        #region Object Repository

        By tabAdTemplates = By.Id("iglbarMenu_1_Item_4");
        By btnnew = By.Id("FFCompanySiteStyleList_btnAddAdTemplate");
        By btnSave = By.Id("btnSave");
        By ddAdSize = By.Name("ddlAdSizeCode");
        By btnNewAdTemplates = By.Id("FFCompanySiteStyleList_btnAddAdTemplate");

        By ddadsize = By.Name("ddlAdSizeCode");
        By tbSiteStyle = By.Id("txtSiteStyle");

        By tableHeaderStyle = By.Id("FFCompanySiteStyleListxgrdSiteStyles_c_0_2");
        By tableHeaderAdSize = By.Id("FFCompanySiteStyleListxgrdSiteStyles_c_0_3");
        By tableHeaderDesignTemplate = By.Id("FFCompanySiteStyleListxgrdSiteStyles_c_0_4");


        By lbadsize = By.Id("lblAdSize");
        By lbsitestyle = By.Id("lblSiteStyle");
        By lbdesigntemplate = By.Id("lblDesignTemplateName");
        By lbdesigntemplatefile = By.Id("lblDesignTemplateFile");
        By lbupload = By.Id("lblUploadThumbnail");

        By tbDesignTemplateName = By.Id("txtDesignTemplateName");
        By tbDesignTemplateFile = By.Id("txtDesignTemplateFile");
        By btnChooseFile = By.Id("fupThumbnail");
        By btnsave = By.Id("btnSave");
        By tableName = By.Id("G_FFCompanySiteStyleListxgrdSiteStyles");
        By rowsInAdTemplate = By.CssSelector("table#G_FFCompanySiteStyleListxgrdSiteStyles > tbody > tr");
        By btnEdit = By.CssSelector("tr#FFCompanySiteStyleListxgrdSiteStyles_r_0>td>nobr>input.ig_d86df3ca_rcb1112");
        By btnClose = By.Id("btnClose");
        By linkViewThumbnail = By.Id("hypThumbnail");

        By btnNew = By.Id("FFCompanySiteStyleList_btnAddAdTemplate");
        #endregion Object Repository

        #region Functions

        public void navigateToAdTemplatesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabAdTemplates));
            driver.FindElement(tabAdTemplates).Click();
        }

        public void verifyAdTemplatesTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewAdTemplates));

            Assert.AreEqual(true, driver.FindElement(btnNewAdTemplates).Displayed);            
            Assert.AreEqual(true, driver.FindElement(tableHeaderStyle).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdSize).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderDesignTemplate).Displayed);
        }

        public void clickNewTemplate()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnnew).Click();
        }


        public void verifyNewTemplateDetails()
        {
            uf.SwitchToNewWindow(driver);            
            driver.SwitchTo().DefaultContent();
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists(ddadsize));
            Assert.AreEqual(true, driver.FindElement(ddadsize).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbSiteStyle).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbDesignTemplateName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbDesignTemplateFile).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnChooseFile).Displayed);
        }

        public void clickOnNewButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNew).Click();
        }

        public void enterAllDetailsInAdTemplates()
        {
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementExists(ddadsize));

            SelectElement drpdownadsize = new SelectElement(driver.FindElement(ddadsize));
            drpdownadsize.SelectByText("Full Page");
            String selectedvalue = drpdownadsize.SelectedOption.Text;
            Console.WriteLine(selectedvalue);
            driver.FindElement(tbSiteStyle).SendKeys("Bold Wider");
            driver.FindElement(tbDesignTemplateName).SendKeys("Design-55");
            driver.FindElement(tbDesignTemplateFile).SendKeys("Design-55");
        }

        public void fileUpload()
        {
            //   AutoItX.WinWaitActive("Ad Template");
            //AutoItX.Send("{TAB}");
            //AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            //AutoItX.Send("{TAB}");
            //AutoItX.Send("{TAB}");
            IWebElement browseButton;
            string uploadFilePath = Environment.CurrentDirectory + "\\Upload\\Documents\\" + "Thumbnail.jpg";
            browseButton = driver.FindElement(btnChooseFile);
            uf.uploadfile(browseButton, uploadFilePath);
        }

        public void saveAdTemplate()
        {
            driver.FindElement(btnSave).Click();
        }


        public void verifyAdTemplateDetails()
        {

            driver.SwitchTo().Window(driver.WindowHandles.First());
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(tableName));
            int rowCount = driver.FindElements(rowsInAdTemplate).Count();
            string adtrc = rowCount.ToString();
            string Style = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(3)>nobr";
            string AdSize = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(4)>nobr";
            string DesignTemplate = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(5)>nobr";

            Assert.AreEqual("Bold Wider", driver.FindElement(By.CssSelector(Style)).Text);
            Assert.AreEqual("Full Page                     ", driver.FindElement(By.CssSelector(AdSize)).Text);
            Assert.AreEqual("Design-55", driver.FindElement(By.CssSelector(DesignTemplate)).Text);
        }

        public void editAdTemplateWindow()

        {
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementExists(ddAdSize));
            driver.FindElement(ddAdSize).Click();
            SelectElement drpdownadsize = new SelectElement(driver.FindElement(ddAdSize));
            drpdownadsize.SelectByText("Quarter Page");
            String selectedvalue = drpdownadsize.SelectedOption.Text;

            driver.FindElement(tbSiteStyle).Clear();
            driver.FindElement(tbSiteStyle).SendKeys("Thin");

            driver.FindElement(tbDesignTemplateName).Clear();
            driver.FindElement(tbDesignTemplateName).SendKeys("Design-22");

            driver.FindElement(tbDesignTemplateFile).Clear();
            driver.FindElement(tbDesignTemplateFile).SendKeys("Design-22");
        }

        public void verifyEditDetailsInAdTemplate()
        {

            driver.SwitchTo().Window(driver.WindowHandles.First());

            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(tableName));

            int rowCount = driver.FindElements(rowsInAdTemplate).Count();
            string adtrc = rowCount.ToString();

            string Estyle = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(3)>nobr";
            string EAdSize = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(4)>nobr";
            string EDesignTemplate = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adtrc + ")>td:nth-child(5)>nobr";

            Assert.AreEqual("Thin", driver.FindElement(By.CssSelector(Estyle)).Text);
            Assert.AreEqual("Quarter Page", driver.FindElement(By.CssSelector(EAdSize)).Text.Trim());
            Assert.AreEqual("Design-22", driver.FindElement(By.CssSelector(EDesignTemplate)).Text);

        }

        public void selectTemplate()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(tableName));

            int rowCount = driver.FindElements(rowsInAdTemplate).Count();
            string adteditrc = rowCount.ToString();
            string select = "table#G_FFCompanySiteStyleListxgrdSiteStyles>tbody>tr:nth-child(" + adteditrc + ")>td:nth-child(1)>nobr";
            driver.FindElement(By.CssSelector(select)).Click();


        }

        public void clickOnCloseButton()
        {
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementExists(btnClose));
            driver.FindElement(btnClose).Click();
        }


        public void AdTemplateWindowIsClosed()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewAdTemplates));

            Assert.AreEqual(true, driver.FindElement(btnNewAdTemplates).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderStyle).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdSize).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderDesignTemplate).Displayed);

        }

        public void verifyThumbanailIsClickable()

        {
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementToBeClickable(linkViewThumbnail));
            int hrefCount = driver.FindElement(linkViewThumbnail).GetAttribute("href").Length;

            if (hrefCount == 0)
            {
                Assert.Fail("Thumbnail Is Not Clickable");
            }
        }


        #endregion Functions
    }
}
