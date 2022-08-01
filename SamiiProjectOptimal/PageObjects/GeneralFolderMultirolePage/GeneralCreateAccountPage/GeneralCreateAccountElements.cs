using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralCreateAccountPage
{
    public partial class GeneralCreateAccount
    {
        public IWebElement ButtonSelectRoleParent => Browser._Driver.FindElement(_ButtonSelectRoleParent);
        public readonly static By _ButtonSelectRoleParent = By.XPath("//div[contains(text(), 'Parent')]");
    }
}
