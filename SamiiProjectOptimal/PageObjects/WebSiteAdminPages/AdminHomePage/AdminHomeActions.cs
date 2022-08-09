using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminHomePage
{
    public partial class AdminHome
    {
        [AllureStep("ScrollToDownHomePage")]
        public AdminHome ScrollToDownHomePage()
        {
            WaitUntil.WaitSomeInterval(1);
            Scrolling.ScrollToDownWebPage();

            return this;
        }

        #region PaginationsForTables

        [AllureStep("ScrollToPaginationEducatorTbl")]
        public AdminHome ScrollToPaginationEducatorTbl()
        {
            WaitUntil.ShouldLocate(_PaginationForTableEducator);
            Scrolling.ScrollToElement(PaginationForTableEducator);

            return this;
        }

        #endregion

        #region TableEducator

        [AllureStep("ClickButtonDetailsTestTeacher")]
        public AdminHome ClickButtonDetailsTestTeacher()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ShouldLocate(_ButtonDetailsTestTeacher);
            ButtonDetailsTestTeacher.SendKeys("");
            WaitUntil.WaitSomeInterval(1);
            ButtonDetailsTestTeacher.Click();

            return this;

        #endregion
        }
    }
}