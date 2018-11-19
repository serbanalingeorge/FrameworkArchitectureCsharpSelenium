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

        private static readonly IWebDriver _driver = new ChromeDriver();

        public static void Init()
        {
            Goto("");
        }

        public static string Title => _driver.Title;

        public static IWebDriver Driver => _driver;

        private static void Goto(string url)
        {
            _driver.Url = baseUrl + url;
        }


        public static void Close()
        {
            _driver.Quit();
        }
    }
}
