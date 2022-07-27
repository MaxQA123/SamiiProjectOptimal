using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.Header
{
    public partial class HeaderStudent
    {
        [AllureStep("ClickArrowDropDownMenu")]
        public HeaderStudent ClickArrowDropDownMenu()
        {
            WaitUntil.WaitSomeInterval(3);
            ArrowDropDownMenu.Click();

            return this;
        }

        #region DropDownMenu

        [AllureStep("ClickItemEditProfileDropDown")]
        public HeaderStudent ClickItemEditProfileDropDown()
        {
            WaitUntil.WaitSomeInterval(5);
            ItemEditProfileDropDown.Click();
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("ClickItemSettingsDropDown")]
        public HeaderStudent ClickItemSettingsDropDown()
        {
            WaitUntil.ShouldLocate(_ItemSettingsDropDown);
            ItemSettingsDropDown.Click();

            return this;
        }

        [AllureStep("ClickItemLogoutDropDown")]
        public HeaderStudent ClickItemLogoutDropDown()
        {
            WaitUntil.WaitSomeInterval(1);
            ItemLogoutDropDown.Click();

            return this;
        }

        #endregion
    }
}
