using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage
{
    public partial class GeneralFolderMultirole
    {
        #region LogInPage

        [AllureStep("ClickLinkForgotPassword")]
        public GeneralFolderMultirole ClickLinkForgotPassword()
        {
            WaitUntil.ShouldLocate(_LinkForgotPassword);
            LinkForgotPassword.Click();

            return this;
        }

        [AllureStep("EnterEmailLogInAfterRstPsswrf")]
        public GeneralFolderMultirole EnterEmailLogInAfterRstPsswrf()
        {
            WaitUntil.ShouldLocate(_FIeldInputEmailLogInPg);
            FIeldInputEmailLogInPg.SendKeys(Credentials.emailForgotPassword);

            return this;

        }

        [AllureStep("EnterCopiedPasswordFromRstPsswrd")]
        public GeneralFolderMultirole EnterCopiedPasswordFromRstPsswrd(string password)
        {
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPasswordLogInPg.SendKeys(password);

            return this;
        }

        [AllureStep("EnterCopiedPasswordFromTabAvlbRsrcsTchrPrflStp")]
        public GeneralFolderMultirole EnterCopiedPasswordFromTabAvlbRsrcsTchrPrflStp(string password)
        {
            WaitUntil.WaitSomeInterval(1);
            FIeldInputPasswordLogInPg.SendKeys(password);

            return this;
        }

        #endregion
    }
}
