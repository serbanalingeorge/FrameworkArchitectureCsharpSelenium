using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Browser
    {
        private static string baseUrl = "https://blog.testproject.io/";

        private static IWebDriver _driver;

        public static string Title => _driver.Title;

        public static IWebDriver Driver => _driver;

        public static void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl(baseUrl);
           
        }


        public static void Close()
        {
            _driver.Quit();
        }
    }
}
