using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
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
    public class WebSiteAdminTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("Login")]

        public void LogInAsAdmin()
        {
            Pages.LogInAdmin
                .EnterEmailPassword();
            Pages.LogInAdmin
                .ClickButtonSignIn();
            Thread.Sleep(10000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SetDateLesson")]

        public void SetDateNewLesson()
        {
            Pages.LogInAdmin
                .EnterEmailPassword();
            Pages.LogInAdmin
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
            Pages.AdminLessonSheduler
                .ClickTwiceCell();
            Pages.AdminLssnShdlrMdlWndwPg
                .SelectAllInstruments();
            //Pages.AdminLssnShdlrMdlWndwPg
            //    .SelectRecurrenceOnce();
            Pages.AdminLssnShdlrMdlWndwPg
                .EnterPriceToStudentsPerGroup();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonNext();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonSaveForAdmin();
            Pages.AdminLessonSheduler
                .ClickOnceCell();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonAssignLessonToAfterSaved();
            Pages.AdminLssnShdlrMdlWndwPg
                .SelectFirstStudentToAssign();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonAssignStudent();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonNextAfterAssignStudent();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonSaveForAdmin();
            Pages.AdminLessonSheduler
                .ClickOnceCell();
                
            Thread.Sleep(10000);
        }
    }
}
