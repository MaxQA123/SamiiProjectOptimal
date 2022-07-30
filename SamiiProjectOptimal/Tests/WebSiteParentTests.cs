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
    }
}
