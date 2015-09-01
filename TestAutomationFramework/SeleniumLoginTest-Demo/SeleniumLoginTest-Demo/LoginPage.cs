using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLoginTest_Demo
{
    class LoginPage
    {
        public static bool Login(IWebDriver driver,string username, string password)
        {
            IWebElement Uname = driver.FindElement(By.Id("loginEmailInput"));

            Uname.SendKeys(username);

            IWebElement Pwd = driver.FindElement(By.Id("loginPasswordInput"));
            Pwd.SendKeys(password);

            IWebElement btn = driver.FindElement((By.Id("loginBtn")));

            btn.Click();

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            return driver.PageSource.Contains("Gunjan");


        }
    }
}
