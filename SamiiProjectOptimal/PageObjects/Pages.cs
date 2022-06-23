using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects.EmailXitrooPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminHomePage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.EducatorsViewPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.HeaderAdminWebSitePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.HeaderTeacherPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.LogInTeacher;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherConfirmCodePage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherCreateAccountPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLessonShedulerPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLssnShdlrMdlWndw;
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
        public static LogInTeacher LogInTeacher => GetPage<LogInTeacher>();
        public static CreateAccountStudent CreateAccountStudent => GetPage<CreateAccountStudent>();
        public static TeacherCreateAccount TeacherCreateAccount => GetPage<TeacherCreateAccount>();
        public static EmailXitroo EmailXitroo => GetPage<EmailXitroo>();
        public static ConfirmationCodeStudent ConfirmationCodeStudent => GetPage<ConfirmationCodeStudent>();
        public static TeacherConfirmCode TeacherConfirmCode => GetPage<TeacherConfirmCode>();
        public static HeaderTeacher HeaderTeacher => GetPage<HeaderTeacher>();
        public static HeaderAdminWebSite HeaderAdminWebSite => GetPage<HeaderAdminWebSite>();
        public static TeacherLessonSheduler TeacherLessonSheduler => GetPage<TeacherLessonSheduler>();
        public static TeacherLssnShdlrMdlWndw TeacherLssnShdlrMdlWndw => GetPage<TeacherLssnShdlrMdlWndw>();
        public static AdminHome AdminHome => GetPage<AdminHome>();
        public static Scrolling Scrolling => GetPage<Scrolling>();
        public static EducatorsView EducatorsView => GetPage<EducatorsView>();

    }
}