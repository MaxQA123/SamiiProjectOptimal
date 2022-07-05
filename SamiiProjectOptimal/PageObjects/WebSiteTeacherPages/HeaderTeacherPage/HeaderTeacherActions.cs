using NUnit.Allure.Attributes;
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
        [AllureStep("ClickArrowDropDown")]
        public HeaderTeacher ClickArrowDropDown()
        {
            WaitUntil.ShouldLocate(_ArrowDropDownMenu);
            ArrowDropDownMenu.Click();

            return this;
        }

        #region DropDownMenu

        [AllureStep("ClickButtonItemProfileSettings")]
        public HeaderTeacher ClickButtonItemProfileSettings()
        {
            WaitUntil.ShouldLocate(_ButtonItemProfileSettings);
            ButtonItemProfileSettings.Click();

            return this;
        }

        [AllureStep("ClickButtonItemLessonSheduler")]
        public HeaderTeacher ClickButtonItemLessonSheduler()
        {
            WaitUntil.ShouldLocate(_ButtonItemLessonSheduler);
            ButtonItemLessonSheduler.Click();

            return this;
        }

        #endregion
    }
}
