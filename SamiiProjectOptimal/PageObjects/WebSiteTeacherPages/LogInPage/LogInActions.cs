using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages
{
    public partial class LogIn
    {
        public LogIn EnterEmailPassword()
        {
            FIeldInputEmail.SendKeys(Credentials.emailStudentOne);
            FIeldInputPassword.SendKeys(Credentials.passwordStudentOne);

            return this;
        }

        public LogIn ClickButtonSignIn()
        {
            ButtonLogIn.Click();

            return this;
        }
    }
}
