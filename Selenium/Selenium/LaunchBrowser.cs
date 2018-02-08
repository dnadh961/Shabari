using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class LaunchBrowser
    {
        private static String browser = "chrome";
        private static IWebDriver driver;

        public static void Main(string[] args)
        {
            initializeDriver(browser);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("Shabari");
            driver.FindElement(By.Name("pass")).SendKeys("MyPassword");
            driver.FindElement(By.XPath("//input[@data-testid='royal_login_button']")).Click();
            driver.Close();
            driver.Quit();
            Console.Write("completed");
        }

        private static void initializeDriver(String browser)
        {
            if ("firefox".Equals(browser))
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\driver");
                driver = new FirefoxDriver(service);
            }
            else if ("chrome".Equals(browser))
            {
                driver = new ChromeDriver(@"C:\driver");
            }
        }
    }
}
