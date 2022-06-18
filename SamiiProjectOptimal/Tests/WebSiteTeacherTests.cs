using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
using System.Threading;

namespace SamiiProjectOptimal.Tests
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
            Pages.LogInTeacher
                .ClickCreateAnAccount();
            Pages.TeacherCreateAccount
                .EnterEmailPasswordConfirmPassword();

            string email = Pages.TeacherCreateAccount.CopyEmailFromCrtAccntPg();

            Pages.TeacherCreateAccount
                .ClickIconShowPassword();
            Pages.TeacherCreateAccount
                .ClickSignUpButton();
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailRandomUrlXitroo);
            Pages.EmailXitroo
                .EnterEmail(email);
            Pages.EmailXitroo
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenWelcomeToSammii();
            Thread.Sleep(5000);
        }

    }
}