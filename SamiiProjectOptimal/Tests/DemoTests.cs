using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
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
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DeleteLessonCurrentDay")]

        //Classic the cycles
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
        [AllureSuite("Student")]
        [AllureSubSuite("ResetPasswordViaLambdaLinq")]

        public void ResetPasswordViaLambdaLinq()
        {
            Pages.LogInStudent
                .EnterEmail();

            string passwordWorking = Pages.CycleForResetPassword.SelectPassword("4");

            Pages.CycleForResetPassword
                .EnterPasswordHowLogIn(passwordWorking);

            Pages.LogInStudent
                .ClickIconShowEnteredPassword()
                .ClickButtonSignIn();
            Pages.HeaderStudent
                .ClickArrowDropDownMenu()
                .ClickItemSettingsDropDown();

            string passwordAWorking = Pages.CycleForResetPassword.SelectPassword("4");

            Pages.CycleForResetPassword
                .EnterPasswordHowLogIn(passwordAWorking);

            string passwordNew = Pages.CycleForResetPassword.SelectPassword("1");

            Pages.CycleForResetPassword
                .EnterNewPasswordForResetedPassword(passwordNew);

            Pages.ResetPassword
                .ClickAllIconShowRstPsswrdPg();

            string passwordResetPasswordPg = Pages.ResetPassword.CopyPasswordResetPasswordPg();

            Pages.ResetPassword
                .ClickButtonChangePasswordRstPsswrdPg();
            Pages.HeaderStudent
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();
            Pages.LogInStudent
                .EnterEmail()
                .CopiedPassword(passwordResetPasswordPg)
                .ClickIconShowEnteredPassword()
                .ClickButtonSignIn();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("ForgotPasswordViaCycle")]
        public void ForgotPasswordViaCycle()
        {
            Pages.LogInTeacher
                .EnterEmail();

            string passwordWorking = Pages.CycleForResetPassword.SelectPasswordViaCycle("1");

            Pages.CycleForResetPassword
                .EnterCurrentPasswordForLogInPage(passwordWorking);

            Pages.LogInStudent
                .ClickIconShowEnteredPassword();
            Pages.LogInTeacher
                .ClickButtonLogIn();
            Pages.HeaderTeacher
                .ClickArrowDropDown()
                .ClickButtonItemProfileSettings();
            Pages.TeacherProfileSetUp
                .ClickTabPasswordTchrPrflStp();

            string passwordAWorking = Pages.CycleForResetPassword.SelectPasswordViaCycle("1");

            Pages.CycleForResetPassword
                .EnterCurrentPasswordForTchrPrflStp(passwordAWorking);

            string passwordNew = Pages.CycleForResetPassword.SelectPasswordViaCycle("4");

            Pages.CycleForResetPassword
                .EnterPasswordConfirmPsswrdForTchrPrflStp(passwordNew);

            Pages.TeacherProfileSetUp
                .ClickBothIconShowTchrPrflStp();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SetNewLessonCurrentDayViaSlctrDays")]

        public void SetNewLessonCurrentDayViaSlctrDays()
        {
            Pages.LogInAdmin
                .EnterEmailPassword()
                .ClickButtonSignIn();
            Pages.AdminHome
                .ScrollToPaginationEducatorTbl();
            Pages.AdminHome
                .ClickButtonThreeOnPgntnEducator();
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.HeaderAdminWebSite
                .ClickArrowDropDown();
            Pages.HeaderAdminWebSite
                .ClickButtonItemLessonSheduler();

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[44].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[44].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .SelectAllInstruments();
            Pages.AdminLssnShdlrMdlWndwPg
                .SelectRecurrenceOnce();
            Pages.AdminLssnShdlrMdlWndwPg
                .EnterPriceToStudentsPerGroup();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonNext();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonSaveForAdmin();

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[44].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonAssignLessonToAfterSaved();
            Pages.AdminLssnShdlrMdlWndwPg
                .SelectFirstStudentToAssign();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonAssignStudent();

            string getTitle = Pages.AdminLssnShdlrMdlWndwPg.GetTitle();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonNextAfterAssignStudent();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonSaveForAdmin();

            IList<IWebElement> _shedulerLessonPageA = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPageA[44].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .VerifySetLesson(getTitle)
                .ClickButtonCloseViaCross();

            Pages.HeaderAdminWebSite
                .ClickArrowDropDown();
            Pages.HeaderAdminWebSite
                .ClickButtonLogout();
            Thread.Sleep(5000);
        }

    }
}
