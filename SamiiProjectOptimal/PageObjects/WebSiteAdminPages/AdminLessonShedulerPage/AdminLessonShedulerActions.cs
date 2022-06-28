using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminLessonShedulerPage
{
    public partial class AdminLessonSheduler
    {

        #region CellsOnTheLessonScheduler

        [AllureStep("ClickTwiceCell")]
        public AdminLessonSheduler ClickTwiceCell()
        {
            WaitUntil.WaitSomeInterval(10);
            CellHalfPastSixPmSecond.Click();
            WaitUntil.WaitSomeInterval(1);
            CellHalfPastSixPmSecond.Click();

            return this;
        }

        [AllureStep("ClickOnceCell")]
        public AdminLessonSheduler ClickOnceCellCellHalfPastSixPmSecond()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(CellHalfPastSixPmSecond);
            CellHalfPastSixPmSecond.Click();

            return this;
        }

        #endregion

        [AllureStep("SelectNextDay")]
        public AdminLessonSheduler SelectNextDay()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowRightSelectingDate.Click();

            return this;
        }

    }
}
