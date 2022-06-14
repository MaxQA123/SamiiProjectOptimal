using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;

namespace SamiiProjectOptimal
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteTeacherTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]
        public void LogInAsTeacher()
        {
        }

    }
}