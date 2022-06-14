using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System.Threading.Tasks;
using SamiiProjectOptimal.PageObjects;
using System.Threading;
using SamiiProjectOptimal.Additional;

namespace SamiiProjectOptimal.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteStudentTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]
        public void LogInAsStudent()
        {
            Pages.LogIn
                .EnterEmailPassword();
            Pages.LogIn
                .ClickButtonSignIn();
            Thread.Sleep(5000);
        }
    }
}
