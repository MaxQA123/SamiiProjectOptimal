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
        public LogInTeacher ClickCreateAnAccount()
        {
            LinkCreateAnAccountl.Click();

            return this;
        }

        public LogInTeacher SwitchTabEmailXitroo()
        {
            WaitUntil.WaitSomeInterval(5);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[1]);

            return this;
        }

        public LogInTeacher EnterPassword()
        {
            WaitUntil.ShouldLocate(_FIeldInputPassword);
            FIeldInputPassword.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        public LogInTeacher ClickButtonLogIn()
        {
            WaitUntil.ShouldLocate(_ButtonLogIn);
            ButtonLogIn.Click();

            return this;
        }

    }
}
