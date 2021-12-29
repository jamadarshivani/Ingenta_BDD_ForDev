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
    public class CompanyRelationship_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        int noOfAssignmentsCount = 0;

        public CompanyRelationship_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        string tommorowsDate = DateTime.Now.AddDays(1).ToString("dd-MM-yyyy");
        string today = DateTime.Today.ToString("dd-MM-yyyy");
        string yesterdaysDate = DateTime.Today.AddDays(-3).ToString("dd-MM-yyyy");


        #region Object Repository

        By btnNewRelationship = By.Id("FFRelationshipList_btnAddRelationship");
        By btnDeleteRelationship = By.Id("FFRelationshipList_btnDeleteRelationship");
        By btnDeleteAssignment = By.Id("ffListAssignment_btnDeleteAssignment");

        By tableRowRole = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_3");
        By tableRowownerName = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_4");
        By tableRowCompany = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_5");
        By tableRowLinkedName = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_6");
        By tableRowBrand = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_7");
        By tableRowProofDelivery = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_8");

        By tableRowStartDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_18");
        By tableRowEndDate = By.Id("FFRelationshipListxgrdCompanyRelationships_c_0_19");

        By rbCurrentFuture = By.Id("FFRelationshipList_rblRelationshipsDateControl_0");
        By rbAll = By.Id("FFRelationshipList_rblRelationshipsDateControl_1");

        By tabRelationships = By.Id("iglbarMenu_0_Item_5");
        By tabRelationshipsFromContact = By.Id("iglbarMenu_0_Item_3");

        By btnOwnerCompanyNameEllipsis = By.Id("ctlModalCompany_btnModal");
        By btnOwnerContactNameEllipsis = By.Id("ctlModalContact_btnModal");

        By btnOwnerLinkedCompanyNameEllipsis = By.Id("ctlModalLinkCompany_btnModal");
        By btnOwnerLinkedCompanyNameByHierarchyEllipsis = By.Id("ctlModalLinkCompanyByHierarchy_btnModal");
        By btnOwnerLinkedContactNameEllipsis = By.Id("ctlModalLinkContact_btnModal");
        //Create/Edit Company Under Linked

        //Under Owner Company Name Ellipsis
        //Refer CompanySearch_Page

        //Under Owner Contact Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        //Under Linked Company Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        //Under Linked Contact Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        By ddRole = By.Id("ddlRole");
        By ddBrand = By.Id("ddlBrand");
        By ddAccountStatus = By.Id("ddlAccountStatus");

        By rbOwner = By.Id("rbtnOwner");
        By rbLinked = By.Id("rbtnLinked");

        //Select Start Date
        //Select End Date

        By tbStartDate = By.Id("dcStartDate_iwdcDate_input");
        By tbEndDate = By.Id("dcEndDate_iwdcDate_input");

        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By btnSearch = By.Id("Search_GoButton");
        By btnSelectCompany = By.CssSelector("input.ig_5aac757b_rcb1112.SelectionSearch.btnOpenSite");
        By btnSelectContact = By.CssSelector("input.ig_5aac757b_rcb1112.SelectionSearch.btnOpenContact");
        //Create/Edit Company Under Owner

        //Under Owner Contact Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        //Select Role using ddRole

        //Under Linked Company Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        //Under Linked Contact Name Ellipsis
        //Refer CompanySearch_Page (Similar)

        //Select Brand using ddBrand
        //Select AccountStatus using ddAccountStatus

        //Select Start Date using tbStartDate
        //Select End Date using tbEndDate

        By rowsRelationship = By.CssSelector("table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr");
        By rowsAssignments = By.CssSelector("table#G_ffListAssignmentxgrdAssignment > tbody > tr");
        By btnEditRelationship = By.CssSelector("input.ig_9ead756a_rcb1112.gridRowImg.relation");
        By btnEditAssignment = By.CssSelector("input.ig_e9a70e42_rcb1112.salesAssignment");
        By salesAssignmentRow = By.Id("ffListAssignmentxgrdAssignment_r_0");
        By tabSalesAssignment = By.Id("iglbarMenu_0_Item_1");


        By gridMediaGroup = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(3) > nobr");
        By gridRole = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(4) > nobr");
        By gridAssigned = By.CssSelector("table#G_ffListAssignmentxgrdAssignment>tbody >tr > td:nth-child(7) > nobr");

        #endregion Object Repository

        #region Functions

        public void navigateToRelationshipTab(string navigatedFrom)
        {
            uf.IsPageLoaded(driver);
            log.Info("Navigate to Re;ationship tab");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            if (navigatedFrom == "Company")
                driver.FindElement(tabRelationships).Click();
            else
                driver.FindElement(tabRelationshipsFromContact).Click();
        }

        public void verifyCompanyRelationshipTabDetails()
        {
            log.Info("Verifying Relationship Tab Details");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(btnNewRelationship));

            Assert.AreEqual(true, driver.FindElement(btnNewRelationship).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnDeleteRelationship).Displayed);
            Assert.AreEqual(true, driver.FindElement(rbCurrentFuture).Selected);
            Assert.AreEqual(true, driver.FindElement(rbAll).Displayed);

            Assert.AreEqual(true, driver.FindElement(tableRowBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowCompany).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowLinkedName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowownerName).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowProofDelivery).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowStartDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(tableRowEndDate).Displayed);
        }


        public void deleteSalesAssignmentBeforeCreating()
        {
            selectSalesAssignment();
            deleteSalesAssignment();
        }
        public void clickNewRelationshipButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(btnNewRelationship).Click();
        }

        public void verifyNewRelationshipButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(rbOwner).Displayed);
            Assert.AreEqual(true, driver.FindElement(rbLinked).Displayed);
            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnOwnerCompanyNameEllipsis), driver));
            Assert.AreEqual(true, driver.FindElement(btnOwnerContactNameEllipsis).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddRole).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedCompanyNameEllipsis).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedCompanyNameByHierarchyEllipsis).Enabled);
            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedContactNameEllipsis).Enabled);
            Assert.AreEqual(true, driver.FindElement(ddBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddAccountStatus).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbStartDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbEndDate).Displayed);
        }

        public void clickLinkedRelationshipRB()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(rbLinked));
            driver.FindElement(rbLinked).Click();
        }

        public void enterDetailsforLinkedRelationship()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnOwnerCompanyNameEllipsis).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            wait.Until(ExpectedConditions.ElementIsVisible(txtCompanyName));
            driver.FindElement(txtCompanyName).SendKeys("MGL Advertising Agency");

            driver.FindElement(btnSearch).Click();
            driver.FindElement(btnSelectCompany).Click();

            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnOwnerContactNameEllipsis).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");
            driver.FindElement(btnSelectContact).Click();

            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            SelectElement roleSelected = new SelectElement(driver.FindElement(ddRole));
            roleSelected.SelectByText("Brand Manager");

            //driver.FindElement(btnOwnerLinkedContactNameEllipsis).Click();
            //driver.SwitchTo().DefaultContent();
            //uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            //uf.switchToFrameByElement(driver, wait, "ifrContent");
            //driver.FindElement(btnSelectContact).Click();

            //uf.IsPageLoaded(driver);

            //driver.SwitchTo().DefaultContent();
            //uf.switchToFrameByElement(driver, wait, "RightPane");
            //uf.switchToFrameByElement(driver, wait, "ifrDetail");

            //SelectElement brandSelected = new SelectElement(driver.FindElement(ddBrand));
            //brandSelected.SelectByText("Ford");

            uf.IsPageLoaded(driver);

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            SelectElement brandSelected1 = new SelectElement(driver.FindElement(ddBrand));
            brandSelected1.SelectByValue("0.0");

            uf.IsPageLoaded(driver);

            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedContactNameEllipsis).Enabled);

            SelectElement accountStatusSelected = new SelectElement(driver.FindElement(ddAccountStatus));
            accountStatusSelected.SelectByValue("OPEN");

            driver.FindElement(tbStartDate).SendKeys(today);
            driver.FindElement(tbEndDate).SendKeys(tommorowsDate);
        }

        public void clickAllRelationshipRB()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(rbLinked));

            driver.FindElement(rbAll).Click();
        }

        public void verifyCreatedLinkedRelationship()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(rowsRelationship));
            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();

            string rrc = rowRelationshipCount.ToString();

            string Role = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(4) > nobr";
            string OwnerName = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(5) > nobr > a";
            string Company = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(6) > nobr> a";
            string Brand = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(8) > nobr";
            string StartDate = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(19) > nobr";
            string EndDate = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(20) > nobr";

            Assert.AreEqual("Brand Manager", driver.FindElement(By.CssSelector(Role)).Text);
            Assert.AreEqual("Pamela Reynolds", driver.FindElement(By.CssSelector(OwnerName)).Text);
            Assert.AreEqual("MGL Advertising Agency GA", driver.FindElement(By.CssSelector(Company)).Text);

            DateTime dt = DateTime.ParseExact(driver.FindElement(By.CssSelector(StartDate)).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.AreEqual(today, dt.ToString("dd-MM-yyyy"));

            //Assert.AreEqual(today, Convert.ToDateTime(driver.FindElement(By.CssSelector(StartDate)).Text).ToString("MM-dd-yyyy"));
            DateTime enddt = DateTime.ParseExact(driver.FindElement(By.CssSelector(EndDate)).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.AreEqual(tommorowsDate, enddt.ToString("dd-MM-yyyy"));
            //Assert.AreEqual(tommorowsDate, Convert.ToDateTime(driver.FindElement(By.CssSelector(EndDate)).Text).ToString("MM-dd-yyyy"));
        }

        public void enterDetailsforOwnerRelationship()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(btnOwnerContactNameEllipsis).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(btnSelectContact).Click();

            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            SelectElement roleSelected = new SelectElement(driver.FindElement(ddRole));
            roleSelected.SelectByText("Brand Manager");

            driver.FindElement(btnOwnerLinkedCompanyNameEllipsis).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(txtCompanyName).SendKeys("MGL Advertising Agency");

            driver.FindElement(btnSearch).Click();

            driver.FindElement(btnSelectCompany).Click();

            uf.IsPageLoaded(driver);
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(btnOwnerLinkedContactNameEllipsis).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByName(driver, wait, "radOpenModalCallerCtl");
            uf.switchToFrameByElement(driver, wait, "ifrContent");

            driver.FindElement(btnSelectContact).Click();

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            wait.Until(ExpectedConditions.ElementExists(ddAccountStatus));
            wait.Until(ExpectedConditions.ElementIsVisible(ddAccountStatus));

            SelectElement accountStatusSelected = new SelectElement(driver.FindElement(ddAccountStatus));
            accountStatusSelected.SelectByValue("OPEN");

            driver.FindElement(tbStartDate).SendKeys(today);
            driver.FindElement(tbEndDate).SendKeys(tommorowsDate);
        }

        public void verifyCreatedOwnerRelationship(string CompanyOrContact)
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            wait.Until(ExpectedConditions.ElementIsVisible(rowsRelationship));

            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();

            string rrc = rowRelationshipCount.ToString();

            //if (CompanyOrContact == "Company")
            rrc = "1";

            string Role = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(4) > nobr";
            string OwnerName = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(5) > nobr > a";
            string Company = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(6) > nobr> a";
            string LinkedName = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(7) > nobr > a";
            string StartDate = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(19) > nobr";
            string EndDate = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + rrc + ") > td:nth-child(20) > nobr";



            Assert.AreEqual("Brand Manager", driver.FindElement(By.CssSelector(Role)).Text);

            if (CompanyOrContact == "Contact")
                Assert.AreEqual("Mr Peter Pendlebury", driver.FindElement(By.CssSelector(OwnerName)).Text);
            else
                Assert.AreEqual("Mr Michael Peter", driver.FindElement(By.CssSelector(OwnerName)).Text);

            //Assert.AreEqual("Mr Peter Pendlebury", driver.FindElement(By.CssSelector(OwnerName)).Text);
            Assert.AreEqual("MGL Advertising Agency GA", driver.FindElement(By.CssSelector(Company)).Text);

            //if (CompanyOrContact == "Contact")
            //    Assert.AreEqual("Pamela Reynolds Mr Peter Pendlebury", driver.FindElement(By.CssSelector(LinkedName)).Text);
            //else
            //    Assert.AreEqual("Pamela Reynolds", driver.FindElement(By.CssSelector(LinkedName)).Text);

            Assert.AreEqual("Pamela Reynolds", driver.FindElement(By.CssSelector(LinkedName)).Text);

            //Assert.AreEqual(today, Convert.ToDateTime(driver.FindElement(By.CssSelector(StartDate)).Text).ToString("dd-MM-yyyy"));
            DateTime dt = DateTime.ParseExact(driver.FindElement(By.CssSelector(StartDate)).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.AreEqual(today, dt.ToString("dd-MM-yyyy"));

            //Assert.AreEqual(tommorowsDate, Convert.ToDateTime(driver.FindElement(By.CssSelector(EndDate)).Text).ToString("dd-MM-yyyy"));
            DateTime enddt = DateTime.ParseExact(driver.FindElement(By.CssSelector(EndDate)).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Assert.AreEqual(tommorowsDate, enddt.ToString("dd-MM-yyyy"));
        }

        public void verifyingCurrentRadioButtonFunctionalitySalesAssignments()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
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

        public void verifyingCurrentAndFutureRadioButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();
            string dtStartDate = "";
            string dtSentDate = "";

            for (int i = 1; i < rowRelationshipCount + 1; i++)
            {
                string startDate = "table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + i + ") > td:nth-child(19)";
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

        public void clickAllRadioButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            driver.FindElement(rbAll).Click();
        }

        public void verifyingAllRadioButtonFunctionality()
        {
            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();
            string dtStartDate = "";
            for (int i = 1; i < rowRelationshipCount + 1; i++)
            {

                string startDate = " table#G_FFRelationshipListxgrdCompanyRelationships > tbody > tr:nth-child(" + i + ") > td:nth-child(19)";
                dtStartDate = DateTime.Parse(driver.FindElement(By.CssSelector(startDate)).GetAttribute("uv")).ToString("dd-MM-yyyy");

                if (dtStartDate == null)
                {
                    Assert.Fail("Fetched Data is wrong");
                }

            }
        }

        public void clickViewThisRelationshipButton()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            int rowRelationshipCount = driver.FindElements(rowsRelationship).Count();
            driver.FindElements(btnEditRelationship)[rowRelationshipCount - 1].Click();
        }

        public void editAssignment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            int assignmentRows = driver.FindElements(rowsAssignments).Count();
            driver.FindElements(btnEditAssignment)[assignmentRows - 1].Click();
        }

        public void verifyEditRelationButtonFunctionality()
        {
            driver.SwitchTo().DefaultContent();

            uf.switchToFrameByElement(driver, wait, "RightPane");

            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            Assert.AreEqual(true, driver.FindElement(rbOwner).Displayed);
            Assert.AreEqual(true, driver.FindElement(rbLinked).Displayed);

            Assert.AreEqual(false, uf.isClickable(driver.FindElement(btnOwnerCompanyNameEllipsis), driver));
            Assert.AreEqual(true, driver.FindElement(btnOwnerContactNameEllipsis).Displayed);

            Assert.AreEqual(true, driver.FindElement(ddRole).Displayed);

            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedCompanyNameEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedCompanyNameByHierarchyEllipsis).Displayed);
            Assert.AreEqual(true, driver.FindElement(btnOwnerLinkedContactNameEllipsis).Displayed);


            Assert.AreEqual(true, driver.FindElement(ddBrand).Displayed);
            Assert.AreEqual(true, driver.FindElement(ddAccountStatus).Displayed);

            Assert.AreEqual(true, driver.FindElement(tbStartDate).Displayed);
            Assert.AreEqual(true, driver.FindElement(tbEndDate).Displayed);

            Assert.AreEqual(true, driver.FindElement(tabSalesAssignment).Displayed);

        }

        public void selectSalesAssignment()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            driver.FindElement(salesAssignmentRow).Click();
        }

        public void deleteSalesAssignment()
        {
            noOfAssignmentsCount = driver.FindElements(rowsAssignments).Count();
            Thread.Sleep(2000);
            driver.FindElement(btnDeleteAssignment).Click();
        }

        public void verifyAssignmentIsDeleted()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            uf.IsPageLoaded(driver);
            Assert.AreEqual(noOfAssignmentsCount - 1, driver.FindElements(rowsAssignments).Count());
        }

        public void navigateToRelationshipTab()
        {
            uf.IsPageLoaded(driver);
            log.Info("Navigate to Relationship");
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");

            driver.FindElement(tabRelationships).Click();
        }

        public void navigateToSalesAssignment()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            driver.FindElement(tabSalesAssignment).Click();
        }

        public void verifySalesAssignmentDetails()
        {

            driver.SwitchTo().Window(driver.WindowHandles.First());
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual("Sector Manager", driver.FindElement(gridRole).Text);
            Assert.AreEqual("Home & Gardens Show", driver.FindElement(gridMediaGroup).Text);
            Assert.AreEqual("80 - TESTUSER2 (100%)", driver.FindElement(gridAssigned).Text);
        }


        #endregion Functions
    }
}

