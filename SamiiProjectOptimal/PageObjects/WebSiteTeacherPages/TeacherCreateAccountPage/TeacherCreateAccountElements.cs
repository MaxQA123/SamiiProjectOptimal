using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherCreateAccountPage
{
    public partial class TeacherCreateAccount
    {
        public IWebElement FieldInputUsernameEmail => Browser._Driver.FindElement(_FieldInputUsernameEmail);
        public readonly static By _FieldInputUsernameEmail = By.XPath("//input[@id = 'username']");

        public IWebElement FieldInputPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputPasswordCrtAccnt);
        public readonly static By _FieldInputPasswordCrtAccnt = By.XPath("//input[@id = 'password']");

        public IWebElement FieldInputConfirmPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputConfirmPasswordCrtAccnt);
        public readonly static By _FieldInputConfirmPasswordCrtAccnt = By.XPath("//input[@id = 'confirm-password']");

        public IWebElement ButtonSignUpCrtAccnt => Browser._Driver.FindElement(_ButtonSignUpCrtAccnt);
        public readonly static By _ButtonSignUpCrtAccnt = By.XPath("//button[@type = 'submit']");

        public IWebElement IconShowPassword => Browser._Driver.FindElement(_IconShowPassword);
        public readonly static By _IconShowPassword = By.XPath("//i[@class = 'fas fa-eye']");

        #region ContinueRegistrationAfterConfirmEmail

        public IWebElement ButtonSelectRoleTeacher => Browser._Driver.FindElement(_ButtonSelectRoleTeacher);
        public readonly static By _ButtonSelectRoleTeacher = By.XPath("//div[@class = 'container']//div[1]//div[1]//div");

        public IWebElement ButtonSelectRoleStudent => Browser._Driver.FindElement(_ButtonSelectRoleStudent);
        public readonly static By _ButtonSelectRoleStudent = By.XPath("//div[@class = 'container']//div[1]//div[2]//div");

        #endregion

        #region TeacherProfileSetupAdministratorTab

        public IWebElement FieldInputTeacherFirstName => Browser._Driver.FindElement(_FieldInputTeacherFirstName);
        public readonly static By _FieldInputTeacherFirstName = By.XPath("//input[@name = 'firstName']");

        public IWebElement FieldInputTeacherLastName => Browser._Driver.FindElement(_FieldInputTeacherLastName);
        public readonly static By _FieldInputTeacherLastName = By.XPath("//input[@name = 'lastName']");

        public IWebElement FieldInputTeacherAllInstrumentsTaughte => Browser._Driver.FindElement(_FieldInputTeacherAllInstrumentsTaughte);
        public readonly static By _FieldInputTeacherAllInstrumentsTaughte = By.XPath("//input[@name = 'instrument-search']");

        public IWebElement FieldInputTeachingAddress => Browser._Driver.FindElement(_FieldInputTeachingAddress);
        public readonly static By _FieldInputTeachingAddress = By.XPath("//input[@class = 'form-control client-address dropdown-toggle ng-untouched ng-pristine ng-valid']");

        public IWebElement FieldInputTeacherPhoneNumber => Browser._Driver.FindElement(_FieldInputTeacherPhoneNumber);
        public readonly static By _FieldInputTeacherPhoneNumber = By.XPath("//input[@name = 'phone']");

        public IWebElement FieldInputTeacherDateOfBirth => Browser._Driver.FindElement(_FieldInputTeacherDateOfBirth);
        public readonly static By _FieldInputTeacherDateOfBirth = By.XPath("//input[@name = 'dp']");

        public IWebElement CheckBoxShowLessonPriceRange => Browser._Driver.FindElement(_CheckBoxShowLessonPriceRange);
        public readonly static By _CheckBoxShowLessonPriceRange = By.XPath("//input[@class = 'form-control col-md-1 border-none ng-valid ng-dirty ng-touched']");

        public IWebElement LinkTeacherNextButton => Browser._Driver.FindElement(_LinkTeacherNextButton);
        public readonly static By _LinkTeacherNextButton = By.XPath("//div[@class = 'd-flex justify-content-end button-area']//button");

        #endregion

    }
}