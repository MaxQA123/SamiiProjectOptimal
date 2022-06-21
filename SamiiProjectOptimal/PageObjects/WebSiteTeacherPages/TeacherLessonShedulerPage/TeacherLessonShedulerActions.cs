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
        public TeacherLessonSheduler ClickBtnAwaitingMoveConfirmations()
        {
            WaitUntil.ElementIsClickable(ButtonAwaitingMoveConfirmations);
            ButtonAwaitingMoveConfirmations.Click();

            return this;
        }

        #region TheDateSelectorAboveTheLessonsScheduler

        public TeacherLessonSheduler ClickArrowLeft()
        {
            WaitUntil.WaitSomeInterval(10);
            WaitUntil.ShouldLocate(_ButtonArrowLeftSelectingDate);
            ButtonArrowLeftSelectingDate.Click();

            return this;
        }

        public TeacherLessonSheduler ClickArrowRight()
        {
            WaitUntil.WaitSomeInterval(10);
            WaitUntil.ElementIsClickable(ButtonArrowRightSelectingDate);
            ButtonArrowRightSelectingDate.Click();

            return this;
        }

        #endregion

        #region CellsOnTheLessonScheduler

        public TeacherLessonSheduler ClickTwiceCell()
        {
            WaitUntil.WaitSomeInterval(10);
            CellHalfPastEightPmHomeStudio.Click();
            WaitUntil.WaitSomeInterval(1);
            CellHalfPastEightPmHomeStudio.Click();

            return this;
        }

        public TeacherLessonSheduler ClickOnceCell()
        {
            WaitUntil.WaitSomeInterval(3);
            CellHalfPastEightPmHomeStudio.Click();

            return this;
        }

        #endregion
    }
}
