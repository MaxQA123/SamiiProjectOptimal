using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteAdminTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]

        public void LogInAsAdmin()
        {
            Pages.LogInAdmin
                .EnterEmailPassword();
            Pages.LogInAdmin
                .ClickButtonSignIn();
            Thread.Sleep(10000);
        }
    }
}
