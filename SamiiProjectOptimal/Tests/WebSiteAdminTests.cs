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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as admin.
        //Comment: 
        //Path to cheking's: 


        public void LogIn()
        {
            Pages.LogInAdmin
                .EnterEmailPassword();
            Pages.LogInAdmin
                .ClickButtonSignIn();

            string nameAdminForCompare = Pages.AdminHome.GetNameAdminFromAdminPage();

            Pages.AdminHome
                .VerifyCurrentNameAdmin(nameAdminForCompare);
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SetNewLessonOnNextDateViaCalendar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully set a new lesson on the next date via calendar with right.
        //Comment: 
        //Path to cheking's: 

        public void SetNewLessonOnNextDateViaCalendar()
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

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[46].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[46].Click();

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

            _shedulerLessonPage[46].Click();

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
        [AllureSubSuite("SetNewLessonCurrentDay")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully set a new lesson on a current day via the table time.
        //Comment: 
        //Path to cheking's: 

        public void SetNewLessonCurrentDay()
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

            shedulerLessonPage[43].Click();
            WaitUntil.WaitSomeInterval(1);
            shedulerLessonPage[43].Click();

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

            _shedulerLessonPage[43].Click();

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

            _shedulerLessonPageA[43].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .VerifySetLesson(getTitle)
                .ClickButtonCloseViaCross();

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
        [AllureSubSuite("MoveDateTimeLessonCurrentDayViaSlctrDays")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully move a new lesson on a current day via the table time.
        //Comment: 
        //Path to cheking's: SetNewLessonCurrentDay > MoveDateTimeLessonCurrentDayViaSlctrDays

        public void MoveDateTimeLessonCurrentDayViaSlctrDays()
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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("MoveDateTimeLessonNextDateViaCalendar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully move a new lesson on a current day via the calindar with right.
        //Comment: 
        //Path to cheking's: SetNewLessonOnNextDateViaCalendar > MoveDateTimeLessonNextDateViaCalendar

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

            IList<IWebElement> shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPage("Home Studio");

            shedulerLessonPage[46].Click();

            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();

            IList<IWebElement> timeline = SearchXpathHelper.SelectorShedulerLessonMdlWndwForMoveLesson("Forth");

            timeline[47].Click();
            timeline[47].Click();

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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("DeleteLessonForCurrentDay")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully delete a lesson from the current day.
        //Comment: 
        //Path to cheking's: 

        public void DeleteLessonForCurrentDay()
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
        [AllureSubSuite("DeleteLessonFromNextDateViaCalendar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully deleted a lesson for the does't current day.
        //Comment: 
        //Path to cheking's: 

        public void DeleteLessonFromNextDateViaCalendar()
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

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional("Home Studio");

            _shedulerLessonPage[46].Click();

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
        [AllureSubSuite("SentMessageViaIconHeader")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has written and sent the message to the student.
        //Comment: 
        //Path to cheking's: 

        public void AdminAsTeacherSentMessageViaIconHeader()
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

            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.Click
                .SelectUserOnMessengerPage(ListOfUsersMessengerPage.secondUser, "");
            Pages.GeneralMessenger
                .EnterMessageOnMessengerPage();

            string getTextMessageForCompare = Pages.GeneralMessenger.GetTextMessage();

            Pages.GeneralMessenger
                .ClickButtonArrowSendMessageOnMessengerPg();
            Pages.HeaderStudent
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();
            Pages.LogInStudent
                .EnterEmailPassword()
                .ClickButtonSignIn();
            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.Click.SelectUserOnMessengerPage(ListOfUsersMessengerPage.firstUser, "");
            Pages.GeneralMessenger
                .VerifyTextMessage(getTextMessageForCompare);

            Thread.Sleep(5000);
        }

    }
}
