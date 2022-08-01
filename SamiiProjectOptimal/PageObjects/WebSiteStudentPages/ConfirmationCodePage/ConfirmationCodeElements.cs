using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage
{
    public partial class ConfirmationCodeStudent
    {
        public IWebElement FieldInputConfirmCode => Browser._Driver.FindElement(_FieldInputConfirmCode);
        public readonly static By _FieldInputConfirmCode = By.XPath("//input[@formcontrolname = 'code']");

        public IWebElement ButtonNextConfirmCode => Browser._Driver.FindElement(_ButtonNextConfirmCode);
        public readonly static By _ButtonNextConfirmCode = By.XPath("//button[text() = ' Next ']");
    }
}