using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        public IWebElement IframeXitrooLetter => Browser._Driver.FindElement(_IframeXitrooLetter);
        public readonly static By _IframeXitrooLetter = By.XPath("//iframe[@id = 'mailContentFrame']");
        
        public IWebElement SelectLetterNumberOneNew => Browser._Driver.FindElement(_SelectLetterNumberOneNew);
        public readonly static By _SelectLetterNumberOneNew = By.XPath("//tbody[@id = 'mailList']//th[text() = '1']");

        public IWebElement VerificationCodeXitroo => Browser._Driver.FindElement(_VerificationCodeXitroo);
        public readonly static By _VerificationCodeXitroo = By.XPath("//div[contains(text(), 'Verification code:')]");

        public IWebElement FieldInputEmail => Browser._Driver.FindElement(_FieldInputEmail);
        public readonly static By _FieldInputEmail = By.XPath("//input[@id = 'mailInput']");

        public IWebElement ButtonSearchEmail => Browser._Driver.FindElement(_ButtonSearchEmail);
        public readonly static By _ButtonSearchEmail = By.XPath("//button[@id = 'requestButton']");
    }
}