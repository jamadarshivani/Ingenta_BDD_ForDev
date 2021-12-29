using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Companies Information Page")]
    public class CompanyInformation_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        #region Variables

        public string verifyCompanyNameText = "TestCompany1234";
        string verifyCompanyMarketNameText = "Test Market Name";
        string verifyCompanyTypeValue = "Advertiser";


        string editedCompanyMarketNameText = "Test Market Name Edited";
        string editedAliasName = "Alias Name Edited";
        string editedCompanyTypeValue = "Agency";

        #endregion Variables


        public CompanyInformation_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By ddCompanyTypeInfo = By.Id("ucCompanyDetail_ddlCompanyType");
        By btnStationery = By.Id("btnStationery");
        By btnSearch = By.Id("btnSelection");
        By btnSelect = By.Id("btnDedupeSel");
        By btnCancel = By.Id("btnCancel");
        By btnCancelInToAddress = By.Id("LinkButton2");
        By btnOverride = By.Id("btnOverride");
        By tablePossibleMatches = By.Id("G_ucCompanyDetailxdgrdDedupeAddressMatches");
        By tabMatchPercentage = By.Id("ucCompanyDetailxdgrdDedupeAddressMatches_rc_0_1");
        By tabConfiguration = By.Id("CONFIGURATION");
        By imgUserCenter = By.Id("hlSECURITY");
        By imgUserPrefDefault = By.Id("hlUSERPREFERENCEDEFAULT");
        By tableUserDefaults = By.Id("dataGridView");
        By tabBoolVal = By.CssSelector("table#dataGridView > tbody > tr:nth-child(4) > td.FormGridCellCode");
        By chkCCCTYBooleanValue = By.Id("chkDEFAULTBOOLEANVALUE");
        By tabBlankSpace = By.CssSelector("table#dataGridView >tbody > tr.GridRow");
        By tbTaxRegNumber = By.Id("ctl00_cphMain_txtVatNumber_textBox1");
        By btnHome = By.Name("ctl08");
        By btnEdit = By.Id("btnEdit");
        By tableCompanyList = By.Id("G_SearchxresultsGrid");
        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By ingentaCompanyInformationNameTextBox = By.Id("ucCompanyDetail_txtCompanyName");
        By ingentaCompanyInformationMarketNameTextBox = By.Id("ucCompanyDetail_txtMarketName");
        By ingentaCompanyInformationAliasTextBox = By.Id("ucCompanyDetail_txtAlias");
        By ingentaCompanyInformationAddress1TextBox = By.Id("ucCompanyDetail_txtAddressLine1");
        By ingentaCompanyInformationAddress2TextBox = By.Id("ucCompanyDetail_txtAddressLine2");
        By ingentaCompanyInformationAddress3TextBox = By.Id("ucCompanyDetail_txtAddressLine3");
        By ingentaCompanyInformationAddress4TextBox = By.Id("ucCompanyDetail_txtAddressLine4");
        By ingentaCompanyInformationCityTextBox = By.Id("ucCompanyDetail_txtTown");
        By ingentaCompanyInformationRegionTextBox = By.Id("ucCompanyDetail_txtRegion");
        By ingentaCompanyInformationPostalCodeTextBox = By.Id("ucCompanyDetail_txtPostcode");
        By ingentaCompanyInformationCountryDropDown = By.Id("ucCompanyDetail_ddlCountry");
        By ingentaCompanyInformationCountryPrivacyCheckBox = By.Id("ucCompanyDetail_chkIsPrivate");
        By ingentaCompanyInformationLanguageDropDown = By.Id("ucCompanyDetail_ddlLanguage");
        By ingentaCompanyInformationInterCompanyCodeTextBox = By.Id("ucCompanyDetail_txtInterComp");
        By ingentaCompanyInformationInterTelephoneTextBox = By.Id("ucCompanyDetail_txtTelephone");
        By ingentaCompanyInformationTelephonePrivacyCheckBox = By.Id("ucCompanyDetail_chkPrvTel");
        By ingentaCompanyInformationMobileTextBox = By.Id("ucCompanyDetail_txtMobile");
        By ingentaCompanyInformationMobilePrivacyCheckBox = By.Id("ucCompanyDetail_chkPrvMob");
        By ingentaCompanyInformationFaxTextBox = By.Id("ucCompanyDetail_txtFax");
        By ingentaCompanyInformationFaxPrivacyCheckBox = By.Id("ucCompanyDetail_chkPrvFax");
        By ingentaCompanyInformationEmailTextBox = By.Id("ucCompanyDetail_txtEmail");
        By ingentaCompanyInformationEmailReadReceiptCheckBox = By.Id("ucCompanyDetail_chkReadReceipt");
        By ingentaCompanyInformationEmailPrivacyCheckBox = By.Id("ucCompanyDetail_chkPrvEml");
        By ingentaCompanyInformationWebsiteTextBox = By.Id("ucCompanyDetail_txtWebsite");
        By ingentaCompanyInformationFacebookTextBox = By.Id("ucCompanyDetail_txtFaceBookURL");
        By ingentaCompanyInformationTwitterTextBox = By.Id("ucCompanyDetail_txtTwitterURL");
        By ingentaCompanyInformationLinkedInTextBox = By.Id("ucCompanyDetail_txtLinkedInURL");
        By ingentaCompanyInformationBlogTextBox = By.Id("ucCompanyDetail_txtBLOGURL");
        By ingentaCompanyInformationCompanyTypeDropDown = By.XPath("//*[@id='ucCompanyDetail_ddlCompanyType']");
        By ingentaCompanyInformationAgencyTypeDropDown = By.Id("ucCompanyDetail_ddlAgencyType");
        By ingentaCompanyInformationStatusDropDown = By.Id("ucCompanyDetail_ddlSiteStatus");
        By btnSaveAndClose = By.Id("btnSaveClose");
        By btnSave = By.Id("btnSave");
        By ddCompanyType = By.Id("ctl00_cphMain_ddlCompanyType_DropDownList1");
        By btnOkCompanyType = By.Id("ctl00_cphMain_btnNewNonInvoiced");
        By btnCloseCompanyType = By.ClassName("rwCloseButton");
        By btnSend = By.Id("lbtnSend");
        By btnSaveAsTemplate = By.Id("lbtnSaveTemplate");
        By txtTemplateName = By.Id("newTemplateName");
        By btnUpdateTemplate = By.Id("lbtnUpdateTemplate");
        By btnClose = By.Id("btnClose");
        By btnCloseEmailPopUp = By.Id("lbtnCancel");
        By ddTemplateName = By.Id("ddlTemplates");
        By chkPrivacyContacts = By.Id("chkIncludePrivacy");
        By chkReadReceipt = By.Id("chkReadReceipt");
        By btnTo = By.Id("btnAddressLookUpTO");
        By btnCC = By.Id("btnAddressLookUpCC");
        By btnBCC = By.Id("btnAddressLookUpBCC");
        By txtTo = By.Id("txtToAddress");
        By txtCC = By.Id("txtCCAddress");
        By txtBCC = By.Id("txtBCCAddress");
        By txtSubject = By.Id("txtSubject");
        By btnBrowse = By.Id("FileUpload1");
        By btnCut = By.Id("igWebEd_tb_ctl01_image");
        By btnCopy = By.Id("igWebEd_tb_ctl02_image");
        By btnPaste = By.Id("igWebEd_tb_ctl03_image");
        By btnPasteAsHTML = By.Id("igWebEd_tb_ctl04_image");
        By btnPrint = By.Id("igWebEd_tb_ctl06_image");
        By txtSpellCheck = By.Id("igWebSpell_WebSpellCheckerDialog_documentTextPanel");
        By btnIgnore = By.Id("igWebSpell_WebSpellCheckerDialog_ignoreButton");
        By btnIgnoreAll = By.Id("igWebSpell_WebSpellCheckerDialog_ignoreAllButton");
        By txtChangeTo = By.Id("igWebSpell_WebSpellCheckerDialog_changeToBox");
        By btnChange = By.Id("igWebSpell_WebSpellCheckerDialog_changeButton");
        By btnChangeAll = By.Id("igWebSpell_WebSpellCheckerDialog_changeAllButton");
        By lstSuggestions = By.Id("igWebSpell_WebSpellCheckerDialog_suggestions");
        By btnFinish = By.Id("igWebSpell_WebSpellCheckerDialog_finishButton");
        By btnCheckSpelling = By.Id("igWebEd_tb_ctl07_image");
        By ddFont = By.Id("Font");
        By selectFont = By.XPath("//*[@id='Courier New']");
        By ddSize = By.Id("igWebEd_tb_ctl10_image");
        By selectSize = By.Id("1");
        By ddFormatting = By.Id("igWebEd_tb_ctl11_image");
        By selectFormatting = By.Id("<h1>");
        By btnLeftJutify = By.Id("igWebEd_tb_ctl13_image");
        By btnCenterJustify = By.Id("igWebEd_tb_ctl14_image");
        By btnRightJustify = By.Id("igWebEd_tb_ctl15_image");
        By btnJustify = By.Id("igWebEd_tb_ctl16_image");
        By btnIncreaseIndent = By.Id("igWebEd_tb_ctl19_image");
        By btnDecreaseIndent = By.Id("igWebEd_tb_ctl20_image");
        By btnUnorderedList = By.Id("igWebEd_tb_ctl22_image");
        By btnOrderedList = By.Id("igWebEd_tb_ctl23_image");
        By btnInsertRule = By.Id("igWebEd_tb_ctl25_image");
        By txtWidth = By.Id("iged_r_w");
        By txtSize = By.Id("iged_r_s");
        By ddAlign = By.Id("iged_r_al");
        By txtColor = By.Id("iged_r_c1");
        By selectColor = By.Id("iged_clr_15_11");
        By chkSolid = By.Id("iged_r_sld");
        By btnOk = By.Id("hrOK");
        By selectFontColor = By.Id("iged_clr_18_11");
        By selectFontHighlight = By.Id("iged_clr_20_9");
        By insertTableElement = By.CssSelector("body > table");
        By deleteTableRow = By.XPath("//*[@id='iged_0_itm']/table/tbody/tr[6]/td");
        By insertTableRow = By.XPath("//*[@id='iged_0_itm']/table/tbody/tr[5]/td");
        By tableRows = By.Id("iged_tp_rr");
        By tableColumns = By.Id("iged_tp_cc");
        By tableAlign = By.Id("iged_tp_al");
        By tableCellPadding = By.Id("iged_tp_cp");
        By tableBorderSize = By.Id("iged_tp_bds");
        By tableCellSpacing = By.Id("iged_tp_cs");
        By tableWidth = By.Id("iged_tp_w");
        By tableBackColor = By.Id("iged_tp_bk1");
        By selectBackColor = By.Id("iged_clr_27_2");
        By tableBorderColor = By.Id("iged_tp_bd1");
        By selectBorderColor = By.Id("iged_clr_4_3");
        By tableOkButton = By.XPath("//input[@type='button' and @value='OK']");
        By tableCancelButton = By.XPath("//input[@type='button' and @value='Cancel']");
        By btnBold = By.Id("igWebEd_tb_ctl27_image");
        By btnItalic = By.Id("igWebEd_tb_ctl28_image");
        By btnUnderline = By.Id("igWebEd_tb_ctl29_image");
        By btnFontColor = By.Id("igWebEd_tb_ctl31_image");
        By btnFontHighlight = By.Id("igWebEd_tb_ctl32_image");
        By btnDisplayTableMenu = By.Id("igWebEd_tb_ctl33_image");
        By insertTable = By.XPath("//*[@id='iged_0_ito']/table/tbody/tr/td/img");
        By btnFindAndReplace = By.Id("igWebEd_tb_ctl35_image");
        By btnInsertImage = By.Id("igWebEd_tb_ctl36_image");
        By btnWordCount = By.Id("igWebEd_tb_ctl37_image");
        //By txtMailBody = By.Id("igWebEd_tw");
        By txtMailBody = By.XPath("//*[@id='igWebEd_tw']");
        By btnDesign = By.Id("igWebEd_ts_d");
        By btnHTML = By.Id("igWebEd_ts_h");
        By btnActiveInaactiveInContacts = By.Id("btnPersonStatus");

        #region Email Address Popup objects

        By btnApply = By.Id("LinkButton1");
        By txtSearchBy = By.Id("txtUserName");
        By btnSearchToAddress = By.Id("btnSearch");
        By tblUserNames = By.Id("grdUserData_ctl00_Header");
        By txtToAddress = By.Id("txtTOAddress");
        By txtCCAddress = By.Id("txtCCAddress");
        By txtBCCAddress = By.Id("txtBCCAddress");
        By ddSearchFor = By.Id("Search_SearchBar_List");
        By btnNew = By.Id("Search_SearchBar_btnUser");
        By btnSiteDisplayMode = By.Id("Search_SearchBar_btnOpenSite");
        By btnSaveResults = By.Id("Search_SearchBar_btnSaveResults");
        By btnOpenResults = By.Id("Search_SearchBar_btnOpenResults");
        By txtCompanySearch = By.Id("Search_FieldSelect0_txtValue1");
        By btnSearchGo = By.Id("Search_GoButton");
        By lnkCompanyRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By txtPostalCode = By.Id("Search_FieldSelect5_txtValue1");
        By txtTown = By.Id("Search_FieldSelect4_txtValue1");
        By txtTel = By.Id("Search_FieldSelect6_txtValue1");
        By ddCountry = By.Id("Search_FieldSelect7_lstValues1");
        By ddCompanyTypes = By.Id("Search_FieldSelect8_lstValues1");
        By chkActive = By.Id("Search_FieldSelect9_checkBox");
        By buttonActiveInactive = By.Id("btnActiveInActive");
        By ingentaCompanyNewButton = By.Id("Search_SearchBar_btnUser");
        By noOfRowsCompanySearched = By.XPath("//table[@id='SearchxresultsGrid_main'//tr");
        By btnSearchInHeader = By.Id("btnSelection");
        By btnStationeryInHeader = By.Id("btnStationery");
        By tableHeaderCompany = By.Id("SearchxresultsGrid_c_0_3");
        By tableHeaderSiteId = By.Id("SearchxresultsGrid_c_0_4");
        By tableHeaderTel = By.Id("SearchxresultsGrid_c_0_5");
        By tableHeaderAdd1 = By.Id("SearchxresultsGrid_c_0_7");
        By tableHeaderAdd2 = By.Id("SearchxresultsGrid_c_0_8");
        By tableHeaderSTown = By.Id("SearchxresultsGrid_c_0_11");
        By tableHeaderRegion = By.Id("SearchxresultsGrid_c_0_12");
        By tableHeaderPostCode = By.Id("SearchxresultsGrid_c_0_13");
        By tableHeaderCountry = By.Id("SearchxresultsGrid_c_0_14");
        By tableHeaderCompanyType = By.Id("SearchxresultsGrid_c_0_15");
        By tableHeaderAgencyType = By.Id("SearchxresultsGrid_c_0_16");
        By titleContactManagementScreen = By.Id("Search_SearchBar_labTitle");
        By btnclose = By.Id("btnclose");
        By ddLetter = By.Id("lstLetter");
        By btnEmail = By.Id("lbtnSend");
        By btnSaveAsPDF = By.Id("btnSaveAsPDF");

        #endregion
        #endregion
        #region Functions

        private void waitUnitlSelectOptionsPopulated(SelectElement dropdown, DefaultWait<IWebDriver> ingentaIDefaultWait, int itemcount, IWebElement ele)
        {
            ingentaIDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            ingentaIDefaultWait.PollingInterval = TimeSpan.FromSeconds(2);
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            ingentaIDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            dropdown = new SelectElement(ele);
            ingentaIDefaultWait.Until(driver => dropdown.Options.Count > 0);
        }

        public void editMarketName()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationMarketNameTextBox));
            string marketName = driver.FindElement(ingentaCompanyInformationMarketNameTextBox).Text;
            driver.FindElement(ingentaCompanyInformationMarketNameTextBox).SendKeys(marketName + " 1");
        }

        public void verifyButtonsDisabled()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));
            Assert.AreEqual(false, driver.FindElement(btnSaveAndClose).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnClose).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSave).Enabled);
        }

        //Following function performs selection of the specific contact
        public void enterCompanyInformation()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            string randomString = uf.RandomString(5, true);
            verifyCompanyNameText = "Test_Company_" + randomString;

            driver.FindElement(ingentaCompanyInformationNameTextBox).SendKeys(verifyCompanyNameText);
            driver.FindElement(ingentaCompanyInformationMarketNameTextBox).SendKeys("Mid Market East");
            driver.FindElement(ingentaCompanyInformationAliasTextBox).SendKeys("alisdfsssdddfas");
            driver.FindElement(ingentaCompanyInformationAddress1TextBox).SendKeys("234, Progress Business Park");
            driver.FindElement(ingentaCompanyInformationAddress2TextBox).SendKeys("Chicago");
            driver.FindElement(ingentaCompanyInformationAddress3TextBox).SendKeys("United States");
            driver.FindElement(ingentaCompanyInformationAddress4TextBox).SendKeys("Address 4");
            driver.FindElement(ingentaCompanyInformationCityTextBox).SendKeys("Chicago");
            driver.FindElement(ingentaCompanyInformationRegionTextBox).SendKeys("Chicago");
            driver.FindElement(ingentaCompanyInformationPostalCodeTextBox).SendKeys("642350");

            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationCountryDropDown));
            IWebElement ddCountry = driver.FindElement(ingentaCompanyInformationCountryDropDown);
            SelectElement country = new SelectElement(ddCountry);
            country.SelectByIndex(231);

            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationLanguageDropDown));
            IWebElement ddpayment1 = driver.FindElement(ingentaCompanyInformationLanguageDropDown);
            SelectElement paymenttype1 = new SelectElement(ddpayment1);
            paymenttype1.SelectByIndex(29);

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationInterCompanyCodeTextBox));
            driver.FindElement(ingentaCompanyInformationInterCompanyCodeTextBox).SendKeys("test_cdode-1");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationInterTelephoneTextBox));
            driver.FindElement(ingentaCompanyInformationInterTelephoneTextBox).SendKeys("631-4252-6813");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationMobileTextBox));
            driver.FindElement(ingentaCompanyInformationMobileTextBox).SendKeys("63-98706543210");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationFaxTextBox));
            driver.FindElement(ingentaCompanyInformationFaxTextBox).SendKeys("63-98765403210");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationEmailTextBox));
            driver.FindElement(ingentaCompanyInformationEmailTextBox).SendKeys("support@casi2owatches.com");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationWebsiteTextBox));
            driver.FindElement(ingentaCompanyInformationWebsiteTextBox).SendKeys("www.casiowatc25hes.com");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationFacebookTextBox));
            driver.FindElement(ingentaCompanyInformationFacebookTextBox).SendKeys("face2book");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationLinkedInTextBox));
            driver.FindElement(ingentaCompanyInformationLinkedInTextBox).SendKeys("linke3din");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationBlogTextBox));
            driver.FindElement(ingentaCompanyInformationBlogTextBox).SendKeys("blog");
            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationCompanyTypeDropDown));
            IWebElement ddpayment2 = driver.FindElement(ingentaCompanyInformationCompanyTypeDropDown);
            SelectElement paymenttype2 = new SelectElement(ddpayment2);
            paymenttype2.SelectByIndex(1);

            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationAgencyTypeDropDown));
            IWebElement ddpayment3 = driver.FindElement(ingentaCompanyInformationAgencyTypeDropDown);
            SelectElement paymenttype3 = new SelectElement(ddpayment3);
            paymenttype3.SelectByIndex(2);

            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationStatusDropDown));
            IWebElement ddpayment4 = driver.FindElement(ingentaCompanyInformationStatusDropDown);
            SelectElement paymenttype4 = new SelectElement(ddpayment4);
            paymenttype4.SelectByIndex(1);
        }

        public void enterMandartoryCompanyInformation()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            string randomString = uf.RandomString(5, true);
            verifyCompanyNameText = "Test_Company_" + randomString;

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationNameTextBox));
            driver.FindElement(ingentaCompanyInformationNameTextBox).SendKeys(verifyCompanyNameText);

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationMarketNameTextBox));
            driver.FindElement(ingentaCompanyInformationMarketNameTextBox).SendKeys("Mid Market East");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationAddress1TextBox));
            driver.FindElement(ingentaCompanyInformationAddress1TextBox).SendKeys("234, Progress Business Park");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationAddress2TextBox));
            driver.FindElement(ingentaCompanyInformationAddress2TextBox).SendKeys("Chicago");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationAddress3TextBox));
            driver.FindElement(ingentaCompanyInformationAddress3TextBox).SendKeys("United States");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationAddress4TextBox));
            driver.FindElement(ingentaCompanyInformationAddress4TextBox).SendKeys("Address 4");


            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationCityTextBox));
            driver.FindElement(ingentaCompanyInformationCityTextBox).SendKeys("Chicago");

            Thread.Sleep(2000);
        }

        public void ClickSaveAndClose()
        {
            log.Info("Save And Close the Record");

            wait.Until(ExpectedConditions.ElementExists(btnSaveAndClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveAndClose));
            driver.FindElement(btnSaveAndClose).Click();
            Thread.Sleep(2000);
        }

        public void ClickClose()
        {
            log.Info("Close the Record");

            wait.Until(ExpectedConditions.ElementExists(btnClose));
            wait.Until(ExpectedConditions.ElementIsVisible(btnClose));
            driver.FindElement(btnClose).Click();
        }

        public void verifyConfirmationPopup()
        {
            log.Info("Verifying Confirmation Popup");

            string alertmessage = driver.SwitchTo().Alert().Text;

            Assert.AreEqual("Amendments will be lost, do you want to continue?", alertmessage);
        }

        public void DismissPopUp()
        {
            log.Info("Dismissing Confirmation Popup");

            driver.SwitchTo().Alert().Dismiss();
        }

        public void AcceptPopUp()
        {
            log.Info("Dismissing Confirmation Popup");

            driver.SwitchTo().Alert().Accept();
        }

        public void SelectCompanyType(string companyName)
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popNewCompanyType");
            wait.Until(ExpectedConditions.ElementIsVisible(ddCompanyType));
            SelectElement ddCompTypes = new SelectElement(driver.FindElement(ddCompanyType));
            ddCompTypes.SelectByValue("CLIE");

        }

        public void PressOkButtonFromDD()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnOkCompanyType));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnOkCompanyType));
            Thread.Sleep(5000);
            driver.FindElement(btnOkCompanyType).Click();
        }

        public void closePopUp()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popNewCompanyType");
            wait.Until(ExpectedConditions.ElementIsVisible(btnCloseCompanyType));
            driver.FindElement(btnCloseCompanyType).Click();
        }

        public void clickTextInEmailTextBox()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationEmailTextBox));
            driver.FindElement(ingentaCompanyInformationEmailTextBox).Click();
        }

        public void verifyEmailPopUpFunctionality()
        {
            //log.Info("Verifying Email Popup functionality");
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");
            wait.Until(ExpectedConditions.ElementIsVisible(btnSend));
        }

        public void enterSubject()
        {
            driver.FindElement(txtSubject).SendKeys("TEST EMAIL");
        }

        public void enterMailBody()
        {
            //uf.switchToFrameByName(driver, wait, "RightPane");
            //uf.switchToFrameByName(driver, wait, "ifrDetail");
            //uf.switchToFrameByName(driver, wait, "radSendEmail");

            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));
            driver.FindElement(txtMailBody).Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));

            //IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
            //exe.ExecuteScript("arguments[0].click();", txtMailBody);


            ////executor.ExecuteScript("arguments[0].click();", name);
            //txtMailBody.SetAttribute("value", "Mail body line 1");

            driver.FindElement(txtMailBody).SendKeys("Mail body line 1");

            //IWebElement name = driver.FindElement(By.Id("igWebEd_tw"));

            //IJavaScriptExecutor exe = (IJavaScriptExecutor)driver;
            ////exe.ExecuteScript("arguments[0].click();", txtMailBody);

            //exe.ExecuteScript("arguments[0].click();", name);
            //name.SendKeys("Mail body line 1");

        }

        public void cutButtonFunctionality()
        {
            log.Info("Cut Button functionality");
            driver.FindElement(txtMailBody).SendKeys(Keys.End);
            driver.FindElement(txtMailBody).SendKeys(Keys.Shift + Keys.Home);
            driver.FindElement(btnCut).Click();
           
            wait.Until(ExpectedConditions.ElementExists(txtMailBody));

            string mailBodyText = driver.FindElement(txtMailBody).Text;
            Assert.AreEqual("", mailBodyText);
        }

        public void pasteButtonFunctionality()
        {
            log.Info("Paste Button functionality");
            driver.FindElement(btnPaste).Click();
            string mailBodyText = driver.FindElement(txtMailBody).Text;
            Assert.AreEqual("", mailBodyText);
        }

        public void copyPasteButtonFunctionality()
        {
            log.Info("Copy And Paste Button functionality");

            driver.FindElement(txtMailBody).Click();
            driver.FindElement(txtMailBody).SendKeys(Keys.End);
            driver.FindElement(txtMailBody).SendKeys(Keys.Shift + Keys.Home);
            driver.FindElement(btnCopy).Click();
            driver.FindElement(txtMailBody).Click();
            driver.FindElement(txtMailBody).SendKeys("\n");
            driver.FindElement(btnPaste).Click();

            string mailBodyText = driver.FindElement(txtMailBody).Text;
            Assert.AreEqual("", mailBodyText);
        }

        public void printButtonFunctionality()
        {
            log.Info("Print Button functionality");
            driver.FindElement(btnPrint).Click();

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);

            AutoItX.Send("{TAB}");
            Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);
            AutoItX.Send("{TAB}");
            Thread.Sleep(3000);
            //AutoItX.Send("{TAB}");
            //Thread.Sleep(2000);            
            AutoItX.Send("{ESCAPE}");
            Thread.Sleep(2000);
            ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
        }

        public void spellCheckingButtonFunctionality()
        {
            log.Info("Check Spelling Button functionality");

            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));
            driver.FindElement(txtMailBody).Click();
            driver.FindElement(txtMailBody).SendKeys("\n");
            driver.FindElement(txtMailBody).SendKeys("Chek Spowlling");

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);

            //verifyEmailPopUpFunctionality();
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCheckSpelling));

            driver.FindElement(btnCheckSpelling).Click();

            uf.SwitchToNewWindow(driver);

            wait.Until(ExpectedConditions.ElementToBeClickable(txtSpellCheck));

            Assert.AreEqual(true, driver.FindElement(txtSpellCheck).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnIgnore).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnIgnoreAll).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtChangeTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnChange).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnChangeAll).Displayed);
            Assert.AreEqual(true, driver.FindElement(lstSuggestions).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFinish).Displayed);

            wait.Until(ExpectedConditions.ElementToBeClickable(btnIgnore));
            driver.FindElement(btnIgnore).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(btnIgnore));
            driver.FindElement(btnIgnoreAll).Click();

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => IsAlertShown(drv));

            // Check the presence of alert
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");
            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));

            wait.Until(ExpectedConditions.ElementToBeClickable(btnCheckSpelling));

            driver.FindElement(btnCheckSpelling).Click();

            uf.SwitchToNewWindow(driver);

            wait.Until(ExpectedConditions.ElementToBeClickable(txtSpellCheck));

            wait.Until(ExpectedConditions.ElementToBeClickable(btnChange));
            driver.FindElement(btnChange).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(btnChangeAll));
            driver.FindElement(btnChangeAll).Click();

            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => IsAlertShown(drv));

            // Check the presence of alert
            alert = driver.SwitchTo().Alert();
            alert.Accept();

        }

        bool IsAlertShown(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException e)
            {
                return false;
            }
            return true;
        }

        public void FontSizeFormatingFuncationality()
        {
            log.Info("Font Dropdown functionality");

            driver.SwitchTo().Window(driver.WindowHandles.First());

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");
            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));

            driver.FindElement(txtMailBody).Click();
            driver.FindElement(txtMailBody).SendKeys(Keys.End);
            driver.FindElement(txtMailBody).SendKeys(Keys.Shift + Keys.Home);

            driver.FindElement(ddFont).Click();
            driver.FindElement(selectFont).Click();

            driver.FindElement(ddSize).Click();
            driver.FindElement(selectSize).Click();

            driver.FindElement(ddFormatting).Click();
            driver.FindElement(selectFormatting).Click();

            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
        }

        public void JustifyFunctionality()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait;

            log.Info("Justify Buttons functionality");

            driver.FindElement(btnCenterJustify).Click();
            ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnJustify).Click();
            ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnRightJustify).Click();
            uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnLeftJutify).Click();
            uf.fluentTimeout(driver, "second", 10, 5);
        }

        public void IndentFunctionality()
        {
            DefaultWait<IWebDriver> ingentaIDefaultWait;

            log.Info("Indent Buttons functionality");

            driver.FindElement(btnIncreaseIndent).Click();
            uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnDecreaseIndent).Click();
            ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnUnorderedList).Click();
            ingentaIDefaultWait = uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnOrderedList).Click();
            uf.fluentTimeout(driver, "second", 10, 5);
            driver.FindElement(btnInsertRule).Click();

            driver.FindElement(txtWidth).Clear();
            driver.FindElement(btnInsertRule).SendKeys("50%");
            driver.FindElement(txtSize).Clear();
            driver.FindElement(txtSize).SendKeys("4");

            IWebElement ddAlig = driver.FindElement(ddAlign);
            SelectElement ddAlign1 = new SelectElement(ddAlig);
            ddAlign1.SelectByText("Center");

            driver.FindElement(txtColor).Click();
            driver.FindElement(selectColor).Click();

            driver.FindElement(chkSolid).Click();
            driver.FindElement(btnOk).Click();
        }

        public void BoldItalicUnderlineFunctionality()
        {

            driver.FindElement(btnBold).Click();

            driver.FindElement(txtMailBody).Click();
            driver.FindElement(txtMailBody).SendKeys("\n" + "Bold letters");

            driver.FindElement(btnItalic).Click();
            driver.FindElement(txtMailBody).SendKeys("\n" + "Italic letters");

            driver.FindElement(btnUnderline).Click();
            driver.FindElement(txtMailBody).SendKeys("\n" + "Underline letters");


            driver.FindElement(txtMailBody).SendKeys("\n" + "Font Color and Font Highlight");

            driver.FindElement(txtMailBody).SendKeys(Keys.End);
            driver.FindElement(txtMailBody).SendKeys(Keys.Shift + Keys.Home);

            driver.FindElement(btnFontColor).Click();
            driver.FindElement(selectFontColor).Click();

            driver.FindElement(btnFontHighlight).Click();
            driver.FindElement(selectFontHighlight).Click();

        }

        public void InsertNewTableDetails()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnDisplayTableMenu));

            driver.FindElement(btnDisplayTableMenu).Click();
            driver.FindElement(insertTable).Click();

            Assert.AreEqual(true, driver.FindElement(tableRows).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableColumns).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableAlign).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableCellPadding).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableBorderSize).Displayed);


            Assert.AreEqual(true, driver.FindElement(tableCellSpacing).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableWidth).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableOkButton).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableCancelButton).Displayed);

            driver.FindElement(tableRows).Clear();
            driver.FindElement(tableColumns).Clear();
            driver.FindElement(tableCellPadding).Clear();
            driver.FindElement(tableBorderSize).Clear();
            driver.FindElement(tableCellSpacing).Clear();
            driver.FindElement(tableWidth).Clear();


            driver.FindElement(tableRows).SendKeys("2");
            driver.FindElement(tableColumns).SendKeys("3");

            IWebElement ddTableAl = driver.FindElement(tableAlign);
            SelectElement ddAlign1 = new SelectElement(ddTableAl);
            ddAlign1.SelectByText("Right");

            driver.FindElement(tableCellPadding).SendKeys("2");
            driver.FindElement(tableBorderSize).SendKeys("2");

            driver.FindElement(tableCellSpacing).SendKeys("2");
            driver.FindElement(tableWidth).SendKeys("50%");

            driver.FindElement(tableBackColor).Click();
            driver.FindElement(selectBackColor).Click();

            driver.FindElement(tableBorderColor).Click();
            driver.FindElement(selectBorderColor).Click();

            Thread.Sleep(2000);

            driver.FindElement(tableOkButton).Click();
        }

        public void WordCountFunctionality()
        {
            log.Info("Word Count functionality");
            driver.FindElement(btnWordCount).Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            driver.FindElement(btnHTML).Click();

            log.Info("Save Template functionality");

            driver.FindElement(btnSaveAsTemplate).Click();
            driver.FindElement(txtTemplateName).SendKeys("Test Template");
            driver.FindElement(btnSaveAsTemplate).Click();

            //driver.FindElement(ddTemplateName).Click();

            log.Info("Font Dropdown functionality");

            driver.SwitchTo().Window(driver.WindowHandles.First());

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");
            wait.Until(ExpectedConditions.ElementToBeClickable(ddTemplateName));

            log.Info("Update Template functionality");

            IWebElement ddTemplate = driver.FindElement(ddTemplateName);
            SelectElement ddTemplateN = new SelectElement(ddTemplate);
            ddTemplateN.SelectByText("Test Template");

            wait.Until(ExpectedConditions.ElementToBeClickable(btnUpdateTemplate));
            driver.FindElement(btnUpdateTemplate).Click();


            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));
            driver.FindElement(txtMailBody).Click();

            driver.FindElement(txtMailBody).SendKeys(Keys.Control + "a");
            driver.FindElement(txtMailBody).SendKeys(Keys.Backspace);

            wait.Until(ExpectedConditions.ElementIsVisible(btnDisplayTableMenu));
            driver.FindElement(btnDisplayTableMenu).Click();
            driver.FindElement(insertTable).Click();
            Thread.Sleep(2000);
            driver.FindElement(tableOkButton).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));
            driver.FindElement(txtMailBody).Click();

            driver.FindElement(txtMailBody).SendKeys(Keys.Down);

            wait.Until(ExpectedConditions.ElementIsVisible(btnDisplayTableMenu));
            driver.FindElement(btnDisplayTableMenu).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(deleteTableRow));
            driver.FindElement(deleteTableRow).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(txtMailBody));
            driver.FindElement(txtMailBody).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(btnDisplayTableMenu));
            driver.FindElement(btnDisplayTableMenu).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(insertTableRow));
            driver.FindElement(insertTableRow).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(btnSaveAsTemplate));
            driver.FindElement(btnSaveAsTemplate).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(btnCloseEmailPopUp));
            driver.FindElement(btnCloseEmailPopUp).Click();
        }

        public void browseFile()
        {
            IWebElement browseButton;
            string uploadFilePath = Environment.CurrentDirectory + "\\Upload\\Documents\\" + "Copyright.txt";
            browseButton = driver.FindElement(btnBrowse);
            uf.uploadfile(browseButton, uploadFilePath);
            StringAssert.Contains("Copyright.txt", driver.FindElement(btnBrowse).GetAttribute("value"));
        }

        public void clickToButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnTo));
            driver.FindElement(btnTo).Click();
        }

        public void verifyEmailAddressBookDetails()
        {   
            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementExists(btnApply));

            Assert.AreEqual(true, driver.FindElement(btnApply).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCancelInToAddress).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtSearchBy).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnSearchToAddress).Enabled);

            Assert.AreEqual(true, driver.FindElement(tblUserNames).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtToAddress).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtCCAddress).Enabled);

            Assert.AreEqual(true, driver.FindElement(txtBCCAddress).Enabled);

        }

        public void verifyEmailPopupDetails()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radSendEmail");


            wait.Until(ExpectedConditions.ElementIsVisible(btnSend));

            Assert.AreEqual(true, driver.FindElement(btnSend).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSaveAsTemplate).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnUpdateTemplate).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddTemplateName).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkPrivacyContacts).Displayed);

            Assert.AreEqual(true, driver.FindElement(chkReadReceipt).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCC).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnBCC).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTo).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtCC).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtBCC).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSubject).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnBrowse).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCut).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnCopy).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnPaste).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnPasteAsHTML).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnPrint).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCheckSpelling).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddFont).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddSize).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddFormatting).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnLeftJutify).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCenterJustify).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnRightJustify).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnJustify).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnIncreaseIndent).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDecreaseIndent).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnUnorderedList).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnInsertRule).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnBold).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnItalic).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnUnderline).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFontColor).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnFontHighlight).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDisplayTableMenu).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFindAndReplace).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnInsertImage).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnWordCount).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtMailBody).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDesign).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnHTML).Displayed);
        }


        public void clickHeaderSearchButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnSearch).Click();
        }
        public void verifySearchCriteria()
        {

            log.Info("Verifying Search Criteria");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrSelection");

            wait.Until(ExpectedConditions.ElementIsVisible(ddSearchFor));

            Assert.AreEqual(true, driver.FindElement(ddSearchFor).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNew).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSiteDisplayMode).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnSaveResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOpenResults).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtCompanySearch).Displayed);

            Assert.AreEqual(true, driver.FindElement(txtTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTel).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCompanyTypes).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearchGo).Displayed);


            Assert.AreEqual(true, driver.FindElement(tableHeaderCompany).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSiteId).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderTel).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdd1).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAdd2).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderSTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderRegion).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderPostCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCompanyType).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAgencyType).Displayed);
        }
        public void clickStationeryButtonInHeader()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnStationeryInHeader));
            driver.FindElement(btnStationeryInHeader).Click();
        }

        public void verifyStationeryPopupDetails()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(btnclose));

            Assert.AreEqual(true, driver.FindElement(btnclose).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddLetter).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnEmail).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);
        }

        public void clickActiveCheckboxOfCompany()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(buttonActiveInactive));
            driver.FindElement(buttonActiveInactive).Click();
        }

        public void clickActiveCheckbox()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnActiveInaactiveInContacts));
            driver.FindElement(btnActiveInaactiveInContacts).Click();
        }
        public void createNewCompanyInformation(string companyName)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationNameTextBox));
            driver.FindElement(ingentaCompanyInformationNameTextBox).SendKeys(companyName);
        }


        //Neerav Code


        public void verifyCompanyTypePopUpIsVisible()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popNewCompanyType");

            Assert.AreEqual(true, driver.FindElement(ddCompanyType).Enabled);

        }

        public void EnterTaxRegNumber(string TaxRegNo)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tbTaxRegNumber));
            driver.FindElement(tbTaxRegNumber).SendKeys(TaxRegNo);
        }

        public void verifyCompanyTypePopup()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popNewCompanyType");
            bool ddCt = driver.FindElement(ddCompanyType).Displayed;
            Assert.AreEqual(true, ddCt);

            bool btnOkCT = driver.FindElement(btnOkCompanyType).Displayed;
            Assert.AreEqual(true, btnOkCT);
        }



        public void clickSearchButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(btnSearch));
            driver.FindElement(btnSearch).Click();
        }

        public void clickSelectButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(btnSelect));
            driver.FindElement(btnSelect).Click();
        }

        public void clickCancelButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(btnCancel));
            driver.FindElement(btnCancel).Click();
        }

        public void clickOverrideButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(btnOverride));
            driver.FindElement(btnOverride).Click();
        }

        public void selectingPossibleMatches()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tablePossibleMatches));
            driver.FindElement(tabMatchPercentage).Click();

            SelectCompanyType(verifyCompanyTypeValue);

        }

        public void verifySaveFuntionality()
        {
            bool btSelect = driver.FindElement(btnSelect).Displayed;
            Assert.AreEqual(true, btSelect);

            bool btSearch = driver.FindElement(btnSearch).Displayed;
            Assert.AreEqual(true, btSearch);

            bool btCancel = driver.FindElement(btnCancel).Displayed;
            Assert.AreEqual(true, btCancel);

            bool btOverride = driver.FindElement(btnOverride).Displayed;
            Assert.AreEqual(true, btOverride);

        }

        public void verifyCancelButtonFuntionality()
        {
            bool btSave = driver.FindElement(btnSave).Enabled;
            Assert.AreEqual(true, btSave);

            bool btSandC = driver.FindElement(btnSaveAndClose).Enabled;
            Assert.AreEqual(true, btSandC);

            bool btClse = driver.FindElement(btnClose).Enabled;
            Assert.AreEqual(true, btSave);

        }
        public void verifyOverrideButtonFuntionality()
        {
            bool btSave = driver.FindElement(btnSave).Enabled;
            Assert.AreEqual(false, btSave);

            bool btSandC = driver.FindElement(btnSaveAndClose).Enabled;
            Assert.AreEqual(false, btSandC);

            bool btClse = driver.FindElement(btnClose).Enabled;
            Assert.AreEqual(false, btSave);

            //bool btAIa = driver.FindElement(btnActiveInActive).Enabled;
            //Assert.AreEqual(false, btAIa);
        }

        public void verifySearchButtonDisabled()
        {
            bool btSrch = driver.FindElement(btnSearch).Enabled;
            Assert.AreEqual(false, btSrch);
        }

        public void verifySearchStationeryButtonEnabled()
        {
            bool btSrch = driver.FindElement(btnSearch).Enabled;
            Assert.AreEqual(true, btSrch);

            bool btStati = driver.FindElement(btnStationery).Enabled;
            Assert.AreEqual(true, btStati);
        }

        public void verifyCompanyMatchesGridDisplayed()
        {
            Assert.AreEqual(false, uf.IsElementDisplayed(driver, tablePossibleMatches));
        }

        public void verifyCompanyName(string companyName)
        {
            string comName = driver.FindElement(ingentaCompanyInformationNameTextBox).Text;

            Assert.AreEqual(companyName, comName);
        }

        public void verifyStationaryButtonIsDisplayed()
        {
            Assert.AreEqual(true, driver.FindElement(btnStationery).Enabled);
        }

        public void ClickOverrideButtonIfExists()
        {
            if (uf.IsElementDisplayed(driver, btnOverride))
            {
                log.Info("Click on override");
                wait.Until(ExpectedConditions.ElementExists(btnOverride));
                wait.Until(ExpectedConditions.ElementIsVisible(btnOverride));
                Assert.AreEqual(true, driver.FindElement(btnOverride).Displayed);
                driver.FindElement(btnOverride).Click();
            }

        }

        public void enterCompanyName(string companyName)
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");
            Thread.Sleep(2000);

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationNameTextBox));
            driver.FindElement(ingentaCompanyInformationNameTextBox).SendKeys(companyName);
        }

        public void verifyInformationPageIsLoaded()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationNameTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationMarketNameTextBox).Displayed);
        }

        public void verifyCompanyType(string companyType)
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");


            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            var mySelectElm = driver.FindElement(ddCompanyTypeInfo);
            var mySelect = new SelectElement(mySelectElm);
            var option = mySelect.SelectedOption;
            string comType = option.Text;
            //string comType = driver.FindElement(ddCompanyTypeInfo).Text;
            Assert.AreEqual(companyType, comType);
        }

        public void verifySavedComapnyDetails()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");


            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            string comName = driver.FindElement(ingentaCompanyInformationNameTextBox).GetAttribute("value").ToString();
            Assert.AreEqual(verifyCompanyNameText, comName);

            string marName = driver.FindElement(ingentaCompanyInformationMarketNameTextBox).GetAttribute("value").ToString();
            Assert.AreEqual("Mid Market East", marName);

            var mySelectElm = driver.FindElement(ddCompanyTypeInfo);
            var mySelect = new SelectElement(mySelectElm);
            var option = mySelect.SelectedOption;
            string comType = option.Text;
            //string comType = driver.FindElement(ddCompanyTypeInfo).Text;
            Assert.AreEqual(verifyCompanyTypeValue, comType);

        }

        public void editCompanyInformation()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");


            uf.switchToFrameByElement(driver, wait, "ifrDetail");


            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationMarketNameTextBox));
            driver.FindElement(ingentaCompanyInformationMarketNameTextBox).Clear();
            driver.FindElement(ingentaCompanyInformationMarketNameTextBox).SendKeys(editedCompanyMarketNameText);

            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationAliasTextBox));
            driver.FindElement(ingentaCompanyInformationAliasTextBox).Clear();
            driver.FindElement(ingentaCompanyInformationAliasTextBox).SendKeys(editedAliasName);

            wait.Until(ExpectedConditions.ElementToBeClickable(ingentaCompanyInformationCompanyTypeDropDown));
            IWebElement ddcomType = driver.FindElement(ingentaCompanyInformationCompanyTypeDropDown);
            SelectElement paymenttype2 = new SelectElement(ddcomType);
            paymenttype2.SelectByText(editedCompanyTypeValue);

        }

        public void verifyUpdatedCompanyInformation()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");


            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            string marName = driver.FindElement(ingentaCompanyInformationMarketNameTextBox).GetAttribute("value").ToString();
            Assert.AreEqual(editedCompanyMarketNameText, marName);

            string aliasName = driver.FindElement(ingentaCompanyInformationAliasTextBox).GetAttribute("value").ToString();
            Assert.AreEqual(editedAliasName, aliasName);

            var mySelectElm = driver.FindElement(ddCompanyTypeInfo);
            var mySelect = new SelectElement(mySelectElm);
            var option = mySelect.SelectedOption;
            string comType = option.Text;
            //string comType = driver.FindElement(ddCompanyTypeInfo).Text;
            Assert.AreEqual(editedCompanyTypeValue, comType);
        }

        public void verifySearchButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            Assert.AreEqual(true, driver.FindElement(tableCompanyList).Displayed);

        }

        public void verifyActiveCheckboxFunctionality()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnActiveInaactiveInContacts));
            string activeStatus = driver.FindElement(btnActiveInaactiveInContacts).GetAttribute("value").ToString();
            if (activeStatus == "Active")
                Assert.AreEqual("Active", activeStatus);
            else
            {
                Assert.AreEqual("Inactive", activeStatus);
            }
        }

        public void verifyActiveCheckboxFunctionalityOfCompany()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(buttonActiveInactive));
            string activeStatus = driver.FindElement(buttonActiveInactive).GetAttribute("value").ToString();
            if (activeStatus == "Active")
                Assert.AreEqual("Active", activeStatus);
            else
            {
                Assert.AreEqual("Inactive", activeStatus);
            }
        }


        public void setCCCTYConfiguration(string CCCTYConfig)
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");
            wait.Until(ExpectedConditions.ElementIsVisible(tabConfiguration));
            wait.Until(ExpectedConditions.ElementToBeClickable(tabConfiguration));
            driver.FindElement(tabConfiguration).Click();

            //In Configuration Page

            wait.Until(ExpectedConditions.ElementIsVisible(imgUserCenter));
            wait.Until(ExpectedConditions.ElementToBeClickable(imgUserCenter));
            driver.FindElement(imgUserCenter).Click();

            //In User Center Page

            wait.Until(ExpectedConditions.ElementIsVisible(imgUserPrefDefault));
            wait.Until(ExpectedConditions.ElementToBeClickable(imgUserPrefDefault));
            driver.FindElement(imgUserPrefDefault).Click();

            //In User Preference Defaults Page

            if (CCCTYConfig == "True")
            {
                CCCTYFlagValueTrue();
            }
            else if (CCCTYConfig == "False")
            {
                CCCTYFlagValueFalse();
            }




        }

        public void CCCTYFlagValueTrue()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tableUserDefaults));

            String boolValue = driver.FindElement(tabBoolVal).Text;

            if (boolValue == "No")
            {
                driver.FindElement(tabBoolVal).Click();

                driver.FindElement(btnEdit).Click();

                wait.Until(ExpectedConditions.ElementIsVisible(chkCCCTYBooleanValue));

                driver.FindElement(chkCCCTYBooleanValue).Click();

                driver.FindElement(btnSave).Click();

                driver.SwitchTo().DefaultContent();

                driver.FindElement(btnHome).Click();
            }

            else if (boolValue == "Yes")
            {
                driver.SwitchTo().DefaultContent();

                driver.FindElement(btnHome).Click();
            }

        }

        public void CCCTYFlagValueFalse()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(tableUserDefaults));

            String boolValue = driver.FindElement(tabBoolVal).Text;

            if (boolValue == "Yes")
            {
                driver.FindElements(tabBlankSpace)[1].Click();

                wait.Until(ExpectedConditions.ElementToBeClickable(btnEdit));

                driver.FindElement(btnEdit).Click();

                wait.Until(ExpectedConditions.ElementIsVisible(chkCCCTYBooleanValue));


                driver.FindElement(chkCCCTYBooleanValue).Click();

                driver.FindElement(btnSave).Click();

                driver.SwitchTo().DefaultContent();

                driver.FindElement(btnHome).Click();

            }

            else if (boolValue == "No")
            {
                driver.SwitchTo().DefaultContent();

                driver.FindElement(btnHome).Click();
            }

        }

        //

        #endregion

    }
}

