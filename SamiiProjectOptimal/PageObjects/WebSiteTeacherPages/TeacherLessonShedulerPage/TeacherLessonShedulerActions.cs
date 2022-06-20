using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLessonShedulerPage
{
    public partial class TeacherLessonSheduler
    {
        #region CellsOnTheLessonScheduler

        public TeacherLessonSheduler ClickCellTwoPmHomeStudio()
        {
            WaitUntil.WaitSomeInterval(10);
            CellHalfPastEightPmHomeStudio.Click();
            WaitUntil.WaitSomeInterval(1);
            CellHalfPastEightPmHomeStudio.Click();

            return this;
        }

        #endregion
    }
}
