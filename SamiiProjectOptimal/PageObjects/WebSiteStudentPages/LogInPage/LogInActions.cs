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
        public LogInStudent EnterEmailPassword()
        {
            FIeldInputEmail.SendKeys(Credentials.emailStudentOne);
            FIeldInputPassword.SendKeys(Credentials.passwordStudentOne);

            return this;
        }

        public LogInStudent ClickButtonSignIn()
        {
            ButtonLogIn.Click();

            return this;
        }
    }
}