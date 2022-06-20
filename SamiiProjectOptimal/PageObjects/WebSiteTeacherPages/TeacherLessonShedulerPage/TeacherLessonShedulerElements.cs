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
        #region CellsOnTheLessonScheduler

        // Если <29 то 28 - 13PM, а если >29 то 30 - 2 : 30PM для //td[29]//div[@class = 'click-zone clickable']
        public IWebElement CellTwoPmHomeStudio => Browser._Driver.FindElement(_CellTwoPmHomeStudio);
        public readonly static By _CellTwoPmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[29]//div[@class = 'click-zone clickable']");

        public IWebElement CellHalfPastThreePmHomeStudio => Browser._Driver.FindElement(_CellHalfPastThreePmHomeStudio);
        public readonly static By _CellHalfPastThreePmHomeStudio = By.XPath("//div[@class = 'timeline-container']//td[34]//div[@class = 'click-zone clickable']");

        #endregion
    }
}
