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

        [AllureStep("ClickButtonThreeOnPgntnEducator")]
        public AdminHome ClickButtonThreeOnPgntnEducator()
        {
            WaitUntil.ShouldLocate(_ButtonThreePagination);
            ButtonThreePagination.Click();

            return this;
        }

        #endregion

        #region TableEducator

        public AdminHome ClickButtonDetailsTestTeacher()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ShouldLocate(_ButtonDetailsTestTeacher);
            ButtonDetailsTestTeachern.SendKeys("");
            WaitUntil.WaitSomeInterval(1);
            ButtonDetailsTestTeachern.Click();

            return this;

        #endregion
        }
    }
}