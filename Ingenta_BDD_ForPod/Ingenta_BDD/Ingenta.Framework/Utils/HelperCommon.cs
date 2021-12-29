using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenta.Framework.Helper
{
    public class HelperCommon
    {
        // This function returns screen height 
        public static int GetScreenHeight(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return Int32.Parse(js.ExecuteScript("return screen.height").ToString());
        }

        // This function returns screen width 
        public static int GetScreenWidth(IWebDriver driver)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            return Int32.Parse(js.ExecuteScript("return screen.width").ToString());
        }

        public static void SetWindowPosition(IWebDriver driver, int xCordinate, int yCordinate)
        {
            driver.Manage().Window.Position = new System.Drawing.Point(xCordinate, yCordinate);
        }

        public static void SetWindowSize(IWebDriver driver, int width, int height)
        {
            driver.Manage().Window.Size = new Size(width, height);
        }

       
    }
}
