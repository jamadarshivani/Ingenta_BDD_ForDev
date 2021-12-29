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
    public class CompanyBrands_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyBrands_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By btnNewBrand = By.Id("FFListCompanyBrand_ibtnAddBrand");

        By gridMarket = By.CssSelector("th#FFListCompanyBrandxgrdCompanyBrands_c_0_3 > nobr");
        By gridGroup = By.CssSelector("th#FFListCompanyBrandxgrdCompanyBrands_c_0_4 > nobr");
        By gridBrand = By.CssSelector("th#FFListCompanyBrandxgrdCompanyBrands_c_0_5 > nobr");
        By gridLicensing = By.CssSelector("th#FFListCompanyBrandxgrdCompanyBrands_c_0_6 > nobr");
        By gridActive = By.CssSelector("th#FFListCompanyBrandxgrdCompanyBrands_c_0_7 > nobr");

        By tableBrandRows = By.CssSelector("table#G_FFListCompanyBrandxgrdCompanyBrands > tbody > tr");

        By btnCog = By.CssSelector("input.ig_e43f87d3_rcb1112.Brand");
        By btnPin = By.CssSelector("input.ig_e43f87d3_rcb1212.detachBrand");
        //Information Under Brands

        By ddMarket = By.Id("ucBrandDetail_ddlMarket");
        By ddBrandGroup = By.Id("ucBrandDetail_ddlMarketGroup");
        By tbBrand = By.Id("ucBrandDetail_txtBrand");
        By cbActive = By.Id("ucBrandDetail_chkIsActive");
        By cbSameAsCompany = By.Id("ucBrandDetail_chkSameAsCompany");

        By btnSave = By.Id("btnSave");
        By btnSaveAndClose = By.Id("btnSaveClose");

        //Brands Under Companies 

        By btnBrand = By.Id("iglbarMenu_0_Item_4");
        By btnViewBrand = By.Id("FFListCompanyBrandxgrdCompanyBrands_rc_6_0"); //Need to pay attention to this as this will change

        By btnRelationships = By.Id("iglbarMenu_0_Item_1");
        By btnSalesAssignments = By.Id("iglbarMenu_0_Item_2");
        By rbCurrentFuture = By.Id("FFRelationshipList_rblRelationshipsDateControl_0");
        By rbAll = By.Id("FFRelationshipList_rblRelationshipsDateControl_1");

        By btnBrandForm = By.Id("iglbarMenu_1_Item_0");

        //Relationships Under Brands

        By btnNewRelationship = By.Id("FFRelationshipList_btnAddRelationship");
        By btnDeleteRelationship = By.Id("FFRelationshipList_btnDeleteRelationship");

        By gridRole = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_3");
        By gridCompany = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_5");
        By gridLinkedName = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_6");
        By gridBrandRel = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_7");
        By gridStartDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_18");
        By gridEndDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_19");

        By btnNewSalesAssignment = By.Id("ffListAssignment_btnAddAssignment");
        By btnDeleteSalesAssignment = By.Id("ffListAssignment_btnDeleteAssignment");
        By btnRequestSalesAssignment = By.Id("ffListAssignment_btnRequest");
        By ddMedia = By.Id("ffListAssignment_ddlMedia");
        By rbCurrent = By.Id("ffListAssignment_rblAssignmentsDateControl_0");
        By rbAllSA = By.Id("ffListAssignment_rblAssignmentsDateControl_1");

        By btnDetachAndReassign = By.Id("btnApply");


        By btnCompanyEllipsis = By.Id("ucCompanyContactChooser_ctlModalCompany_btnModal");
        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By btnSelectCompany = By.CssSelector("input.ig_5aac757b_rcb1112.SelectionSearch.btnOpenSite");
        By gridFirstBrandName = By.CssSelector("td#FFListCompanyBrandxgrdCompanyBrands_rc_0_5 > nobr");
        By btnSearch = By.Id("Search_GoButton");
        //New,Edit and Delete Relation

        //Refer CompanyRelationships_Page

        //For Sales Assignment Steps Refer CompanySalesAssignment_Page

        //Under User Forms

        By btnElectronicsClassification = By.Id("iglbarMenu_3_Item_0");
        By btnCompanyInfo = By.Id("iglbarMenu_3_Item_1");

        By btnBrands = By.Id("iglbarMenu_0_Item_4");

        By btnDetachCompany = By.Id("FFListCompanyBrandxgrdCompanyBrands_rc_0_1");

        By btnCompany = By.Id("btnCompany");

        //Detaching A Company Steps

        //Under Company Name Ellipsis
        //Refer CompanySearch_Page

        //Under Owner Contact Name Ellipsis
        //Refer CompanySearch_Page

        By btnDetachnReassignBrands = By.Id("btnApply");

        #endregion Object Repository

        #region Functions

        public void navigateToBrandsTab()
        {
            uf.IsPageLoaded(driver);

            log.Info("Navigate to History tab");

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementExists(btnBrands));

            driver.FindElement(btnBrands).Click();
        }

        public void verifyBrandsTabFunctionality()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewBrand).Enabled);
            Assert.AreEqual("Market", driver.FindElement(gridMarket).Text);
            Assert.AreEqual("Group", driver.FindElement(gridGroup).Text);
            Assert.AreEqual("Brand", driver.FindElement(gridBrand).Text);
            Assert.AreEqual("Licensing", driver.FindElement(gridLicensing).Text);
            Assert.AreEqual("Active", driver.FindElement(gridActive).Text);
        }

        public void clickNewBrandsButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnNewBrand).Click();

        }

        public void verifyNewBrandsButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(ddMarket).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddBrandGroup).Enabled);
            Assert.AreEqual(true, driver.FindElement(tbBrand).Enabled);
            Assert.AreEqual(true, driver.FindElement(cbActive).Enabled);
            Assert.AreEqual(true, driver.FindElement(cbSameAsCompany).Enabled);
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(btnRelationships).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(btnSalesAssignments).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(btnBrandForm).GetAttribute("disabled").ToLower());
        }

        public void enterBrandDetails()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            SelectElement market = new SelectElement(driver.FindElement(ddMarket));
            market.SelectByText("Electrical/Electronics");

            uf.IsPageLoaded(driver);

            SelectElement brandGroup = new SelectElement(driver.FindElement(ddBrandGroup));
            brandGroup.SelectByText("Lighting");

            driver.FindElement(cbActive).Click();
        }

        public void enterCompanyName(string companyName)
        {
            driver.FindElement(tbBrand).SendKeys(companyName);
        }

        public void verifyBrandsInformation()
        {
            var marketSelected = driver.FindElement(ddMarket);
            var mSel = new SelectElement(marketSelected);
            var ms = mSel.SelectedOption;
            string selectedMarket = ms.Text;
            Assert.AreEqual("Electrical/Electronics", selectedMarket);

            var brandGroupSelected = driver.FindElement(ddBrandGroup);
            var bgSel = new SelectElement(brandGroupSelected);
            var bgs = bgSel.SelectedOption;
            string selectedBrandGroup = bgs.Text;
            Assert.AreEqual("Lighting", selectedBrandGroup);

            Assert.AreEqual("test brand", driver.FindElement(tbBrand).GetAttribute("value").ToString());

        }

        public void verifyUserFormCompanyBrandsAreEnabled()
        {
            Assert.AreEqual(true, driver.FindElement(btnRelationships).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnSalesAssignments).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnBrandForm).Enabled);
        }

        public void selectBrandNameAsCompanyName()
        {
            driver.FindElement(cbSameAsCompany).Click();
        }

        public void clickSaveAndCloseButton()
        {
            wait.Until(ExpectedConditions.ElementExists(btnSave));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnSaveAndClose).Click();
        }

        public void clickCogButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementExists(btnCog));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCog));

            int cogBtnCount = driver.FindElements(btnCog).Count();
            driver.FindElements(btnCog)[cogBtnCount - 1].Click();
        }

        public void clickFirstCogButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementExists(btnCog));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCog));

            driver.FindElements(btnCog)[0].Click();
        }

        public void clickFirstPinButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementExists(btnPin));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnPin));

            driver.FindElements(btnPin)[0].Click();
        }


        public void verifyBrandIsCreatedSuccessfully()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            var marketSelected = driver.FindElement(ddMarket);
            var mSel = new SelectElement(marketSelected);
            var ms = mSel.SelectedOption;
            string selectedMarket = ms.Text;
            Assert.AreEqual("Electrical/Electronics", selectedMarket);


            var brandGroupSelected = driver.FindElement(ddBrandGroup);
            var bgSel = new SelectElement(brandGroupSelected);
            var bgs = bgSel.SelectedOption;
            string selectedBrandGroup = bgs.Text;
            Assert.AreEqual("Lighting", selectedBrandGroup);

            Assert.AreEqual("test brand", driver.FindElement(tbBrand).GetAttribute("value").ToString());

        }

        public void clickRelationshipTab()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnRelationships).Click();
        }
        public void clickSalesAssignmentsTab()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnSalesAssignments).Click();
        }

        public void clickCompanyButton()
        {

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnCompany).Click();
        }

        public void verifyRelationshipsTab()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewRelationship).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnDeleteRelationship).Enabled);
            Assert.AreEqual(true, driver.FindElement(rbCurrentFuture).Enabled);
            Assert.AreEqual(true, driver.FindElement(rbAll).Enabled);

            Assert.AreEqual("Role", driver.FindElement(gridRole).Text);
            Assert.AreEqual("Company", driver.FindElement(gridCompany).Text);
            Assert.AreEqual("LinkedName", driver.FindElement(gridLinkedName).Text);
            Assert.AreEqual("Brand", driver.FindElement(gridBrandRel).Text);
            Assert.AreEqual("Start Date", driver.FindElement(gridStartDate).Text);
            Assert.AreEqual("End Date", driver.FindElement(gridEndDate).Text);
        }

        public void verifyRowAndPinButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            int brandRowsCount = driver.FindElements(tableBrandRows).Count();
            int cogCount = driver.FindElements(btnCog).Count();
            int pinCount = driver.FindElements(btnPin).Count();

            Assert.AreEqual(brandRowsCount, cogCount);
            Assert.AreEqual(brandRowsCount, pinCount);

        }

        public void verifySalesAssignmentTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewSalesAssignment).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnDeleteSalesAssignment).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnRequestSalesAssignment).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddMedia).Enabled);

            var mediaSelected = driver.FindElement(ddMedia);
            var mSel = new SelectElement(mediaSelected);
            var ms = mSel.SelectedOption;
            string selectedMedia = ms.Text;
            Assert.AreEqual("<All>", selectedMedia);

            Assert.AreEqual(true, driver.FindElement(rbCurrent).Enabled);
            Assert.AreEqual(true, driver.FindElement(rbAllSA).Enabled);
        }

        public void clickDetachAndReassignButton()
        {
            driver.SwitchTo().DefaultContent();
            driver.FindElement(btnDetachAndReassign).Click();
        }

        public void verifyNewBrandIsAssigned()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("test brand", driver.FindElement(gridFirstBrandName).Text);
        }

        public void assignCompanyNameInNewWindow()
        {
            driver.SwitchTo().DefaultContent();

            uf.SwitchToNewWindow(driver);

            clickCompanyEllipsis();

            enterCompanyInformation();
        }

        public void clickCompanyEllipsis()
        {
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(btnCompanyEllipsis));

            driver.FindElement(btnCompanyEllipsis).Click();
        }

        public void enterCompanyInformation()
        {
            driver.SwitchTo().DefaultContent();

            //driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");

            uf.switchToFrameByElement(driver, wait, "ifrContent");

            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));

            driver.FindElement(txtCompanyName).SendKeys("TestCompany");

            driver.FindElement(btnSearch).Click();

            driver.FindElement(btnSelectCompany).Click();
        }

        #endregion Functions
    }
}