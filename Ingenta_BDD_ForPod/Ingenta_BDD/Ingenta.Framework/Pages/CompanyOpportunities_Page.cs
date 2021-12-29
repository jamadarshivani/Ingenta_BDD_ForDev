
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;
using Utility_Classes;


namespace Ingenta.Framework.Pages
{
    public class CompanyOpportunities_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        #region Variables

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        string notesRandomString = RandomString(20);
        string randomSpecialInstructions = "Special Instructions " + RandomString(20);
        string randomDescription = "Description " + RandomString(20);

        int noOfCompetitorsCount = 0;
        int noOfResponsibilitiesCount = 0;
        int noOfMediaCount = 0;
        int noOfQuoteCount = 0;        

        string valueOfDepth = "";
        string valueOfCol = "";
        int countOfDeleteButton = 0;
        int rowsOfQuote = 0;
        int QuoteBookingIssueRows = 0;
        #endregion Variables


        public CompanyOpportunities_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object Repository

        By tabOpportunity = By.Id("iglbarMenu_1_Item_0");

        By btnNewOpportunity = By.Id("FFOpportunityList_btnAddOpportunity");

        //Table Opportunities
        By tabOpportunities = By.Id("iglbarMenu_1_Item_0");
        By tabOpportunitiesFromContact = By.Id("iglbarMenu_0_Item_4");
        By btnNewOpportunities = By.Id("FFOpportunityList_btnAddOpportunity");
        By tableHeaderName = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_2");
        By tableHeaderDate = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_3");
        By tableHeaderContact = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_4");
        By tableHeaderRating = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_5");
        By tableHeaderEstValue = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_7");
        By tableHeaderEstCloseDate = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_8");
        By tableHeaderCloseProbability = By.Id("FFOpportunityListxgrdCompanyOpportunities_c_0_9");

        By gridName = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(3)");
        By gridDate = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(4)");
        By gridContact = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(5)");
        By gridRating = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(6)");
        By gridEstimatedValue = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(8)");
        By gridEstimatedCloseValue = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(9)");
        By gridCloseProbability = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > thead > tr > th:nth-child(10)");
        
        By oppsRows = By.CssSelector("table#G_FFOpportunityListxgrdCompanyOpportunities > tbody > tr");


        By btnNewTask = By.Id("btnAdd");
        By gridStartDate = By.CssSelector("th#grdOpportunityTask_c_0_6 > nobr");
        By gridSubject = By.CssSelector("th#grdOpportunityTask_c_0_7 > nobr");
        By gridStatusTask = By.CssSelector("th#grdOpportunityTask_c_0_8 > nobr");
        By gridNameTask = By.CssSelector("th#grdOpportunityTask_c_0_9 > nobr");

        //Creating a new opportunity

        By tbOpportunityName = By.Id("ucOpportunityDetail_txtOpportunityName");
        By ddSalesPerson = By.Id("ucOpportunityDetail_ddlSalesperson");
        By ddConsolidationOption = By.Id("ucOpportunityDetail_ddlConsolidation");
        By ddBrand = By.Id("ucOpportunityDetail_ddlBrand");
        By ddContract = By.Id("ucOpportunityDetail_ddlContract");
        By tbEstimatedValue = By.Id("ucOpportunityDetail_txtEstimatedValue");
        //By tbEstimatedValueBase = By.Id("ucOpportunityDetail_txtEstimatedValueBase");
        By ddCurrency = By.Id("ucOpportunityDetail_ddlCurrency");
        By ddOpportunityStatus = By.Id("ucOpportunityDetail_ddlOpportunityStatus");
        By txtSpecialInstructions = By.Id("ucOpportunityDetail_txtSpecialInstructions");
        By ddRating = By.Id("ucOpportunityDetail_ddlRating");
        By txtDescription = By.Id("ucOpportunityDetail_txtOpportunityDescription");

        //Relations

        By gridCompanyName = By.CssSelector("table#ctl00_cphMain_RadGrid1_ctl00 > thead > tr > th:nth-child(3)");
        By gridType = By.CssSelector("table#ctl00_cphMain_RadGrid1_ctl00 > thead > tr > th:nth-child(4)");
        By gridCountry = By.CssSelector("table#ctl00_cphMain_RadGrid1_ctl00 > thead > tr > th:nth-child(5)");

        //Opportunities

        By gridCompetitor = By.CssSelector("table#G_grdOpportunityCompetitor> thead > tr > th:nth-child(5)");
        By gridEstimatedValueCompetitor = By.CssSelector("table#G_grdOpportunityCompetitor> thead > tr > th:nth-child(6)");
        By competitorGridRow = By.CssSelector("tr#grdOpportunityCompetitor_r_0 > td:nth-child(5) > nobr");
        By gridFirstEstValCompetitor = By.CssSelector("tr#grdOpportunityCompetitor_r_0 > td:nth-child(6) > nobr");
        //Editing The Opportunity

        By btnEditOpportunity = By.CssSelector("input.ig_ddd113d9_rcb1112.opportunity");

        By btnInformation = By.Id("iglbarMenu_0_Item_0");
        By btnRelations = By.Id("iglbarMenu_0_Item_1");
        By btnCompetitor = By.Id("iglbarMenu_0_Item_2");
        By btnResponsibility = By.Id("iglbarMenu_0_Item_3");
        By btnMedia = By.Id("iglbarMenu_0_Item_4");
        By btnProposal = By.Id("iglbarMenu_0_Item_5");
        By btnInsertions = By.Id("iglbarMenu_0_Item_6");
        By btnTasks = By.Id("iglbarMenu_0_Item_7");
        By btnNotes = By.Id("iglbarMenu_0_Item_8");
        By btnAttachements = By.Id("iglbarMenu_0_Item_9");
        By btnSalesAssignment = By.Id("iglbarMenu_0_Item_10");

        //Responsibility

        By gridRoleResponsibility = By.CssSelector("table#G_grdOpportunityResponsibility> thead > tr > th:nth-child(5)");
        By gridApplicationUserResponsibility = By.CssSelector("table#G_grdOpportunityResponsibility> thead > tr > th:nth-child(6)");
        By gridFirstRoleResponsibility = By.CssSelector("tr#grdOpportunityResponsibility_r_0> td:nth-child(5) > nobr");
        By gridFirstApplicationUserResponsibility = By.CssSelector("tr#grdOpportunityResponsibility_r_0> td:nth-child(6) > nobr");
        //Competitor        

        //New Competitor
        By btnNewCompetitor = By.Id("btnAdd");
        By ddCompetitor = By.Id("ddlCompetitor");
        By tbEstimatedValueCompetitor = By.Id("txtEstimatedValue");
        By btnSaveNewCompetitor = By.Id("btnSave");
        By btnCancelNewCompetitor = By.Id("btnCancel");
        By headingCompetitor = By.Id("lblCompetitor");

        By competitorsRow = By.CssSelector("table#G_grdOpportunityCompetitor > tbody > tr");

        //Edit and Delete Competitor 

        By btnEditCompetitor = By.CssSelector("#grdOpportunityCompetitor_rc_0_0 > nobr > input");

        By btnEditClass = By.CssSelector("input.ig_20e6d1d4_rcb1112.gridRowImg.gridCompetitor");

        By tabCompetitor = By.Id("grdOpportunityCompetitor_rc_0_4");
        By btnDeleteCompetitor = By.Id("btnDelete");

        //Responsibility

        By btnNewResponsibility = By.Id("btnAdd");

        //New Responsibility
        By ddRole = By.Id("ddlRole");
        By ddUser = By.Id("ddlApplicationUser");
        By btnSaveNewResponsibility = By.Id("btnSave");
        By btnCancelNewResponsibility = By.Id("btnCancel");

        //Edit and Delete Responsibility

        By btnEditResponsibility = By.Id("grdOpportunityResponsibility_rc_0_0");
        By tabResponsibility = By.Id("grdOpportunityResponsibility_rc_0_4");
        By btnDeleteResponsibility = By.Id("btnDelete");
        By responsibilitysRow = By.CssSelector("table#G_grdOpportunityResponsibility > tbody > tr");

        //Media
        By btnNewMedia = By.Id("btnAdd");
        By gridMedia = By.CssSelector("table#G_grdOpportunityMedium> thead > tr > th:nth-child(5)");
        By gridEstimatedValueMedia = By.CssSelector("table#G_grdOpportunityMedium> thead > tr > th:nth-child(6)");
        By gridFirstMedia = By.CssSelector("table#G_grdOpportunityMedium > tbody > tr > td:nth-child(5) > nobr");
        By gridFirstEstValMedia = By.CssSelector("table#G_grdOpportunityMedium > tbody > tr > td:nth-child(6) > nobr");
        By mediaRow = By.CssSelector("table#G_grdOpportunityMedium > tbody > tr");


        //New Media
        By ddMedia = By.Id("ddlMedium");
        By tbEstimatedValueMedia = By.Id("txtEstimatedValue");
        By cbSelectDeselectAll = By.Id("ucFFMediumIssuesList_chkSelectAll");
        By txtIssueCount = By.Id("ucFFMediumIssuesList_txtIssueCount");
        By txtMedia = By.Id("ucFFMediumIssuesList_txtMedia");
        By gridCode = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(2) > nobr");
        By gridIssueDate = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(3) > nobr");
        By gridCoverDate = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(4) > nobr");
        By gridDescription = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(5) > nobr");
        By gridStatus = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(8) > nobr");
        By gridEstimatedValueNewMedia = By.CssSelector("table#G_ucFFMediumIssuesListxgrdIssues > thead > tr > th:nth-child(9) > nobr");

        //Edit And Delete Media
        By btnEditMedia = By.Id("grdOpportunityMedium_rc_0_0");
        By tabMedia = By.Id("grdOpportunityMedium_rc_0_4");
        By btnDeleteMedia = By.Id("btnDelete");


        //Proposal

        By btnNewPro = By.Id("btnAdd");

        By ddAdType = By.Id("ctl00_cphMain_ddlAdType_DropDownList1");
        By ddMediaGroup = By.Id("ctl00_cphMain_ddlMediaGroup_DropDownList1");

        //Insertions

        By btnNewInsertionsBooking = By.Id("btnAddBooking");
        By btnSelectMediaInsertions = By.Id("ctl00_cphMain_grdMedia_ctl02_lkbEditNewMediaIssues");
        By btnCancel = By.Id("ctl00_cphMain_ucRibbon_btnClose");
        By gridBookingId = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(2)");
        By gridMedium = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(4)");
        By gridIssue = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(5)");
        By gridStatusInsertions = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(6)");
        By gridDetails = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(7)");
        By gridRateInsertions = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(8)");
        By gridAgreedRateInsertions = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(9)");
        By gridNetAmount = By.CssSelector("table#grdOpportunityBooking1_ctl00> thead > tr > th:nth-child(10)");
        By popUpWindowBooking = By.Id("ctl00_cphMain_pnlBooking");
        By tabsBookingPopUp = By.CssSelector("div#ctl00_cphMain_pnlBooking > table > tbody > tr");
        By txtBuyer = By.Id("ctl00_cphMain_txtBuyer_textBox1");
        By txtAdvertiser = By.Id("ctl00_cphMain_txtAdvertiser_textBox1");
        By btnSaveClose = By.Id("btnSaveClose");

        //Task
        By txtSubject = By.Id("ucTaskDetail_txtSubject");
        By cbIsActive = By.CssSelector("span.FormCheckbox.mycheckbox > input");
        By ddlUser = By.Id("ucTaskDetail_ddlApplicationUsers");
        By ddDatePickerStart = By.Id("ucTaskDetail_ffdcStartDate_iwdcDate_img");
        By ddDatePickerEnd = By.Id("ucTaskDetail_ffdcEndDate_iwdcDate_img");
        By calStartDate = By.Id("igcalucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1");
        By calEndDate = By.Id("igcalucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2");
        By ddlTaskType = By.Id("ucTaskDetail_ddlTaskType");
        By ddlBrand = By.Id("ucTaskDetail_ddlBrand");
        By ddlResult = By.Id("ucTaskDetail_ddlTaskResult");
        By cbComplete = By.Id("ucTaskDetail_chkComplete");
        By btnCompanyEllipsis = By.Name("ucTaskDetail$ucCompanyContactChooser$ctlModalCompany$btnModal");
        By btnContactEllipsis = By.Name("ucTaskDetail$ucCompanyContactChooser$ctlModalContact$btnModal");
        By startCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_1_512 > tbody >tr > td.ucTaskDetail_ffdcStartDate_iwdcDate_DrpPnl1_DP_CAL_ID_10");
        By endCalendarDays = By.CssSelector("table#ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_2_512> tbody >tr > td.ucTaskDetail_ffdcEndDate_iwdcDate_DrpPnl2_DP_CAL_ID_20");
        By tableCompanyResults = By.Id("SearchxresultsGrid_div");
        By selectingCompanybutton = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By tbLastName = By.Id("Search_FieldSelect0_txtValue1");
        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By btnSearchGo = By.Id("Search_GoButton");
        By lnkCompanyRecord = By.CssSelector("tr#SearchxresultsGrid_r_0 > td");
        By increaseStartTime = By.Id("ucTaskDetail_iwdteStart_b1");
        By decreaseEndTime = By.Id("ucTaskDetail_iwdteEnd_b2");
        By btnSaveTask = By.Id("btnSave");
        #endregion Object Repository

        //Quote Details

        By btnQuote = By.Id("iglbarMenu_0_Item_5");

        By gridQuoteId = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(2) > nobr");
        By gridQuoteDate = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(5) > nobr");
        By gridUser = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(6) > nobr");
        By gridRate = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(7) > nobr");
        By gridAgreedRate = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(8) > nobr");
        By gridSeriesDiscount = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(9) > nobr");
        By gridNet = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(10) > nobr");
        By gridTotal = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(11) > nobr");
        By gridBookingIdQuote = By.CssSelector("table#G_grdOpportunityQuote > thead > tr >th:nth-child(12) > nobr");

        By btnNewQuote = By.Id("btnAddQuote");
        By ddlAdType = By.Id("ddlAdType");
        By ddlMediaGroup = By.Id("ddlMediaGroup");
        By gridInsertedMediaQuote = By.CssSelector("table#G_grdMedia > thead > tr > th:nth-child(3) >nobr");
        By gridFrequency = By.CssSelector("table#G_grdMedia > thead > tr > th:nth-child(4) >nobr");
        By gridNextIssue = By.CssSelector("table#G_grdMedia > thead > tr > th:nth-child(5) >nobr");
        By gridSelectedMediaQuote = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(6) > nobr");
        By gridIns = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(8) > nobr");
        By gridAdType = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(9) > nobr");
        By gridIssueSelectedMedia = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(11) > nobr");
        By gridDetailsSelectedMedia = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(15) > nobr");
        By gridSelectedMediaRate = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(17) > nobr");
        By gridSelectedMediaAgreedRate = By.CssSelector("table#G_grdSelectedMedia> thead > tr > th:nth-child(18) > nobr");

        By QuoteRow = By.CssSelector("table#G_grdOpportunityQuote > tbody > tr");
        

        By tbNoOfInsertions = By.Id("ucAdvertDetail_txtIns");
        By btnAddInsertion = By.Id("ucAdvertDetail_btnAddAdDetail");
        By txtNEP = By.Id("txtNEP");
        By txtPublishedRate = By.Id("txtPublishedRate");
        By txtRate = By.Id("txtRate");
        By txtAgreedRate = By.Id("txtAgreedRate");
        By txtSeriesDiscount = By.Id("txtSeriesDiscount");
        By txtAgencyCommissionPercentage = By.Id("txtAgencyCommissionPercentage");
        By txtAgencyCommission = By.Id("txtAgencyCommission");
        By txtNetTotal = By.Id("txtNetTotal");
        By txtTaxRate = By.Id("txtTaxRate");
        By txtTax = By.Id("txtTax");
        By tblMedia = By.Id("grdMedia_main");
        By mediaRows = By.CssSelector("table#grdMedia_main > tbody > tr");
        By mediaFirstRow = By.Id("grdMedia_r_0");
        By rowMedia = By.CssSelector("table#G_grdMedia > tbody > tr  > td:nth-child(3) > nobr");
        By ddlAdSize = By.Id("ucAdvertDetail_ddlAdSize");
        By ddlPosition = By.Id("ucAdvertDetail_ddlPosition");
        By ddlSection = By.Id("ucAdvertDetail_ddlSection");
        By btnEditQuote = By.ClassName("ig_a04eb238_rcb1112");
        By btnDeleteQuote = By.ClassName("ig_a04eb238_rcb1212");
        By btnDelQuote = By.Id("btnDeleteQuote");        
        By txtDepth = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_txtDepth");
        By txtDepthSel = By.Id("ucAdvertDetail_txtDepth");
        By txtCol = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_txtCol");
        By txtColumn = By.Id("ucAdvertDetail_txtCol");
        By txtIns = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_txtIns");
        By ddPositionPopUp = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_ddlPosition");
        By ddSectionPopUp = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_ddlSection");
        By ddAdSizePopUp = By.Id("wdwEditAdvertDetails_tmpl_ucAmendAdvertDetail_ddlAdSize");
        By btnApply = By.Id("wdwEditAdvertDetails_tmpl_btnApply");
        By btnCancelQuote = By.Id("btnCancel");
        By btnEditCreatedQuote = By.CssSelector("table#G_grdOpportunityQuote > tbody > tr > td > nobr > input");
        By btnStationery = By.Id("btnStationery");
        By ddlSelectLetter = By.Id("lstLetter");
        By btnEmail = By.Id("lbtnSend");
        By btnSaveAsPDF = By.Id("btnSaveAsPDF");
        By btnCloseStatitonery = By.Id("btnclose");
        By btnCreateBookingInQuote = By.Id("btnCreateBooking");
        By btnNext = By.Id("ucConvertQuoteToBooking_btnNext");
        By btnCancelQuoteBooking = By.Id("ucConvertQuoteToBooking_btnCancelCreateBooking");
        By colHeaderSelectIssues = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_2");
        By colHeaderMedia = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_3");
        By colHeaderInsertion = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_4");
        By colHeaderAdType = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_5");
        By colHeaderDetails = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_7");
        By colHeaderRate = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_8");
        By colHeaderAgreedRate = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_9");
        By colHeaderStatus = By.Id("ucConvertQuoteToBookingxgrdQuoteLine_c_0_11");


        //By QuoteBookingRow = By.CssSelector("table#G_ucConvertQuoteToBookingxgrdQuoteLine > tbody > tr");
        By btnSelectIssue = By.CssSelector("table#G_ucConvertQuoteToBookingxgrdQuoteLine > tbody > tr > td > nobr > input");
        By txtListNoOfIssues = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_txtIssueCount_textBox1");
        By txtCalenderNoOfIssues = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffCalender_txtIssueCount_textBox1");
        By ddlBookingStatus = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_ddlBkingStatus_DropDownList1");

        By selectIssueGridHeaderSelectIssue = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(1)");
        By selectIssueGridHeaderIssueDate = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(2)");
        By selectIssueGridHeaderDesc = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(4)");
        By selectIssueGridHeaderCopyDL = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(5)");
        By selectIssueGridHeaderReservationDL = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(6)");
        By selectIssueGridHeaderStatus = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(7)");
        By selectIssueGridHeaderPosition = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(8)");
        By selectIssueGridHeaderCustomerRef = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(9)");
        By selectIssueGridHeaderAgencyRef = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(10)");
        By selectIssueGridHeaderBrand = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(11)");
        By selectIssueGridHeaderSInsertionType = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(12)");
        By selectIssueGridHeaderPromoType = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(13)");
        By selectIssueGridHeaderBookingStatus = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_Header > thead > tr > th:nth-child(14)");

        By selectIssueGridHeaderDelete = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffCalender_grdSelectedIssues_ctl00_ctl02_ctl00_btnDeleteAll");
        By selectIssueGridHeaderIssue = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffCalender_grdSelectedIssues_ctl00_Header > thead > tr > th:nth-child(3)");
        By selectIssueGridHeaderCopyDeadLine = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffCalender_grdSelectedIssues_ctl00_Header > thead > tr > th:nth-child(4)");
        By selectIssueGridHeaderResDL = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffCalender_grdSelectedIssues_ctl00_Header > thead > tr > th:nth-child(5)");
        By selectIssueGridHeaderSta = By.CssSelector("#ucConvertQuoteToBooking_ucIssueSelection_ffCalender_grdSelectedIssues_ctl00_Header > thead > tr > th:nth-child(3)");


        By chkSelectIssue = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_chkIsSelected");
        By txtCustomerRef = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_txtIssueCustomerRef");
        By txtAgencyRef = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_txtIssueAgencyRef");
        By ddlBrandInSelectIssue = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_ddlIssueBrand");
        By ddlBookingStatusInSelectIssue = By.Id("ucConvertQuoteToBooking_ucIssueSelection_ffIssuePicklist_grdIssues_ctl00_ctl04_ddlBookingStatus");

        By btnApplyIssueSelection = By.Id("ucConvertQuoteToBooking_btnApplyIssueSelection");
        #region Functions

        public void navigateToOpportunitiesTab(string navigatedFrom)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            if (navigatedFrom == "Company")
            {
                wait.Until(ExpectedConditions.ElementExists(tabOpportunities));
                driver.FindElement(tabOpportunities).Click();
            }
            else
            {
                wait.Until(ExpectedConditions.ElementExists(tabOpportunitiesFromContact));
                driver.FindElement(tabOpportunitiesFromContact).Click();
            }
        }

        public void navigateToOpportunitiesTab()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(tabOpportunity));
            wait.Until(ExpectedConditions.ElementToBeClickable(tabOpportunity));
            driver.FindElement(tabOpportunity).Click();
        }

        public void verifyOpportunitiesTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewOpportunities).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderCloseProbability).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderContact).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderEstCloseDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderEstValue).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableHeaderRating).Displayed);
        }

        public void clickNewOpportunitiesButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            driver.FindElement(btnNewOpportunity).Click();
        }

        public void verifyNewOpportunityButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(btnInformation).Enabled);
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnRelations), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnCompetitor), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnResponsibility), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnMedia), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnProposal), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnInsertions), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnTasks), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnAttachements), driver));
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnSalesAssignment), driver));

            Assert.AreEqual(true, driver.FindElement(tbOpportunityName).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddSalesPerson).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddConsolidationOption).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddContract).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbEstimatedValue).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddCurrency).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddOpportunityStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtSpecialInstructions).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddRating).Displayed);
            Assert.AreEqual(true, driver.FindElement(txtDescription).Displayed);
        }

        public void enterOpportunityInformation()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            driver.FindElement(tbOpportunityName).SendKeys("Product Launch");

            SelectElement selectedSalesPerson = new SelectElement(driver.FindElement(ddSalesPerson));
            selectedSalesPerson.SelectByText("TESTUSER2");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(ddConsolidationOption));

            IWebElement ddConsOption = driver.FindElement(ddConsolidationOption);
            SelectElement selectedConsolidationOption = new SelectElement(ddConsOption);
            selectedConsolidationOption.SelectByText("By Payer/Advertiser");

            SelectElement selectedBrand = new SelectElement(driver.FindElement(ddBrand));
            //selectedBrand.SelectByText("Belling");
            selectedBrand.SelectByIndex(1);

            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementExists(tbEstimatedValue));

            driver.FindElement(tbEstimatedValue).Clear();
            driver.FindElement(tbEstimatedValue).SendKeys("2000");

            wait.Until(ExpectedConditions.ElementExists(ddCurrency));

            SelectElement selectedCurrency = new SelectElement(driver.FindElement(ddCurrency));
            selectedCurrency.SelectByText("US Dollars");

            SelectElement selectedOpportunityStatus = new SelectElement(driver.FindElement(ddOpportunityStatus));
            selectedOpportunityStatus.SelectByText("3. Needs Analysis");

            SelectElement selectedRating = new SelectElement(driver.FindElement(ddRating));
            selectedRating.SelectByText("Warm");

            driver.FindElement(txtSpecialInstructions).SendKeys(randomSpecialInstructions);

            driver.FindElement(txtDescription).SendKeys(randomDescription);

        }

        public void clickSaveButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnSaveNewCompetitor).Click();
        }

        public void saveTaskInOpportunities()
        {
            wait.Until(ExpectedConditions.ElementExists(btnSaveTask));
            driver.FindElement(btnSaveTask).Click();
        }

        public void verifyDetailsAreSavedSucessfully()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");

            uf.IsPageLoaded(driver);

            Assert.AreEqual("Product Launch", driver.FindElement(tbOpportunityName).GetAttribute("value"));

            var salesPerSelected = driver.FindElement(ddSalesPerson);
            var spSel = new SelectElement(salesPerSelected);
            var sps = spSel.SelectedOption;
            string selectedSalesPerson = sps.Text;
            Assert.AreEqual("TESTUSER2", selectedSalesPerson);

            var consOpSelected = driver.FindElement(ddConsolidationOption);
            var coSel = new SelectElement(consOpSelected);
            var cos = coSel.SelectedOption;
            string selectedConsolidationOption = cos.Text;
            Assert.AreEqual("By Payer/Advertiser", selectedConsolidationOption);

            //var brandSelected = driver.FindElement(ddBrand);
            //var bSel = new SelectElement(brandSelected);
            //var bs = bSel.SelectedOption;
            //string selectedBrand = bs.Text;
            //Assert.AreEqual("Belling", selectedBrand);

            Assert.AreEqual("2000", driver.FindElement(tbEstimatedValue).GetAttribute("value"));

            var currencySelected = driver.FindElement(ddCurrency);
            var cSel = new SelectElement(currencySelected);
            var cs = cSel.SelectedOption;
            string selectedCurrency = cs.Text;
            Assert.AreEqual("US Dollars", selectedCurrency);

            var opportunityStatusSelected = driver.FindElement(ddOpportunityStatus);
            var osSel = new SelectElement(opportunityStatusSelected);
            var oss = osSel.SelectedOption;
            string selectedOpportunityStatus = oss.Text;
            Assert.AreEqual("3. Needs Analysis", selectedOpportunityStatus);

            var ratingSelected = driver.FindElement(ddRating);
            var rSel = new SelectElement(ratingSelected);
            var rs = rSel.SelectedOption;
            string selectedRating = rs.Text;
            Assert.AreEqual("Warm", selectedRating);

            Assert.AreEqual(randomSpecialInstructions, driver.FindElement(txtSpecialInstructions).Text);
            Assert.AreEqual(randomDescription, driver.FindElement(txtDescription).Text);

            Assert.AreEqual(false, driver.FindElement(btnSaveNewCompetitor).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveClose).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnCancelNewCompetitor).Enabled);

            Assert.AreEqual(true, driver.FindElement(btnRelations).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCompetitor).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnResponsibility).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnMedia).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnProposal).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnInsertions).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnTasks).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnAttachements).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnSalesAssignment).Enabled);
        }

        public void selectCreatedTestOpportunityinPendleburyContact()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementExists(btnEditOpportunity));

            driver.FindElements(btnEditOpportunity)[2].Click();
        }

        public void editCreatedOpportunity()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementExists(btnEditOpportunity));

            driver.FindElements(btnEditOpportunity)[0].Click();
        }


        public void selectCalenderViewForQuoteInCompanyOpportunity()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            int noOfOpps = driver.FindElements(oppsRows).Count();

            string openCalOpp,oppGridRows = "";

            for (int i = 0; i < noOfOpps; i++)
            {
                oppGridRows = "tr#FFOpportunityListxgrdCompanyOpportunities_r_" + i + "> td:nth-child(3) > nobr";
                openCalOpp = "tr#FFOpportunityListxgrdCompanyOpportunities_r_" + i + "> td:nth-child(1)";
                By OppGridR = By.CssSelector(oppGridRows);
                By openCalOppR = By.CssSelector(openCalOpp);
                if (driver.FindElement(OppGridR).Text == "Calendar View Quote Opp")
                {
                    driver.FindElement(openCalOppR).Click();
                    break;
                }

            }
        }

        public void selectLastCreatedOpportunity()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            int noOfOpps = driver.FindElements(oppsRows).Count() - 1;
            wait.Until(ExpectedConditions.ElementExists(btnEditOpportunity));
            driver.FindElements(btnEditOpportunity)[noOfOpps].Click();
        }

        public void clickSaveAndCloseButton()
        {
            driver.FindElement(btnSaveClose).Click();
        }

        public void navigateToRelationsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnRelations));
            driver.FindElement(btnRelations).Click();
        }

        public void navigateToCompetitorTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnCompetitor).Click();
        }

        public void verifyRelationsTab()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual("Company Name", driver.FindElement(gridCompanyName).Text);
            Assert.AreEqual("Type", driver.FindElement(gridType).Text);
            Assert.AreEqual("Country", driver.FindElement(gridCountry).Text);
        }

        public void verifyCompetitorTab()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual("Competitor", driver.FindElement(gridCompetitor).Text);
            Assert.AreEqual("Estimated Value", driver.FindElement(gridEstimatedValueCompetitor).Text);

            Assert.AreEqual(true, driver.FindElement(btnNewCompetitor).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnDeleteCompetitor).Enabled);
        }

        public void clickNewCompetitorButton()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            driver.FindElement(btnNewCompetitor).Click();
        }

        public void verifyNewOpportunityWindow()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(ddCompetitor));

            Assert.AreEqual(true, driver.FindElement(ddCompetitor).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbEstimatedValueCompetitor).Displayed);
        }

        public void enterNewCompetitorDetails(string NewOrDelete)
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);
            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(ddCompetitor));

            SelectElement selectCompetitor = new SelectElement(driver.FindElement(ddCompetitor));

            if (NewOrDelete == "New")
            {
                selectCompetitor.SelectByText("FLAMES");
            }
            else
            {
                selectCompetitor.SelectByText("Live Sound Radio");
            }

            driver.FindElement(tbEstimatedValueCompetitor).SendKeys("500");
        }

        public void verifyNewCompetitorDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("FLAMES", driver.FindElement(competitorGridRow).Text);
            Assert.AreEqual("500.00", driver.FindElement(gridFirstEstValCompetitor).Text);
        }

        public void editCompetitor()
        {            
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnEditClass).Click();
        }

        public void clickCancelCompetitor()
        {
            driver.FindElement(btnCancelNewCompetitor).Click();
        }

        public void verifyCompetitorWindowIsClosed()
        {
            log.Info("Verifying Competitor Window is closed");
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(headingCompetitor).Displayed);

        }

        public void verifyCompetitorDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);
            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(ddCompetitor));

            var compSelected = driver.FindElement(ddCompetitor);
            var compeSel = new SelectElement(compSelected);
            var cs = compeSel.SelectedOption;
            string selectedComp = cs.Text;

            Assert.AreEqual("FLAMES", selectedComp);
            Assert.AreEqual("500.0000", driver.FindElement(tbEstimatedValueCompetitor).GetAttribute("value"));
        }

        public void saveDetailsInNewWindow()
        {
            driver.FindElement(btnSaveNewCompetitor).Click();
        }

        public void selectCreatedCompetitor()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            noOfCompetitorsCount = driver.FindElements(competitorsRow).Count();
            string competitorGridRows = "";
            for (int i = 0; i < noOfCompetitorsCount; i++)
            {
                competitorGridRows = "tr#grdOpportunityCompetitor_r_" + i + "> td:nth-child(5) > nobr";
                By competitorGridR = By.CssSelector(competitorGridRows);
                if (driver.FindElement(competitorGridR).Text == "Live Sound Radio")
                {
                    driver.FindElement(competitorGridR).Click();
                    break;
                }

            }
        }

        public void deleteAllCompetitors()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            noOfCompetitorsCount = driver.FindElements(competitorsRow).Count();
            string competitorGridRows = "";
            for (int i = 0; i < noOfCompetitorsCount; i++)
            {
                competitorGridRows = "tr#grdOpportunityCompetitor_r_" + i + "> td:nth-child(5) > nobr";
                By competitorGridR = By.CssSelector(competitorGridRows);
                driver.FindElement(competitorGridR).Click();
                driver.FindElement(btnDeleteCompetitor).Click();
            }
        }

        public void deleteCompetitor()
        {
            noOfCompetitorsCount = driver.FindElements(competitorsRow).Count();
            driver.FindElement(btnDeleteCompetitor).Click();
        }

        public void verifyCompetitorIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfCompetitorsCount - 1, driver.FindElements(competitorsRow).Count());
        }


        public void verifyMediaIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfMediaCount - 1, driver.FindElements(mediaRow).Count());
        }

        public void navigateToResponsibilityTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnResponsibility).Click();
        }

        public void verifyResponsibilityTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewResponsibility));

            Assert.AreEqual(true, driver.FindElement(btnNewResponsibility).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteResponsibility).Displayed);
            Assert.AreEqual("Role", driver.FindElement(gridRoleResponsibility).Text);
            Assert.AreEqual("Application User", driver.FindElement(gridApplicationUserResponsibility).Text);
        }

        public void clickNewResponsibilityButton()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            driver.FindElement(btnNewResponsibility).Click();
        }

        public void verifyNewResponsibilityWindow()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveNewResponsibility));

            Assert.AreEqual(true, driver.FindElement(btnSaveNewResponsibility).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnCancelNewResponsibility).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddUser).Displayed);
        }

        public void enterResponsibilityDetails(string NewOrDelete)
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            uf.IsPageLoaded(driver);

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));

            if (NewOrDelete == "New")
                selectRole.SelectByText("Client Management");
            else
                selectRole.SelectByText("Digital Sales Manager");


            SelectElement selectUser = new SelectElement(driver.FindElement(ddUser));
            selectUser.SelectByText("TESTUSER2");

        }

        public void verifyResponsibilityDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfResponsibilitiesCount = driver.FindElements(responsibilitysRow).Count();

            string responsibilityGridRows = "";
            for (int i = 0; i < noOfResponsibilitiesCount; i++)
            {
                responsibilityGridRows = "tr#grdOpportunityResponsibility_r_" + i + "> td:nth-child(5) > nobr";
                By responsibilityGridR = By.CssSelector(responsibilityGridRows);
                if (driver.FindElement(responsibilityGridR).Text == "Client Management")
                {
                    Assert.AreEqual("Client Management", driver.FindElement(responsibilityGridR).Text);
                }
            }


        }

        public void selectCreatedResponsibility()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfResponsibilitiesCount = driver.FindElements(responsibilitysRow).Count();


            string responsibilityGridRowRole = "";
            string responsibilityGridRowAppUser = "";
            for (int i = 0; i < noOfResponsibilitiesCount; i++)
            {
                responsibilityGridRowRole = "tr#grdOpportunityResponsibility_r_" + i + "> td:nth-child(5) > nobr";
                responsibilityGridRowAppUser = "tr#grdOpportunityResponsibility_r_" + i + "> td:nth-child(6) > nobr";
                By responsibilityGridRole = By.CssSelector(responsibilityGridRowRole);
                By responsibilityGridAppUser = By.CssSelector(responsibilityGridRowAppUser);
                if (driver.FindElement(responsibilityGridRole).Text == "Digital Sales Manager" && driver.FindElement(responsibilityGridAppUser).Text == "TESTUSER2")
                {
                    driver.FindElement(responsibilityGridRole).Click();
                    break;
                }
            }
        }

        public void deleteCreatedResponsiblity()
        {
            noOfResponsibilitiesCount = driver.FindElements(responsibilitysRow).Count();
            driver.FindElement(btnDeleteResponsibility).Click();
        }

        public void verifyResponsibilityIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfResponsibilitiesCount - 1, driver.FindElements(responsibilitysRow).Count());
        }

        public void navigateToMediaTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnMedia).Click();
        }

        public void verifyMediaTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewMedia));

            Assert.AreEqual(true, driver.FindElement(btnNewMedia).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteMedia).Displayed);
            Assert.AreEqual("Media", driver.FindElement(gridMedia).Text);
            Assert.AreEqual("Estimated Value", driver.FindElement(gridEstimatedValueMedia).Text);
        }

        public void clickNewMediaButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewMedia).Click();
        }

        public void verifyNewMediaButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(btnSaveNewResponsibility));

            Assert.AreEqual(true, driver.FindElement(btnSaveNewResponsibility).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCancelNewCompetitor).Enabled);

            Assert.AreEqual(true, driver.FindElement(ddMedia).Enabled);
            Assert.AreEqual(true, driver.FindElement(tbEstimatedValueMedia).Enabled);
            Assert.AreEqual(true, driver.FindElement(cbSelectDeselectAll).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtIssueCount).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtMedia).Enabled);

            Assert.AreEqual("Code", driver.FindElement(gridCode).Text);
            Assert.AreEqual("Issue Date", driver.FindElement(gridIssueDate).Text);
            Assert.AreEqual("Cover Date", driver.FindElement(gridCoverDate).Text);
            Assert.AreEqual("Description", driver.FindElement(gridDescription).Text);
            Assert.AreEqual("Status", driver.FindElement(gridStatus).Text);
            Assert.AreEqual("Estimated Value", driver.FindElement(gridEstimatedValueNewMedia).Text);

        }

        public void enterMediaDetails(string NewORDelete)
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            uf.IsPageLoaded(driver);

            SelectElement selectedMedia = new SelectElement(driver.FindElement(ddMedia));
            if (NewORDelete == "New")
                selectedMedia.SelectByText("Brides Magazine");
            else
                selectedMedia.SelectByText("Alberton Record");

            uf.IsPageLoaded(driver);
            driver.FindElement(cbSelectDeselectAll).Click();

            uf.IsPageLoaded(driver);
            driver.FindElement(cbSelectDeselectAll).Click();

            driver.FindElement(tbEstimatedValueMedia).SendKeys("500");
        }

        public void verifyMediaDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfMediaCount = driver.FindElements(mediaRow).Count();

            string mediaGridRows = "";
            for (int i = 0; i < noOfMediaCount; i++)
            {
                mediaGridRows = "tr#grdOpportunityMedium_r_" + i + "> td:nth-child(5) > nobr";
                By mediaGridR = By.CssSelector(mediaGridRows);
                if (driver.FindElement(mediaGridR).Text == "Brides Magazine")
                {
                    Assert.AreEqual("Brides Magazine", driver.FindElement(mediaGridR).Text);
                }
            }
        }

        public void selectCreatedMedia()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfMediaCount = driver.FindElements(mediaRow).Count();

            string mediaGridRows = "";
            for (int i = 0; i < noOfMediaCount; i++)
            {
                mediaGridRows = "tr#grdOpportunityMedium_r_" + i + "> td:nth-child(5) > nobr";
                By mediaGridR = By.CssSelector(mediaGridRows);
                if (driver.FindElement(mediaGridR).Text == "Alberton Record")
                {
                    driver.FindElement(mediaGridR).Click();
                }
            }
        }


        public void selectCreatedQuote()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfQuoteCount = driver.FindElements(QuoteRow).Count() -1;
            string lastQuoteRow = "grdOpportunityQuote_r_" + noOfQuoteCount;
            driver.FindElement(By.Id(lastQuoteRow)).Click();
        }

        public void deleteAllCreatedMedias()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfMediaCount = driver.FindElements(mediaRow).Count();

            string mediaGridRows = "";
            for (int i = 0; i < noOfMediaCount; i++)
            {
                mediaGridRows = "tr#grdOpportunityMedium_r_" + i + "> td:nth-child(5) > nobr";
                By mediaGridR = By.CssSelector(mediaGridRows);
                driver.FindElement(mediaGridR).Click();
                driver.FindElement(btnDeleteMedia).Click();
            }
        }
        public void deleteMedia()
        {
            noOfMediaCount = driver.FindElements(mediaRow).Count();
            driver.FindElement(btnDeleteMedia).Click();
        }

        public void navigateToInsertionsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnInsertions).Click();
        }

        public void verifyInsertionsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewInsertionsBooking).Enabled);
            Assert.AreEqual("Booking ID", driver.FindElement(gridBookingId).Text);
            Assert.AreEqual("Medium", driver.FindElement(gridMedium).Text);
            Assert.AreEqual("Issue", driver.FindElement(gridIssue).Text);
            Assert.AreEqual("Status", driver.FindElement(gridStatusInsertions).Text);
            Assert.AreEqual("Details", driver.FindElement(gridDetails).Text);
            Assert.AreEqual("Rate", driver.FindElement(gridRateInsertions).Text);
            Assert.AreEqual("Agreed Rate", driver.FindElement(gridAgreedRateInsertions).Text);
            Assert.AreEqual("Net Amount", driver.FindElement(gridNetAmount).Text);
        }

        public void clickNewBookingButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnNewInsertionsBooking).Click();
        }

        public void verifyNewBookingPopUp()
        {
            // Check the presence of alert
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radWindow");

            Assert.AreEqual(3, driver.FindElements(tabsBookingPopUp).Count);
        }

        public void verifyBuyerAndAdvitiserName()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            uf.switchToFrameByName(driver, wait, "radWindow");

            Assert.AreEqual("TestCompany1234", driver.FindElement(txtBuyer).GetAttribute("value"));
            Assert.AreEqual("TestCompany1234", driver.FindElement(txtAdvertiser).GetAttribute("value"));
        }

        public void clickCancelBookingsButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radWindow");

            driver.FindElement(btnCancel).Click();

        }

        public void verifyCancelButtonFunctionality()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            uf.IsElementDisplayed(driver, popUpWindowBooking);

        }

        public void saveNewResponsibility()
        {
            driver.FindElement(btnSaveNewCompetitor).Click();
        }

        public void navigateToTasksTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnTasks).Click();
        }

        public void navigateToNotesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnNotes).Click();
        }

        public void navigateToAttachmentsTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnAttachements).Click();
        }

        public void navigateToSalesAssignmentTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnSalesAssignment).Click();
        }

        public void verifyTasksButtonFunctionality()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual("Start Date", driver.FindElement(gridStartDate).Text);
            Assert.AreEqual("Subject", driver.FindElement(gridSubject).Text);
            Assert.AreEqual("Status", driver.FindElement(gridStatusTask).Text);
            Assert.AreEqual("Name", driver.FindElement(gridNameTask).Text);
        }

        public void clickNewTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewTask).Click();
            uf.SwitchToNewWindow(driver);
        }

        public void enterNewTaskInformation()
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
            driver.FindElement(cbComplete).Click();
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

        public void selectingContactfromEllipsis()
        {
            clickContactEllipsis();
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            wait.Until(ExpectedConditions.ElementIsVisible(tableCompanyResults));
            driver.FindElement(selectingCompanybutton).Click();
        }

        public void clickCompanyEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(btnCompanyEllipsis));
            driver.FindElement(btnCompanyEllipsis).Click();
        }

        public void clickContactEllipsis()
        {
            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(btnContactEllipsis));
            driver.FindElement(btnContactEllipsis).Click();
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

        public void verifyTaskInOpportunitiesIsSavedSuccessfully()
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
        }

        public void navigateToQuoteTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            driver.FindElement(btnQuote).Click();
        }


        public void verifyQuoteDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");


            Assert.AreEqual("Quote ID", driver.FindElement(gridQuoteId).Text);
            Assert.AreEqual("Quote Date", driver.FindElement(gridQuoteDate).Text);
            Assert.AreEqual("User", driver.FindElement(gridUser).Text);
            Assert.AreEqual("Rate", driver.FindElement(gridRate).Text);
            Assert.AreEqual("Agreed Rate", driver.FindElement(gridAgreedRate).Text);
            Assert.AreEqual("Series Discount", driver.FindElement(gridSeriesDiscount).Text);
            Assert.AreEqual("Net", driver.FindElement(gridNet).Text);
            Assert.AreEqual("Total", driver.FindElement(gridTotal).Text);
            Assert.AreEqual("Booking ID", driver.FindElement(gridBookingIdQuote).Text);

            Assert.AreEqual(true, driver.FindElement(btnNewQuote).Enabled);
        }

        public void clickNewQuoteButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");

            driver.FindElement(btnNewQuote).Click();
        }

        public void verifyQuotePopUp()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            //uf.switchToFrameByName(driver, wait, "ifrPages");

            Assert.AreEqual("Media", driver.FindElement(gridInsertedMediaQuote).Text);
            Assert.AreEqual("Frequency", driver.FindElement(gridFrequency).Text);
            Assert.AreEqual("Next Issue", driver.FindElement(gridNextIssue).Text);

            Assert.AreEqual("Media", driver.FindElement(gridSelectedMediaQuote).Text);
            Assert.AreEqual("Ins", driver.FindElement(gridIns).Text);
            Assert.AreEqual("Ad Type", driver.FindElement(gridAdType).Text);
            Assert.AreEqual("Issue", driver.FindElement(gridIssueSelectedMedia).Text);
            Assert.AreEqual("Next Issue", driver.FindElement(gridNextIssue).Text);
            Assert.AreEqual("Details", driver.FindElement(gridDetailsSelectedMedia).Text);
            Assert.AreEqual("Rate", driver.FindElement(gridSelectedMediaRate).Text);
            Assert.AreEqual("Agreed Rate", driver.FindElement(gridSelectedMediaAgreedRate).Text);

            Assert.AreEqual(true, driver.FindElement(tbNoOfInsertions).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnAddInsertion).Displayed);

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtNEP), driver));
            Assert.AreEqual("0.000", driver.FindElement(txtNEP).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtPublishedRate), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtPublishedRate).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtRate), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtRate).GetAttribute("value"));

            Assert.AreEqual("0.00", driver.FindElement(txtAgreedRate).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtSeriesDiscount), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtSeriesDiscount).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtAgencyCommissionPercentage), driver));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtAgencyCommission), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtAgencyCommission).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtNetTotal), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtNetTotal).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtTaxRate), driver));
            Assert.AreEqual("0.00%", driver.FindElement(txtTaxRate).GetAttribute("value"));

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(txtTax), driver));
            Assert.AreEqual("0.00", driver.FindElement(txtTax).GetAttribute("value"));

        }

        public void enterQuoteDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            SelectElement selectAdType = new SelectElement(driver.FindElement(ddlAdType));
            selectAdType.SelectByText("Display");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddlMediaGroup));
            selectMediaGroup.SelectByText("Magazine Titles");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            wait.Until(ExpectedConditions.ElementIsVisible(mediaFirstRow));


            int noOfRows = driver.FindElements(rowMedia).Count;

            for (int i = 0; i < noOfRows; i++)
            {
                if (driver.FindElements(rowMedia)[i].Text == "House & Garden Magazine")
                {
                    driver.FindElements(rowMedia)[i].Click();
                }
            }

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(ddlAdSize));
            SelectElement selectAdSize = new SelectElement(driver.FindElement(ddlAdSize));
            selectAdSize.SelectByText("8x2");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            wait.Until((d) => driver.FindElement(txtColumn).GetAttribute("value") != "");

            valueOfDepth = driver.FindElement(txtDepthSel).GetAttribute("value");
            valueOfCol = driver.FindElement(txtColumn).GetAttribute("value");

            wait.Until(ExpectedConditions.ElementIsVisible(ddlPosition));
            SelectElement selectPosition = new SelectElement(driver.FindElement(ddlPosition));
            selectPosition.SelectByText("First Page");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(ddlSection));
            SelectElement selectSection = new SelectElement(driver.FindElement(ddlSection));
            selectSection.SelectByText("Lifestyle");

            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementIsVisible(tbNoOfInsertions));
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(tbNoOfInsertions));
            Thread.Sleep(2000);
            driver.FindElement(tbNoOfInsertions).Clear();
            driver.FindElement(tbNoOfInsertions).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(btnAddInsertion).Click();
        }

        public void clickEditQuoteButton()
        {
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            wait.Until(ExpectedConditions.ElementToBeClickable(btnEditQuote));
            int countOfEditButton = driver.FindElements(btnEditQuote).Count();
            Thread.Sleep(2000);
            driver.FindElements(btnEditQuote)[countOfEditButton - 1].Click();
        }

        public void clickDeleteQuoteButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDelQuote));            
            noOfQuoteCount = driver.FindElements(QuoteRow).Count();
            driver.FindElement(btnDelQuote).Click();
        }

        public void verifyQuoteDetailsAreSaved()
        {

            wait.Until(ExpectedConditions.ElementIsVisible(ddAdSizePopUp));
            var adSizeSelected = driver.FindElement(ddAdSizePopUp);
            var adSel = new SelectElement(adSizeSelected);
            var ads = adSel.SelectedOption;
            string selectedAdSize = ads.Text;
            Assert.AreEqual("8x2", selectedAdSize);

            Assert.AreEqual(valueOfDepth, driver.FindElement(txtDepth).GetAttribute("value"));
            Assert.AreEqual(valueOfCol, driver.FindElement(txtCol).GetAttribute("value"));

            var positionSelected = driver.FindElement(ddPositionPopUp);
            var pSel = new SelectElement(positionSelected);
            var ps = pSel.SelectedOption;
            string selectedPosition = ps.Text;
            Assert.AreEqual("First Page", selectedPosition);

            var selectionSelected = driver.FindElement(ddSectionPopUp);
            var dSel = new SelectElement(selectionSelected);
            var ds = dSel.SelectedOption;
            string selectedSelection = ds.Text;
            Assert.AreEqual("Lifestyle", selectedSelection);

            Assert.AreEqual("1", driver.FindElement(txtIns).GetAttribute("value"));
        }

        public void verifyQuoteIsDeleted()
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(btnDeleteQuote));
            Assert.AreEqual(countOfDeleteButton - 1, driver.FindElements(btnDeleteQuote).Count);

            Assert.AreEqual(noOfQuoteCount - 1, driver.FindElements(QuoteRow).Count);
        }

        public void clickCancelButton()
        {
            driver.FindElement(btnCancelQuote).Click();
            driver.SwitchTo().Alert().Accept();
        }

        public void editQuote()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ddPositionPopUp));
            SelectElement selectPosition = new SelectElement(driver.FindElement(ddPositionPopUp));
            selectPosition.SelectByText("Left Hand Page");
        }

        public void clickApplyButton()
        {
            driver.FindElement(btnApply).Click();
        }

        public void verifyEditedQuote()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            wait.Until(ExpectedConditions.ElementExists(ddPositionPopUp));
            var positionSelected = driver.FindElement(ddPositionPopUp);
            var pSel = new SelectElement(positionSelected);
            var ps = pSel.SelectedOption;
            string selectedPosition = ps.Text;
            Assert.AreEqual("Left Hand Page", selectedPosition);
        }

        public void clickEditQuote()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            rowsOfQuote = driver.FindElements(btnEditCreatedQuote).Count;
            driver.FindElements(btnEditCreatedQuote)[rowsOfQuote - 1].Click();
        }

        public void navigateToCalenderViewQuote()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "ifrPages");
            rowsOfQuote = driver.FindElements(btnEditCreatedQuote).Count;
            driver.FindElements(btnEditCreatedQuote)[0].Click();
        }


        public void clickStationeryButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            driver.FindElement(btnStationery).Click();
        }

        public void verifyStationeryButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.SwitchToNewWindow(driver);

            Assert.AreEqual(true, driver.FindElement(btnCloseStatitonery).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlSelectLetter).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnEmail).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnSaveAsPDF).Enabled);

        }

        public void clickCreateBooking()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            wait.Until(ExpectedConditions.ElementToBeClickable(btnCreateBookingInQuote));
            driver.FindElement(btnCreateBookingInQuote).Click();
        }

        public void verifyQuoteBookingDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            wait.Until(ExpectedConditions.ElementExists(btnCancelQuoteBooking));

            Assert.AreEqual(false, driver.FindElement(btnNext).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnCancelQuoteBooking).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderSelectIssues).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderMedia).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderInsertion).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderAdType).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderDetails).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderRate).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderAgreedRate).Displayed);
            Assert.AreEqual(true, driver.FindElement(colHeaderStatus).Displayed);
        }

        public void selectQuoteBookingIssue(string CalenderOrListView)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            QuoteBookingIssueRows = driver.FindElements(btnSelectIssue).Count;
            driver.FindElements(btnSelectIssue)[QuoteBookingIssueRows - 1].Click();
            if (CalenderOrListView == "ListView")
                driver.SwitchTo().Alert().Accept();
        }

        public void verifyQuoteBookingIssueDetails(string ListOrCalenderView)
        {
            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            if (ListOrCalenderView == "List")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(txtListNoOfIssues));

                Assert.AreEqual(true, driver.FindElement(txtListNoOfIssues).Displayed);
                Assert.AreEqual(true, driver.FindElement(ddlBookingStatus).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderSelectIssue).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderIssueDate).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderDesc).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderCopyDL).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderReservationDL).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderStatus).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderPosition).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderCustomerRef).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderAgencyRef).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderBrand).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderSInsertionType).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderPromoType).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderBookingStatus).Displayed);
            }
            else
            {
                wait.Until(ExpectedConditions.ElementIsVisible(txtCalenderNoOfIssues));

                Assert.AreEqual(true, driver.FindElement(txtCalenderNoOfIssues).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderDelete).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderIssue).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderCopyDeadLine).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderResDL).Displayed);
                Assert.AreEqual(true, driver.FindElement(selectIssueGridHeaderSta).Displayed);
            }

        }

        public void selectIssueInIssueSelectionGrid()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            wait.Until(ExpectedConditions.ElementExists(chkSelectIssue));
            driver.FindElement(chkSelectIssue).Click();
        }



        public void verifySelectIssueDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            wait.Until(ExpectedConditions.ElementIsVisible(txtCustomerRef));

            Assert.AreEqual(true, driver.FindElement(txtCustomerRef).Enabled);
            Assert.AreEqual(true, driver.FindElement(txtAgencyRef).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlBrandInSelectIssue).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddlBookingStatusInSelectIssue).Enabled);
        }


        public void enterIssueDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");

            wait.Until(ExpectedConditions.ElementToBeClickable(txtCustomerRef));
            driver.FindElement(txtCustomerRef).SendKeys("Test ref");
            driver.FindElement(txtAgencyRef).SendKeys("Test ref");


            IWebElement ddBookingS = driver.FindElement(ddlBookingStatus);
            SelectElement seBookingS = new SelectElement(ddBookingS);
            seBookingS.SelectByText("Confirmed");

            IWebElement ddBookingSI = driver.FindElement(ddlBookingStatusInSelectIssue);
            SelectElement seBookingSI = new SelectElement(ddBookingSI);
            seBookingSI.SelectByText("Confirmed");

            driver.FindElement(btnApplyIssueSelection).Click();

        }

        public void verifyNextButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "RightPane");
            uf.switchToFrameByName(driver, wait, "ifrDetail");
            uf.switchToFrameByName(driver, wait, "radOppQuote");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNext));

            Assert.AreEqual(true, driver.FindElement(btnNext).Enabled);
        }

        #endregion Functions
    }
}