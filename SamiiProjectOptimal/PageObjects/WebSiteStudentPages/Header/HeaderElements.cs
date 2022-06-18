using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.Header
{
    public partial class HeaderStudent
    {
        //ul[@class = 'navbar-nav right desktop']//span[contains(text(), 'Hi')]
        //ul[@class = 'navbar-nav right desktop']//span//strong
        public IWebElement FieldHiUsernameHdr => Browser._Driver.FindElement(_FieldHiUsernameHdr);
        public readonly static By _FieldHiUsernameHdr = By.XPath("//ul[@class = 'navbar-nav right desktop']//span[contains(text(), 'Hi')]");
    }
}
