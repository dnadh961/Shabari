using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class WaitUtil
    {
        private static int MAX_TIMEOUT = 120;

        public static void waitForElementPresent(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MAX_TIMEOUT));
            wait.Until(ExpectedConditions.ElementExists(by));
        }

        public static void waitForElementVisibility(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MAX_TIMEOUT));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static void waitForElementClickable(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MAX_TIMEOUT));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public static void waitForElementNotPresent(IWebDriver driver, By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(MAX_TIMEOUT));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

    }
}
