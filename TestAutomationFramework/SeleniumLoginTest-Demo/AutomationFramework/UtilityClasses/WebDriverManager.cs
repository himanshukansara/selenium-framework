using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
   public class WebDriverManager
   {
      public static IWebDriver InitializeDriver()
       {
         return new FirefoxDriver();
       }
      
       public static void QuitDriver(IWebDriver driver)
       {
           driver.Quit();
       }

       public static void NavigateToPage(IWebDriver driver,string URL)
       {
           driver.Navigate().GoToUrl(URL);
           WaitUntilPageIsLoaded(driver,URL);
       }

       public static void SetDriverTimeout(IWebDriver driver,int sec)
       {
           driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(sec));
       }

       public static bool IsElementPresent(IWebDriver driver, string elementid)
       {
            return  driver.FindElement(By.Id(elementid)).Displayed;
       }
       public static IWebElement GetElementById(IWebDriver driver, string elementid)
       {
           return driver.FindElement(By.Id(elementid));
       }
       public static IWebElement GetElementByLinkText(IWebDriver driver, string elementid)
       {
           return driver.FindElement(By.LinkText(elementid));
       }
      public static void WaitForElementById(IWebDriver driver,string id)
       {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
               wait.Until(ExpectedConditions.ElementIsVisible(By.Id(id)));
       }

       public static void WaitForElementByLinkText(IWebDriver driver, string id)
       {
           
               WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
               wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(id)));
           
       }

       public static void WaitUntilPageIsLoaded(IWebDriver driver,string Url)
       {
           WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
           wait.Until(driver1 => driver.Url.Equals(Url));
       }

       public static string CurrentUrl(IWebDriver driver)
       {
           return driver.Url;
       }

       public static void WaitUntilNextPageIsLoaded(IWebDriver driver,string currentUrl)
       {
           new WebDriverWait(driver, new TimeSpan(0, 0, 20))
               .Until(driver1 => !(driver1.Url.Equals(currentUrl)));

       }


   }
   }

