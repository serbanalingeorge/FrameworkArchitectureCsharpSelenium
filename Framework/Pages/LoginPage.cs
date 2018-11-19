using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LoginPage
    {
        const string _username = "serbanalingeorge";
        const string _email = "serbanalingeorge@yahoo.com";
        const string _password = "Test1234!";
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginform\"]/p[1]/label")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"user_pass\"]")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"wp-submit\"]")]
        private IWebElement logInButton;

        [FindsBy(How = How.ClassName, Using = "forgetmenot")]
        private IWebElement rememberMe;

        public void Goto()
        {
            Pages.TopNavigation.Login();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Username or Email");
        }
        
        public void InputYourEmail(string email)
        {
            emailAddressTextField.Click();
            emailAddressTextField.SendKeys(email);
        }

        public void InputYourPassword(string password)
        {
            passwordTextField.SendKeys(password);
        }

        public void ClickLogin()
        {
            logInButton.Click();
        }

        public void ClickRememberMe()
        {
            rememberMe.Click();
        }

    }
}
