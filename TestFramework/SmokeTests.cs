using System;
using System.Threading;
using Framework;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestFramework
{
    [TestFixture]
    public class SmokeTests : TestBase
    {
        [Test]
        public void ContactUsTestFlow()
        {
            Pages.ContactUs.Goto();

            NUnit.Framework.Assert.IsTrue(Pages.ContactUs.IsAt());

            Pages.ContactUs.SendYourName("George");
            Pages.ContactUs.SendYourEmail("serbanalingeorge@yahoo.com");
            Pages.ContactUs.SendYourSubject("Test");
            Pages.ContactUs.SendYourMessage("This is a test");
            Thread.Sleep(5000);
            Pages.ContactUs.ClickSubmit();
            Pages.ContactUs.ValidateMessage();
        }
    }
    
    
}
