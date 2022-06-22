using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages
{
    public partial class LogInAdmin
    {
        [AllureStep("Enter Credentials")]
        public LogInAdmin EnterEmailPassword()
        {
            WaitUntil.ShouldLocate(_FIeldInputEmail);
            FIeldInputEmail.SendKeys(Credentials.emailAdmin);
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPassword.SendKeys(Credentials.passwordAdmin);

            return this;
        }

        [AllureStep("ClickButtonSignIn")]
        public LogInAdmin ClickButtonSignIn()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonLogIn.Click();

            return this;
        }
    }
}
