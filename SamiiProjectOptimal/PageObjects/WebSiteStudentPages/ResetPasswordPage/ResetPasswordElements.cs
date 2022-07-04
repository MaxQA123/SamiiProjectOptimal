using OpenQA.Selenium;
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
        public IWebElement FieldInputCurrentPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputCurrentPasswordRstPsswrdPg);
        public readonly static By _FieldInputCurrentPasswordRstPsswrdPg = By.XPath("//input[@id= 'oldPassword']");

        public IWebElement FieldInputPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputPasswordRstPsswrdPg);
        public readonly static By _FieldInputPasswordRstPsswrdPg = By.XPath("//input[@id= 'password']");

        public IWebElement FieldInputConfirmPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputConfirmPasswordRstPsswrdPg);
        public readonly static By _FieldInputConfirmPasswordRstPsswrdPg = By.XPath("//input[@id= 'confirm-password']");

        public IWebElement IconShowCurrentPasswordRstPsswrdPg => Browser._Driver.FindElement(_IconShowCurrentPasswordRstPsswrdPg);
        public readonly static By _IconShowCurrentPasswordRstPsswrdPg = By.XPath("//label[@for = 'oldPassword']/parent::div//span");

        public IWebElement IconShowPasswordRstPsswrdPg => Browser._Driver.FindElement(_IconShowPasswordRstPsswrdPg);
        public readonly static By _IconShowPasswordRstPsswrdPg = By.XPath("//label[@for = 'password']/parent::div//span");

        public IWebElement ButtonChangePasswordRstPsswrdPg => Browser._Driver.FindElement(_ButtonChangePasswordRstPsswrdPg);
        public readonly static By _ButtonChangePasswordRstPsswrdPg = By.XPath("//button[@type = 'submit']");
    }
}
