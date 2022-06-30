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
        public IWebElement ButtonAwaitingMoveConfirmations => Browser._Driver.FindElement(_ButtonAwaitingMoveConfirmations);
        public readonly static By _ButtonAwaitingMoveConfirmations = By.XPath("//div[@class = 'align-self-end ng-star-inserted']//button[text() = ' Awaiting Move Confirmations ']");

        #region TheDateSelectorAboveTheLessonsScheduler
        public IWebElement ButtonArrowLeftSelectingDate => Browser._Driver.FindElement(_ButtonArrowLeftSelectingDate);
        public readonly static By _ButtonArrowLeftSelectingDate = By.XPath("//div[@class = 'd-flex flex-wrap justify-content-center align-items-center']//button[1]//i");

        public IWebElement ButtonArrowRightSelectingDate => Browser._Driver.FindElement(_ButtonArrowRightSelectingDate);
        public readonly static By _ButtonArrowRightSelectingDate = By.XPath("//div[@class = 'd-flex flex-wrap justify-content-center align-items-center']//button[2]");

        #endregion

        #region CellsOnTheLessonScheduler

        // Если <29 то 28 - 13PM, а если >29 то 30 - 2 : 30PM для //td[29]//div[@class = 'click-zone clickable']
        public IWebElement CellTwoPmHomeStudio => Browser._Driver.FindElement(_CellTwoPmHomeStudio);
        public readonly static By _CellTwoPmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[29]//div[@class = 'click-zone clickable']");

        public IWebElement CellHalfPastThreePmHomeStudio => Browser._Driver.FindElement(_CellHalfPastThreePmHomeStudio);
        public readonly static By _CellHalfPastThreePmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[34]//div[@class = 'click-zone clickable']");

        public IWebElement CellHalfPastEightPmHomeStudio => Browser._Driver.FindElement(_CellHalfPastEightPmHomeStudio);
        public readonly static By _CellHalfPastEightPmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[42]//div[@class = 'click-zone clickable']");

        #endregion

        #region SelectorCalendarWithTheRightSideBar

        public IWebElement ButtonArrowCalendarSideBarTop => Browser._Driver.FindElement(_ButtonArrowCalendarSideBarTop);
        public readonly static By _ButtonArrowCalendarSideBarTop = By.XPath("//div[@class = 'col-md-3 custom-date-picker ng-star-inserted']//i[@class = 'fas fa-chevron-up']");

        public IWebElement ButtonArrowCalendarSideBarBottom => Browser._Driver.FindElement(_ButtonArrowCalendarSideBarBottom);
        public readonly static By _ButtonArrowCalendarSideBarBottom = By.XPath("//div[@class = 'col-md-3 custom-date-picker ng-star-inserted']//i[@class = 'fas fa-chevron-down']");

        #endregion
    }
}