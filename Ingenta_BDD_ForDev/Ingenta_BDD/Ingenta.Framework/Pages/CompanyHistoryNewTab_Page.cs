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
    public class CompanyHistoryNewTab_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public CompanyHistoryNewTab_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Variables

        string tomDate = DateTime.Now.AddDays(1).ToString("d-M-yyyy");
        //string todaysDate = DateTime.Today.ToString("dd-M-yyyy");
        string todaysDate = DateTime.Today.ToString("dd-MM-yyyy");
        string yesDate = DateTime.Today.AddDays(-1).ToString("d/M/yyyy");
        string demoNote = "This is a demo note";
        string replyNote = "This is a reply note";

        int noOfTaskRecords = 0;
        int noOfNotesRecords = 0;

        #endregion Variables

        #region OR

        By btnCompanyEllipsis = By.Name("ucTaskDetail$ucCompanyContactChooser$ctlModalCompany$btnModal");
        By btnContactEllipsis = By.Name("ucTaskDetail$ucCompanyContactChooser$ctlModalContact$btnModal");

        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By txtTown = By.Id("Search_FieldSelect3_txtValue1");
        By txtPostalCode = By.Id("Search_FieldSelect2_txtValue1");
        By txtTelephone = By.Id("Search_FieldSelect1_txtValue1");


        By ddCountry = By.Id("Search_FieldSelect4_lstValues1");
        By ddCompanyType = By.Id("Search_FieldSelect5_lstValues1");

        By cbIsActive = By.Id("Search_FieldSelect6_checkBox");

        By btnSearchGo = By.Id("Search_GoButton");
        By lnkCompanyRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");

        By ingentaCompanyNewButton = By.Id("Search_SearchBar_btnUser");

        By btnSiteDisplayMode = By.Id("Search_SearchBar_btnOpenSite");
        By btnSaveSeachResults = By.Id("Search_SearchBar_btnSaveResults");

        By tableSearchCompany = By.Id("tdQuery");

        By btnSaveAndClose = By.Id("btnSaveClose");
        By btnSave = By.Id("btnSave");
        By btnDelete = By.Id("btnDelete");
        By btnStationery = By.Id("btnStationery");
        By btnCreateBooking = By.Name("btnCreateBooking");
        By btnClose = By.Id("btnCancel");

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

        By txtSubject = By.Id("ucTaskDetail_txtSubject");
        By chkPrivate = By.Name("ucTaskDetail$chkPrivate");
        By ddlUser = By.Id("ucTaskDetail_ddlApplicationUsers");
        By txtLinksTo = By.Id("ucTaskDetail_txtLinkType");
        By ddlTaskType = By.Id("ucTaskDetail_ddlTaskType");
        By dtStarts = By.Id("ucTaskDetail_ffdcStartDate_iwdcDate_input");
        By dtStartTime = By.Id("ucTaskDetail_iwdteStart_t");

        By dtEnds = By.Id("ucTaskDetail_ffdcEndDate_iwdcDate_input");
        By dtEndTime = By.Id("ucTaskDetail_iwdteEnd_t");

        By chkAllDayApp = By.Id("ucTaskDetail_chkAllDay");
        By ddlTaskStatus = By.Id("ucTaskDetail_ddlTaskStatus");
        By txtRegistrationNumber = By.Id("ucHistoryDetail_txtRegistrationNumber");

        By companyEllipsis = By.Id("ucTaskDetail_ucCompanyContactChooser_txtCompany");
        By contactEllipsis = By.Id("ucTaskDetail_ucCompanyContactChooser_ctlModalContact_btnModal");

        By ddlBrand = By.Id("ucTaskDetail_ddlBrand");
        By ddlResult = By.Id("ucTaskDetail_ddlTaskResult");
        By cbComplete = By.Name("ucTaskDetail$chkComplete");
        By txtNotes = By.Id("ucTaskDetail_txtNotes");

        By ddDatePickerStart = By.Id("ucTaskDetail_ffdcStartDate_iwdcDate_img");
        By ddDatePickerEnd = By.Id("ucTaskDetail_ffdcEndDate_iwdcDate_img");

        By calStartDate = By.Id("igcalucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1");
        By calEndDate = By.Id("igcalucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2");

        By startCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody >tr > td.ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_10");
        By endCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2_512> tbody >tr > td.ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_20");

        By increaseStartTime = By.Id("ucTaskDetail_iwdteStart_b1");
        By decreaseEndTime = By.Id("ucTaskDetail_iwdteEnd_b2");

        By tableCompanyResults = By.Id("SearchxresultsGrid_div");

        By selectingCompanybutton = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");

        By tbCompanyName = By.Id("ucTaskDetail_ucCompanyContactChooser_txtCompany");
        By tbContactName = By.Id("ucTaskDetail_ucCompanyContactChooser_txtContact");

        By txtPageHeading = By.Id("lblPageHeading");

        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By tabFollowUpCalls = By.Id("iglbarMenu_0_Item_1");
        By tabNotes = By.Id("iglbarMenu_0_Item_2");
        By tabAttachements = By.Id("iglbarMenu_0_Item_3");
        By tabMessages = By.Id("iglbarMenu_0_Item_4");

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

        By btnReply = By.CssSelector("input.linkButton.edit");
        By msgBlankReply = By.Id("Notes_rfvNoteText");
        By btnDeleteNote = By.Name("Notes$btnDelete");
        By selectParentNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trNote");

        By btnNewAttachement = By.Id("ucAttachment_btnNewAttachment");

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

        By taskRow = By.CssSelector("table#G_FFHistoryxgrdHistory > tbody > tr");

        By notesRow = By.CssSelector("div.NoteListContainer table > tbody > tr");

        #endregion OR


        #region Functions

        public void clickCompanyEllipsis()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnCompanyEllipsis));

            driver.FindElement(btnCompanyEllipsis).Click();
        }

        public void verifyCompanyEllipsisPopUp()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));

            Assert.AreEqual(true, driver.FindElement(txtCompanyName).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTown).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtPostalCode).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtTelephone).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCountry).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCompanyType).Displayed);
            Assert.AreEqual(true, driver.FindElement(cbIsActive).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnSearchGo).Displayed);
        }

        public void clickContactEllipsis()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnContactEllipsis));

            driver.FindElement(btnContactEllipsis).Click();
        }

        public void verifyContactEllipsisPopUp()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");

            uf.switchToFrameByElement(driver, wait, "ifrContent");

            Assert.AreEqual(true, driver.FindElement(tbLastName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbCompanyNameContact).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbTelephoneContact).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbEmailContact).Displayed);

            Assert.AreEqual("First Name", driver.FindElement(colFirstName).Text);
            Assert.AreEqual("Last Name", driver.FindElement(colLastName).Text);
            Assert.AreEqual("Job Title", driver.FindElement(colJobTitle).Text);
            Assert.AreEqual("Company", driver.FindElement(colCompany).Text);
            Assert.AreEqual("Site ID", driver.FindElement(colSiteId).Text);
            Assert.AreEqual("Location", driver.FindElement(colLocation).Text);
            Assert.AreEqual("Postal Code", driver.FindElement(colPostalCode).Text);
            Assert.AreEqual("Telephone", driver.FindElement(colTelephone).Text);
            Assert.AreEqual("Fax", driver.FindElement(colFax).Text);
            Assert.AreEqual("E-Mail", driver.FindElement(colEmail).Text);

        }

        public void enterNewTaskInformation(string NewOrDelete)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));
            if (NewOrDelete == "New")
            {
                driver.FindElement(txtSubject).SendKeys("Task_Test");
                SelectElement user = new SelectElement(driver.FindElement(ddlUser));
                user.SelectByText("TESTUSER2");
            }
            else
                driver.FindElement(txtSubject).SendKeys("Task_ToBeDeleted");

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

            if (NewOrDelete == "New")
            {
                selectingCompanyfromEllipsis();
                uf.IsPageLoaded(driver);
                selectingContactfromEllipsis();
                uf.IsPageLoaded(driver);
                driver.SwitchTo().DefaultContent();
                uf.switchToFrameByElement(driver, wait, "RightPane");
                uf.switchToFrameByElement(driver, wait, "ifrDetail");
                SelectElement brand = new SelectElement(driver.FindElement(ddlBrand));
                brand.SelectByText("Ford");
                SelectElement result = new SelectElement(driver.FindElement(ddlResult));
                result.SelectByText("NR - Call Back (not ready)");
            }
            driver.FindElement(cbComplete).Click();
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
            Assert.AreEqual("Ford Motor Company ", driver.FindElement(tbCompanyName).GetAttribute("value"));
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

        public void clickFollowUpCalls()
        {
            driver.FindElement(tabFollowUpCalls).Click();
        }

        public void enterInformationInNewWindow()
        {
            uf.SwitchToNewWindow(driver);

            enterNewTaskInformationNewWindow();

        }

        public void clickSaveNewWindow()
        {
            driver.FindElement(btnSave).Click();
        }

        public void clickCloseNewWindow()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnClose));

            driver.FindElement(btnClose).Click();
        }

        public void clickClose()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementIsVisible(btnClose));

            driver.FindElement(btnClose).Click();


        }

        public void clickNotesTab()
        {
            driver.FindElement(tabNotes).Click();
        }

        public void enterNotes()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(tbNotes));
            driver.FindElement(tbNotes).SendKeys(demoNote);
        }

        public void selectingDateForNotes()
        {
            driver.FindElement(btnDatePicker).SendKeys(tomDate);
        }

        public void clickPostNotesButton()
        {
            driver.FindElement(btnPostNote).Click();
        }

        public void verifyCreatedNote()
        {
            wait.Until(ExpectedConditions.ElementExists(tableNotes));

            //Assert.AreEqual(todaysDate, driver.FindElement(tabNotesDate).Text);            
            DateTime dt = DateTime.ParseExact(driver.FindElement(tabNotesDate).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);            
            Assert.AreEqual(todaysDate, dt.ToString("dd-MM-yyyy"));

            Assert.AreEqual("DAVID", driver.FindElement(tabUser).Text);
            Assert.AreEqual(demoNote, driver.FindElement(tabNoteCreated).Text);
        }

        public void selectNote()
        {
            driver.FindElement(noteToBeSelected).Click();
        }

        public void createReplyNote()
        {
            driver.FindElement(tbNotes).SendKeys(replyNote);
        }

        public void clickReplyButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnReply));
            driver.FindElement(btnReply).Click();
        }

        public void verifyBlankMessageError()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(msgBlankReply));
            Assert.AreEqual("Please enter note text", driver.FindElement(msgBlankReply).Text);
        }

        public void verifyDeleteButtonIsDisabled()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(btnDeleteNote));
            Assert.AreEqual(false, driver.FindElement(btnDeleteNote).Enabled);
        }

        public void clickDeleteButton()
        {
            noOfNotesRecords = driver.FindElements(notesRow).Count;
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteNote));
            driver.FindElement(btnDeleteNote).Click();
        }

        public void verifynoteIsDeleted()
        {
            Assert.AreEqual(noOfNotesRecords - 2, driver.FindElements(notesRow).Count);
        }

        public void selectStartDate(string startDate)
        {
            if (startDate == "current date")
            {
                driver.FindElement(btnDatePicker).Click();
                driver.FindElement(btnDatePicker).SendKeys(todaysDate);
                driver.FindElement(btnDatePicker).SendKeys(Keys.Enter);
            }
            else if (startDate == "past date")
            {
                driver.FindElement(btnDatePicker).Click();
                driver.FindElement(btnDatePicker).SendKeys(yesDate);
                driver.FindElement(btnDatePicker).SendKeys(Keys.Enter);
            }
            else if (startDate == "future date")
            {
                driver.FindElement(btnDatePicker).Click();
                driver.FindElement(btnDatePicker).SendKeys(tomDate);
                driver.FindElement(btnDatePicker).SendKeys(Keys.Enter);
            }
        }

        public void verifyNoteIsSeen()
        {
            Assert.AreEqual(true, uf.IsElementPresent(driver, noteToBeSelected, 60));
        }
        public void verifyNoteIsNotSeen()
        {
            Assert.AreEqual(false, uf.IsElementDisplayed(driver, grdNotesFirstRow));
        }

        public void clickAttachments()
        {
            driver.FindElement(tabAttachements).Click();
        }

        public void clickNewAttachementButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnNewAttachement).Click();
        }

        public void clickMessages()
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

        public void verifyStationeryWindow()
        {
            driver.SwitchTo().DefaultContent();

            uf.SwitchToNewWindow(driver);

            Assert.AreEqual(true, driver.FindElement(btnCloseStatitonery).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlSelectLetter).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnEmail).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);
        }

        public void clickCompanyButton()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnCompany).Click();

        }

        public void selectTaskToBeDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            //int CallCount = driver.FindElements(btnViewThisCall).Count();            
            //driver.FindElements(btnViewThisCall)[CallCount -1].Click();

            noOfTaskRecords = driver.FindElements(taskRow).Count();

            string taskGridRows = "";
            string viewTask = "";
            string taskUser = "";
            for (int i = 0; i < noOfTaskRecords; i++)
            {
                taskGridRows = "tr#FFHistoryxgrdHistory_r_" + i + "> td:nth-child(10) > nobr";
                viewTask = "tr#FFHistoryxgrdHistory_r_" + i + "> td:nth-child(1) > nobr";
                taskUser = "tr#FFHistoryxgrdHistory_r_" + i + "> td:nth-child(12) > nobr";
                By taskGridR = By.CssSelector(taskGridRows);
                By viewTaskR = By.CssSelector(viewTask);
                By taskUserR = By.CssSelector(taskUser);
                if (driver.FindElement(taskGridR).Text == "Task_ToBeDeleted" && driver.FindElement(taskUserR).Text == "David Beckham (Super User)")
                {
                    driver.FindElement(viewTaskR).Click();
                }
            }


        }

        public int noOfCallElements()
        {
            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByElement(driver, wait, "ifrPages");

            return driver.FindElements(btnViewThisCall).Count();
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
            //Assert.AreEqual(noOfCallElements() - 1, driver.FindElements(btnViewThisCall).Count);
            Assert.AreEqual(noOfTaskRecords - 1, driver.FindElements(taskRow).Count());
        }

        public void enterBookingDetailsNewWindow()
        {
            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();

            uf.SwitchToNewWindow(driver);

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

        public void verifyNewBookingButtonFunctionality()
        {
            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();

            uf.SwitchToNewWindow(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(btnCloseCB));

            Assert.AreEqual(true, driver.FindElement(btnCloseCB).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCustomerCB).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnNextCB).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnBundleSearchCB).Enabled);
            Assert.AreEqual(3, driver.FindElements(frameBookingHeader).Count);
        }


        #region RF
        public void selectingFutureStartDate()
        {
            //int week = driver.FindElements(By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody > tr")).Count();

            // int day = driver.FindElements(By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody > tr:nth-child(week) > td")).Count();
            int lastDay = driver.FindElements(startCalendarDays).Count();
            driver.FindElements(startCalendarDays)[lastDay - 1].Click();
        }
        public void selectingFutureEndDate()
        {
            //int week = driver.FindElements(By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody > tr")).Count();

            // int day = driver.FindElements(By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody > tr:nth-child(week) > td")).Count();
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

        public void selectingContactfromEllipsisTask()
        {
            clickContactEllipsisTask();

            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(tbLastName).SendKeys("Pendlebury");
            driver.FindElement(btnSearchGo).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyResults));
            driver.FindElement(selectingCompanybutton).Click();
        }

        public void clickCompanyEllipsisTask()
        {

            wait.Until(ExpectedConditions.ElementIsVisible(btnCompanyEllipsis));

            driver.FindElement(btnCompanyEllipsis).Click();
        }

        public void clickContactEllipsisTask()
        {
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(btnContactEllipsis));

            driver.FindElement(btnContactEllipsis).Click();

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


        public void enterNewTaskInformationNewWindow()
        {
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(txtSubject));

            driver.FindElement(txtSubject).SendKeys("Task_Test");

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

            selectingCompanyfromEllipsisTask();
            uf.IsPageLoaded(driver);
            selectingContactfromEllipsisTask();
            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();


            SelectElement brand = new SelectElement(driver.FindElement(ddlBrand));
            brand.SelectByText("Ford");

            SelectElement result = new SelectElement(driver.FindElement(ddlResult));
            result.SelectByText("NR - Call Back (not ready)");

            driver.FindElement(cbComplete).Click();

        }




        #endregion RF

        #endregion Functions

    }
}
