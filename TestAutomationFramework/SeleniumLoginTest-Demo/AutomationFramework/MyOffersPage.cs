using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public class MyOffersPage
    {

        public static string Url = "http://test.peddle.com/my-offers";

        public static void WaitUntilPageIsLoaded(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(driver1 => driver.Url.Equals(Url));
        }

        

    }
}
