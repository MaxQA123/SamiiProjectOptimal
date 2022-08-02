using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.ProfileSetUpPage
{
    public partial class ParentProfileSetUp
    {
        public IWebElement FieldInputEmailFromParentProfileSetUp => Browser._Driver.FindElement(_FieldInputEmailFromParentProfileSetUp);
        public readonly static By _FieldInputEmailFromParentProfileSetUp = By.XPath("//input[@name = 'email']");

        public IWebElement FIeldInputEmailLogInPg => Browser._Driver.FindElement(_FIeldInputEmailLogInPg);
        public readonly static By _FIeldInputEmailLogInPg = By.XPath("//input[@id = 'email']");
    }
}
