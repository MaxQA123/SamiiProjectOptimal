﻿using Allure.Commons;
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
        [AllureSubSuite("DemoDeleteLessonViaCalendarNexDateViaCicle")]

        //Classic the cycles
        public void DemoDeleteLessonViaCalendarNexDateViaCicle()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu();
            Pages.GeneralHeader
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DemoDeleteLessonCurrentDayViaActionsMethodsVarTwo")]

        public void DemoDeleteLessonCurrentDayViaActionsMethodsVarTwo()
        {
            Pages.LogInTeacher
               .EnterEmailPassword()
               .ClickButtonLogInAsTeacher();

            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();

            Pages.TeacherLessonSheduler
                .OpenPopUpForCreatelesson(TimeSlots.timeSlot_21_00, "Home Studio");

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

            string time = Pages.TeacherLessonSheduler.GetTime(TimeSlots.timeSlot_21_00, "Home Studio");

            Pages.TeacherLessonSheduler
                .OpenPopUpForDeletelesson(TimeSlots.timeSlot_21_00, "Home Studio");

            Pages.TeacherLssnShdlrMdlWndw
               .ClickDeleteDtlsTab();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonYes();
            Pages.TeacherLessonSheduler
                .VerifyDeletelesson(time);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DemoDeleteLessonCurrentDayViaGeneralMethodsVarTwo")]

        public void DemoDeleteLessonCurrentDayViaGeneralMethodsVarTwo()
        {
            Pages.LogInTeacher
               .EnterEmailPassword()
               .ClickButtonLogInAsTeacher();

            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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

            string time = Pages.TeacherLessonSheduler.GetTime(TimeSlots.timeSlot_21_00, "Home Studio");

            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");

            Pages.TeacherLssnShdlrMdlWndw
               .ClickDeleteDtlsTab();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonYes();
            Pages.TeacherLessonSheduler
                .VerifyDeletelesson(time);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.comm")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("DemoDeleteLessonCurrentDayVarThree")]

        public void DeleteLessonForCurrentDay()
        {
            Pages.LogInTeacher
               .EnterEmailPassword()
               .ClickButtonLogInAsTeacher();

            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
            Pages.GeneralHeader
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
            Pages.GeneralHeader
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
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
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
                .SelectNumberPaginationForTeacherAdminPg(NumbersForThePaginationAdminAcTableTeacher.fiveth, "");
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
            Pages.AdminLssnShdlrMdlWndwPg
                .VerifySetLesson(getTitle)
                .ClickButtonCloseViaCross();

            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();

            Thread.Sleep(5000);
        }

        

    }
}
