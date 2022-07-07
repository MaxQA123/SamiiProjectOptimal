using NUnit.Allure.Attributes;
using OpenQA.Selenium;
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
        [AllureStep("ClickBtnAwaitingMoveConfirmations")]
        public TeacherLessonSheduler ClickBtnAwaitingMoveConfirmations()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(ButtonAwaitingMoveConfirmations);
            ButtonAwaitingMoveConfirmations.Click();

            return this;
        }

        #region TheDateSelectorAboveTheLessonsScheduler

        [AllureStep("ClickArrowLeft")]
        public TeacherLessonSheduler ClickArrowLeft()
        {
            WaitUntil.WaitSomeInterval(10);
            WaitUntil.ShouldLocate(_ButtonArrowLeftSelectingDate);
            ButtonArrowLeftSelectingDate.Click();

            return this;
        }

        [AllureStep("ClickArrowRight")]
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

        #region ScrollingOnPage

        [AllureStep("ScrollToCellElevenPmShdlrPg")]
        public TeacherLessonSheduler ScrollToCellElevenPmShdlrPg()
        {
            WaitUntil.ShouldLocate(_CellElevenPmLessonShedulerPage);
            Scrolling.ScrollToElement(CellElevenPmLessonShedulerPag);

            return this;
        }

        #endregion

        public TeacherLessonSheduler OpenPopUpForCreatelesson(int timeSlot, string location)
        {
            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

            _shedulerLessonPage[timeSlot].Click();
            _shedulerLessonPage[timeSlot].Click();

            return this;
        }

        public TeacherLessonSheduler OpenPopUpForDeletelesson(int timeSlot, string location)
        {
            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

            _shedulerLessonPage[timeSlot].Click();

            return this;
        }
    }
}
