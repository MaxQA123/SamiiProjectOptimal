using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
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

        public void LogIn()
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
        [AllureSubSuite("SetDateNewLessonForNextDay")]

        public void SetDateNewLessonForNextDay()
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
            Pages.AdminLessonSheduler
                .SelectNextDay();

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[42].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[42].Click();

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

            _shedulerLessonPage[42].Click();

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
            Pages.HeaderAdminWebSite
                .ClickArrowDropDown();
            Pages.HeaderAdminWebSite
                .ClickButtonLogout();
            Thread.Sleep(10000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SetDateNewLessonForCurrentDay")]

        public void SetDateNewLessonForCurrentDay()
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

            shedulerLessonPage[29].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[29].Click();

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

            _shedulerLessonPage[29].Click();

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
            Pages.HeaderAdminWebSite
                .ClickArrowDropDown();
            Pages.HeaderAdminWebSite
                .ClickButtonLogout();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("MoveDateTimeLesson")]

        public void MoveDateTimeLesson()
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
            Pages.AdminLessonSheduler
                .ClickOnceCellCellHalfPastSixPmSecond();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();

            IList<IWebElement> timeline = SearchXpathHelper.SelectorShedulerLessonMdlWndwForMoveLesson("Second");

            timeline[47].Click();
            timeline[47].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .SelectInstrumentsForMoveLesson()
                .SelectRecurrenceForMoveLesson()
                .EnterMinPriceToStudentsPerGroupForMoveLesson()
                .ClickButtonNextDetailsTabForMoveLesson()
                .ClickButtonSaveRecourceTabForMoveLesson();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("DeleteLessonAsAdminForCurrentDay")]

        public void DeleteLessonAsAdminForCurrentDay()
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

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[29].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickDeleteDtlsTab();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonYes();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("DeleteLessonAsAdminForNextDay")]

        public void DeleteLessonAsAdminForNextDay()
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

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[42].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickDeleteDtlsTab();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonYes();
            Thread.Sleep(5000);
        }

    }
}
