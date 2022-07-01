using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.HeaderAdminWebSitePage
{
    public partial class HeaderAdminWebSite
    {
        public IWebElement ArrowDropDownMenu => Browser._Driver.FindElement(_ArrowDropDownMenu);
        public readonly static By _ArrowDropDownMenu = By.XPath("//i[@class = 'fas fa-angle-down']");

        #region DropDownMenu

        public IWebElement ButtonItemLessonSheduler => Browser._Driver.FindElement(_ButtonItemLessonSheduler);
        public readonly static By _ButtonItemLessonSheduler = By.XPath("//div[@class = 'dropdown-menu show']//a[@href= '#/lesson/dashboard']");

        public IWebElement ButtonItemLogout => Browser._Driver.FindElement(_ButtonItemLogout);
        public readonly static By _ButtonItemLogout = By.XPath("//div[@class = 'dropdown-menu show']//a[text()= 'Logout']");

        #endregion
    }
}
