using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomationFramework.SellerSitePages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.Tests
{
    class CreateSellerAccountPageTests
    {
        public IWebDriver driver; 
       
        [SetUp]
        public void Setup()
        {
               driver = WebDriverManager.InitializeDriver();
               WebDriverManager.NavigateToPage(driver, CreateAccountPage.Url);
        }

        [Test] 
        public void CreateAccountWithValidCredentials() 
        {
           CreateAccountPage.CreateAccount(driver,CreateAccountPage.GetRandomEmail("Valid"),CreateAccountPage.GetRandomPassword(6));
           Assert.IsTrue(WebDriverManager.CurrentUrl(driver).Equals(SellCarPage.Url));
        }

        [Test]
        public void CreateAccountWithInValidCredentials()
        {
            CreateAccountPage.CreateAccount(driver, CreateAccountPage.GetRandomEmail("Invalid"), CreateAccountPage.GetRandomPassword(6));
            WebDriverManager.WaitForElementById(driver,CreateAccountPage.CreateAccountErrorMessage);
            Assert.IsTrue(WebDriverManager.IsElementPresent(driver, CreateAccountPage.CreateAccountErrorMessage));
        }

        [Test]
        public void ReturnToLoginPage()
        {
            CreateAccountPage.ClickOnAlreadyHaveAccountLink(driver);
            Assert.IsTrue(WebDriverManager.CurrentUrl(driver).Equals(LoginPage.Url));
        }

        [TearDown]
        public void TearDown()

        {
            WebDriverManager.QuitDriver(driver);
        }

    }
}
