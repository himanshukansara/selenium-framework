using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomationFramework.SellerSitePages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace AutomationFramework.Tests
{
    [TestFixture]
    class ForgotPasswordPageTests
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverManager.InitializeDriver();
            WebDriverManager.NavigateToPage(driver, ForgotPasswordPage.Url);
        }

        [Test]
        public void EnterValidEmailAddress()
        {
            ForgotPasswordPage.EnterEmailAndSubmit(driver, TestDataReader.GetLoginCredentials("ValidCredentials").ElementAt(0));
            WebDriverManager.WaitForElementById(driver,ForgotPasswordPage.ForgetPasswordsuccesselement);
            Assert.IsTrue(WebDriverManager.GetElementById(driver,ForgotPasswordPage.ForgetPasswordsuccesselement).Displayed);
       }
        [Test]
        public void EnterInvalidEmailAddress()
        {
            ForgotPasswordPage.EnterEmailAndSubmit(driver, TestDataReader.GetLoginCredentials("InvalidCredentials2").ElementAt(0));
            WebDriverManager.WaitForElementById(driver, ForgotPasswordPage.ForgetPassworderror);
            Assert.IsTrue(WebDriverManager.GetElementById(driver, ForgotPasswordPage.ForgetPassworderror).Displayed);
        }
        [Test]
        public void ReturnToLoginPage()
        {
            ForgotPasswordPage.ClickOnReturnToLogin(driver);
            Assert.IsTrue(WebDriverManager.CurrentUrl(driver).Equals(LoginPage.Url));
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.QuitDriver(driver);
        }
    }
}
