using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages
{
    public partial class LogInStudent
    {
        [AllureStep("EnterEmailPassword")]
        public LogInStudent EnterEmailPassword()
        {
            FIeldInputEmail.SendKeys(Credentials.emailStudentOne);
            FIeldInputPassword.SendKeys(Credentials.passwordStudentOne);

            return this;
        }

        [AllureStep("EnterPasswordAfterCreateAccount")]
        public LogInStudent EnterEmailPasswordAfterCreateAccount()
        {
            WaitUntil.ShouldLocate(_FIeldInputEmail);
            FIeldInputPassword.SendKeys(Credentials.passwordForCreateAccount);

            return this;
        }

        [AllureStep("ClickButtonSignIn")]
        public LogInStudent ClickButtonSignIn()
        {
            WaitUntil.ElementIsClickable(ButtonLogIn);
            ButtonLogIn.Click();

            return this;
        }

        [AllureStep("ClickLinkCreateAnAccount")]
        public LogInStudent ClickLinkCreateAnAccount()
        {
            LinkCreateAnAccountl.Click();

            return this;
        }
    }
}