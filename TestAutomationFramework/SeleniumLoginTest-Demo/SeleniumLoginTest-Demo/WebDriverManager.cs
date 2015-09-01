using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumLoginTest_Demo
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

       public static void NavigateToURL(IWebDriver driver,string URL)
       {
           driver.Navigate().GoToUrl(URL);
       }

    }
}
