using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.HeaderTeacherPage
{
    public partial class HeaderTeacher
    {
        public HeaderTeacher ClickArrowDropDown()
        {
            WaitUntil.ShouldLocate(_ArrowDropDownMenu);
            ArrowDropDownMenu.Click();

            return this;
        }

        #region DropDownMenu

        public HeaderTeacher ClickButtonItemLessonSheduler()
        {
            WaitUntil.ShouldLocate(_ButtonItemLessonSheduler);
            ButtonItemLessonSheduler.Click();

            return this;
        }

        #endregion
    }
}
