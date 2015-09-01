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

        //List of all web UI elements within the Login page with Ids

        public static string Loginerror = "loginErrorMsg";
        public static string Usernamefield = "loginEmailInput";
        public static string Passwordfield = "loginPasswordInput";
        public static string Loginbutton = "loginBtn";

        //Login page URL

        public static string Url = "http://test.peddle.com/login";

        public static void Login(IWebDriver driver,string username, string password)
        {
            GetUserNameInputElement(driver).SendKeys(username);
            GetPasswordInputElement(driver).SendKeys(password);
            GetLoginButtonElement(driver).Click();
        }

        public static IWebElement GetUserNameInputElement(IWebDriver driver)
        {
            return driver.FindElement(By.Id(Usernamefield));
        }

        public static IWebElement GetPasswordInputElement(IWebDriver driver)
        {
            return driver.FindElement(By.Id(Passwordfield));
        }

        public static IWebElement GetLoginButtonElement(IWebDriver driver)
        {
            return driver.FindElement(By.Id(Loginbutton));
        }

        public static IWebElement GetLoginErrorElement(IWebDriver driver)
        {
            return driver.FindElement(By.Id(Loginerror));
        }

        public static void WaitUntilPageIsLoaded(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(driver1 => driver.Url.Equals(Url));
        }

     }
}
