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
        [AllureOwner("Artem Sukharevskyi")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Artem", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]
        public void Setup()
        {
        }

    }
}