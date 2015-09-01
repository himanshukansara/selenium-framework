using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.SellerSitePages
{
    public class ForgotPasswordPage
    {
        //Properties of Forget Password Page
        public static string Emailfield = "fpEmailInput";
        public static string Submitbutton = "resetBtn";
        public static string Returntologin = "Return to Log in";
        public static string ForgetPassworderror = "forgotPasswordErrorMsg";
        public static string ForgetPasswordsuccesselement = "infoPopUp";
        public static string SuccessText = "Check your inbox for password reset instructions.";
        public static string Url = "https://test.peddle.com/forgot-password";

        
        public static void EnterEmailAndSubmit(IWebDriver driver,string email)
        {
            driver.FindElement(By.Id(Emailfield)).SendKeys(email);
            driver.FindElement(By.Id(Submitbutton)).Click();
        }

        public static void ClickOnReturnToLogin(IWebDriver driver)
        {
            WebDriverManager.WaitForElementByLinkText(driver, Returntologin);
            WebDriverManager.WaitUntilNextPageIsLoaded(driver,Url);
        }



    }

}
