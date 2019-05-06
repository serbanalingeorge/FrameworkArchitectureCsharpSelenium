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

            Pages.ContactUs.SendYourName("name");
            Pages.ContactUs.SendYourEmail("email");
            Pages.ContactUs.SendYourSubject("subject");
            Pages.ContactUs.SendYourMessage("message");
            Thread.Sleep(5000);
            Pages.ContactUs.ClickSubmit();
            Pages.ContactUs.ValidateMessage();
        }

    }
    
    
}
