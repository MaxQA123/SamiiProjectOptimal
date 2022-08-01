using NUnit.Allure.Attributes;
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
        [AllureStep("SelectRoleParent")]
        public GeneralCreateAccount SelectRoleParent()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(ButtonSelectRoleParent);
            ButtonSelectRoleParent.Click();

            return this;
        }
    }
}
