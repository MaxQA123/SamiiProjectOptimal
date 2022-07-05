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
        [AllureStep("ClickTabPasswordTchrPrflStp")]
        public TeacherProfileSetUp ClickTabPasswordTchrPrflStp()
        {
            WaitUntil.WaitSomeInterval(1);
            TabPasswordTchrPrflStp.Click();

            return this;
        }

        [AllureStep("ClickTabAvailableResourcesTchrPrflStp")]
        public TeacherProfileSetUp ClickTabAvailableResourcesTchrPrflStp()
        {
            WaitUntil.WaitSomeInterval(1);
            TabAvailableResourcesTchrPrflStp.Click();

            return this;
        }

        #region TabPassword

        [AllureStep("ClickBothIconShow")]
        public TeacherProfileSetUp ClickBothIconShowTchrPrflStp()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowCurrentPsswrdTabPsswrdTchrPrflStp.Click();
            WaitUntil.WaitSomeInterval(1);
            IconShowPsswrdTabPsswrdTchrPrflStp.Click();

            return this;
        }

        #endregion

        #region TabAvailableResources

        [AllureStep("ClickButtonCompleteAvlbRsrcsTchrPrflStp")]
        public TeacherProfileSetUp ClickButtonCompleteAvlbRsrcsTchrPrflStp()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonCompleteAvlbRsrcsTchrPrflStp.Click();

            return this;
        }

        #endregion
    }
}
