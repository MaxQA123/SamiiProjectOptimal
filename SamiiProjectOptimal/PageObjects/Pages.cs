using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects.EmailXitrooPage;
using SamiiProjectOptimal.PageObjects.ForgotPasswordPage;
using SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage;
using SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralFolderHeaderPage;
using SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralMessengerPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminHomePage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminLessonShedulerPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminLssnShdlrMdlWndwPg;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.EducatorsViewPage;
using SamiiProjectOptimal.PageObjects.WebSiteAdminPages.HeaderAdminWebSitePage;
using SamiiProjectOptimal.PageObjects.WebSiteParentPages.LogInPage;
using SamiiProjectOptimal.PageObjects.WebSiteParentPages.PayLessonParentPage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.EditProfilePage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.Header;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.PayLessonStudentPage;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ResetPasswordPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.EditProfilePage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.HeaderTeacherPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.LogInTeacher;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherConfirmCodePage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherCreateAccountPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLessonShedulerPage;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLssnShdlrMdlWndw;
using SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherProfileSetUpPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SamiiProjectOptimal.Additional.Input;

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
        public static PayLessonStudent PayLessonStudent => GetPage<PayLessonStudent>();
        public static LogInTeacher LogInTeacher => GetPage<LogInTeacher>();
        public static CreateAccountStudent CreateAccountStudent => GetPage<CreateAccountStudent>();
        public static TeacherCreateAccount TeacherCreateAccount => GetPage<TeacherCreateAccount>();
        public static EmailXitroo EmailXitroo => GetPage<EmailXitroo>();
        public static ConfirmationCodeStudent ConfirmationCodeStudent => GetPage<ConfirmationCodeStudent>();
        public static TeacherConfirmCode TeacherConfirmCode => GetPage<TeacherConfirmCode>();
        public static HeaderTeacher HeaderTeacher => GetPage<HeaderTeacher>();
        public static HeaderAdminWebSite HeaderAdminWebSite => GetPage<HeaderAdminWebSite>();
        public static HeaderStudent HeaderStudent => GetPage<HeaderStudent>();
        public static TeacherLessonSheduler TeacherLessonSheduler => GetPage<TeacherLessonSheduler>();
        public static AdminLessonSheduler AdminLessonSheduler => GetPage<AdminLessonSheduler>();
        public static TeacherLssnShdlrMdlWndw TeacherLssnShdlrMdlWndw => GetPage<TeacherLssnShdlrMdlWndw>();
        public static AdminLssnShdlrMdlWndwPg AdminLssnShdlrMdlWndwPg => GetPage<AdminLssnShdlrMdlWndwPg>();
        public static AdminHome AdminHome => GetPage<AdminHome>();
        public static Scrolling Scrolling => GetPage<Scrolling>();
        public static EducatorsView EducatorsView => GetPage<EducatorsView>();
        public static StudentProfileSetUp StudentProfileSetUp => GetPage<StudentProfileSetUp>();
        public static GeneralFolderMultirole GeneralFolderMultirole => GetPage<GeneralFolderMultirole>();
        public static ForgotPassword ForgotPassword => GetPage<ForgotPassword>();
        public static ResetPassword ResetPassword => GetPage<ResetPassword>();
        public static CycleForResetPassword CycleForResetPassword => GetPage<CycleForResetPassword>();
        public static TeacherProfileSetUp TeacherProfileSetUp => GetPage<TeacherProfileSetUp>();
        public static Click Click => GetPage<Click>();
        public static GeneralHeader GeneralHeader => GetPage<GeneralHeader>();
        public static GeneralMessenger GeneralMessenger => GetPage<GeneralMessenger>();
        public static EditProfile EditProfile => GetPage<EditProfile>();
        public static PayLessonParent PayLessonParent => GetPage<PayLessonParent>();
        public static LogInParent LogInParent => GetPage<LogInParent>();
    }
}