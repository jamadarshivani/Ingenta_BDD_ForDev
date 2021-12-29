using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Ingenta.Framework.Utils;
using Ingenta.Framework.Helper;
using NUnit.Framework;
using Microsoft.Expression.Encoder.ScreenCapture;
using Utility_Classes;
using System.Threading;

namespace Ingenta.Test.Utils
{
    [Binding]
    public class Start : Driver
    {
        Objects ob = null;
        Utility_Functions uf = new Utility_Functions();
        ScreenCaptureJob job = new ScreenCaptureJob();

        [BeforeScenario]
        public void setUp()
        {
            uf.CreateOrReplaceVideoFolder();

            // Initiating Logger
            HelperLog.SetLogger();

            // Initiating Browser
            StepDefinationInitialise();

            // Initializing all the Page Objects
            ob = new Objects(browser.driver,browser.iWait);           
            ob.ObjectInitialisation();

            // Start video capture
            job = new ScreenCaptureJob();
            string testname = NUnit.Framework.TestContext.CurrentContext.Test.FullName;
            uf.ScreenCap(job, testname, browser.driver);


            // Navigating to URL
            string appURL = ConfigurationManager.AppSettings["ApplicationURL"];
            //string appURL = "https://iaautodev.addepotcloud.com";
            //string username = "david";
            //string password = "tyer";

            string username = ConfigurationManager.AppSettings["ApplicationUsername"];
            string password = ConfigurationManager.AppSettings["ApplicationPassword"];
            
            Driver.Navigate(appURL);

            Objects.poLogin.ingentaLogin(username,password);
            
        }


        [AfterScenario]
        public void TearDown()
        {
            this.job.Stop();
            uf.TakeScreenshot(browser.driver, "ie", NUnit.Framework.TestContext.CurrentContext.Test.FullName.ToString());
            Thread.Sleep(4000);
            Close();
        }
                       
    }
}

