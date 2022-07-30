using OpenQA.Selenium;
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
        public IWebElement FIeldInputEmailLogInPg => Browser._Driver.FindElement(_FIeldInputEmailLogInPg);
        public readonly static By _FIeldInputEmailLogInPg = By.XPath("//input[@id = 'email']");

        public IWebElement FIeldInputPasswordLogInPg => Browser._Driver.FindElement(_FIeldInputPasswordLogInPg);
        public readonly static By _FIeldInputPasswordLogInPg = By.XPath("//input[@id = 'password']");

        public IWebElement ButtonLogIn => Browser._Driver.FindElement(_ButtonLogIn);
        public readonly static By _ButtonLogIn = By.XPath("//button[@type = 'submit']");
    }
}
