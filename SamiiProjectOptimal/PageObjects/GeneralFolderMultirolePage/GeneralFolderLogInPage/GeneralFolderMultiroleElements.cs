using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage
{
    public partial class GeneralFolderMultirole
    {
        #region LogInPage

        public IWebElement LinkForgotPassword => Browser._Driver.FindElement(_LinkForgotPassword);
        public readonly static By _LinkForgotPassword = By.XPath("//button[@routerlink = '/forgot-password']");

        public IWebElement FIeldInputEmailLogInPg => Browser._Driver.FindElement(_FIeldInputEmailLogInPg);
        public readonly static By _FIeldInputEmailLogInPg = By.XPath("//input[@id = 'email']");

        public IWebElement FIeldInputPasswordLogInPg => Browser._Driver.FindElement(_FIeldInputPasswordLogInPg);
        public readonly static By _FIeldInputPasswordLogInPg = By.XPath("//input[@id = 'password']");

        #endregion
    }
}
