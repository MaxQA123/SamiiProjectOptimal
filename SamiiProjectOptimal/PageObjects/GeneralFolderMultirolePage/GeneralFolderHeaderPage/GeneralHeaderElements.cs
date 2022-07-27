using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralFolderHeaderPage
{
    public partial class GeneralHeader
    {
        public IWebElement IconMessageHeader => Browser._Driver.FindElement(_IconMessageHeader);
        public readonly static By _IconMessageHeader = By.XPath("//i[@class = 'far fa-comment messanger-icon']");
    }
}
