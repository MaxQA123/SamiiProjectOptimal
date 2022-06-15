using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects.EmailXitrooPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static LogInAdmin LogInAdmin => GetPage<LogInAdmin>();
        public static LogInStudent LogInStudent => GetPage<LogInStudent>();
        public static CreateAccountStudent CreateAccountStudent => GetPage<CreateAccountStudent>();
        public static EmailXitroo EmailXitroo => GetPage<EmailXitroo>();

    }
}