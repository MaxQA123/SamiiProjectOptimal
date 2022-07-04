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
        public IWebElement FieldInputEmailForgotPassword => Browser._Driver.FindElement(_FieldInputEmailForgotPassword);
        public readonly static By _FieldInputEmailForgotPassword = By.XPath("//input[@id= 'email']");

        public IWebElement ButtonSubmitForgotPassword => Browser._Driver.FindElement(_ButtonSubmitForgotPassword);
        public readonly static By _ButtonSubmitForgotPassword = By.XPath("//button[@type= 'submit']");

        #region ResetPasswordPage

        public IWebElement FieldInputPasswordResetPsswd => Browser._Driver.FindElement(_FieldInputPasswordResetPsswd);
        public readonly static By _FieldInputPasswordResetPsswd = By.XPath("//input[@id = 'password']");

        public IWebElement FieldInputConfirmPasswordResetPsswd => Browser._Driver.FindElement(_FieldInputConfirmPasswordResetPsswd);
        public readonly static By _FieldInputConfirmPasswordResetPsswd = By.XPath("//input[@id = 'confirm-password']");

        public IWebElement IconShowPassword => Browser._Driver.FindElement(_IconShowPassword);
        public readonly static By _IconShowPassword = By.XPath("//i[@class = 'fas fa-eye']");

        public IWebElement ButtonSubmitResetPasswordPage => Browser._Driver.FindElement(_ButtonSubmitResetPasswordPage);
        public readonly static By _ButtonSubmitResetPasswordPage = By.XPath("//button[text() = 'Submit']");

        #endregion
    }
}
