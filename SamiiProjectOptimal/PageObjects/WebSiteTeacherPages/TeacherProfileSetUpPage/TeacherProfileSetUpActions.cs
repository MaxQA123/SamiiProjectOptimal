using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherProfileSetUpPage
{
    public partial class TeacherProfileSetUp
    {
        [AllureStep("ClickBtnAwaitingMoveConfirmations")]
        public TeacherProfileSetUp ClickTabPasswordTchrPrflStp()
        {
            WaitUntil.WaitSomeInterval(1);
            TabPasswordTchrPrflStp.Click();

            return this;
        }

        #region TabPassword

        [AllureStep("ClickBothIconShow")]
        public TeacherProfileSetUp ClickBothIconShow()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowCurrentPsswrdTabPsswrdTchrPrflStp.Click();
            WaitUntil.WaitSomeInterval(1);
            IconShowPsswrdTabPsswrdTchrPrflStp.Click();

            return this;
        }

        #endregion
    }
}
