using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "user_login")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "user_pass")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.Id, Using = "wp-submit")]
        private IWebElement logInButton;

        public void Goto()
        {
            Pages.TopNavigation.Login();
        }

        public void InputYourEmail(string email)
        {
            emailAddressTextField.SendKeys(email);
        }

        public void InputYourPassword(string password)
        {
            passwordTextField.SendKeys(password);
        }

        public void Login()
        {
            logInButton.Click();
        }
    }
}
