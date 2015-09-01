using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace SeleniumLoginTest_Demo
{
    [TestFixture]
    public class LoginPageTests
    {
        [Test]
        public void LoginWithValidCredentials()
        {

            var driver = WebDriverManager.InitializeDriver();

            WebDriverManager.NavigateToURL(driver, "http://test.peddle.com/login");
            
            Assert.IsTrue(LoginPage.Login(driver,"gunjan.ranparia@marutitech.com","123456"));

            WebDriverManager.QuitDriver(driver);
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            var driver = WebDriverManager.InitializeDriver();

            WebDriverManager.NavigateToURL(driver, "http://test.peddle.com/login");

            Assert.IsFalse(LoginPage.Login(driver, "gunjan.ranparia@marutitech.com", "12345"));

            WebDriverManager.QuitDriver(driver);
        }
    }
}
