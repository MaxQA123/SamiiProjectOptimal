using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.PayLessonParentPage
{
    public partial class PayLessonParent
    {
        [AllureStep("EnterEmailPasswordAsParentPayLogInPg")]
        public PayLessonParent EnterEmailPasswordAsParentPayLogInPg()
        {
            WaitUntil.WaitSomeInterval(3);
            Input.InputFunctionWithClear(FieldInputEmailAddressLogForPay, Credentials.emailParent);
            Input.InputFunctionWithClear(FieldInputPasswordLogForPay, Credentials.passwordParent);

            return this;
        }

        [AllureStep("ClickButtonLogIn")]
        public PayLessonParent ClickButtonLogInAsParent()
        {
            WaitUntil.ShouldLocate(_ButtonLogInLogForPay);
            ButtonLogInLogForPayy.Click();

            return this;
        }
    }
}
