﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.PayLessonStudentPage
{
    public partial class PayLessonStudent
    {
        #region ModalWindowLogInAsStudent

        [AllureStep("SwitchOnLogInModalWndw")]
        public PayLessonStudent SwitchOnLogInModalWndw()
        {
            WaitUntil.WaitSomeInterval(3);
            List<string> tablist = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tablist[2]);
            WaitUntil.WaitSomeInterval(5);

            return this;
        }

        [AllureStep("EnterEmailPasswordPayLogInPg")]
        public PayLessonStudent EnterEmailPasswordPayLogInPg()
        {
            WaitUntil.WaitSomeInterval(3);
            Input.InputFunctionWithClear(FieldInputEmailAddressLogForPay, Credentials.emailStudentOne);
            Input.InputFunctionWithClear(FieldInputPasswordLogForPay, Credentials.passwordStudentOne);

            return this;
        }

        [AllureStep("ClickButtonLogIn")]
        public PayLessonStudent ClickButtonLogIn()
        {
            WaitUntil.ShouldLocate(_ButtonLogInLogForPay);
            ButtonLogInLogForPayy.Click();

            return this;
        }

        #endregion

        #region PageEnrolInALessonTabDetailsVersion1.0

        [AllureStep("ClickButtonNextPayLssnStdnt")]
        public PayLessonStudent ClickButtonNextPayLssnStdnt()
        {
            WaitUntil.WaitSomeInterval(2);
            ButtonNextPayLssnStdntDtlsTab.Click();

            return this; 
        }

        #endregion

        #region PageEnrolInALessonTabDetailsVersion2.0

        [AllureStep("ClickButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab")]
        public PayLessonStudent ClickButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab()
        {
            WaitUntil.WaitSomeInterval(2);
            WaitUntil.ElementIsClickable(ButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab);
            ButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab.Click();

            return this;
        }

        #endregion

        #region PageEnrolInALessonTabConfirmation

        [AllureStep("ClickCheckBoxIAgreeToTheTermsAndConditions")]
        public PayLessonStudent ClickCheckBoxIAgreeToTheTermsAndConditions()
        {
            WaitUntil.WaitSomeInterval(3);
            CheckBoxIAgreeToTheTermsAndConditions.Click();

            return this;
        }

        [AllureStep("SwitchOnLogInModalWndw")]
        public PayLessonStudent ClickButtonNextPayLssnStdntCnfrmtnTab()
        {
            WaitUntil.WaitSomeInterval(3);
            ButtonNextPayLssnStdntCnfrmtnTab.Click();

            return this;
        }

        #endregion

        #region PageEnrolInALessonTabPayment

        [AllureStep("SelectRadioButtonPayForTenLessonsTabPayment")]
        public PayLessonStudent SelectRadioButtonPayForTenLessonsTabPayment()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(RadioButtonPayForTenLessonsTabPayment);
            RadioButtonPayForTenLessonsTabPayment.Click();

            return this;
        }

        [AllureStep("ClickButtonCloseMdlWndwPerLessonDdTabPayment")]
        public PayLessonStudent ClickButtonCloseMdlWndwPerLessonDdTabPayment()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonCloseMdlWndwPerLessonDdTabPayment.Click();

            return this;
        }

        [AllureStep("ClickButtonEnrolTabPayment")]
        public PayLessonStudent ClickButtonEnrolTabPayment()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonEnrolTabPayment.Click();

            return this;
        }

        #endregion

        [AllureStep("ClickButtonConfirmMdlWndwYouveDone")]
        public PayLessonStudent ClickButtonConfirmMdlWndwYouveDone()
        {
            WaitUntil.ShouldLocate(_ButtonConfirmMdlWndwYouveDone);
            ButtonConfirmMdlWndwYouveDone.Click();

            return this;
        }

        [AllureStep("SelectInstrumentConfirmationtabPayPg")]
        public PayLessonStudent SelectInstrumentConfirmationtabPayPg(int numberItem, string locationInstrument)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorInstrumentConfirmationtabPayPg(locationInstrument);

            _numberItem[numberItem].Click();

            return this;
        }
    }
}
