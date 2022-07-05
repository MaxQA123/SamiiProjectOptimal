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
                .EnterEmailPassword();
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
        [AllureSubSuite("SetNewLessonCurrentDayViaSlctrDays")]

        public void SetNewLessonCurrentDayViaSlctrDays()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.HeaderTeacher
                .ClickArrowDropDown();
            Pages.HeaderTeacher
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[43].Click();
            WaitUntil.WaitSomeInterval(3);
            shedulerLessonPage[43].Click();

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

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[43].Click();

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("SetNewLessonOnNextDateViaCalendar")]

        public void SetNewLessonOnNextDateViaCalendar()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.HeaderTeacher
                .ClickArrowDropDown();
            Pages.HeaderTeacher
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> shedulerLessonOnSideRight = SearchXpathHelper.SelectorOnsideRghtCalendarShedulerLessonPage("August");

            //shedulerLessonOnSideRight[8].Click();

            foreach (var item in shedulerLessonOnSideRight)
            {
                if (item.Text == "1")
                {
                    item.Click();

                    break;
                }
            }

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Third");

            shedulerLessonPage[42].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[42].Click();

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

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Third");

            _shedulerLessonPage[42].Click();

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("MoveDateTimeLessonCurrentDayViaSlctrDays")]

        public void MoveDateTimeLessonCurrentDayViaSlctrDays()
        {
            Pages.LogInTeacher
                .EnterEmailPassword()
                .ClickButtonLogInAsTeacher();

            Pages.HeaderTeacher
                .ClickArrowDropDown()
                .ClickButtonItemLessonSheduler();

            Pages.TeacherLessonSheduler
                .ScrollToCellElevenPmShdlrPg();

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[43].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();

            IList<IWebElement> timeline = SearchXpathHelper.SelectorShedulerLessonMdlWndwForMoveLesson("Second");

            timeline[46].Click();
            WaitUntil.WaitSomeInterval(1);
            timeline[46].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .SelectInstrumentsForMoveLesson()
                .SelectRecurrenceForMoveLesson()
                .EnterMinPriceToStudentsPerGroupForMoveLesson()
                .ClickButtonNextDetailsTabForMoveLesson()
                .ClickButtonSaveRecourceTabForMoveLesson();
            Pages.TeacherLessonSheduler
                .ClickBtnAwaitingMoveConfirmations();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DeleteLessonCurrentDay")]

        public void DeleteLessonViaSlctrDays()
        {
            Pages.LogInTeacher
               .EnterEmailPassword()
               .ClickButtonLogInAsTeacher();

            Pages.HeaderTeacher
                .ClickArrowDropDown()
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[31].Click();

            Pages.TeacherLssnShdlrMdlWndw
               .ClickDeleteDtlsTab();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonYes();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("MoveDateTimeLessonNextDateViaCalendar")]

        public void MoveDateTimeLessonNextDateViaCalendar()
        {
            Pages.LogInAdmin
                .EnterEmailPassword()
                .ClickButtonSignIn();
            Pages.AdminHome
                .ScrollToPaginationEducatorTbl()
                .ClickButtonThreeOnPgntnEducator()
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.HeaderAdminWebSite
                .ClickArrowDropDown()
                .ClickButtonItemLessonSheduler();

            Pages.TeacherLessonSheduler
                .ScrollToCellElevenPmShdlrPg();

            IList<IWebElement> shedulerLessonOnSideRight = SearchXpathHelper.SelectorOnsideRghtCalendarShedulerLessonPage("August");

            //shedulerLessonOnSideRight[8].Click();

            foreach (var item in shedulerLessonOnSideRight)
            {
                if (item.Text == "1")
                {
                    item.Click();

                    break;
                }
            }

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Third");

            shedulerLessonPage[42].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();

            IList<IWebElement> timeline = SearchXpathHelper.SelectorShedulerLessonMdlWndwForMoveLesson("Forth");

            timeline[45].Click();
            timeline[45].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .SelectInstrumentsForMoveLesson()
                .SelectRecurrenceForMoveLesson()
                .EnterMinPriceToStudentsPerGroupForMoveLesson()
                .ClickButtonNextDetailsTabForMoveLesson()
                .ClickButtonSaveRecourceTabForMoveLesson();
            Pages.TeacherLessonSheduler
                .ClickBtnAwaitingMoveConfirmations();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DeleteLessonCurrentDay")]

        public void DeleteLessonFromNextDateViaCalendar()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.HeaderTeacher
                .ClickArrowDropDown();
            Pages.HeaderTeacher
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> shedulerLessonOnSideRight = SearchXpathHelper.SelectorOnsideRghtCalendarShedulerLessonPage("August");

            //shedulerLessonOnSideRight[8].Click();

            foreach (var item in shedulerLessonOnSideRight)
            {
                if (item.Text == "1")
                {
                    item.Click();

                    break;
                }
            }

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Third");

            _shedulerLessonPage[29].Click();

            Pages.TeacherLssnShdlrMdlWndw
               .ClickDeleteDtlsTab();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonYes();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("ForgotPassword")]
        public void ForgotPassword()
        {
            Pages.LogInTeacher
                .EnterEmail();

            string passwordWorking = Pages.CycleForResetPassword.SelectPasswordAlternativeway("4");

            Pages.CycleForResetPassword
                .EnterCurrentPasswordForTchrPrflStp(passwordWorking);

            Pages.LogInStudent
                .ClickIconShowEnteredPassword();
            Pages.LogInTeacher
                .ClickButtonLogIn();
            Pages.HeaderTeacher
                .ClickArrowDropDown()
                .ClickButtonItemProfileSettings();
            Pages.TeacherProfileSetUp
                .ClickTabPasswordTchrPrflStp();

            Thread.Sleep(5000);
        }

    }
}