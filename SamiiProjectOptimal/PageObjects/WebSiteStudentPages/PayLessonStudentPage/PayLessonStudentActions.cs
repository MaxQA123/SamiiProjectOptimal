﻿using NUnit.Allure.Attributes;
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

        [AllureStep("EnterEmailPasswordPayLogInPg")]
        public PayLessonStudent EnterEmailPasswordPayLogInPg()
        {
            //WaitUntil.WaitSomeInterval(3);
            //Browser._Driver.SwitchTo().Frame(IframePayModalWndw);
            WaitUntil.WaitSomeInterval(3);
            FieldInputEmailAddressLogForPay.SendKeys(Credentials.emailStudentOne);
            FieldInputPasswordLogForPay.SendKeys(Credentials.passwordStudentOne);

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
    }
}
