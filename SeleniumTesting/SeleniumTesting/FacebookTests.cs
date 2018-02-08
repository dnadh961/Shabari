using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SeleniumTesting
{
    [TestClass]
    public class FacebookTests
    {
        IWebDriver driver;

        [TestMethod]
        public void testLogin()
        {
            initializeDriver("chrome");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("dnadh961@gmail.com");
            driver.FindElement(By.Name("pass")).SendKeys("dnadh961");
            driver.FindElement(By.XPath("//input[@data-testid='royal_login_button']")).Click();
            Assert.IsTrue(verifyElement(By.XPath("//div[text()='Welcome to Faceboo']")));
            driver.Close();
            driver.Quit();
        }

        private bool verifyElement(By by)
        {
            bool isPresent = true;
            try
            {
                driver.FindElement(by);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.StackTrace);
                isPresent = false;
            }
            return isPresent;
        }

        private void initializeDriver(String browser)
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
