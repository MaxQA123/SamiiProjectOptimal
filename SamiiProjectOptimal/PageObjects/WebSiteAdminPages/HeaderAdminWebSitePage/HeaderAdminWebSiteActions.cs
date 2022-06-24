using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.HeaderAdminWebSitePage
{
    public partial class HeaderAdminWebSite
    {
        [AllureStep("ClickArrowDropDown")]
        public HeaderAdminWebSite ClickArrowDropDown()
        {
            WaitUntil.ShouldLocate(_ArrowDropDownMenu);
            ArrowDropDownMenu.Click();

            return this;
        }

        [AllureStep("ClickButtonItemLessonSheduler")]
        public HeaderAdminWebSite ClickButtonItemLessonSheduler()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ShouldLocate(_ButtonItemLessonSheduler);
            ButtonItemLessonSheduler.Click();

            return this;
        }

        [AllureStep("ClickButtonLogout")]
        public HeaderAdminWebSite ClickButtonLogout()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ShouldLocate(_ButtonItemLogout);
            ButtonItemLogout.Click();

            return this;
        }
    }
}
