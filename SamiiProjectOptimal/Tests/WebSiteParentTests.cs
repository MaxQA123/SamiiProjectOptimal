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

    public class WebSiteParentTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Parent")]
        [AllureSubSuite("PayForOnceLesson")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully payid for the lesson.
        //Comment: 
        //Path to cheking's: 

        public void PayForOnceLesson()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailParentStudTestNeww);
            Pages.EmailXitroo
                .OpenAssignToLesson();
            Pages.EmailXitroo
                .ClickLinkHere();
            Pages.PayLessonStudent
                .SwitchOnLogInModalWndw();
            Pages.PayLessonParent
                .EnterEmailPasswordAsParentPayLogInPg()
                .ClickButtonLogInAsParent();
            Pages.PayLessonStudent
                .ClickButtonNextPayLssnStdnt();
            Pages.Click.SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
            Pages.PayLessonStudent
                .ClickCheckBoxIAgreeToTheTermsAndConditions();
            Pages.PayLessonStudent
                .ClickButtonNextPayLssnStdntCnfrmtnTab();
            Pages.PayLessonStudent
                .ClickButtonEnrolTabPayment();
            Pages.PayLessonStudent
                .ClickButtonConfirmMdlWndwYouveDone();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Parent")]
        [AllureSubSuite("PayForAllLessonExceptOnce")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully payid for the lesson.
        //Comment: 
        //Path to cheking's: 

        public void PayForAllLessonExceptOnce()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailParentStudTestNeww);
            Pages.EmailXitroo
                .OpenAssignToLesson();
            Pages.EmailXitroo
                .ClickLinkHere();
            Pages.PayLessonStudent
                .SwitchOnLogInModalWndw();
            Pages.PayLessonParent
                .EnterEmailPasswordAsParentPayLogInPg()
                .ClickButtonLogInAsParent();
            Pages.PayLessonStudent
                .ClickButtonNextPayLssnStdnt();
            Pages.Click.SelectInstrumentConfirmationtabPayPg(ListInstrumentForConfirmationtabPayPg.piano, "");
            Pages.PayLessonStudent
                .ClickCheckBoxIAgreeToTheTermsAndConditions();
            Pages.PayLessonStudent
                .ClickButtonNextPayLssnStdntCnfrmtnTab()
                .SelectRadioButtonPayForTenLessonsTabPayment()
                .ClickButtonCloseMdlWndwPerLessonDdTabPayment();
            Pages.PayLessonStudent
                .ClickButtonEnrolTabPayment();
            Pages.PayLessonStudent
                .ClickButtonConfirmMdlWndwYouveDone();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Parent")]
        [AllureSubSuite("CreateAccountForParent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully created an account for the parent.
        //Comment: 
        //Path to cheking's: 

        public void CreateAccountForParent()
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
            Pages.GeneralCreateAccount
                .SelectRoleParent();
            Pages.CreateAccountStudent
                .EnterFirslastNamePhoneAddress();
            Pages.CreateAccountStudent
                .UploadImage();
            Pages.CreateAccountStudent
                .ClickButtonDone();
            Pages.ParentCreateAccount
                .EnterFieldInputParentDateOfBirth()
                .EnterFirstLastNameParentStudentDetails();
            Scrolling.ScrollToDownWebPage();
            Pages.ParentCreateAccount
                .EnterFieldInputParentDateOfBirth()
                .EnterFieldInputParentStudentDetailsDateOfBirth();
            Pages.CreateAccountStudent
                .ClickNextButton();
            Pages.CreateAccountStudent
                .ClickCompleteButton();

            Thread.Sleep(5000);
        }
    }
}
