using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.ForgotPasswordPage
{
    public partial class ForgotPassword
    {
        [AllureStep("EnterEmailForgotPassword")]
        public ForgotPassword EnterEmailForgotPassword()
        {
            WaitUntil.ShouldLocate(_FieldInputEmailForgotPassword);
            Input.InputFunctionWithClear(FieldInputEmailForgotPassword, Credentials.emailForgotPassword);

            return this;
        }

        [AllureStep("ClickButtonSubmitForgotPassword")]
        public ForgotPassword ClickButtonSubmitForgotPassword()
        {
            WaitUntil.ShouldLocate(_ButtonSubmitForgotPassword);
            ButtonSubmitForgotPassword.Click();

            return this;
        }

        [AllureStep("OpenNewTab")]
        public ForgotPassword OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;
        }

        #region ResetPasswordPage

        [AllureStep("EnterPsswrdAndConfirmPsswrd")]
        public ForgotPassword EnterPsswrdAndConfirmPsswrd()
        {
            WaitUntil.WaitSomeInterval(3);
            List<string> tabList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabList[2]);
            WaitUntil.ShouldLocate(_FieldInputPasswordResetPsswd);
            Input.InputFunctionWithClear(FieldInputPasswordResetPsswd, Credentials.passwordForChange);
            Input.InputFunctionWithClear(FieldInputConfirmPasswordResetPsswd, Credentials.passwordForChange);

            return this;
        }

        [AllureStep("ClickIconShowPassword")]
        public ForgotPassword ClickIconShowPassword()
        {
            WaitUntil.ShouldLocate(_IconShowPassword);
            IconShowPassword.Click();

            return this;
        }

        [AllureStep("ClickButtonSubmitResetPasswordPage")]
        public ForgotPassword ClickButtonSubmitResetPasswordPage()
        {
            WaitUntil.ShouldLocate(_ButtonSubmitResetPasswordPage);
            ButtonSubmitResetPasswordPage.Click();

            return this;
        }

        [AllureStep("CopyPasswordFromRstPsswrd")]
        public string CopyPasswordFromRstPsswrd()
        {
            WaitUntil.WaitSomeInterval(1);
            string getPassword = Browser._Driver.FindElement(_FieldInputConfirmPasswordResetPsswd).GetAttribute("value");
            string password = getPassword.ToString();

            return password;
        }

        #endregion
    }
}
