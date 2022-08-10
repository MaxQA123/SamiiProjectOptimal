using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System.Threading.Tasks;
using SamiiProjectOptimal.PageObjects;
using System.Threading;
using SamiiProjectOptimal.Additional;
using OpenQA.Selenium;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage;
using SamiiProjectOptimal.PageObjects.WorkWithIssuePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage;

namespace SamiiProjectOptimal.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteStudentTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("Login")]
        public void LogIn()
        {
            Pages.LogInStudent
                .EnterEmailPassword();

            string getEmailFromLogIn = Pages.StudentProfileSetUp.GetEmailFromLogIn();

            Pages.LogInStudent
                .ClickButtonSignIn();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemStudentEditProfileDropDown();
            Pages.StudentProfileSetUp
                .VerifyEmailIsRight(getEmailFromLogIn);
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("CreateAccountForStudent")]
        public void CreateAccountForStudent()
        {
            Pages.LogInStudent
                .ClickLinkCreateAnAccount();
            Pages.CreateAccountStudent
                .EnterEmailPasswordCnfrmPsswrd();

            string email = Pages.TeacherCreateAccount.CopyEmailFromCrtAccntPg();

            Pages.CreateAccountStudent
                .ClickSignUpButtonCrtAccnt();
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailRandomUrlXitroo);
            Pages.EmailXitroo
                .EnterEmail(email);
            Pages.EmailXitroo
                .ClickSearchButton();
            Pages.EmailXitroo
                .OpenWelcomeToSammii();

            string verificationCode = Pages.EmailXitroo.CopyVerificationCode();

            Pages.EmailXitroo
                .CloseNewTab();
            Pages.ConfirmationCodeStudent
                .EnterDataVerify(verificationCode);
            Pages.ConfirmationCodeStudent
                .ClickNextButton();

            Pages.LogInTeacher
                .SwitchTabEmailXitroo();
            Pages.EmailXitroo
                .ClickButtonBack();

            string _email = Pages.EmailXitroo.CopyEmailPgXitroo();

            Pages.EmailXitroo
                .SwitchOnLogInPage();
            Pages.EmailXitroo
                .EnterRepeatEmail(_email);
            Pages.LogInStudent
                .EnterEmailPasswordAfterCreateAccount();
            Pages.LogInStudent
                .ClickButtonSignIn();
            Pages.GeneralMethods
                .SelectRoleOnCreateAccountPage(ListRolesCreateAccountpagePg.student, "");
            Pages.CreateAccountStudent
                .EnterFirslastNamePhoneAddress();
            Pages.CreateAccountStudent
                .UploadImage();
            Pages.CreateAccountStudent
                .ClickButtonDone();
            Pages.CreateAccountStudent
                .ClickNextButton();
            Pages.CreateAccountStudent
                .ClickCompleteButton();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("PayForOnceLesson")]

        //Date of publication:
        //Version\Build: 1.0
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has paid of the lesson.
        //Comment: 
        //Path to cheking's: 

        #region Version 1.0

        //public void PayForOnceLesson()
        //{
        //    Pages.EmailXitroo
        //        .OpenNewTab();
        //    Browser._Driver.Navigate().GoToUrl(EndPoints.emailStudentStudTestNeww);
        //    Pages.EmailXitroo
        //        .OpenAssignToLesson();
        //    Pages.EmailXitroo
        //        .ClickLinkHere();
        //    Pages.PayLessonStudent
        //        .SwitchOnLogInModalWndw();
        //    Pages.PayLessonStudent
        //        .EnterEmailPasswordPayLogInPg();
        //    Pages.PayLessonStudent
        //        .ClickButtonLogIn();
        //    Pages.PayLessonStudent
        //        .ClickButtonNextPayLssnStdnt();
        //    Pages.Click.SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
        //    Pages.PayLessonStudent
        //        .ClickCheckBoxIAgreeToTheTermsAndConditions();
        //    Pages.PayLessonStudent
        //        .ClickButtonNextPayLssnStdntCnfrmtnTab();
        //    Pages.PayLessonStudent
        //        .ClickButtonEnrolTabPayment();
        //    Pages.PayLessonStudent
        //        .ClickButtonConfirmMdlWndwYouveDone();
        //    Thread.Sleep(5000);
        //}

        #endregion

        #region Version 2.0

        //Date of publication:
        //Version\Build: 2.0
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has paid of the lesson.
        //Comment: 
        //Path to cheking's: 

        public void PayForOnceLesson()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailStudentStudTestNeww);
            Pages.EmailXitroo
                .OpenAssignToLesson();
            Pages.EmailXitroo
                .ClickLinkHere();
            Pages.PayLessonStudent
                .SwitchOnLogInModalWndw();
            Pages.PayLessonStudent
                .EnterEmailPasswordPayLogInPg();
            Pages.PayLessonStudent
                .ClickButtonLogIn()
                .ClickButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab()
                .ClickButtonNextPayLssnStdnt();
            Pages.TeacherCreateAccount
                .SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
            Pages.PayLessonStudent
                .ClickCheckBoxIAgreeToTheTermsAndConditions()
                .ClickButtonNextPayLssnStdntCnfrmtnTab()
                .ClickButtonEnrolTabPayment()
                .ClickButtonConfirmMdlWndwYouveDone();

            Thread.Sleep(5000);
        }

        #endregion

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("PayForAllLessonExceptOnce")]

        //Date of publication:
        //Version\Build: 1.0
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has paid of the lesson.
        //Comment: 
        //Path to cheking's: 

        #region Version1.0

        //public void PayForAllLessonExceptOnce()
        //{
        //    Pages.EmailXitroo
        //        .OpenNewTab();
        //    Browser._Driver.Navigate().GoToUrl(EndPoints.emailStudentStudTestNeww);
        //    Pages.EmailXitroo
        //        .OpenAssignToLesson();
        //    Pages.EmailXitroo
        //        .ClickLinkHere();
        //    Pages.PayLessonStudent
        //        .SwitchOnLogInModalWndw();
        //    Pages.PayLessonStudent
        //        .EnterEmailPasswordPayLogInPg();
        //    Pages.PayLessonStudent
        //        .ClickButtonLogIn();
        //    Pages.PayLessonStudent
        //        .ClickButtonNextPayLssnStdnt();
        //    Pages.Click.SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
        //    Pages.PayLessonStudent
        //        .ClickCheckBoxIAgreeToTheTermsAndConditions();
        //    Pages.PayLessonStudent
        //        .ClickButtonNextPayLssnStdntCnfrmtnTab()
        //        .SelectRadioButtonPayForTenLessonsTabPayment()
        //        .ClickButtonCloseMdlWndwPerLessonDdTabPayment();
        //    Pages.PayLessonStudent
        //        .ClickButtonEnrolTabPayment();
        //    Pages.PayLessonStudent
        //        .ClickButtonConfirmMdlWndwYouveDone();

        //    Thread.Sleep(5000);
        //}

        #endregion

        //Date of publication:
        //Version\Build: 2.0
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has paid of the lesson.
        //Comment: 
        //Path to cheking's: 

        #region Version2.0

        public void PayForAllLessonExceptOnce()
        {
            Pages.EmailXitroo
               .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailStudentStudTestNeww);
            Pages.EmailXitroo
                .OpenAssignToLesson();
            Pages.EmailXitroo
                .ClickLinkHere();
            Pages.PayLessonStudent
                .SwitchOnLogInModalWndw();
            Pages.PayLessonStudent
                .EnterEmailPasswordPayLogInPg();
            Pages.PayLessonStudent
                .ClickButtonLogIn()
                
                .ClickButtonNextPayLssnStdnt();
            Pages.TeacherCreateAccount
                .SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
            Pages.PayLessonStudent
                .ClickCheckBoxIAgreeToTheTermsAndConditions()
                .ClickButtonNextPayLssnStdntCnfrmtnTab()
                .SelectRadioButtonPayForTenLessonsTabPayment()
                .ClickButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab()
                .ClickButtonEnrolTabPayment()
                .ClickButtonConfirmMdlWndwYouveDone();

            Thread.Sleep(5000);
        }

        #endregion


        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("ForgotPassword")]
        public void ForgotPassword()
        {
            Pages.GeneralFolderMultirole
                .ClickLinkForgotPassword();
            Pages.ForgotPassword
                .EnterEmailForgotPassword()
                .ClickButtonSubmitForgotPassword()
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailUrlForgotPasswordStudent);
            Pages.EmailXitroo
                .OpenLetterResetPassword()
                .ClickButtonResetPassword();
            Pages.ForgotPassword
                .EnterPsswrdAndConfirmPsswrd();

            string password = Pages.ForgotPassword.CopyPasswordFromRstPsswrd();

            Pages.ForgotPassword
                .ClickIconShowPassword()
                .ClickButtonSubmitResetPasswordPage();
            Pages.GeneralFolderMultirole
                .EnterEmailLogInAfterRstPsswrf();

            Pages.GeneralFolderMultirole
                .EnterCopiedPasswordFromRstPsswrd(password);
            Pages.LogInStudent
                .ClickButtonSignIn();
                
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Student")]
        [AllureSubSuite("ResetPassword")]

        public void ResetPassword()
        {
            Pages.LogInStudent
                .EnterEmail();

            string passwordWorking = Pages.CycleForResetPassword.SelectPassword("4");

            Pages.CycleForResetPassword
                .EnterPasswordForLogIn(passwordWorking);

            Pages.LogInStudent
                .ClickIconShowEnteredPassword()
                .ClickButtonSignIn();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemStudentEditProfileDropDown();

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
                .ClickItemStudentEditProfileDropDown();
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
        [AllureSuite("Student")]
        [AllureSubSuite("SentMessageViaIconHeader")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has written and sent the message to the teacher.
        //Comment: 
        //Path to cheking's: 

        public void StudentSentMessageViaIconHeader()
        {
            Pages.LogInStudent
                .EnterEmailPassword()
                .ClickButtonSignIn();
            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.GeneralMethods
                .SelectUserOnMessengerPage(ListOfUsersMessengerPage.firstUser, "");
            Pages.GeneralMessenger
                .EnterMessageOnMessengerPage();

            string getTextMessageForCompare = Pages.GeneralMessenger.GetTextMessage();

            Pages.GeneralMessenger
                .ClickButtonArrowSendMessageOnMessengerPg();
            Pages.GeneralHeader
                .ClickArrowDropDownMenu()
                .ClickItemStudentEditProfileDropDown();
            Pages.LogInTeacher
                .EnterEmailPassword()
                .ClickButtonLogInAsTeacher();
            Pages.GeneralHeader
                .ClickIconMessageHeader();
            Pages.GeneralMethods
                .SelectUserOnMessengerPage(ListOfUsersMessengerPage.secondUser, "");
            Thread.Sleep(5000);
            Pages.GeneralMessenger
                .VerifyTextMessage(getTextMessageForCompare);

            Thread.Sleep(5000);
        }

    }
}
