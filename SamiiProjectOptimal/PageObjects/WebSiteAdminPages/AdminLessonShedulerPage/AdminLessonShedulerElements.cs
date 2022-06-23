using OpenQA.Selenium;
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
        public IWebElement ButtonAwaitingMoveConfirmations => Browser._Driver.FindElement(_ButtonAwaitingMoveConfirmations);
        public readonly static By _ButtonAwaitingMoveConfirmations = By.XPath("//div[@class = 'align-self-end ng-star-inserted']//button[1]");

        #region TheDateSelectorAboveTheLessonsScheduler
        public IWebElement ButtonArrowLeftSelectingDate => Browser._Driver.FindElement(_ButtonArrowLeftSelectingDate);
        public readonly static By _ButtonArrowLeftSelectingDate = By.XPath("//div[@class = 'd-flex flex-wrap justify-content-center align-items-center']//button[1]//i");

        public IWebElement ButtonArrowRightSelectingDate => Browser._Driver.FindElement(_ButtonArrowRightSelectingDate);
        public readonly static By _ButtonArrowRightSelectingDate = By.XPath("//div[@class = 'd-flex flex-wrap justify-content-center align-items-center']//button[2]");

        #endregion

        #region CellsOnTheLessonScheduler

        // Если <29 то 28 - 13PM, а если >29 то 30 - 2 : 30PM для //td[29]//div[@class = 'click-zone clickable']
        public IWebElement CellHalfPastSixPmSecond => Browser._Driver.FindElement(_CellHalfPastSixPmSecond);
        public readonly static By _CellHalfPastSixPmSecond = By.XPath("//tr[@class = 'ng-star-inserted'][2]//td[38]//div[@class = 'click-zone clickable']");

        public IWebElement CellHalfPastThreePmHomeStudio => Browser._Driver.FindElement(_CellHalfPastThreePmHomeStudio);
        public readonly static By _CellHalfPastThreePmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[34]//div[@class = 'click-zone clickable']");

        public IWebElement CellHalfPastEightPmHomeStudio => Browser._Driver.FindElement(_CellHalfPastEightPmHomeStudio);
        public readonly static By _CellHalfPastEightPmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[42]//div[@class = 'click-zone clickable']");

        #endregion
    }
}
