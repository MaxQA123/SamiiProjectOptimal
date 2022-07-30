using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.LogInPage
{
    public partial class LogInParent
    {
        [AllureStep("EnterEmailPasswordForParent")]
        public LogInParent EnterEmailPasswordForParent()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(FIeldInputEmailLogInPg);
            FIeldInputEmailLogInPg.SendKeys(Credentials.emailParent);
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPasswordLogInPg.SendKeys(Credentials.passwordParent);

            return this;
        }

        [AllureStep("ClickButtonSignIn")]
        public LogInParent ClickButtonLogIn()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonLogIn.Click();

            return this;
        }
    }
}
