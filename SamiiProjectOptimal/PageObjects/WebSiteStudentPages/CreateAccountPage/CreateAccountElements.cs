using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage
{
    public partial class CreateAccountStudent
    {
        public IWebElement FieldInputUsernameEmail => Browser._Driver.FindElement(_FieldInputUsernameEmail);
        public readonly static By _FieldInputUsernameEmail = By.XPath("//input[@id = 'username']");

        public IWebElement FieldInputPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputPasswordCrtAccnt);
        public readonly static By _FieldInputPasswordCrtAccnt = By.XPath("//input[@id = 'password']");

        public IWebElement FieldInputConfirmPasswordCrtAccnt => Browser._Driver.FindElement(_FieldInputConfirmPasswordCrtAccnt);
        public readonly static By _FieldInputConfirmPasswordCrtAccnt = By.XPath("//input[@id = 'confirm-password']");

        public IWebElement ButtonSignUpCrtAccntt => Browser._Driver.FindElement(_ButtonSignUpCrtAccnt);
        public readonly static By _ButtonSignUpCrtAccnt = By.XPath("//button[@type = 'submit']");

        #region ContinueRegistrationAfterConfirmEmail

        public IWebElement ButtonSelectRoleTeacher => Browser._Driver.FindElement(_ButtonSelectRoleTeacher);
        public readonly static By _ButtonSelectRoleTeacher = By.XPath("//div[@class = 'container']//div[1]//div[1]//div");

        public IWebElement ButtonSelectRoleStudent => Browser._Driver.FindElement(_ButtonSelectRoleStudent);
        public readonly static By _ButtonSelectRoleStudent = By.XPath("//div[@class = 'container']//div[1]//div[2]//div");

        #endregion

        #region StudentProfileSetupAdministratorTab

        //img[@src = 'assets/images/avatar-default.png']
        //div[@class = 'avatar-container']//div[@class = 'ng-star-inserted']
        public IWebElement IconAddAvatarCrtPrfl => Browser._Driver.FindElement(_IconAddAvatarCrtPrfl);
        public readonly static By _IconAddAvatarCrtPrfl = By.XPath("//div[@class = 'avatar-container']//div[@class = 'ng-star-inserted']");

        public IWebElement FieldInputFirstNameCrtPrfl => Browser._Driver.FindElement(_FieldInputFirstNameCrtPrfl);
        public readonly static By _FieldInputFirstNameCrtPrfl = By.XPath("//input[@name = 'firstName']");

        public IWebElement FieldInputLastNameCrtPrfl => Browser._Driver.FindElement(_FieldInputLastNameCrtPrfl);
        public readonly static By _FieldInputLastNameCrtPrfl = By.XPath("//input[@name = 'lastName']");

        public IWebElement FieldInputPhoneNumberCrtPrfl => Browser._Driver.FindElement(_FieldInputPhoneNumberCrtPrfl);
        public readonly static By _FieldInputPhoneNumberCrtPrfl = By.XPath("//input[@name = 'phone']");

        public IWebElement FieldInputAddressCrtPrfl => Browser._Driver.FindElement(_FieldInputAddressCrtPrfl);
        public readonly static By _FieldInputAddressCrtPrfl = By.XPath("//input[@type = 'text']");

        public IWebElement ButtonNextCrtPrfl => Browser._Driver.FindElement(_ButtonNextCrtPrfl);
        public readonly static By _ButtonNextCrtPrfl = By.XPath("//button[@class = 'btn icon grey']");

        #endregion
    }
}