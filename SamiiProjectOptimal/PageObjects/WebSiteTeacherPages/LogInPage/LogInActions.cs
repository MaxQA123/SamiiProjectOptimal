using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.LogInTeacher
{
    public partial class LogInTeacher
    {
        [AllureStep("ClickLinkCreateAnAccount")]
        public LogInTeacher ClickCreateAnAccount()
        {
            LinkCreateAnAccountl.Click();

            return this;
        }

        [AllureStep("SwitchTabEmailXitroo")]
        public LogInTeacher SwitchTabEmailXitroo()
        {
            WaitUntil.WaitSomeInterval(5);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[1]);

            return this;
        }

        [AllureStep("EnterPassword")]
        public LogInTeacher EnterPassword()
        {
            WaitUntil.ShouldLocate(_FIeldInputPassword);
            FIeldInputPassword.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        [AllureStep("ClickButtonLogIn")]
        public LogInTeacher ClickButtonLogIn()
        {
            WaitUntil.ShouldLocate(_ButtonLogIn);
            ButtonLogIn.Click();

            return this;
        }

        [AllureStep("EnterEamilPassword")]
        public LogInTeacher EnterEmailPassword()
        {
            WaitUntil.ShouldLocate(_FIeldInputEmail);
            FIeldInputEmail.SendKeys(Credentials.emailTeacherOne);
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPassword.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        [AllureStep("ClickButtonLogInAsTeacher")]
        public LogInTeacher ClickButtonLogInAsTeacher()
        {
            WaitUntil.ShouldLocate(_ButtonLogIn);
            ButtonLogIn.Click();

            return this;
        }

    }
}
