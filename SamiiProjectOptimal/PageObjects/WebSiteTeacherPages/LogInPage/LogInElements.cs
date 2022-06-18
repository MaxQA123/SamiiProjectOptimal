using OpenQA.Selenium;
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
        public IWebElement LinkCreateAnAccountl => Browser._Driver.FindElement(_LinkCreateAnAccount);
        public readonly static By _LinkCreateAnAccount = By.XPath("//a[text() = 'Create an account']");

        public IWebElement FIeldInputEmail => Browser._Driver.FindElement(_FIeldInputEmail);
        public readonly static By _FIeldInputEmail = By.XPath("//input[@id = 'email']");

        public IWebElement FIeldInputPassword => Browser._Driver.FindElement(_FIeldInputPassword);
        public readonly static By _FIeldInputPassword = By.XPath("//input[@id = 'password']");

        public IWebElement ButtonLogIn => Browser._Driver.FindElement(_ButtonLogIn);
        public readonly static By _ButtonLogIn = By.XPath("//button[@type = 'submit']");
    }
}
