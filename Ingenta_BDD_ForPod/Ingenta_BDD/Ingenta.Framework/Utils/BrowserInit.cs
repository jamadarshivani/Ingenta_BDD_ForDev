using Ingenta.Framework.Browser;
using Ingenta.Framework.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenta.Framework.Utils
{
    public class BrowserInit
    {
        public IWebDriver driver;
        internal string driverName = string.Empty;
        internal string driverPath = string.Empty;
        public WebDriverWait iWait = null;

        Browsers browser = new Browsers();

        int screenHeight, screenWidth;


        public BrowserInit()
        {
            try
            {
                if (Convert.ToBoolean(browser.SelectBrowser("chrome", "Browser.xml")) == true)
                {
                    string startPath = Environment.CurrentDirectory;

                    string frameWorkPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(startPath)));

                    //  driverPath = Path.Combine(frameWorkPath + "\\Ingenta.Framework\\bin\\Debug");
                    driverPath = @"C:\Project\Ingenta\Drivers\";
                    driverName = "webdriver.chrome.driver";

                    driver = new ChromeDriver(driverPath);
                    // Event firing
                    EventFire ef = new EventFire(driver);
                    driver = ef;

                    iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    screenHeight = HelperCommon.GetScreenHeight(driver);

                    screenWidth = HelperCommon.GetScreenWidth(driver);

                    HelperCommon.SetWindowPosition(driver, 0, 0);

                    HelperCommon.SetWindowSize(driver, screenWidth, screenHeight);
                }
                else if (Convert.ToBoolean(browser.SelectBrowser("firefox", "Browser.xml")) == true)
                {
                    string startPath = Environment.CurrentDirectory;

                    // string driverPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(startPath)));
                    driverPath = @"C:\Project\Ingenta\Drivers\";
                    driver = new FirefoxDriver(driverPath);

                    iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    screenHeight = HelperCommon.GetScreenHeight(driver);

                    screenWidth = HelperCommon.GetScreenWidth(driver);

                    HelperCommon.SetWindowPosition(driver, 0, 0);

                    HelperCommon.SetWindowSize(driver, screenWidth, screenHeight);
                }

                else if (Convert.ToBoolean(browser.SelectBrowser("ie", "Browser.xml")) == true)
                {
                    InternetExplorerOptions options = new InternetExplorerOptions();
                    options.EnsureCleanSession = true;
                    options.EnableNativeEvents = true;
                    options.IgnoreZoomLevel = true;
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;


                    driverName = "webdriver.ie.driver";

                    string rootPath = Environment.CurrentDirectory;

                    string startPath = Environment.CurrentDirectory;

                    string frameWorkPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(startPath)));

                    // driverPath = Path.Combine(frameWorkPath + "\\Ingenta.Framework\\bin\\Debug\\Driver\\");
                    driverPath = @"C:\Project\Ingenta\Drivers\";
                    driver = new InternetExplorerDriver(driverPath, options);

                    // Event firing
                    EventFire ef = new EventFire(driver);
                    driver = ef;

                    iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    screenHeight = HelperCommon.GetScreenHeight(driver);

                    screenWidth = HelperCommon.GetScreenWidth(driver);

                    HelperCommon.SetWindowPosition(driver, 0, 0);

                    HelperCommon.SetWindowSize(driver, screenWidth, screenHeight);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Browser has not been initialised: " + e.Message + e.StackTrace);
            }
        }
    }
}
