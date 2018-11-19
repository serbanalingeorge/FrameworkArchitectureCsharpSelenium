﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class ContactUs
    {
        [FindsBy(How = How.Name, Using = "your-name")]
        private IWebElement yourName;

        [FindsBy(How = How.Name, Using = "your-email")]
        private IWebElement yourEmail;

        [FindsBy(How = How.Name, Using = "your-subject")]
        private IWebElement yourSubject;

        [FindsBy(How = How.Name, Using = "your-message")]
        private IWebElement yourMessage;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement submit;

        [FindsBy(How = How.ClassName, Using = "wpcf7-response-output")]
        private IWebElement SuccMessage;

        [FindsBy(How = How.Id, Using = "menu-item-1296")]
        private IWebElement contactUs;

        public void Goto()
        {
            Pages.TopNavigation.ContactUs();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Contact");
        }

        public void SendYourName(string name)
        {
            yourName.SendKeys(name);
        }

        public void SendYourEmail(string email)
        {
            yourEmail.SendKeys(email);
        }

        public void SendYourSubject(string subject)
        {
            yourSubject.SendKeys(subject);
        }

        public void SendYourMessage(string message)
        {
            yourMessage.SendKeys(message);
        }

        public void ClickSubmit()
        {
            submit.Click();
        }

        public void ValidateMessage()
        {
            try
            {
                var text = SuccMessage.Text;
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}
