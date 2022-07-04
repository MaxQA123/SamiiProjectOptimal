using NUnit.Allure.Attributes;
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
        [AllureStep("CopyPasswordResetPasswordPg")]
        public string CopyPasswordResetPasswordPg()
        {
            string getPassword = Browser._Driver.FindElement(_FieldInputConfirmPasswordRstPsswrdPg).GetAttribute("value");
            string passwordResetPasswordPg = getPassword.ToString();

            return passwordResetPasswordPg;
        }
    }
}
