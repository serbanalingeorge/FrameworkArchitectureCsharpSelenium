using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public static class Pages
    {
        public static LoginPage LoginPage => GetPage<LoginPage>();
        
        public static ContactUs ContactUs => GetPage<ContactUs>();

        public static TopNavigationPage TopNavigation => GetPage<TopNavigationPage>();

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
    }

}
