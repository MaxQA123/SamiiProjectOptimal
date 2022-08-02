using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralFolderHeaderPage
{
    public partial class GeneralHeader
    {
        [AllureStep("ClickIconMessageHeader")]
        public GeneralHeader ClickIconMessageHeader()
        {
            WaitUntil.WaitSomeInterval(5);
            WaitUntil.ElementIsClickable(IconMessageHeader);
            IconMessageHeader.Click();

            return this;
        }

        [AllureStep("ClickArrowDropDownMenu")]
        public GeneralHeader ClickArrowDropDownMenu()
        {
            WaitUntil.WaitSomeInterval(3);
            ArrowDropDownMenu.Click();

            return this;
        }

        #region DropDownMenu

        [AllureStep("ClickItemParentEditProfileDropDown")]
        public GeneralHeader ClickItemParentEditProfileDropDown()
        {
            WaitUntil.WaitSomeInterval(1);
            ItemParentEditProfileDropDown.Click();

            return this;
        }

        [AllureStep("ClickItemStudentEditProfileDropDown")]
        public GeneralHeader ClickItemStudentEditProfileDropDown()
        {
            WaitUntil.WaitSomeInterval(5);
            ItemStudentEditProfileDropDown.Click();
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("ClickItemTeacherEditProfileDropDown")]
        public GeneralHeader ClickItemTeacherEditProfileDropDown()
        {
            WaitUntil.WaitSomeInterval(5);
            ItemTeacherEditProfileDropDown.Click();
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("ClickItemSettingsDropDown")]
        public GeneralHeader ClickItemSettingsDropDown()
        {
            WaitUntil.ShouldLocate(_ItemSettingsDropDown);
            ItemSettingsDropDown.Click();

            return this;
        }

        [AllureStep("ClickButtonItemLessonSheduler")]
        public GeneralHeader ClickButtonItemLessonSheduler()
        {
            WaitUntil.ShouldLocate(_ButtonItemLessonSheduler);
            ButtonItemLessonSheduler.Click();

            return this;
        }

        [AllureStep("ClickButtonItemProfileSettings")]
        public GeneralHeader ClickButtonItemProfileSettings()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ShouldLocate(_ButtonItemProfileSettings);
            ButtonItemProfileSettings.Click();

            return this;
        }

        [AllureStep("ClickItemLogoutDropDown")]
        public GeneralHeader ClickItemLogoutDropDown()
        {
            WaitUntil.WaitSomeInterval(1);
            ItemLogoutDropDown.Click();

            return this;
        }

        #endregion
    }
}
