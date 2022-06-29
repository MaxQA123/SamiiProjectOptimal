using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("CreateAccountForTeacher")]
        public void CreateAccountForTeacher()
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

            string verifyCode = Pages.EmailXitroo.CopyVerificationCode();

            Pages.EmailXitroo
                .CloseNewTab();
            Pages.TeacherConfirmCode
                .EnterDataVerifyCode(verifyCode);
            Pages.TeacherConfirmCode
                .ClickButtonNext();
            Pages.LogInTeacher
                .SwitchTabEmailXitroo();
            Pages.EmailXitroo
                .ClickButtonBack();

            string _email = Pages.EmailXitroo.CopyEmailPgXitroo();

            Pages.EmailXitroo
                .SwitchOnLogInPage();
            Pages.EmailXitroo
                .EnterRepeatEmail(_email);
            Pages.LogInTeacher
                .EnterPassword();
            Pages.LogInTeacher
                .ClickButtonLogIn();
            Pages.TeacherCreateAccount
                .ClickButtonTeacher();
            Pages.TeacherCreateAccount
                .EnterFirstLastNameAddressPhone();
            Pages.TeacherCreateAccount
                .SelectInstrument();
            Pages.TeacherCreateAccount
                .ScrollToFieldDateOfBirth();
            Pages.TeacherCreateAccount
                .EnterForTeacherDateOfBirth();
            //Pages.TeacherCreateAccount
            //    .CkickOnCheckBoxShowLessonPriceRange();
            Pages.TeacherCreateAccount
                .ClickButtonNextStep();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("Login")]

        public void LogIn()
        {
            Pages.LogInTeacher
                .EnterEamilPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("SetDateLessonByTheTeacher")]

        public void SetDateLessonByTheTeacher()
        {
            Pages.LogInTeacher
                .EnterEamilPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.HeaderTeacher
                .ClickArrowDropDown();
            Pages.HeaderTeacher
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[29].Click();
            WaitUntil.WaitSomeInterval(3);
            shedulerLessonPage[29].Click();

            Pages.TeacherLssnShdlrMdlWndw
                .SelectAllInstruments();
            Pages.TeacherLssnShdlrMdlWndw
                .SelectRecurrenceOnce();
            Pages.TeacherLssnShdlrMdlWndw
                .EnterPriceToStudentsPerGroup();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonNext();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonSaveForTeacher();

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAddotional("Home Studio");

            _shedulerLessonPage[29].Click();

            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonAssignLessonTo();
            Pages.TeacherLssnShdlrMdlWndw
                .SelectFirstStudentToAssign();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonAssignStudent();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonNextAfterAssignStudent();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonSaveForTeacher();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DeleteLesson")]

        public void DeleteLesson()
        {
            Pages.LogInTeacher
                .EnterEamilPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.HeaderTeacher
                .ClickArrowDropDown();
            Pages.HeaderTeacher
                .ClickButtonItemLessonSheduler();
            Pages.TeacherLessonSheduler
                .ClickOnceCell();
            Pages.TeacherLssnShdlrMdlWndw
               .ClickDeleteDtlsTab();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonYes();
            Thread.Sleep(5000);
        }

    }
}