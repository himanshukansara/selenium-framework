using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.SellerSitePages
{
    public class CreateAccountPage
    {
        //Properties of Create Account Page
        public static string Url = "https://test.peddle.com/create-account";
        public static string Firstnamefield = "createAccountFirstNameInput";
        public static string Lastnamefield = "createAccountLastNameInput";
        public static string Emailfield = "createAccountEmailInput";
        public static string Passwordfield = "createAccountPasswordInput";
        public static string Createaccountbutton = "createAccountBtn";
        public static string GoogleSignOnButton = "googleSignOnButtonId";
        public static string FacebookSignOnButton = "facebookSignOnButtonId";
        public static string Returntologinlink = "Already have an account?";
        public static string CreateAccountErrorMessage = "createAccountErrorMsg";

        public static void ClickOnAlreadyHaveAccountLink(IWebDriver driver)
        {
            WebDriverManager.GetElementByLinkText(driver,Returntologinlink).Click();
            WebDriverManager.WaitUntilNextPageIsLoaded(driver,Url);
        }

        public static string GetRandomEmail(string type)
        {
            string firstpart = "";
            string secondpart = "";
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for(var i=0; i<4;i++)
            {
                firstpart = firstpart + chars[rnd.Next(chars.Length)];
                secondpart = secondpart + chars[rnd.Next(chars.Length)];
            }

            string email = firstpart + "@" + secondpart + ".com";
            if (type == "Invalid")
            {
                return firstpart + secondpart + ".com";
            }
            else if (type == "Valid")
            {

                return email.ToLower();
            }
            return email.ToLower();
        }
        public static string GetRandomPassword(int size)
        {
            char[] password = new char[size];
            Random rnd = new Random();
            string chars = "AB@DEF!HI2KLM3OPQ8STU(WXYZ";

            for (var i = 0; i < password.Length; i++)
            {
                password[i] = chars[rnd.Next(chars.Length)];
            }

           return new string(password);
        }

        public static void CreateAccount(IWebDriver driver,string email, string password)
        {
            WebDriverManager.GetElementById(driver,Firstnamefield).SendKeys("Test");
            WebDriverManager.GetElementById(driver,Lastnamefield).SendKeys("Test");
            WebDriverManager.GetElementById(driver,Emailfield).SendKeys(email);
            WebDriverManager.GetElementById(driver,Passwordfield).SendKeys(password);
            WebDriverManager.GetElementById(driver, Createaccountbutton).Click();
            WebDriverManager.WaitUntilNextPageIsLoaded(driver,Url);

        }
        
    }
}
