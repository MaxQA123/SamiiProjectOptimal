using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage
{
    public partial class CreateAccountStudent
    {
        public CreateAccountStudent EnterEmailPasswordCnfrmPsswrd()
        {
            WaitUntil.ElementIsClickable(FieldInputUsernameEmail);
            FieldInputUsernameEmail.SendKeys(Credentials.emailForCreateAccount);
            WaitUntil.ElementIsClickable(FieldInputPasswordCrtAccnt);
            FieldInputPasswordCrtAccnt.SendKeys(Credentials.passwordStudentOne);
            FieldInputConfirmPasswordCrtAccnt.SendKeys(Credentials.passwordStudentOne);

            return this;
        }

        public CreateAccountStudent ClickSignUpButtonCrtAccnt()
        {
            ButtonSignUpCrtAccntt.Click();

            return this;
        }
    }
}
