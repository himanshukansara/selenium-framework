using System;
using System.Linq;
using AutomationFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using AutomationFramework;
using AutomationFramework.SellerSitePages;


namespace SeleniumAutomationTests   
{
    [TestFixture]
    public class LoginPageTests
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverManager.InitializeDriver();
            WebDriverManager.NavigateToPage(driver, LoginPage.Url);
        }

        [Test]
        public void LoginWithValidCredentials()
        {

            LoginPage.Login(driver, TestDataReader.GetLoginCredentials("ValidCredentials").ElementAt(0), TestDataReader.GetLoginCredentials("ValidCredentials").ElementAt(1));
            Assert.IsTrue(WebDriverManager.CurrentUrl(driver).Equals(MyOffersPage.Url));
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            LoginPage.Login(driver, TestDataReader.GetLoginCredentials("InvalidCredentials").ElementAt(0), TestDataReader.GetLoginCredentials("InvalidCredentials").ElementAt(1));
            WebDriverManager.WaitForElementById(driver,LoginPage.Loginerror);
            Assert.IsTrue(WebDriverManager.IsElementPresent(driver,LoginPage.Loginerror));
        }
        [Test]
        public void ClickOnForgotPasswordLink()
        {
            LoginPage.ClickOnForgorPassword(driver);
            Assert.IsTrue(WebDriverManager.CurrentUrl(driver).Equals(ForgotPasswordPage.Url));
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriver(driver);
        }

        
    }
}
