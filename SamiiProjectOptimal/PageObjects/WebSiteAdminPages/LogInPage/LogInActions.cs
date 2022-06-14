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
        public LogInAdmin EnterEmailPassword()
        {
            FIeldInputEmail.SendKeys(Credentials.emailAdmin);
            FIeldInputPassword.SendKeys(Credentials.passwordAdmin);

            return this;
        }

        public LogInAdmin ClickButtonSignIn()
        {
            ButtonLogIn.Click();

            return this;
        }
    }
}
