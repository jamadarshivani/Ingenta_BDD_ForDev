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
    public class CompanyNotes_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        string demoNote = "This is a demo note";
        string replyNote = "This is a reply note";

        public CompanyNotes_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Variables

        private static Random random = new Random();

        string notesRandomString = RandomString(20);
        public string notesStringToBeVerified;
        string today = DateTime.Today.ToString("dd-MM-yyyy");
        #endregion Variables


        #region Object Repository

        By btnNotes = By.Id("iglbarMenu_0_Item_6");
        By btnNotesFromContacts = By.Id("iglbarMenu_0_Item_5");
        By tabNotes = By.Id("iglbarMenu_0_Item_2");
        By txtNotes = By.Id("Notes_txtNote");
        By btnPostNote = By.Id("Notes_btnPost");
        By rowNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trNote");
        By btnReply = By.Id("Notes_btnReply");
        By msgBlankReply = By.Id("Notes_rfvNoteText");
        By tabReplyNote = By.Id("Notes_ucNoteList_rptMain_ctl00_trReply");
        By tbDateStartingFrom = By.Id("Notes_ucStartDate_ucDateChooser_iwdcDate_input");
        By btnDeleteNotes = By.Id("Notes_btnDelete");

        By btnExternalRef = By.Id("iglbarMenu_0_Item_7");

        By gridDate = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(2)");
        By gridName = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(3)");
        By gridPosts = By.CssSelector("table.FormPanel > tbody > tr.GridHeader > td:nth-child(4)");

        By gridCreatedPost = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(4)");
        By noteToBeSelected = By.CssSelector("div.NoteListContainer > table > tbody > tr:nth-child(2) > td");

        By tableNotes = By.ClassName("NoteListContainer");

        By tabNotesDate = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(2)");
        By tabUser = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(3)");
        By tabNoteCreated = By.CssSelector("tr#Notes_ucNoteList_rptMain_ctl00_trNote > td:nth-child(4)");

        #endregion Object Repository

        #region Functions

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void navigateToNotesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnNotes));
            driver.FindElement(btnNotes).Click();
        }

        public void navigateToNotesFromContacts()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementExists(btnNotesFromContacts));
            driver.FindElement(btnNotesFromContacts).Click();
        }

        public void navigateToNotesTabFromHistory()
        {
            wait.Until(ExpectedConditions.ElementExists(tabNotes));
            driver.FindElement(tabNotes).Click();
        }

        public void verifyNotesTab()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");

            Assert.AreEqual(true, driver.FindElement(btnPostNote).Displayed);
            Assert.AreEqual(false, driver.FindElement(btnReply).Enabled);
            Assert.AreEqual(false, driver.FindElement(btnDeleteNotes).Enabled);
            Assert.AreEqual(true, driver.FindElement(tbDateStartingFrom).Displayed);
            Assert.AreEqual("Date", driver.FindElement(gridDate).Text);
            Assert.AreEqual("Name", driver.FindElement(gridName).Text);
            Assert.AreEqual("Posts", driver.FindElement(gridPosts).Text);
        }

        public void enterNotes()
        {
            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            uf.switchToFrameByElement(driver, wait, "ifrPages");
            wait.Until(ExpectedConditions.ElementIsVisible(txtNotes));
            //notesStringToBeVerified = RandomString(20);
            driver.FindElement(txtNotes).SendKeys("This is a demo note");
        }

        public void clickPostButton()
        {
            driver.FindElement(btnPostNote).Click();
        }

        public void verifyCreatedNoteOnGrid()
        {
            Assert.AreEqual("This is a demo note", driver.FindElement(gridCreatedPost).Text);
        }

        public void selectNote()
        {
            driver.FindElement(noteToBeSelected).Click();
        }

        public void createReplyNote()
        {
            driver.FindElement(txtNotes).SendKeys(replyNote);
        }

        public void clickReplyButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnReply));
            driver.FindElement(btnReply).Click();
        }

        public void verifyReplyNoteIsCreated()
        {
            Assert.AreEqual(true, driver.FindElement(tabReplyNote).Displayed);
        }

        public void verifyBlankMessageError()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(msgBlankReply));
            Assert.AreEqual("Please enter note text", driver.FindElement(msgBlankReply).Text);
        }

        public void clickDeleteButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(btnDeleteNotes));
            driver.FindElement(btnDeleteNotes).Click();
        }

        public void verifynoteIsDeleted()
        {
            Assert.AreEqual(false, uf.IsElementPresent(driver, noteToBeSelected, 60));
        }

        public void verifyCreatedNoteDetails()
        {
            wait.Until(ExpectedConditions.ElementExists(tableNotes));

            //string notesDate = DateTime.Today.ToString("dd-MM-yyyy");

            DateTime dt = DateTime.ParseExact(driver.FindElement(tabNotesDate).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);           
            Assert.AreEqual(today, dt.ToString("dd-MM-yyyy"));

            Assert.AreEqual("DAVID", driver.FindElement(tabUser).Text);
            Assert.AreEqual("This is a demo note", driver.FindElement(tabNoteCreated).Text);
        }
        #endregion Functions
    }
}
