using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.EducatorsViewPage
{
    public partial class EducatorsView
    {
        public IWebElement ButtonImpersonateEducatorView => Browser._Driver.FindElement(_ButtonImpersonateEducatorView);
        public readonly static By _ButtonImpersonateEducatorView = By.XPath("//div[@class = 'd-flex align-items-center justify-content-between']//div[4]//div//button[1]");
    }
}
