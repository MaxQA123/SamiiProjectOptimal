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
        //tbody[@id = 'mailList']//th[text() = '1']
        //th[text() = '1']
        public IWebElement SelectLetterNumberOneNew => Browser._Driver.FindElement(_SelectLetterNumberOneNew);
        public readonly static By _SelectLetterNumberOneNew = By.XPath("//tbody[@id = 'mailList']//th[text() = '1']");

        public IWebElement VerificationCodeXitroo => Browser._Driver.FindElement(_VerificationCodeXitroo);
        public readonly static By _VerificationCodeXitroo = By.XPath("//div[contains(text(), 'Verification code:')]");
    }
}