using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminHomePage
{
    public partial class AdminHome
    {
        public IWebElement CurrentNameAdmin => Browser._Driver.FindElement(_CurrentNameAdmin);
        public readonly static By _CurrentNameAdmin = By.XPath("//li[text() = ' Pete Barter']");

        #region PaginationsForTables

        public IWebElement PaginationForTableEducator => Browser._Driver.FindElement(_PaginationForTableEducator);
        public readonly static By _PaginationForTableEducator = By.XPath("//nav[@class = 'pagination ng-star-inserted']");

        #endregion

        #region TableEducator

        public IWebElement ButtonDetailsTestTeacher => Browser._Driver.FindElement(_ButtonDetailsTestTeacher);
        public readonly static By _ButtonDetailsTestTeacher = By.XPath("//table[@class = 'table table-hover']//tr[6]//td[12]//button");

        #endregion
    }
}