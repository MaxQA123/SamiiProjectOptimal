using OpenQA.Selenium;
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
        public IWebElement IconMessageHeader => Browser._Driver.FindElement(_IconMessageHeader);
        public readonly static By _IconMessageHeader = By.XPath("//i[@class = 'far fa-comment messanger-icon']");

        public IWebElement ArrowDropDownMenu => Browser._Driver.FindElement(_ArrowDropDownMenu);
        public readonly static By _ArrowDropDownMenu = By.XPath("//i[@class = 'fas fa-angle-down']");

        #region DropDownMenu

        public IWebElement ItemFindATeacherDropDown => Browser._Driver.FindElement(_ItemFindATeacherDropDown);
        public readonly static By _ItemFindATeacherDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/teacher/search']a");

        public IWebElement ItemDashDropDown => Browser._Driver.FindElement(_ItemDashDropDown);
        public readonly static By _ItemDashDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/student/dashboard']");

        public IWebElement ItemStudentEditProfileDropDown => Browser._Driver.FindElement(_ItemStudentEditProfileDropDown);
        public readonly static By _ItemStudentEditProfileDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/student/profile/create']");

        public IWebElement ItemParentEditProfileDropDown => Browser._Driver.FindElement(_ItemParentEditProfileDropDown);
        public readonly static By _ItemParentEditProfileDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/parent/profile/create']");

        public IWebElement ItemTeacherEditProfileDropDown => Browser._Driver.FindElement(_ItemTeacherEditProfileDropDown);
        public readonly static By _ItemTeacherEditProfileDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/teacher/profile/228/view']");

        public IWebElement ItemSettingsDropDown => Browser._Driver.FindElement(_ItemSettingsDropDown);
        public readonly static By _ItemSettingsDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/change-password']");

        public IWebElement ItemMessengerDropDown => Browser._Driver.FindElement(_ItemMessengerDropDown);
        public readonly static By _ItemMessengerDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/messenger']");

        public IWebElement ButtonItemLessonSheduler => Browser._Driver.FindElement(_ButtonItemLessonSheduler);
        public readonly static By _ButtonItemLessonSheduler = By.XPath("//div[@class = 'dropdown-menu show']//a[@href = '#/lesson/dashboard']");

        public IWebElement ButtonItemProfileSettings => Browser._Driver.FindElement(_ButtonItemProfileSettings);
        public readonly static By _ButtonItemProfileSettings = By.XPath("//div[@class = 'dropdown-menu show']//a[@href = '#/teacher/profile/create/step/setup']");

        public IWebElement ItemLogoutDropDown => Browser._Driver.FindElement(_ItemLogoutDropDown);
        public readonly static By _ItemLogoutDropDown = By.XPath("//div[@class = 'dropdown-menu show']//a[text() = 'Logout']");

        #endregion
    }
}
