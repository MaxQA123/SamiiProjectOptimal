using NUnit.Allure.Attributes;
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

        #region PageEnrolInALessonTabDetails

        public PayLessonStudent ClickButtonNextPayLssnStdnt()
        {
            WaitUntil.ShouldLocate(_ButtonNextPayLssnStdntDtlsTab);
            ButtonNextPayLssnStdntDtlsTab.Click();

            return this; 
        }

        #endregion
    }
}
