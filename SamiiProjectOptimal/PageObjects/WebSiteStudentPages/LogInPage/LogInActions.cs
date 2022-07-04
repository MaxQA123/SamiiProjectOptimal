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
            FIeldInputPassword.SendKeys(Credentials.passwordForChange);

            return this;
        }

        [AllureStep("EnterEmail")]
        public LogInStudent EnterEmail()
        {
            FIeldInputEmail.SendKeys(Credentials.emailStudentOne);

            return this;
        }

        [AllureStep("EnterPassword")]
        public LogInStudent EnterPassword()
        {
            FIeldInputEmail.SendKeys("");

            return this;
        }

        [AllureStep("SelectPassword")]
        public string SelectPassword(string passwordEnding)
        {
            string[] password = { "1111", "1234" };

            var passwordNew = password.Where(x => x.EndsWith(passwordEnding)).ToList();
            string passwordDrop = passwordNew[0];

            return passwordDrop;
        }

        [AllureStep("EnterPasswordResetedPassword")]
        public LogInStudent EnterPasswordResetedPassword(string pass)
        {
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPassword.SendKeys(pass);

            return this;
        }

        [AllureStep("EnterPasswordAfterCreateAccount")]
        public LogInStudent EnterEmailPasswordAfterCreateAccount()
        {
            WaitUntil.ShouldLocate(_FIeldInputEmail);
            FIeldInputPassword.SendKeys(Credentials.passwordForCreateAccount);

            return this;
        }

        [AllureStep("EnterPasswordAfterCreateAccount")]
        public LogInStudent ClickIconShowEnteredPassword()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowEnteredPassword.Click();

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

        [AllureStep("ClickLinkCreateAnAccount")]
        public LogInStudent CopiedPassword(string passwordResetPasswordPg)
        {
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPassword.SendKeys(passwordResetPasswordPg);

            return this;
        }
    }
}