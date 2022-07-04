using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ResetPasswordPage
{
    public partial class ResetPassword
    {
        [AllureStep("EnterCrrntPsswrdPsswrdCnfrPsswrd")]
        public ResetPassword EnterCrrntPsswrdPsswrdCnfrPsswrd()
        {
            WaitUntil.ShouldLocate(_FieldInputCurrentPasswordRstPsswrdPg);
            Input.InputFunctionWithClear(FieldInputCurrentPasswordRstPsswrdPg, Credentials.passwordForChange);
            Input.InputFunctionWithClear(FieldInputPasswordRstPsswrdPg, Credentials.passwordStudentOne);
            Input.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, Credentials.passwordStudentOne);

            return this;
        }

        [AllureStep("ClickAllIconShowRstPsswrdPg")]
        public ResetPassword ClickAllIconShowRstPsswrdPg()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowCurrentPasswordRstPsswrdPg.Click();
            WaitUntil.WaitSomeInterval(1);
            IconShowPasswordRstPsswrdPg.Click();

            return this;
        }

        [AllureStep("ClickButtonChangePasswordRstPsswrdPg")]
        public ResetPassword ClickButtonChangePasswordRstPsswrdPg()
        {
            ButtonChangePasswordRstPsswrdPg.Click();

            return this;
        }

    }
}
