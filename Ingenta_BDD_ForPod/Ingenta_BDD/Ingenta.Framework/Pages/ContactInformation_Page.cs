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
    public class ContactInformation_Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public ContactInformation_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        #region Object Repository

        By tabContacts = By.Id("iglbarMenu_0_Item_3");

        By btnNew = By.Id("FFCompanyContact_ibtnAddContact");
        By btnActive = By.Id("btnPersonStatus");
        By btnCompany = By.Id("btnCompany");
        By txtName = By.Id("ucContactDetail_txtName");
        By pageHeading = By.Id("lblPageHeading");
        By buttonStationery = By.Id("btnStationery");

        By txtTitle = By.Id("ucContactDetail_txtHonorific");
        By txtInitials = By.Id("ucContactDetail_txtInitials");

        By txtFirstName = By.Id("ucContactDetail_txtFirstName");
        By txtLastName = By.Id("ucContactDetail_txtLastName");

        By txtTel = By.Id("ucContactDetail_txtTelephone");
        By chkTelPrivacy = By.Id("ucContactDetail_chkPrvTel");

        By txtFax = By.Id("ucContactDetail_txtFax");
        By chkFaxPrivacy = By.Id("ucContactDetail_chkPrvFax");

        By txtEmail = By.Id("ucContactDetail_txtEmail");
        By chkEmailReadReceipt = By.Id("ucContactDetail_chkReadReceipt");
        By chkEmailPrivacy = By.Id("ucContactDetail_chkPrvEml");

        By txtMobile = By.Id("ucContactDetail_txtMobile");
        By chkMobPrivacy = By.Id("ucContactDetail_chkPrvMob");

        By txtFacebook = By.Id("ucContactDetail_txtFaceBookURL");
        By txtTwitter = By.Id("ucContactDetail_txtTwitterURL");

        By txtLinkedIn = By.Id("ucContactDetail_txtLinkedInURL");
        By txtBlog = By.Id("ucContactDetail_txtBLOGURL");
        By ddFunction = By.Id("ucContactDetail_ddlJobFunction");
        By txtPosition = By.Id("ucContactDetail_txtJobTitle");


        By ddStatus = By.Id("ucContactDetail_ddlPersonStatus");
        By txtCompany = By.Id("ucContactDetail_txtCompanyName");
        By txtAddress = By.Id("ucContactDetail_txtAddress");
        By txtPostCode = By.Id("ucContactDetail_txtPostcode");
        By chkPostCodePrivacy = By.Id("ucContactDetail_chkIsPrivate");

        By tabInformation = By.Id("iglbarMenu_0_Item_0");
        By contactName = By.CssSelector("table#FFCompanyContact_grdCompanyContacts_ctl00 > tbody > tr > td:nth-child(6)");
        By tblCompanyContacts = By.Id("FFCompanyContact_grdCompanyContacts_ctl00");

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



        #endregion


        #region Functions
        public void verifyContactTabDetails()
        {

            log.Info("Verifying Contacts Tab Details");

            driver.SwitchTo().DefaultContent();
            uf.switchToFrameByElement(driver, wait, "RightPane");
            uf.switchToFrameByElement(driver, wait, "ifrDetail");
            wait.Until(ExpectedConditions.ElementIsVisible(ingentaCompanyInformationNameTextBox));


            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationNameTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationMarketNameTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationAliasTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationAddress1TextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationAddress2TextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationAddress3TextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationAddress4TextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationCityTextBox).Displayed);
            //Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationRegionTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationPostalCodeTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationCountryDropDown).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationCountryPrivacyCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationLanguageDropDown).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationInterCompanyCodeTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationInterTelephoneTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationTelephonePrivacyCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationMobileTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationMobilePrivacyCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationFaxTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationFaxPrivacyCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationEmailTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationEmailReadReceiptCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationEmailPrivacyCheckBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationWebsiteTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationFacebookTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationTwitterTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationLinkedInTextBox).Displayed);
            Assert.AreEqual(true, driver.FindElement(ingentaCompanyInformationBlogTextBox).Displayed);
        }

        #endregion Functions

    }
}
