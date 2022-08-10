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

namespace AdminTests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteAdminTests : BaseAdmin
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
                .SelectNumberPaginationForTeacherAdminPg(NumbersForThePaginationAdminAcTableTeacher.fiveth, "");
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.AdminLessonSheduler
                .SelectNextDay();
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
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonNextAfterAssignStudent();
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonSaveForAdmin();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();

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

            Pages.TeacherLessonSheduler
                .ScrollToCellElevenPmShdlrPg();
            Pages.GeneralMethods
               .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
                .SelectNumberPaginationForTeacherAdminPg(NumbersForThePaginationAdminAcTableTeacher.fiveth, "");
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
                .SelectNumberPaginationForTeacherAdminPg(NumbersForThePaginationAdminAcTableTeacher.fiveth, "");
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
                .ScrollToPaginationEducatorTbl();
            Pages.AdminHome
                .SelectNumberPaginationForTeacherAdminPg(NumbersForThePaginationAdminAcTableTeacher.fiveth, "");
            Pages.AdminHome
                .ClickButtonDetailsTestTeacher();
            Pages.EducatorsView
                .ClickButtonImpersonateEducatorView();

            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.GeneralMethods
                .SelectUserOnMessengerPage(ListOfUsersMessengerPage.secondUser, "");
            Pages.GeneralMessenger
                .EnterMessageOnMessengerPage();

            string getTextMessageForCompare = Pages.GeneralMessenger.GetTextMessage();

            Pages.GeneralMessenger
                .ClickButtonArrowSendMessageOnMessengerPg();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();
            Pages.LogInStudent
                .EnterEmailPassword()
                .ClickButtonSignIn();
            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.GeneralMethods
                .SelectUserOnMessengerPage(ListOfUsersMessengerPage.firstUser, "");
            Pages.GeneralMessenger
                .VerifyTextMessage(getTextMessageForCompare);

            Thread.Sleep(5000);
        }

    }
}
