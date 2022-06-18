using OpenQA.Selenium;
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
        public IWebElement FieldInputUsernameEmail => Browser._Driver.FindElement(_FieldInputUsernameEmail);
        public readonly static By _FieldInputUsernameEmail = By.XPath("//input[@id = 'username']");

        public IWebElement FieldInputPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputPasswordCrtAccnt);
        public readonly static By _FieldInputPasswordCrtAccnt = By.XPath("//input[@id = 'password']");

        public IWebElement FieldInputConfirmPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputConfirmPasswordCrtAccnt);
        public readonly static By _FieldInputConfirmPasswordCrtAccnt = By.XPath("//input[@id = 'confirm-password']");

        public IWebElement ButtonSignUpCrtAccnt => Browser._Driver.FindElement(_ButtonSignUpCrtAccnt);
        public readonly static By _ButtonSignUpCrtAccnt = By.XPath("//button[@type = 'submit']");

        public IWebElement IconShowPassword => Browser._Driver.FindElement(_IconShowPassword);
        public readonly static By _IconShowPassword = By.XPath("//i[@class = 'fas fa-eye']");

    }
}
