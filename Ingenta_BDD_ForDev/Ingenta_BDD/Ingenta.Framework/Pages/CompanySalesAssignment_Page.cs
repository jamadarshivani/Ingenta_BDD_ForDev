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
    public class CompanySalesAssignment_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();


        #region Variables

        int noOfSalesAssignment = 0;
        string tommorowsDate = DateTime.Now.AddDays(4).ToString("dd-MM-yyyy");
        string today = DateTime.Today.ToString("dd-MM-yyyy");
        string yesterdaysDate = DateTime.Today.AddDays(-3).ToString("dd-MM-yyyy");
        string futureDate = DateTime.Now.AddDays(10).ToString("dd-MM-yyyy");
        //string selectedDate = null;
        #endregion Variables

        public CompanySalesAssignment_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }


        #region Object Repository

        By tabSalesAssignment = By.Id("iglbarMenu_1_Item_2");
        By btnNewSalesAssignment = By.Id("ffListAssignment_btnAddAssignment");

        //New Sales Assignment

        By ddRole = By.Id("ddlRole");
        By ddMediaEditAssignment = By.Id("ddlMedia");
        By ddMediaGroup = By.Id("ddlMediaGroup");
        By ddMedia = By.Id("ffListAssignment_ddlMedia");
        By btnEllipsisStartDate = By.Id("btnStartIssue");
        By btnEllipsisEndDate = By.Id("btnEndIssue");

        By btnIssue = By.CssSelector("input.ig_341d2b7f_rcb1112.salesAssignment");
        //By btnEndIssue = By.Id("ffIssueListxgrdIssues_rc_1_0");

        //Selecting Start and End Date

        By btnIssueDate = By.Id("ffIssueListxgrdIssues_rc_0_0");
        By ddSalesGroup = By.Id("ddlUserGroup");
        By listSalesPerson = By.Id("lstSalesPerson");
        By rbCurrentAssignments = By.Id("ffListAssignment_rblAssignmentsDateControl_0");
        By rbAllAssignments = By.Id("ffListAssignment_rblAssignmentsDateControl_1");
        By mediaGroupGridHeader = By.Id("ffListAssignmentxgrdAssignment_c_0_2");
        By roleGridHeader = By.Id("ffListAssignmentxgrdAssignment_c_0_3");
        By assignedGridHeader = By.Id("ffListAssignmentxgrdAssignment_c_0_6");
        By assignmentTypeGridHeader = By.Id("ffListAssignmentxgrdAssignment_c_0_14");
        By sourceGridHeader = By.Id("ffListAssignmentxgrdAssignment_c_0_15");
        By btnEditAssignment = By.CssSelector("input.ig_e9a70e42_rcb1112.salesAssignment");
        By btnRequest = By.Id("ffListAssignment_btnRequest");
        By btnDelete = By.Id("ffListAssignment_btnDeleteAssignment");
        By btnAdd = By.Id("btnAdd");
        By btnRemove = By.Id("btnRemove");
        By tableAssignedSalesperson = By.CssSelector("th#grdAssignedSalesPerson_c_0_2 > nobr");
        By tablePercentage = By.CssSelector("th#grdAssignedSalesPerson_c_0_3 > nobr");
        By calBtnStartDate = By.Id("dateIssueStartDate_dteDate_img");
        By calBtnEndDate = By.Id("dateIssueEndDate_dteDate_img");
        By tbTodayDate = By.Id("dateIssueStartDate_dteDate_DrpPnl1_DP_CAL_ID_1_508");
        //By endCalendarDays = By.CssSelector("table#dateIssueEndDate_dteDate_DrpPnl2_DP_CAL_ID_2_512 > tbody > tr > td.dateIssueEndDate_dteDate_DrpPnl2_DP_CAL_ID_20");
        By calenderEndDate = By.Id("dateIssueEndDate_dteDate_DrpPnl2_DP_CAL_ID_2_d41");
        By btnSave = By.Id("btnSave");
        By btnSaveClose = By.Id("btnSaveClose");
        By btnClose = By.Id("btnClose");
        By gridMediaGroup = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(3) > nobr");
        By gridRole = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(4) > nobr");
        By gridAssigned = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(7) > nobr");
        By gridMediaGroup2 = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr:nth-child(2) > td:nth-child(3) > nobr");
        By gridRole2 = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr:nth-child(2) > td:nth-child(4) > nobr");
        By gridAssigned2 = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr:nth-child(2) > td:nth-child(7) > nobr");
        By txtAssignmentExistsErrorMsg = By.Id("lblErrorMessage");
        By tbStartDate = By.Id("dateIssueStartDate_dteDate_input");
        By tbEndDate = By.Id("dateIssueEndDate_dteDate_input");
        By rowMediaGroup = By.CssSelector("table#G_ffListAssignmentxgrdAssignment> tbody > tr");
        By rowsAssignments = By.CssSelector("table#G_ffListAssignmentxgrdAssignment > tbody > tr");
        By rowsRelationship = By.CssSelector("table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr");
        By todaysDate = By.ClassName("todayCalender");
        By tabSalesAssignments = By.Id("iglbarMenu_1_Item_2");
        By tabSalesAssignmentsRelationship = By.Id("iglbarMenu_0_Item_1");
        By btnNewSalesAssignments = By.Id("ffListAssignment_btnAddAssignment");
        By btnDeleteSalesAssignments = By.Id("ffListAssignment_btnDeleteAssignment");
        By rdCurrentAssignment = By.Id("ffListAssignment_rblAssignmentsDateControl_0");
        By rdAllAssignment = By.Id("ffListAssignment_rblAssignmentsDateControl_1");

        #endregion Object Repository

        #region Functions

        public void navigateToSalesAssignnment()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(tabSalesAssignment));
            driver.FindElement(tabSalesAssignment).Click();
        }

        public void newSalesAssignmentWindow()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementToBeClickable(btnNewSalesAssignment));
            driver.FindElement(btnNewSalesAssignment).Click();
        }

        public void verifySalesAssignmentButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnNewSalesAssignment).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDelete).Displayed);
            //Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnRequest), driver));
            Assert.AreEqual(true, driver.FindElement(btnRequest).Enabled);

            var mediaSelected = driver.FindElement(ddMedia);
            var mSel = new SelectElement(mediaSelected);
            var ms = mSel.SelectedOption;
            string selectedMedia = ms.Text;
            Assert.AreEqual("<All>", selectedMedia);

            Assert.AreEqual(true, driver.FindElement(rbCurrentAssignments).Displayed);
            Assert.AreEqual(true, driver.FindElement(rbAllAssignments).Displayed);
        }

        public void verifyOpportunitiesSalesAssignmentViaContact()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(rbCurrentAssignments).Displayed);
            Assert.AreEqual(true, driver.FindElement(rbAllAssignments).Displayed);

            Assert.AreEqual(true, driver.FindElement(mediaGroupGridHeader).Displayed);
            Assert.AreEqual(true, driver.FindElement(roleGridHeader).Displayed);
            Assert.AreEqual(true, driver.FindElement(assignedGridHeader).Displayed);
            Assert.AreEqual(true, driver.FindElement(assignmentTypeGridHeader).Displayed);
            Assert.AreEqual(true, driver.FindElement(sourceGridHeader).Displayed);
        }

        public void verifyNewSalesAssignmentButton()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);

            driver.SwitchTo().DefaultContent();
            wait.Until(ExpectedConditions.ElementIsVisible(ddRole));
            Assert.AreEqual(true, driver.FindElement(ddRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddMediaGroup).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddMediaEditAssignment).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnEllipsisStartDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnEllipsisEndDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddSalesGroup).Displayed);
            Assert.AreEqual(true, driver.FindElement(listSalesPerson).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnAdd).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnRemove).Displayed);
            Assert.AreEqual("Assigned Salesperson", driver.FindElement(tableAssignedSalesperson).Text);
            Assert.AreEqual("Percentage (%)", driver.FindElement(tablePercentage).Text);
        }

        public void enterSalesAssignmentDetailsWithDiffMediaGroup()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");

            uf.IsPageLoaded(driver);
            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Events & Awards");

            uf.IsPageLoaded(driver);
            driver.FindElement(calBtnStartDate).Click();
            driver.FindElement(tbTodayDate).Click();

            driver.FindElement(calBtnEndDate).Click();
            //selectingFutureEndDate();

            driver.FindElement(tbEndDate).Click();
            driver.FindElement(tbEndDate).Clear();
            driver.FindElement(tbEndDate).SendKeys(futureDate);


            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();

        }

        public void saveSalesAssignmentDetails()
        {
            Thread.Sleep(2000);
            driver.FindElement(btnSave).Click();
        }

        public void closeAssignmentDetailsWindow()
        {
            driver.FindElement(btnClose).Click();
        }

        public void selectingFutureEndDate()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(calenderEndDate));
            //int lastDay = driver.FindElements(endCalendarDays).Count();
            //driver.FindElements(endCalendarDays)[lastDay - 1].Click();

            driver.FindElement(calenderEndDate).Click();


        }

        public void verifyAssignmentExistsErrorMessage()
        {
            Assert.AreEqual("Assignment already exists", driver.FindElement(txtAssignmentExistsErrorMsg).Text);
        }

        public void verifySecondSalesAssignment()
        {
            Assert.AreEqual("Events & Awards", driver.FindElement(gridMediaGroup2).Text);
            Assert.AreEqual("Display Sales", driver.FindElement(gridRole2).Text);
            Assert.AreEqual("80 - TESTUSER2 (100.00%)", driver.FindElement(gridAssigned2).Text);
        }

        public void enterSalesAssignmentDetailsWithMedia()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");

            Thread.Sleep(2000);

            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Magazine Titles");
            Thread.Sleep(2000);
            uf.IsPageLoaded(driver);
            SelectElement selectMedia = new SelectElement(driver.FindElement(ddMediaEditAssignment));
            selectMedia.SelectByText("Brides Magazine");
            Thread.Sleep(2000);
            uf.IsPageLoaded(driver);
            selectStartIssueDate();
            selectEndIssueDate();
            driver.SwitchTo().DefaultContent();

            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();
        }

        public void selectStartIssueDate()
        {
            driver.FindElement(btnEllipsisStartDate).Click();
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "popListIssues");

            driver.FindElements(btnIssue)[1].Click();
        }

        public void selectEndIssueDate()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnEllipsisEndDate));
            driver.FindElement(btnEllipsisEndDate).Click();
            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "popListIssues");

            driver.FindElements(btnIssue)[2].Click();
        }

        public void verifyAssignmentDetailsWithMedia()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbAllAssignments).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(gridMediaGroup));

            Assert.AreEqual("Brides Magazine", driver.FindElement(gridMediaGroup).Text);
            Assert.AreEqual("Display Sales", driver.FindElement(gridRole).Text);
            Assert.AreEqual("80 - TESTUSER2 (100.00%)", driver.FindElement(gridAssigned).Text);
        }

        public void selectAllRadioButton()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbAllAssignments).Click();
        }

        public void selectCurrentRadioButton()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbCurrentAssignments).Click();
        }

        public void clickSaveAndCloseButton()
        {
            uf.IsPageLoaded(driver);
            driver.FindElement(btnSaveClose).Click();
        }

        public void enterSalesAssignmentDetailsWithDifferentUser()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");

            uf.IsPageLoaded(driver);
            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Magazine Titles");

            uf.IsPageLoaded(driver);
            SelectElement selectMedia = new SelectElement(driver.FindElement(ddMediaEditAssignment));
            selectMedia.SelectByText("Brides Magazine");

            uf.IsPageLoaded(driver);
            selectStartIssueDate();
            driver.SwitchTo().DefaultContent();

            selectEndIssueDate();

            driver.SwitchTo().DefaultContent();

            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER");

            driver.FindElement(btnAdd).Click();
        }

        public void verifyingCurrentRadioButtonFunctionalitySalesAssignments()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            int rowAssignmentsCount = driver.FindElements(rowsAssignments).Count();
            string dtStartDate = "";
            string dtSentDate = "";

            for (int i = 1; i < rowAssignmentsCount + 1; i++)
            {
                string startDate = "table#G_ffListAssignmentxgrdAssignment > tbody > tr:nth-child(" + i + ") > td:nth-child(5)";
                dtStartDate = DateTime.Parse(driver.FindElement(By.CssSelector(startDate)).GetAttribute("uv")).ToString("dd/MM/yyyy");
                dtSentDate = DateTime.Parse(DateTime.Today.ToShortDateString()).ToString("dd/MM/yyyy");

                DateTime pstartDate = DateTime.ParseExact(dtStartDate, "dd/MM/yyyy", null);
                DateTime pendDate = DateTime.ParseExact(dtSentDate, "dd/MM/yyyy", null);

                if (pstartDate < pendDate)
                {
                    Assert.Fail("Fetched Data is wrong");
                }
            }

        }

        public void verifyingAllRadioButtonFunctionalitySalesAssignments()
        {
            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();
            string dtStartDate = "";
            for (int i = 1; i < rowRelationshipCount + 1; i++)
            {

                string startDate = "table#G_ffListAssignmentxgrdAssignment > tbody > tr:nth-child(" + i + ") > td:nth-child(5)";
                dtStartDate = DateTime.Parse(driver.FindElement(By.CssSelector(startDate)).GetAttribute("uv")).ToString("dd-MM-yyyy");

                if (dtStartDate == null)
                {
                    Assert.Fail("Fetched Data is wrong");
                }

            }
        }

        public void verifySalesAssignmentDetails()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfSalesAssignment = driver.FindElements(rowsAssignments).Count();

            string mediaRows = "";
            string roleRows = "";

            for (int i = 0; i < noOfSalesAssignment; i++)
            {
                mediaRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(3) > nobr";
                roleRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(4) > nobr";
                By mediaRowsR = By.CssSelector(mediaRows);
                By roleRowsR = By.CssSelector(roleRows);
                if (driver.FindElement(mediaRowsR).Text == "Digital Media" && driver.FindElement(roleRowsR).Text == "Display Sales")
                {
                    Assert.AreEqual("Digital Media", driver.FindElement(gridMediaGroup).Text);
                    Assert.AreEqual("Display Sales", driver.FindElement(gridRole).Text);
                    Assert.AreEqual("80 - TESTUSER2 (100%)", driver.FindElement(gridAssigned).Text);
                }
            }


        }

        public void verifySalesPersonIsChanged()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbAllAssignments).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(gridMediaGroup));

            Assert.AreEqual("Brides Magazine", driver.FindElement(gridMediaGroup).Text);
            Assert.AreEqual("Display Sales", driver.FindElement(gridRole).Text);
            Assert.AreEqual("74 - TESTUSER (100.00%)", driver.FindElement(gridAssigned).Text);
        }

        public void clickEditSalesAssignmentButton()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnEditAssignment).Click();
        }

        public void editSalesAssignment()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Hub");
        }

        public void verifyUpdatedSalesAssignment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("Hub", driver.FindElement(gridMediaGroup).Text);
            Assert.AreEqual("Display Sales", driver.FindElement(gridRole).Text);
            Assert.AreEqual("80 - TESTUSER2 (100.00%)", driver.FindElement(gridAssigned).Text);
        }

        public void selectSalesAssignment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfSalesAssignment = driver.FindElements(rowMediaGroup).Count();

            driver.FindElement(gridMediaGroup).Click();

            //string mediaRows = "";
            //string roleRows = "";

            //for (int i = 0; i < noOfSalesAssignment; i++)
            //{
            //    mediaRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(3) > nobr";
            //    roleRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(4) > nobr";
            //    By mediaRowsR = By.CssSelector(mediaRows);
            //    By roleRowsR = By.CssSelector(roleRows);
            //    if (driver.FindElement(mediaRowsR).Text == "Brides Magazine" && driver.FindElement(roleRowsR).Text == "Sector Manager")
            //    {
            //        driver.FindElement(gridMediaGroup).Click();
            //    }
            //}
        }

        public void selectSalesAssignmentBeforeCreating()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(gridMediaGroup).Click();

        }
        public void deleteSalesAssignment()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(btnDelete).Click();
        }

        public void verifyDeleteButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfSalesAssignment - 1, driver.FindElements(rowMediaGroup).Count());
        }

        public void enterSalesAssignmentDetailsWithStartDate(string selectedDate)
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            if (selectedDate == "current date")
            {
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Magazine Titles");
            }
            else if (selectedDate == "past date")
            {
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Newspaper Titles");
            }
            else
            {
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Digital Media");
            }
            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            if (selectedDate == "current date")
            {
                driver.FindElement(tbStartDate).Click();
                driver.FindElement(tbStartDate).Clear();
                driver.FindElement(tbStartDate).SendKeys(today);

            }
            else if (selectedDate == "past date")
            {
                driver.FindElement(tbStartDate).Click();
                driver.FindElement(tbStartDate).Clear();
                driver.FindElement(tbStartDate).SendKeys(yesterdaysDate);

            }
            else if (selectedDate == "future date")
            {
                driver.FindElement(tbStartDate).Click();
                driver.FindElement(tbStartDate).Clear();
                driver.FindElement(tbStartDate).SendKeys(tommorowsDate);
            }

            //Thread.Sleep(2000);

            //uf.IsPageLoaded(driver);
            //wait.Until(ExpectedConditions.ElementToBeClickable(calBtnEndDate));
            //driver.FindElement(calBtnEndDate).Click();

            Thread.Sleep(2000);

            //selectingFutureEndDate();           

            driver.FindElement(tbEndDate).Click();
            driver.FindElement(tbEndDate).Clear();
            driver.FindElement(tbEndDate).SendKeys(futureDate);


            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();

        }

        public void navigateToSalesAssignmentsTab(string navigatedFrom)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            if (navigatedFrom == "Company")
            {
                wait.Until(ExpectedConditions.ElementExists(tabSalesAssignments));
                driver.FindElement(tabSalesAssignments).Click();
            }
            else
            {
                wait.Until(ExpectedConditions.ElementExists(tabSalesAssignmentsRelationship));
                driver.FindElement(tabSalesAssignmentsRelationship).Click();
            }
        }

        public void verifySalesAssignmentsTabDetails()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(btnNewSalesAssignments));

            Assert.AreEqual(true, driver.FindElement(btnNewSalesAssignments).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteSalesAssignments).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddMedia).Displayed);
            Assert.AreEqual(true, driver.FindElement(rdCurrentAssignment).Selected);
            Assert.AreEqual(true, driver.FindElement(rdAllAssignment).Displayed);
        }

        public void deleteAllSalesAssignmentsBeforeCreatingNew()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbAllAssignments).Click();

            noOfSalesAssignment = driver.FindElements(rowMediaGroup).Count();

            string mediaRows = "";
            string roleRows = "";

            for (int i = 0; i < noOfSalesAssignment; i++)
            {
                mediaRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(3) > nobr";
                roleRows = "tr#ffListAssignmentxgrdAssignment_r_" + i + " > td:nth-child(4) > nobr";
                By mediaRowsR = By.CssSelector(mediaRows);
                By roleRowsR = By.CssSelector(roleRows);
                Thread.Sleep(2000);
                driver.FindElement(gridMediaGroup).Click();
                Thread.Sleep(2000);
                driver.FindElement(btnDelete).Click();
                Thread.Sleep(2000);
            }
        }

        public void clickNewSalesAssignmentButton()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewSalesAssignment).Click();
        }

        public void deleteSalesAssignmentBeforeCreatingContactRelationShip()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            noOfSalesAssignment = driver.FindElements(rowsAssignments).Count();

            for (int i = 0; i < noOfSalesAssignment; i++)
            {
                selectSalesAssignmentBeforeCreating();
                deleteSalesAssignment();
            }
        }

        public void selectAllAssignments()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(rdAllAssignment).Click();
        }


        public void selectCurrentSalesAssignmentRadioButton()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(rdCurrentAssignment).Click();
        }

        

        public void enterSalesAssignmentDetails(string NewOrDelete)
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();
            //if (NewOrDelete == "New")
            //{
            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");
            //}
            //else
            //{
            //    SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            //    selectRole.SelectByText("Sector Manager");

            //}

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Radio");

            Thread.Sleep(2000);

            //if (NewOrDelete == "Delete")
            //{

            //    uf.IsPageLoaded(driver);
            //    SelectElement selectRole = new SelectElement(driver.FindElement(ddMediaEditAssignment));
            //    selectRole.SelectByText("Brides Magazine");

            //    uf.IsPageLoaded(driver);
            //    selectStartIssueDate();
            //    selectEndIssueDate();

            //    driver.SwitchTo().DefaultContent();

            //    SelectElement selectSalesGroupDel = new SelectElement(driver.FindElement(ddSalesGroup));
            //    selectSalesGroupDel.SelectByText("Sales Execs");

            //    uf.IsPageLoaded(driver);
            //    wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            //    SelectElement selectSalesPersonDel = new SelectElement(driver.FindElement(listSalesPerson));
            //    selectSalesPersonDel.SelectByText("TESTUSER2");

            //    driver.FindElement(btnAdd).Click();
            //}

            //else
            //{  
            driver.FindElement(tbStartDate).Click();
            driver.FindElement(tbStartDate).Clear();
            driver.FindElement(tbStartDate).SendKeys(today);

            driver.FindElement(tbEndDate).Click();
            driver.FindElement(tbEndDate).Clear();
            driver.FindElement(tbEndDate).SendKeys(futureDate);

            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();
            //}

        }

        public void enterSalesAssignmentDetailsToBeVerified()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Sector Manager");

            Thread.Sleep(2000);

            SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
            selectMediaGroup.SelectByText("Events & Awards");
            Thread.Sleep(2000);
            uf.IsPageLoaded(driver);
            SelectElement selectMedia = new SelectElement(driver.FindElement(ddMediaEditAssignment));
            selectMedia.SelectByText("Home & Gardens Show");
            Thread.Sleep(2000);
            uf.IsPageLoaded(driver);
            selectStartIssueDate();
            selectEndIssueDate();
            driver.SwitchTo().DefaultContent();

            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();
        }

        //public void enterSalesAssignmentDetailsCurrentFuture(string CurrentOrFuture)
        //{
        //    uf.IsPageLoaded(driver);
        //    uf.SwitchToNewWindow(driver);
        //    driver.SwitchTo().DefaultContent();

        //    wait.Until(ExpectedConditions.ElementToBeClickable(ddRole));
        //    SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
        //    selectRole.SelectByText("Display Sales");

        //    uf.IsPageLoaded(driver);
        //    SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
        //    selectMediaGroup.SelectByText("Digital Media");

        //    Thread.Sleep(2000);

        //    uf.IsPageLoaded(driver);

        //    if (CurrentOrFuture == "Current")
        //    {
        //        driver.FindElement(calBtnStartDate).Click();
        //        driver.FindElement(tbTodayDate).Click();

        //        //driver.FindElement(calBtnEndDate).Click();
        //        //selectingFutureEndDate();

        //        driver.FindElement(tbEndDate).Click();
        //        driver.FindElement(tbEndDate).Clear();
        //        driver.FindElement(tbEndDate).SendKeys(futureDate);


        //    }
        //    else
        //    {
        //        driver.FindElement(calBtnStartDate).Click();
        //        driver.FindElement(tbTodayDate).Click();

        //        //driver.FindElement(calBtnEndDate).Click();
        //        //selectingFutureEndDate();

        //        driver.FindElement(tbEndDate).Click();
        //        driver.FindElement(tbEndDate).Clear();
        //        driver.FindElement(tbEndDate).SendKeys(futureDate);

        //    }

        //    Thread.Sleep(2000);

        //    SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
        //    selectSalesGroup.SelectByText("Sales Execs");

        //    Thread.Sleep(2000);

        //    uf.IsPageLoaded(driver);
        //    wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
        //    SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
        //    selectSalesPerson.SelectByText("TESTUSER2");

        //    driver.FindElement(btnAdd).Click();
        //}


        public void enterSalesAssignmentDetailsCurrentFuture(string CurrentOrFuture)
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementToBeClickable(ddRole));
            SelectElement selectRole = new SelectElement(driver.FindElement(ddRole));
            selectRole.SelectByText("Display Sales");
            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);

            if (CurrentOrFuture == "Current")
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Digital Media");
                Thread.Sleep(2000);
                driver.FindElement(calBtnStartDate).Click();
                driver.FindElement(tbTodayDate).Click();
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }
            else if (CurrentOrFuture == "Past")
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Group of all Media Titles");
                Thread.Sleep(2000);
                driver.FindElement(tbStartDate).Clear();
                driver.FindElement(tbStartDate).SendKeys(yesterdaysDate);
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }
            else if (CurrentOrFuture == "Future")
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Emailed Newsletters");
                Thread.Sleep(2000);                
                driver.FindElement(tbStartDate).SendKeys(tommorowsDate);
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }

            else if (CurrentOrFuture == "currentRadioButton")
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Events & Awards");
                Thread.Sleep(2000);
                driver.FindElement(calBtnStartDate).Click();
                driver.FindElement(tbTodayDate).Click();
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }

            else if (CurrentOrFuture == "editSalesAssignment")
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Group of all Media Titles");
                Thread.Sleep(2000);
                driver.FindElement(calBtnStartDate).Click();
                driver.FindElement(tbTodayDate).Click();
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }
            else
            {
                uf.IsPageLoaded(driver);
                SelectElement selectMediaGroup = new SelectElement(driver.FindElement(ddMediaGroup));
                selectMediaGroup.SelectByText("Hub");

                Thread.Sleep(2000);
                driver.FindElement(calBtnStartDate).Click();
                driver.FindElement(tbTodayDate).Click();
                driver.FindElement(tbEndDate).Click();
                driver.FindElement(tbEndDate).Clear();
                driver.FindElement(tbEndDate).SendKeys(futureDate);
            }

            Thread.Sleep(2000);

            SelectElement selectSalesGroup = new SelectElement(driver.FindElement(ddSalesGroup));
            selectSalesGroup.SelectByText("Sales Execs");

            Thread.Sleep(2000);

            uf.IsPageLoaded(driver);
            wait.Until(ExpectedConditions.ElementExists(By.TagName("option")));
            SelectElement selectSalesPerson = new SelectElement(driver.FindElement(listSalesPerson));
            selectSalesPerson.SelectByText("TESTUSER2");

            driver.FindElement(btnAdd).Click();
        }

        public void selectFutureStartDate()
        {

            //int lastDay = driver.FindElements(endCalendarDays).Count();
            //driver.FindElements(endCalendarDays)[lastDay - 1].Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(calenderEndDate));
            //int lastDay = driver.FindElements(endCalendarDays).Count();
            //driver.FindElements(endCalendarDays)[lastDay - 1].Click();

            driver.FindElement(calenderEndDate).Click();
        }

        public void verifyEditAssignmentButtonFunctionality()
        {
            uf.IsPageLoaded(driver);
            uf.SwitchToNewWindow(driver);
            driver.SwitchTo().DefaultContent();

            wait.Until(ExpectedConditions.ElementIsVisible(ddRole));
            string role = ddRole.ToString();

            var roleSelected = driver.FindElement(ddRole);
            var roleSel = new SelectElement(roleSelected);
            var rs = roleSel.SelectedOption;
            string selectedRole = rs.Text;

            Assert.AreEqual("Display Sales", selectedRole);
        }


        #endregion Functions
    }
}




