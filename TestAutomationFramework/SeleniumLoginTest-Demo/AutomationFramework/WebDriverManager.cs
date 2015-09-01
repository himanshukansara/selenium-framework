using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

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
       }

       public static void SetDriverTimeout(IWebDriver driver,int sec)
       {
           driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(sec));
       }

       public static bool FindElementById(IWebDriver driver, string elementid)
       {
            return  driver.FindElement(By.Id(elementid)).Displayed;
       }

    }
}
