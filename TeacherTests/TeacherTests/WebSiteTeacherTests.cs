using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects;
using System.Threading;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace TeacherTests
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully create a new account.
        //Comment: 
        //Path to cheking's: 

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
            Pages.GeneralMethods
                .SelectRoleOnCreateAccountPage(ListRolesCreateAccountpagePg.teacher, "");
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
            //KeyBoardActions.ClickEnterButton();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("Login")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as teacher.
        //Comment: 
        //Path to cheking's: 

        public void LogIn()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();

            string getEmailLogIn = Pages.LogInTeacher.GetEmailFromlogIn();

            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemProfileSettings();
            Pages.LogInTeacher
                .VerifyByEmail(getEmailLogIn);
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("SetNewLessonCurrentDay")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully set a new lesson on the current day.
        //Comment: 
        //Path to cheking's: 

        public void SetNewLessonCurrentDay()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();

            Pages.GeneralMethods
                .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
            Pages.TeacherLssnShdlrMdlWndw
                .SelectAllInstruments();
            Pages.TeacherLssnShdlrMdlWndw
                .SelectRecurrenceOnce();
            Pages.TeacherLssnShdlrMdlWndw
                .EnterPriceToStudentsPerGroup();

            string getTitleForCompare = Pages.TeacherLssnShdlrMdlWndw.GetTitle();

            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonNext();
            Pages.TeacherLssnShdlrMdlWndw
                .ClickButtonSaveForTeacher();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Hame page");
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
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
            Pages.TeacherLssnShdlrMdlWndw
                .VerifyTitle(getTitleForCompare);
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonCloseViaCross();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemTeacherEditProfileDropDown();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("SetNewLessonOnNextDateViaCalendar")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully create a new account via the calendar with right.
        //Comment: 
        //Path to cheking's: 

        public void SetNewLessonOnNextDateViaCalendar()
        {
            Pages.LogInTeacher
                .EnterEmailPassword();
            Pages.LogInTeacher
                .ClickButtonLogInAsTeacher();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();
            Pages.GeneralMethods
               .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully move a new lesson on a current day via the table time.
        //Comment: 
        //Path to cheking's: SetNewLessonCurrentDay > MoveDateTimeLessonCurrentDayViaSlctrDays

        public void MoveDateTimeLessonCurrentDayViaSlctrDays()
        {
            Pages.LogInTeacher
                .EnterEmailPassword()
                .ClickButtonLogInAsTeacher();

            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickButtonItemLessonSheduler();

            Pages.TeacherLessonSheduler
                .ScrollToCellElevenPmShdlrPg();
            Pages.GeneralMethods
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();
            Pages.GeneralMethods
                .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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
        [AllureSuite("Teacher")]
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
                .ClickOnceLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
            Pages.AdminLssnShdlrMdlWndwPg
                .ClickButtonMoveStudentsMdlWndwLssnShdlr()
                .ClickButtonSelectAllLessonBelongsTo()
                .ClickButtonMoveOneLessonLessonBelongsTo();
            Pages.AdminLssnShdlrMdlWndwPg
                .ScrollToCellElevenPmPmMdlWndwCalendar();
            Pages.GeneralMethods
                .ClickTwiceOnLessonPage(TimeSlots.timeSlot_21_30, "Home Studio");
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

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully delete a lessin from the a current day.
        //Comment: 
        //Path to cheking's: 

        public void ADeleteLessonForCurrentDay()
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
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("ForgotPassword")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully changing a password for the user in the role teacher.
        //Comment: 
        //Path to cheking's: 

        public void ForgotPassword()
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

            string copyNewPassword = Pages.TeacherProfileSetUp.CopyPasswordTabAvlbRsrcsTchrPrflStp();

            Pages.TeacherProfileSetUp
                .ClickTabAvailableResourcesTchrPrflStp()
                .ClickButtonCompleteAvlbRsrcsTchrPrflStp();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemLogoutDropDown();
            Pages.LogInTeacher
                .EnterEmail();
            Pages.GeneralFolderMultirole
                .EnterCopiedPasswordFromTabAvlbRsrcsTchrPrflStp(copyNewPassword);
            Pages.LogInStudent
                .ClickIconShowEnteredPassword();
            Pages.LogInTeacher
                .ClickButtonLogIn();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("SentMessageViaIconHeader")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has written and sent the message to the student.
        //Comment: 
        //Path to cheking's: 

        public void TeacherSentMessageViaIconHeader()
        {
            Pages.LogInTeacher
                .EnterEmailPassword()
                .ClickButtonLogInAsTeacher();
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

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Teacher")]
        [AllureSubSuite("EditProfile")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully has edited the profile teachert.
        //Comment: 
        //Path to cheking's: 

        public void EditProfile()
        {
            Pages.LogInTeacher
                .EnterEmailPassword()
                .ClickButtonLogIn();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemTeacherEditProfileDropDown();
            Pages.EditProfile
                .ClickIconEditBadgesEdtPrfPg();
            Pages.EditProfile
                .SelectItemBadgesEdtPrflPg(ListItemBadges.internationalTourningMusician, "")
                .ClickButtonArrowWithRightBadgesEdtPrfPg()
                .SelectItemBadgesEdtPrflPg(ListItemBadges.twelveYearsOfTeaching, "")
            
                .ClickIconConfirmEditBadgesEdtPrfPg()
                .ClickIconEditIntroductionEdtPrfPg()
                .EnterTextInFieldInputEditIntroductionEdtPrfPg()
                .ClickIconConfirmIntroductionBadgesEdtPrfPg()
                .ClickIconEditLocationEdtPrfPg()
                .ScrollToRadioButtonProfileListedOnDirectoryEdtPrfPg()
                .ClickButtonAddForLocationEdtPrfPg();
            Pages.EditProfile
                .SelectLocationFieldsWithLeftForTeacherEdtPrfPg(ListOfNameLocationsEdtPrfPg.fourthInputField, "");

            Thread.Sleep(5000);
        }
    }
}