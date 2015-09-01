using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public class LoginPage
    {

        //Properties of Login page

        public static string Loginerror = "loginErrorMsg";
        public static string Usernamefield = "loginEmailInput";
        public static string Passwordfield = "loginPasswordInput";
        public static string Loginbutton = "loginBtn";
        public static string ForgetPasswordLink = "Forgot your password?";
        public static string Url = "https://test.peddle.com/login";

        public static void Login(IWebDriver driver,string username, string password)
        {
            WebDriverManager.GetElementById(driver,Usernamefield).SendKeys(username);
            WebDriverManager.GetElementById(driver, Passwordfield).SendKeys(password);
            WebDriverManager.GetElementById(driver, Loginbutton).Click();
            WebDriverManager.WaitUntilNextPageIsLoaded(driver,Url);
        }

        public static void ClickOnForgorPassword(IWebDriver driver)
        {
            driver.FindElement(By.LinkText(ForgetPasswordLink)).Click();
        }

    }
}
