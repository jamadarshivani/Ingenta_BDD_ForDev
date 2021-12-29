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
   public class SelectedContact_Page
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        IWebDriver driver = null;
        WebDriverWait wait = null;
        Utility_Functions uf = new Utility_Functions();

        public SelectedContact_Page(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;

        }

        #region Object Repository

        By btnInformation = By.Id("iglbarMenu_0_Item_0");

        By btnHistory = By.Id("iglbarMenu_0_Item_1");

        By btnResponsiblities = By.Id("iglbarMenu_0_Item_2");

        By btnRelationships = By.Id("iglbarMenu_0_Item_3");

        By btnNotes = By.Id("iglbarMenu_0_Item_4");

        By btnAttachements = By.Id("iglbarMenu_0_Item_5");

        By btnWebUser = By.Id("iglbarMenu_0_Item_6");

        By btnCampaign = By.Id("iglbarMenu_0_Item_7");

        By btnExternalRef = By.Id("iglbarMenu_0_Item_8");

        By btnDocuments = By.Id("iglbarMenu_0_Item_9");

        By btnContactInformation = By.Id("iglbarMenu_1_Item_0");

        By btnMailing = By.Id("iglbarMenu_1_Item_1");

        By btnMarketing = By.Id("iglbarMenu_1_Item_2");

        By btnElectronicsClassification = By.Id("iglbarMenu_1_Item_3");

        By btnCompanyInfo = By.Id("iglbarMenu_0_Item_4");

        By btnSave = By.Id("btnSave");

        By btnSaveAndClose = By.Id("btnSaveClose");

        By btnClose = By.Id("btnClose");

        # endregion Object Repository

        #region Functions



        #endregion Functions

    }
}
