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
using OpenQA.Selenium;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage;
using SamiiProjectOptimal.PageObjects.WorkWithIssuePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage;

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("Login")]
        public void LogInAsStudent()
        {
            Pages.LogInStudent
                .EnterEmailPassword();
            Pages.LogInStudent
                .ClickButtonSignIn();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("CreateAccount")]
        public void CreateAccountForStudent()
        {
            Pages.LogInStudent
                .ClickLinkCreateAnAccount();
            Pages.CreateAccountStudent
                .EnterEmailPasswordCnfrmPsswrd();

            string email = Pages.TeacherCreateAccount.CopyEmailFromCrtAccntPg();

            Pages.CreateAccountStudent
                .ClickSignUpButtonCrtAccnt();
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailRandomUrlXitroo);
            Pages.EmailXitroo
                .EnterEmail(email);
            Pages.EmailXitroo
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenWelcomeToSammii();

            string verificationCode = Pages.EmailXitroo.CopyVerificationCode();

            Pages.EmailXitroo
                .CloseNewTab();
            Pages.ConfirmationCodeStudent
                .EnterDataVerify(verificationCode);
            Pages.ConfirmationCodeStudent
                .ClickNextButton();

            Pages.LogInTeacher
                .SwitchTabEmailXitroo();
            Pages.EmailXitroo
                .ClickButtonBack();

            string _email = Pages.EmailXitroo.CopyEmailPgXitroo();

            Pages.EmailXitroo
                .SwitchOnLogInPage();
            Pages.EmailXitroo
                .EnterRepeatEmail(_email);

            Pages.LogInStudent
                .EnterEmailPasswordAfterCreateAccount();
            Pages.LogInStudent
                .ClickButtonSignIn();
            Pages.CreateAccountStudent
                .ClickButtonRoleStudent();
            Pages.CreateAccountStudent
                .EnterFirslastNamePhoneAddress();
            Pages.CreateAccountStudent
                .UploadImage();
            Pages.CreateAccountStudent
                .ClickButtonDone();
            Pages.CreateAccountStudent
                .ClickNextButton();
            Pages.CreateAccountStudent
                .ClickCompleteButton();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("PayForLesson")]
        public void PayForLesson()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailStudentStudTestNeww);
            Pages.EmailXitroo
                .OpenAssignToLesson();
            Pages.EmailXitroo
                .ClickLinkHere();
            Pages.PayLessonStudent
                .EnterEmailPasswordPayLogInPg();
            Pages.PayLessonStudent
                .ClickButtonLogIn();
            Thread.Sleep(10000);
        }
    }
}
