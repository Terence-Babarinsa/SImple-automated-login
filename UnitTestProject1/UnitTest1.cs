using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        
        [TestMethod]
        public void Login()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

            IWebElement username =  driver.FindElement(By.Id("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement submit = driver.FindElement(By.Id("submit"));
            

            username.SendKeys("student");
            password.SendKeys("Password123");
            submit.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            IWebElement _login = driver.FindElement(By.XPath("//h1[normalize-space()='Logged In Successfully']"));
            Assert.AreEqual("Logged In Successfully", _login.Text.ToString());


        }
    }
}
