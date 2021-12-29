using AutoIt;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility_Classes;

namespace Ingenta.Framework.Pages
{
    [TestFixture, Description("This is a page object for Companies History Page")]
    public class CompanyHistory_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        #region Variables
        string tommorowsDate = DateTime.Now.AddDays(4).ToString("dd-M-yyyy");
        string today = DateTime.Today.ToString("dd-M-yyyy");
        string yesterdaysDate = DateTime.Today.AddDays(-3).ToString("dd-M-yyyy");

        int totalNoOfCalls;
        int noOfAttachmentsCount = 0;
        int verifyNoOfAttachmentsCount;

        #endregion Variables


        public CompanyHistory_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository
        By lblHistory = By.Id("FFHistory_lblHistory");
        By tabHistory = By.Id("iglbarMenu_0_Item_2");
        By tabHistoryFromContact = By.Id("iglbarMenu_0_Item_1");
        By btnSaveAndClose = By.Id("btnSaveClose");
        By btnSave = By.Id("btnSave");
        By btnNewTask = By.Id("FFHistory_ibtnAddCall");
        By btnClose = By.Id("btnCancel");
        By btnContact = By.Id("btnContact");
        By txtSubject = By.Id("ucTaskDetail_txtSubject");
        By chkPrivate = By.Id("ucTaskDetail_chkPrivate");
        By ddlUser = By.Id("ucTaskDetail_ddlApplicationUsers");
        By txtLinksTo = By.Id("ucTaskDetail_txtLinkType");
        By ddlTaskType = By.Id("ucTaskDetail_ddlTaskType");
        By dtStarts = By.Id("ucTaskDetail_ffdcStartDate_iwdcDate_input");
        By dtStartTime = By.Id("ucTaskDetail_iwdteStart_t");
        By companyEllipsis = By.Id("ucTaskDetail_ucCompanyContactChooser_ctlModalCompany_btnModal");
        By dtEnds = By.Id("ucTaskDetail_ffdcEndDate_iwdcDate_input");
        By dtEndTime = By.Id("ucTaskDetail_iwdteEnd_t");

        By chkAllDayApp = By.Id("ucTaskDetail_chkAllDay");
        By ddlTaskStatus = By.Id("ucTaskDetail_ddlTaskStatus");
        By txtRegistrationNumber = By.Id("ucHistoryDetail_txtRegistrationNumber");
        By contactEllipsis = By.Id("ucTaskDetail_ucCompanyContactChooser_ctlModalContact_btnModal");
        By txtNotes = By.Id("ucTaskDetail_txtNotes");
        By btnNewBooking = By.Name("FFHistory$ibtnAddBooking");
        By btnInventory = By.Id("FFHistory_ibtnInventorySelection");
        By btnRefresh = By.Id("FFHistory_ibtnRefresh");
        By dtStartingFrom = By.Id("FFHistory_ffdcShowHistoryFrom_dteDate_input");
        By ddFilterGroup = By.Id("FFHistory_ddlFilterBy");
        By colType = By.Id("FFHistoryxgrdHistory_c_0_7");
        By colStartDate = By.Id("FFHistoryxgrdHistory_c_0_8");
        By colSubject = By.Id("FFHistoryxgrdHistory_c_0_9");
        By colStatus = By.Id("FFHistoryxgrdHistory_c_0_10");
        By colName = By.Id("FFHistoryxgrdHistory_c_0_11");
        By tableTask = By.Id("G_FFHistoryxgrdHistory");
        By tableTaskRows = By.CssSelector("table#G_FFHistoryxgrdHistory > tbody >tr");
        By gridStartTimeDate = By.CssSelector("td.ig_336a881e_r1.GridRow.UltraWebGridRow.FormGridCellDate");
        By tabFollowUpCalls = By.Id("iglbarMenu_0_Item_1");
        By tabNotes = By.Id("iglbarMenu_0_Item_2");
        By tabAttachmentsInNewTask = By.Id("iglbarMenu_0_Item_3");
        By tabMessages = By.Id("iglbarMenu_0_Item_4");
        By tabElectronicClassification = By.Id("iglbarMenu_1_Item_0");
        By tabCompanyInformation = By.Id("iglbarMenu_1_Item_1");
        By tabAttachments = By.Id("iglbarMenu_0_Item_8");
        By btnNewAttachement = By.Id("ucAttachment_btnNewAttachment");
        By btnDeleteAttachement = By.Id("ucAttachment_pnlDelete");
        By tableHeaderTitle = By.Id("ucAttachmentxgrdAttachments_c_0_3");
        By tableHeaderType = By.Id("ucAttachmentxgrdAttachments_c_0_4");
        By tableHeaderFileName = By.Id("ucAttachmentxgrdAttachments_c_0_5");
        By tableHeaderAddedBy = By.Id("ucAttachmentxgrdAttachments_c_0_6");
        By tableHeaderCreated = By.Id("ucAttachmentxgrdAttachments_c_0_7");
        By ddBrand = By.Id("ucTaskDetail_ddlBrand");
        By ddResult = By.Id("ucTaskDetail_ddlTaskResult");
        By chkComplete = By.Id("ucTaskDetail_chkComplete");
        By startIncreaseTime = By.Id("ucTaskDetail_iwdteStart_b1");
        By startDecreaseTime = By.Id("ucTaskDetail_iwdteStart_b2");
        By endIncreaseTime = By.Id("ucTaskDetail_iwdteEnd_b1");
        By endDecreaseTime = By.Id("ucTaskDetail_iwdteEnd_b2");
        By chkIsActive = By.CssSelector("span.FormCheckbox.mycheckbox > input");
        By selectingCompanybutton = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By ddDatePickerStart = By.Id("ucTaskDetail_ffdcStartDate_iwdcDate_img");
        By ddDatePickerEnd = By.Id("ucTaskDetail_ffdcEndDate_iwdcDate_img");
        By calStartDate = By.Id("igcalucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1");
        By calEndDate = By.Id("igcalucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2");
        By headingFollowUpCalls = By.Id("ucFollowupCallList_lblFollowupCalls");

        //OR N
        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By btnSearchGo = By.Id("Search_GoButton");
        By lnkCompanyRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By ingentaCompanyNewButton = By.Id("Search_SearchBar_btnUser");
        By btnSiteDisplayMode = By.Id("Search_SearchBar_btnOpenSite");
        By tableSearchCompany = By.Id("tdQuery");
        By btnDelete = By.Id("btnDelete");
        By btnStationery = By.Id("btnStationery");
        By btnCreateBooking = By.Name("btnCreateBooking");
        By tbLastName = By.Id("Search_FieldSelect0_txtValue1");
        By tbCompanyNameContact = By.Id("Search_FieldSelect2_txtValue1");
        By tbTelephoneContact = By.Id("Search_FieldSelect3_txtValue1");
        By tbEmailContact = By.Id("Search_FieldSelect4_txtValue1");
        By colFirstName = By.Id("SearchxresultsGrid_c_0_5");
        By colLastName = By.Id("SearchxresultsGrid_c_0_4");
        By colJobTitle = By.Id("SearchxresultsGrid_c_0_7");
        By colCompany = By.Id("SearchxresultsGrid_c_0_10");
        By colSiteId = By.Id("SearchxresultsGrid_c_0_11");
        By colLocation = By.Id("SearchxresultsGrid_c_0_13");
        By colPostalCode = By.Id("SearchxresultsGrid_c_0_14");
        By colTelephone = By.Id("SearchxresultsGrid_c_0_17");
        By colFax = By.Id("SearchxresultsGrid_c_0_18");
        By colEmail = By.Id("SearchxresultsGrid_c_0_19");
        By ddlBrand = By.Id("ucTaskDetail_ddlBrand");
        By ddlResult = By.Id("ucTaskDetail_ddlTaskResult");
        By cbComplete = By.Name("ucTaskDetail$chkComplete");
        By startCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody >tr > td.ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_10");
        By endCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2_512> tbody >tr > td.ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_20");
        By increaseStartTime = By.Id("ucTaskDetail_iwdteStart_b1");
        By decreaseEndTime = By.Id("ucTaskDetail_iwdteEnd_b2");
        By tableCompanyResults = By.Id("SearchxresultsGrid_div");
        By tbCompanyName = By.Id("ucTaskDetail_ucCompanyContactChooser_txtCompany");
        By tbContactName = By.Id("ucTaskDetail_ucCompanyContactChooser_txtContact");
        By txtPageHeading = By.Id("lblPageHeading");
        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By tabElectronicsClassification = By.Id("iglbarMenu_1_Item_0");
        By tabCompanyInfo = By.Id("iglbarMenu_1_Item_1");
        By tabContactInfo = By.Id("iglbarMenu_1_Item_2");
        By tabMailing = By.Id("iglbarMenu_1_Item_3");
        By tabMarketing = By.Id("iglbarMenu_1_Item_4");
        By tbNotes = By.Id("Notes_txtNote");
        By btnDatePicker = By.Id("Notes_ucStartDate_ucDateChooser_iwdcDate_input");
        By btnPostNote = By.Id("Notes_btnPost");
        By tableNotes = By.ClassName("NoteListContainer");
        By tabNotesDate = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(2)");
        By tabUser = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(3)");
        By tabNoteCreated = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(4)");
        By noteToBeSelected = By.CssSelector("div.NoteListContainer > table > tbody > tr:nth-child(2) > td");
        By grdNotesFirstRow = By.Id("Notes_ucNoteList_rptMain_ctl00_trNote");
        By tabReplyNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trReply");
        By btnReply = By.CssSelector("input.linkButton.edit");
        By btnEditAttachement = By.CssSelector("input.ig_850be207_rcb1212.gridRowImg.editBlack");
        By btnViewAttachement = By.CssSelector("table#G_ucAttachmentxgrdAttachments > tbody > tr > td:nth-child(2)");
        By msgBlankReply = By.Id("Notes_rfvNoteText");
        By btnDeleteNote = By.Name("Notes$btnDelete");
        By selectParentNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trNote");
        By txtSalesAccountCode = By.Id("txtSalesAccountCodeValue");
        By txtAccountStatus = By.Id("txtAccountStatusValue");
        By txtSalesLedgerCode = By.Id("txtSalesLedgerCodeValue");
        By txtStatusReason = By.Id("txtStatusReasonValue");
        By btnCloseCB = By.Id("ctl00_cphMain_ucRibbon_btnSave");
        By btnCancelCB = By.Id("ctl00_cphMain_ucRibbon_btnClose");
        By btnCustomerCB = By.Id("ctl00_cphMain_ucRibbon_btnEditParties");
        By btnNextCB = By.Id("ctl00_cphMain_ucRibbon_btnNext");
        By btnBundleSearchCB = By.Id("ctl00_cphMain_ucRibbon_btnBundle");
        By frameBookingHeader = By.ClassName("HeaderPanelFieldset");
        By ddlBookingType = By.Id("ctl00_cphMain_ddlBookingType_DropDownList1");
        By txtBookingRefernece = By.Id("ctl00_cphMain_txtBookingRef_textBox1");
        By cbParentBooking = By.Id("ctl00_cphMain_chkIsParent_CheckBox1");
        By btnBundleSearch = By.Id("ctl00_cphMain_ucRibbon_btnBundle");
        By btnCancelPopUp = By.Id("ctl00_cphMain_ucRibbon_btnClose");
        By tableRecentBookings = By.Id("ctl00_cphMain_grdRecentBookings");
        By gridRecentBookingRef = By.CssSelector("table#ctl00_cphMain_grdRecentBookings > tbody > tr:nth-child(2) > td:nth-child(3)");
        By gridRecentBookingCompanyName = By.CssSelector("table#ctl00_cphMain_grdRecentBookings > tbody > tr:nth-child(2) > td:nth-child(4)");
        By ddlSelectLetter = By.Id("lstLetter");
        By btnEmail = By.Id("lbtnSend");
        By btnSaveAsPDF = By.Id("btnSaveAsPDF");
        By btnCloseStatitonery = By.Id("btnclose");
        By btnCompany = By.Id("btnCompany");
        By btnCloseHistory = By.Id("btnCancel");
        By btnViewThisCall = By.ClassName("ig_336a881e_rcb1112");
        By btnDeleteCall = By.Id("btnDelete");
        By ddlStartingDatePT = By.Id("ctl00_cphMain_ffdcShowHistoryFrom_iwdcDate");
        By btnRefreshPt = By.Id("ctl00_cphMain_btnRefresh");
        By gridStartDateTimePT = By.CssSelector("th.GridHeader.rgHeader:nth-child(2)");
        By gridSubjectPT = By.CssSelector("th.GridHeader.rgHeader:nth-child(3)");
        By gridCompanyPT = By.CssSelector("th.GridHeader.rgHeader:nth-child(4)");
        By gridContactPT = By.CssSelector("th.GridHeader.rgHeader:nth-child(5)");
        By gridCallStatusPT = By.CssSelector("th.GridHeader.rgHeader:nth-child(6)");
        By ddlUserGroupsUC = By.Id("ctl00_cphMain_ddlUserGroup");
        By ddlUserListUC = By.Id("ctl00_cphMain_cblUsers_Input");
        By btnDisplayUC = By.Id("ctl00_cphMain_btnUsers");
        By txtMinPerRowUC = By.Name("ctl00$cphMain$txtMinutesPerRow");
        By txtTodayUC = By.ClassName("rsToday");
        By headerDay = By.ClassName("rsHeaderDay");
        By headerWeek = By.ClassName("rsHeaderWeek");
        By headerMonth = By.ClassName("rsHeaderMonth");
        By headerMultiDay = By.ClassName("rsHeaderMultiDay");
        By btnNewFollowUpCalls = By.Id("ucFollowupCallList_btnAddFollowupTask");
        By txtAttachement = By.Id("txtAttachment");
        By ddlAttachmentType = By.Id("ddlAttachmentType");
        By btnChooseFile = By.Id("fupAttachment");
        By btnSaveAttachement = By.ClassName("toolbarPanel");
        By lblAttachment = By.Id("lblFileName");
        By gridTitle = By.CssSelector("td.ig_850be207_r1.GridRow.UltraWebGridRow.FormGridCellText");
        By attachmentsRow = By.CssSelector("table#G_ucAttachmentxgrdAttachments > tbody > tr");
        By btnDeleteAttachment = By.Id("ucAttachment_btnDelete");
        By btnDeleteAttachmentNewWindow = By.Id("btnDelete");
        //Inventory
        By btnNewSearch = By.Id("ctl00_cphMain_btnNewSearch");
        By ddlAdType = By.Id("ctl00_cphMain_srch01_ddlAdType_DropDownList1");
        By ddlCategory = By.Id("ctl00_cphMain_srch01_ddlCategory_DropDownList1");
        By ddlMediaGrp = By.Id("ctl00_cphMain_srch01_ddlMediumGroup_DropDownList1");
        By lstMedia = By.Id("ctl00_cphMain_srch01_lbMedia_ListBox1");
        By chkAll = By.Id("ctl00_cphMain_srch01_lbMedia_chkAll");
        By lstSection = By.Id("ctl00_cphMain_srch01_lbMediumSection_ListBox1");

        By lstInventoryPlacement = By.Id("ctl00_cphMain_srch01_lbMediumInventory_ListBox1");
        By ddlPeriod = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_ddlPeriod");
        By ddlWeek = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_ddlWeekNum");

        By dtRangeFrom = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_dteRangeFrom_iwdcDate_input");
        By dtRangeTo = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_dteRangeTo_iwdcDate_input");
        By chkSun = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkSun");
        By chkMon = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkMon");
        By chkTue = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkTue");
        By chkWed = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkWed");
        By chkThus = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkThu");
        By chkFri = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkFri");
        By chkSat = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_chkSat");

        By btnJan = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnJanuary");
        By btnFeb = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnFebruary");
        By btnMar = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnMarch");
        By btnApr = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnApril");
        By btnMay = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnMay");
        By btnJun = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnJune");
        By btnJul = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnJuly");
        By btnAug = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnAugust");
        By btnSep = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnSeptember");
        By btnOct = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnOctober");
        By btnNov = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnNovember");
        By btnDec = By.Id("ctl00_cphMain_srch01_ucBkingPeriod_btnDecember");

        By rdMatrix = By.Id("ctl00_cphMain_srch01_rblInventoryView_0");
        By rdPages = By.Id("ctl00_cphMain_srch01_rblInventoryView_1");
        By rdList = By.Id("ctl00_cphMain_srch01_rblInventoryView_2");
        By ddlListMode = By.Id("ctl00_cphMain_srch01_ddlListViewMode_DropDownList1");
        By ddlAdSize = By.Id("ctl00_cphMain_srch01_ddlAdSize_DropDownList1");
        By btnGetInventory = By.Id("ctl00_cphMain_srch01_btnGetInventory");
        By ddlAddToCart = By.Id("ctl00_cphMain_srch01_ddlBookingStatus_ListView_DropDownList1");


        //Inventory

        //

        #endregion

        #region Functions
        //Following function performs navigation to History Tab
        public void navigateToHistoryTab(string calledFrom)
        {
            log.Info("Navigate to History tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            if (calledFrom == "Company")
            {
                wait.Until(ExpectedConditions.ElementExists(tabHistory));
                driver.FindElement(tabHistory).Click();
            }
            else
            {
                wait.Until(ExpectedConditions.ElementExists(tabHistoryFromContact));
                driver.FindElement(tabHistoryFromContact).Click();
            }
        }
        public void navigateToCreateBookingFromNewTask()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnCreateBooking).Click();
        }

        public void enterBookingDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popChild");
            SelectElement bookingType = new SelectElement(driver.FindElement(ddlBookingType));
            bookingType.SelectByText("Normal Sale");
            driver.FindElement(txtBookingRefernece).SendKeys("Bref");
            driver.FindElement(cbParentBooking).Click();
            driver.FindElement(btnBundleSearch).Click();

        }

        public void verifyBookingisCreated()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnCancelPopUp));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCancelPopUp));
            driver.FindElement(btnCancelPopUp).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tableRecentBookings));
            Assert.AreEqual("Bref", driver.FindElement(gridRecentBookingRef).Text);
            Assert.AreEqual("TestCompany1234", driver.FindElement(gridRecentBookingCompanyName).Text);
        }

        public void verifyCreateBookingButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "popChild");

            Assert.AreEqual(true, driver.FindElement(btnCloseCB).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCustomerCB).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnNextCB).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnBundleSearchCB).Enabled);
            Assert.AreEqual(3, driver.FindElements(frameBookingHeader).Count);

        }

        public void verifyInformationIsSavedSuccessfully()
        {
            Assert.AreEqual("Task_Test", driver.FindElement(txtSubject).GetAttribute("value"));

            var userSelected = driver.FindElement(ddlUser);
            var usSel = new SelectElement(userSelected);
            var uss = usSel.SelectedOption;
            string selectedUser = uss.Text;
            Assert.AreEqual("TESTUSER2", selectedUser);

            var taskSelected = driver.FindElement(ddlTaskType);
            var tsSel = new SelectElement(taskSelected);
            var tss = tsSel.SelectedOption;
            string selectedTask = tss.Text;
            Assert.AreEqual("Follow Up Call", selectedTask);
            Assert.AreEqual("Ford Motor Company", driver.FindElement(tbCompanyName).GetAttribute("value").ToString().Trim());
            Assert.AreEqual("Mr Peter Pendlebury", driver.FindElement(tbContactName).GetAttribute("value"));
        }

        public void verifySaveSaveAndCloseButtonsAreDisabled()
        {
            Assert.AreEqual(false, driver.FindElement(btnSave).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAndClose).Enabled);
        }

        public void verifyDeleteStationeryCreateBookingAreDisplayed()
        {
            Assert.AreEqual(true, driver.FindElement(btnDelete).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnStationery).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCreateBooking).Displayed);
        }

        public void verifyTitle()
        {
            String subj = driver.FindElement(txtSubject).GetAttribute("value");
            String compname = driver.FindElement(tbCompanyName).GetAttribute("value");
            String contname = driver.FindElement(tbContactName).GetAttribute("value");
            String titleName = compname + ", " + contname + ", " + subj;

            Assert.AreEqual(titleName, driver.FindElement(txtPageHeading).Text);
        }

        public void verifyTaskAndUserFormTabsAreEnabled()
        {
            Assert.AreEqual(true, driver.FindElement(tabInformation).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabFollowUpCalls).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabNotes).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabAttachmentsInNewTask).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabMessages).Enabled);

            Assert.AreEqual(true, driver.FindElement(tabElectronicsClassification).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabCompanyInfo).Enabled);
            Assert.AreEqual(true, driver.FindElement(tabContactInfo).Enabled);
            //Assert.AreEqual(true, driver.FindElement(tabMailing).Enabled);
            //Assert.AreEqual(true, driver.FindElement(tabMarketing).Enabled);
        }

        public void navigateToFollowUp()
        {
            log.Info("Navigate to History tab");
            wait.Until(ExpectedConditions.ElementExists(tabHistory));
            driver.FindElement(tabHistory).Click();
        }

        public void navigateToAttachmentsTabFromHistory()
        {
            log.Info("Navigate to Attachments tab From History");
            wait.Until(ExpectedConditions.ElementExists(tabAttachmentsInNewTask));
            driver.FindElement(tabAttachmentsInNewTask).Click();
        }

        public void enterHistoryDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            log.Info("History Details");
            DefaultWait<IWebDriver> ingentaIDefaultWait = uf.fluentTimeout(driver, "minute", 1, 5);
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));
            driver.FindElement(txtSubject).SendKeys("Task_Test");
            driver.FindElement(chkPrivate).Click();


            driver.FindElement(dtStarts).SendKeys(DateTime.Today.ToString());
            driver.FindElement(dtStartTime).SendKeys(DateTime.Now.ToString());

            driver.FindElement(chkAllDayApp).Click();

            IWebElement ddUser = driver.FindElement(ddlUser);
            SelectElement User = new SelectElement(ddUser);
            User.SelectByText("TESTUSER2");

            IWebElement ddTaskType = driver.FindElement(ddlTaskType);
            SelectElement taskType = new SelectElement(ddTaskType);
            taskType.SelectByText("Follow Up Call");

            IWebElement ddlTaskStat = driver.FindElement(ddlTaskStatus);
            SelectElement taskStatus = new SelectElement(ddlTaskStat);
            taskStatus.SelectByText("Follow Up");

            driver.FindElement(dtEnds).SendKeys(DateTime.Today.AddDays(1).ToString());
            driver.FindElement(dtEndTime).SendKeys(DateTime.Now.ToString());

            driver.FindElement(txtNotes).SendKeys("Test Notes");
        }

        public void ClickSave()
        {
            log.Info("Save Record");
            wait.Until(ExpectedConditions.ElementExists(btnSave));
            wait.Until(ExpectedConditions.ElementIsVisible(btnSave));
            driver.FindElement(btnSave).Click();
            Thread.Sleep(2000);
        }

        public void ClickNewTask()
        {
            try
            {
                uf.switchToFrameByElement(driver, wait, "ifrPages");
                log.Info("New Task button clicked");
                wait.Until(ExpectedConditions.ElementIsVisible(btnNewTask));
                Assert.AreEqual(true, driver.FindElement(btnNewTask).Displayed);
                driver.FindElement(btnNewTask).Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                log.Info(ex.Message + "\n");
                log.Info(ex.StackTrace);
                Assert.Fail("Test Failed...");
            }
        }

        public void ClickInventory()
        {
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            log.Info("Inventory button clicked");
            wait.Until(ExpectedConditions.ElementExists(btnInventory));
            wait.Until(ExpectedConditions.ElementIsVisible(btnInventory));
            driver.FindElement(btnInventory).Click();
        }

        public void clickFollowUpCalls()
        {
            driver.FindElement(tabFollowUpCalls).Click();
        }

        public void clickNewFollowUpCallsbtn()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewFollowUpCalls).Click();
        }

        public void verifyNewTaskInfoPageDetails()
        {
            uf.SwitchToNewWindow(driver);
            verifyTaskInfoPageDetails("TaskFollowUp");
        }

        public void VerifyInventoryDetails()
        {
            uf.SwitchToNewWindow(driver);
            verifyInventoryPopUpDetails();
        }

        public void verifyInventoryPopUpDetails()
        {
            log.Info("Inventory Details");
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(btnNewSearch));

            Assert.AreEqual(true, driver.FindElement(btnNewSearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAdType).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCategory).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlMediaGrp).Displayed);
            Assert.AreEqual(true, driver.FindElement(lstMedia).Displayed);

            Assert.AreEqual(true, driver.FindElement(chkAll).Displayed);
            Assert.AreEqual(true, driver.FindElement(lstSection).Displayed);

            Assert.AreEqual(true, driver.FindElement(lstInventoryPlacement).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlPeriod).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlWeek).Displayed);

            Assert.AreEqual(true, driver.FindElement(dtRangeFrom).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtRangeTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkSun).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkMon).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkTue).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkWed).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkThus).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkFri).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkSat).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnJan).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFeb).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnMar).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnApr).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnMay).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnJun).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnJul).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnAug).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSep).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOct).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNov).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDec).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdMatrix).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdPages).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdList).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlListMode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAdSize).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnGetInventory).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAddToCart).Displayed);
        }

        public void closeNewTaskWindow()
        {
            log.Info("Close New Task Window");
            driver.FindElement(btnClose).Click();
            //uf.SwitchToNewWindow(driver);
        }

        public void verifyTaskWindowIsClosed()
        {
            log.Info("Verifying Task Window is closed");
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(headingFollowUpCalls).Displayed);
        }

        public void verifyAttachmentsTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementExists(btnNewAttachement));

            Assert.AreEqual(true, driver.FindElement(btnNewAttachement).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNewAttachement).Displayed);

            Assert.AreEqual(true, driver.FindElement(tableHeaderTitle).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderType).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderFileName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderAddedBy).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCreated).Displayed);

        }

        public void verifyTaskInfoPageDetails(string TaskOrTaskFollowUp)
        {
            log.Info("New Task Information Details");
            driver.SwitchTo().DefaultContent();
            if (TaskOrTaskFollowUp == "Task")
            {
                uf.switchToFrameByElement(driver, wait, "RightPane");
                uf.switchToFrameByElement(driver, wait, "ifrDetail");
            }
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));

            Assert.AreEqual(false, driver.FindElement(btnSave).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAndClose).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnClose).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnContact).Enabled);

            Assert.AreEqual(true, driver.FindElement(txtSubject).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLinksTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkPrivate).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlUser).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlTaskType).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStarts).Displayed);

            Assert.AreEqual(true, driver.FindElement(dtStartTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkAllDayApp).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlTaskStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtEnds).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtEndTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(companyEllipsis).Displayed);

            Assert.AreEqual(true, driver.FindElement(contactEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddResult).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkComplete).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtNotes).Displayed);

            Assert.AreEqual(true, driver.FindElement(startIncreaseTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(startDecreaseTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(endIncreaseTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(endDecreaseTime).Displayed);


            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabFollowUpCalls), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabNotes), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabAttachmentsInNewTask), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabMessages), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabElectronicClassification), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabCompanyInformation), driver));

            //Assert.AreEqual(false, driver.FindElement(tabFollowUpCalls).Enabled);
            //Assert.AreEqual(false, driver.FindElement(tabNotes).Enabled);
            //Assert.AreEqual(false, driver.FindElement(tabAttachmentsInNewTask).Enabled);
            //Assert.AreEqual(false, driver.FindElement(tabMessages).Enabled);
            //Assert.AreEqual(false, driver.FindElement(tabElectronicClassification).Enabled);
            //Assert.AreEqual(false, driver.FindElement(tabCompanyInformation).Enabled);

        }



        ////below method will verify that after saving the finance tab system will be redirected to Information Tab
        //public void verifyInformationPage()
        //{
        //    try
        //    {
        //        log.Info("Verify Information Page");
        //        Assert.AreEqual(true, driver.FindElement(titleInformation).Displayed);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Info(ex.Message + "\n");
        //        log.Info(ex.StackTrace);
        //        Assert.Fail("Test Failed...");
        //    }
        //}

        //public void verifyHistoryDetails()
        //{
        //    try
        //    {
        //        log.Info("Verify History Details");
        //        Assert.AreEqual("TAX12345", driver.FindElement(txtRegistrationNumber).Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Info(ex.Message + "\n");
        //        log.Info(ex.StackTrace);
        //        Assert.Fail("Test Failed...");
        //    }
        //}

        public void verifyHistoryPageDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewTask).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNewBooking).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnInventory).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnRefresh).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStartingFrom).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddFilterGroup).Displayed);

            Assert.AreEqual("Type", driver.FindElement(colType).Text);
            Assert.AreEqual("Start Date/Time", driver.FindElement(colStartDate).Text);
            Assert.AreEqual("Subject", driver.FindElement(colSubject).Text);
            Assert.AreEqual("Status", driver.FindElement(colStatus).Text);
            Assert.AreEqual("Name", driver.FindElement(colName).Text);

        }

        public void clickCloseButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnCloseHistory).Click();
        }

        public void verifyContactHistoryTitle()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            Assert.AreEqual(true, driver.FindElement(lblHistory).Displayed);
        }

        public void enterNewTaskInformation()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));

            driver.FindElement(txtSubject).SendKeys("Task_Test");
            driver.FindElement(chkIsActive).Click();
            SelectElement user = new SelectElement(driver.FindElement(ddlUser));
            user.SelectByText("TESTUSER2");
            SelectElement tasktype = new SelectElement(driver.FindElement(ddlTaskType));
            tasktype.SelectByText("Follow Up Call");

            driver.FindElement(ddDatePickerStart).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(calStartDate));
            selectingFutureStartDate();

            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(increaseStartTime).Click();
            }

            driver.FindElement(ddDatePickerEnd).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(calEndDate));
            selectingFutureEndDate();

            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(decreaseEndTime).Click();
            }

            selectingCompanyfromEllipsis();
            uf.IsPageLoaded(driver);
            selectingContactfromEllipsis();
            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            SelectElement brand = new SelectElement(driver.FindElement(ddBrand));
            brand.SelectByText("Ford");

            SelectElement result = new SelectElement(driver.FindElement(ddResult));
            result.SelectByText("NR - Call Back (not ready)");

            driver.FindElement(chkComplete).Click();

        }

        public void enterNewTaskInformationWithMandatoryDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));

            driver.FindElement(txtSubject).SendKeys("Task_Test");
            driver.FindElement(chkIsActive).Click();
            SelectElement tasktype = new SelectElement(driver.FindElement(ddlTaskType));
            tasktype.SelectByText("Follow Up Call");

            driver.FindElement(ddDatePickerStart).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(calStartDate));
            selectingFutureStartDate();

            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(increaseStartTime).Click();
            }

            driver.FindElement(ddDatePickerEnd).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(calEndDate));
            selectingFutureEndDate();

            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(decreaseEndTime).Click();
            }

            wait.Until(ExpectedConditions.ElementIsVisible(chkComplete));

            driver.FindElement(chkComplete).Click();

        }

        public void selectingContactfromEllipsis()
        {
            clickContactEllipsis();
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            driver.FindElement(tbLastName).SendKeys("Pendlebury");
            driver.FindElement(btnSearchGo).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyResults));
            driver.FindElement(selectingCompanybutton).Click();
        }

        public void clickContactEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(contactEllipsis));
            driver.FindElement(contactEllipsis).Click();
        }

        public void selectingFutureStartDate()
        {
            int lastDay = driver.FindElements(startCalendarDays).Count();
            driver.FindElements(startCalendarDays)[lastDay - 1].Click();
        }

        public void selectingFutureEndDate()
        {
            int lastDay = driver.FindElements(endCalendarDays).Count();
            driver.FindElements(endCalendarDays)[lastDay - 1].Click();
        }

        public void selectingCompanyfromEllipsis()
        {
            clickCompanyEllipsis();
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            driver.FindElement(txtCompanyName).SendKeys("Ford Motor Company");
            driver.FindElement(btnSearchGo).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyResults));
            driver.FindElement(selectingCompanybutton).Click();
        }

        public void selectingCompanyfromEllipsisTask()
        {
            clickCompanyEllipsisTask();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            driver.FindElement(txtCompanyName).SendKeys("Ford Motor Company");
            driver.FindElement(btnSearchGo).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyResults));
            driver.FindElement(selectingCompanybutton).Click();
        }

        public void clickCompanyEllipsisTask()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(companyEllipsis));
            driver.FindElement(companyEllipsis).Click();
        }

        public void clickContactEllipsisTask()
        {
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(contactEllipsis));
            driver.FindElement(contactEllipsis).Click();
        }

        public void clickCompanyEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(companyEllipsis));
            driver.FindElement(companyEllipsis).Click();
        }

        public void clickNewAttachmentButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewAttachement).Click();
        }

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
            AutoItX.Send("{TAB}");
            AutoItX.Send("{TAB}");
            Thread.Sleep(2000);
            AutoItX.Send("{TAB}");

            IWebElement browseButton;
            string uploadFilePath = Environment.CurrentDirectory + "\\Upload\\Documents\\" + "TestXLSFile.xls";
            browseButton = driver.FindElement(btnChooseFile);
            uf.uploadfile(browseButton, uploadFilePath);
            SelectElement attachementType = new SelectElement(driver.FindElement(ddlAttachmentType));
            attachementType.SelectByText(".xls");

        }

        public void clickSaveAttachment()
        {
            driver.SwitchTo().DefaultContent();
            driver.FindElements(btnSaveAttachement)[0].Click();
        }

        public void clickViewAttachment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnViewAttachement).Click();
        }

        public void clickEditAttachment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnEditAttachement).Click();
        }

        public void verifyAttachmentIsUploaded()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementExists(lblAttachment));            
            Assert.AreEqual("TestXLSFile.xls", driver.FindElement(lblAttachment).Text);
        }

        public void selectAttachment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(gridTitle).Click();
        }

        public void deleteAttachment()
        {
            noOfAttachmentsCount = driver.FindElements(attachmentsRow).Count();
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementExists(btnDeleteAttachment));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteAttachment));
            Thread.Sleep(2000);
            driver.FindElement(btnDeleteAttachment).Click();
            Thread.Sleep(2000);
        }

        public void verifyAttachmentIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            verifyNoOfAttachmentsCount = noOfAttachmentsCount - 1;
            uf.IsPageLoaded(driver);
            Assert.AreEqual(verifyNoOfAttachmentsCount, driver.FindElements(attachmentsRow).Count());
        }

        public void deleteAttachmentFromNewWindow()
        {
            noOfAttachmentsCount = driver.FindElements(attachmentsRow).Count();
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(btnDeleteAttachmentNewWindow).Click();
        }

        public void navigateToMessages()
        {
            driver.FindElement(tabMessages).Click();
        }

        public void verifyMessageTab()
        {
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(txtSalesAccountCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtAccountStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSalesLedgerCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtStatusReason).Displayed);
        }

        public void verifyAttachmentIsDeletedPrevWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfAttachmentsCount - 1, driver.FindElements(attachmentsRow).Count());
        }

        public void ClickStationeryButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnStationery).Click();
        }

        public void verifyStationeryWindow()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);
            Assert.AreEqual(true, driver.FindElement(btnCloseStatitonery).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlSelectLetter).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnEmail).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);
        }

        public void clickContactButtonInHeader()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnContact).Click();
        }

        public void clickViewThisCall()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            int CallCount = driver.FindElements(btnViewThisCall).Count();
            driver.FindElements(btnViewThisCall)[CallCount - 1].Click();
        }

        public void clickDeleteCallButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnDeleteCall).Click();
        }

        public void verifyPendingTaskElements()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(ddlStartingDatePT).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnRefreshPt).Enabled);
            Assert.AreEqual("Start Date/Time", driver.FindElement(gridStartDateTimePT).Text);
            Assert.AreEqual("Subject", driver.FindElement(gridSubjectPT).Text);
            Assert.AreEqual("Company", driver.FindElement(gridCompanyPT).Text);
            Assert.AreEqual("Contact", driver.FindElement(gridContactPT).Text);
            Assert.AreEqual("Call Status", driver.FindElement(gridCallStatusPT).Text);
        }

        public void verifyUserCalendarElements()
        {
            uf.IsPageLoaded(driver);
            Assert.AreEqual(true, driver.FindElement(ddlUserGroupsUC).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlUserListUC).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDisplayUC).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtMinPerRowUC).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTodayUC).Displayed);
            Assert.AreEqual(true, driver.FindElement(headerDay).Displayed);
            Assert.AreEqual(true, driver.FindElement(headerWeek).Displayed);
            Assert.AreEqual(true, driver.FindElement(headerMonth).Displayed);
            Assert.AreEqual(true, driver.FindElement(headerMultiDay).Displayed);
        }

        public void verifyTaskIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            Assert.AreEqual(totalNoOfCalls - 1, driver.FindElements(btnViewThisCall).Count);
        }

        public void noOfCallsBeforeDeleting()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            totalNoOfCalls = driver.FindElements(btnViewThisCall).Count();
        }

        public void enterBookingDetailsNewWindow()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementToBeClickable(ddlBookingType));
            SelectElement bookingType = new SelectElement(driver.FindElement(ddlBookingType));
            bookingType.SelectByText("Normal Sale");
            driver.FindElement(txtBookingRefernece).SendKeys("Bref");
            driver.FindElement(cbParentBooking).Click();
            driver.FindElement(btnBundleSearch).Click();
        }

        public void verifyBookingisCreatedNewWindow()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnCancelPopUp));
            wait.Until(ExpectedConditions.ElementToBeClickable(btnCancelPopUp));
            driver.FindElement(btnCancelPopUp).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(tableRecentBookings));
            Assert.AreEqual("Bref", driver.FindElement(gridRecentBookingRef).Text);
            Assert.AreEqual("TestCompany1234", driver.FindElement(gridRecentBookingCompanyName).Text);
        }

        public void clickRefreshButton()
        {
            driver.FindElement(btnRefresh).Click();
        }

        public void selectStartingFromDate(string selectedDate)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            if (selectedDate == "current date")
            {
                driver.FindElement(dtStartingFrom).Click();
                driver.FindElement(dtStartingFrom).Clear();
                driver.FindElement(dtStartingFrom).SendKeys(today);

            }
            else if (selectedDate == "past date")
            {
                driver.FindElement(dtStartingFrom).Click();
                driver.FindElement(dtStartingFrom).Clear();
                driver.FindElement(dtStartingFrom).SendKeys(yesterdaysDate);

            }
            else if (selectedDate == "future date")
            {
                driver.FindElement(dtStartingFrom).Click();
                driver.FindElement(dtStartingFrom).Clear();
                driver.FindElement(dtStartingFrom).SendKeys(tommorowsDate);
            }
        }

        public void verifyTasksAreVisible()
        {
            int gridDateCount = driver.FindElements(gridStartTimeDate).Count();
            string dtStartDate = "";
            string dtSentDate = "";
            for (int i = 0; i < gridDateCount; i++)
            {
                dtStartDate = driver.FindElements(gridStartTimeDate)[i].Text.Substring(0, 10);
                //dtStartDate = DateTime.Parse(driver.FindElements(gridStartTimeDate)[i].Text).ToString("dd/MM/yyyy");
                dtSentDate = driver.FindElement(dtStartingFrom).GetAttribute("value");

                DateTime pstartDate = DateTime.ParseExact(dtStartDate, "dd/MM/yyyy", null);
                DateTime pendDate = DateTime.ParseExact(dtSentDate, "dd/MM/yyyy", null);

                //DateTime dtStDate = Convert.ToDateTime(driver.FindElements(gridStartTimeDate)[i].Text);
                //DateTime dtStDate = driver.FindElements(gridStartTimeDate)[i].Text.ToString("dd/MM/yyyy");
                //DateTime dtStartDate = DateTime.ParseExact(driver.FindElements(gridStartTimeDate)[i].Text, "MM/dd/yyyy HH:mm tt", CultureInfo.InvariantCulture);
                //DateTime dtsndDate = Convert.ToDateTime(driver.FindElement(dtStartingFrom).GetAttribute("value"));
                //DateTime dtSentDate = DateTime.ParseExact(driver.FindElement(dtStartingFrom).GetAttribute("value"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                //dt.ToString("dd-MM-yyyy")

                //dtStartDate = DateTime.Parse(driver.FindElements(gridStartTimeDate)[i].Text).ToString("MM-dd-yyyy");
                //dtSentDate = DateTime.Parse(driver.FindElement(dtStartingFrom).GetAttribute("value")).ToString();
                if (pstartDate < pendDate)
                {
                    Assert.Fail("Fetched Data is wrong");
                }
            }
        }

        public void navigateToHistoryTab()
        {
            log.Info("Navigate to History tab");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabHistory));

            driver.FindElement(tabHistory).Click();
        }

        public void verifyHistoryPage()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewTask).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNewBooking).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnInventory).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnRefresh).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStartingFrom).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddFilterGroup).Displayed);

            Assert.AreEqual("Type", driver.FindElement(colType).Text);
            Assert.AreEqual("Start Date/Time", driver.FindElement(colStartDate).Text);
            Assert.AreEqual("Subject", driver.FindElement(colSubject).Text);
            Assert.AreEqual("Status", driver.FindElement(colStatus).Text);
            Assert.AreEqual("Name", driver.FindElement(colName).Text);

        }

        public void navigateToNewTaskPage()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewTask).Click();
        }

        public void verifyNewTaskButtonFunctionality(string viaOpportunityOrHistory)
        {
            driver.SwitchTo().DefaultContent();

            if (viaOpportunityOrHistory == "History")
            {
                uf.switchToFrameByElement(driver, wait, "RightPane");
                uf.switchToFrameByElement(driver, wait, "ifrDetail");
            }
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));

            Assert.AreEqual(true, driver.FindElement(txtSubject).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkPrivate).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtLinksTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStarts).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtStartTime).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtEnds).Displayed);
            Assert.AreEqual(true, driver.FindElement(companyEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(contactEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlResult).Displayed);
            Assert.AreEqual(true, driver.FindElement(cbComplete).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlUser).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlTaskType).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlTaskStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtNotes).Displayed);


            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabFollowUpCalls), driver));            
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabNotes), driver));
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabAttachments), driver));
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabMessages), driver));
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabElectronicClassification), driver));
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(tabCompanyInformation), driver));

            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabFollowUpCalls).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabNotes).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabAttachmentsInNewTask).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabMessages).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabElectronicClassification).GetAttribute("disabled").ToLower());
            Assert.AreEqual(true.ToString().ToLower(), driver.FindElement(tabCompanyInformation).GetAttribute("disabled").ToLower());

        }

        public void verifyFollowUpCall()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(tableTask));
            int countTask = driver.FindElements(tableTaskRows).Count;

            string ct = countTask.ToString();
            string TS = "table#G_FFHistoryxgrdHistory > tbody >tr:nth-child(" + ct + ") >td:nth-child(10)";
            By tabSubject = By.CssSelector(TS);
            string txtSubject = driver.FindElement(tabSubject).Text;
            Assert.AreEqual("Task_Test", txtSubject);
        }

        public void navigateToNewBookingWindow()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnNewBooking).Click();
        }

        public void clickInventoryButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnInventory).Click();
        }

        public void verifyNewInventoryWindow()
        {
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(btnNewSearch));

            Assert.AreEqual(true, driver.FindElement(btnNewSearch).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAdType).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlCategory).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlMediaGrp).Displayed);
            Assert.AreEqual(true, driver.FindElement(lstMedia).Displayed);

            Assert.AreEqual(true, driver.FindElement(chkAll).Displayed);
            Assert.AreEqual(true, driver.FindElement(lstSection).Displayed);

            Assert.AreEqual(true, driver.FindElement(lstInventoryPlacement).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlPeriod).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlWeek).Displayed);

            Assert.AreEqual(true, driver.FindElement(dtRangeFrom).Displayed);
            Assert.AreEqual(true, driver.FindElement(dtRangeTo).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkSun).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkMon).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkTue).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkWed).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkThus).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkFri).Displayed);
            Assert.AreEqual(true, driver.FindElement(chkSat).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnJan).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnFeb).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnMar).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnApr).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnMay).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnJun).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnJul).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnAug).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSep).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOct).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnNov).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDec).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdMatrix).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdPages).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdList).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlListMode).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAdSize).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnGetInventory).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddlAddToCart).Displayed);
        }
    }
    #endregion

}