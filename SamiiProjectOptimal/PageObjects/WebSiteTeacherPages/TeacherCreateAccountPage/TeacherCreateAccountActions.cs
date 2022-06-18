using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherCreateAccountPage
{
    public partial class TeacherCreateAccount
    {
        public TeacherCreateAccount EnterEmailPasswordConfirmPassword()
        {
            WaitUntil.ShouldLocate(_FieldInputUsernameEmail);
            FieldInputUsernameEmail.SendKeys(RandomGenerateData.RandomEmail(6) + NameDomen.Xitroo);
            WaitUntil.WaitSomeInterval(1);
            FieldInputPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);
            WaitUntil.WaitSomeInterval(1);
            FieldInputConfirmPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        public TeacherCreateAccount ClickSignUpButton()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonSignUpCrtAccnt.Click();

            return this;
        }

        public TeacherCreateAccount ClickIconShowPassword()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowPassword.Click();

            return this;
        }

        public string CopyEmailFromCrtAccntPg()
        {
            WaitUntil.WaitSomeInterval(1);
            string getemail = Browser._Driver.FindElement(_FieldInputUsernameEmail).GetAttribute("value");
            string email = getemail.ToLower();

            return email;
        }
    }
}
