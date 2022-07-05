using OpenQA.Selenium;
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
        public IWebElement ArrowDropDownMenu => Browser._Driver.FindElement(_ArrowDropDownMenu);
        public readonly static By _ArrowDropDownMenu = By.XPath("//i[@class = 'fas fa-angle-down']");

        #region DropDownMenu

        public IWebElement ItemFindATeacherDropDown => Browser._Driver.FindElement(_ItemFindATeacherDropDown);
        public readonly static By _ItemFindATeacherDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/teacher/search']a");

        public IWebElement ItemDashDropDown => Browser._Driver.FindElement(_ItemDashDropDown);
        public readonly static By _ItemDashDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/student/dashboard']");

        public IWebElement ItemEditProfileDropDown => Browser._Driver.FindElement(_ItemEditProfileDropDown);
        public readonly static By _ItemEditProfileDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/student/profile/create']");

        public IWebElement ItemSettingsDropDown => Browser._Driver.FindElement(_ItemSettingsDropDown);
        public readonly static By _ItemSettingsDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/change-password']");

        public IWebElement ItemMessengerDropDown => Browser._Driver.FindElement(_ItemMessengerDropDown);
        public readonly static By _ItemMessengerDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/messenger']");

        public IWebElement ItemLogoutDropDown => Browser._Driver.FindElement(_ItemLogoutDropDown);
        public readonly static By _ItemLogoutDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[text() = 'Logout']");

        #endregion
    }
}
