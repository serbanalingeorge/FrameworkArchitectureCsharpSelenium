using System;
using Framework;
using Framework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

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
            Pages.ContactUs.ClickSubmit();
            Pages.ContactUs.ValidateMessage();
        }

    }
}
