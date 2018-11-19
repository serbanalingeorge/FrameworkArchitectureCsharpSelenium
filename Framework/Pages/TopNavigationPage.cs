using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.Id, Using = "menu-item-1296")]
        private IWebElement contactUs;

        [FindsBy(How = How.Id, Using = "menu-item-263")]
        private IWebElement register;

        [FindsBy(How = How.Id, Using = "menu-item-117")]
        private IWebElement login;

        public void ContactUs()
        {
            contactUs.Click();
        }

        public void Register()
        {
            register.Click();
        }

        public void Login()
        {
            login.Click();
        }

    }
}
