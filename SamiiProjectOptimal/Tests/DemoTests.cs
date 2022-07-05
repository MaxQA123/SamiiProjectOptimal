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

    }
}
