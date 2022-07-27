using NUnit.Allure.Attributes;
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
        [AllureStep("ClickIconMessageHeader")]
        public GeneralHeader ClickIconMessageHeader()
        {
            WaitUntil.WaitSomeInterval(5);
            WaitUntil.ElementIsClickable(IconMessageHeader);
            IconMessageHeader.Click();

            return this;
        }
    }
}
