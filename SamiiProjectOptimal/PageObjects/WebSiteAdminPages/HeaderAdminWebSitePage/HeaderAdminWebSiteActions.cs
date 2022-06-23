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
        public HeaderAdminWebSite ClickArrowDropDown()
        {
            WaitUntil.ShouldLocate(_ArrowDropDownMenu);
            ArrowDropDownMenu.Click();

            return this;
        }

        public HeaderAdminWebSite ClickButtonItemLessonSheduler()
        {
            WaitUntil.ShouldLocate(_ButtonItemLessonSheduler);
            ButtonItemLessonSheduler.Click();

            return this;
        }
    }
}
