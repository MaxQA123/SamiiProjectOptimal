using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
using SamiiProjectOptimal.PageObjects.WorkWithIssuePage;
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
    public class DemoTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("Demo")]

        public void Demo()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(TestDataEndPoint.studentProfileSetup);
            Pages.CreateAccountStudent
                .EnterFirslastNamePhoneAddress();
            Thread.Sleep(5000);
        }

    }
}
