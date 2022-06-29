using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.EditProfilePage
{
    public partial class StudentProfileSetUp
    {
        #region StudentProfileSetupAdministratorTab

        public IWebElement IconAddAvatarCrtPrfl => Browser._Driver.FindElement(_IconAddAvatarCrtPrfl);
        public readonly static By _IconAddAvatarCrtPrfl = By.XPath("//input[@type = 'file']");

        public IWebElement FieldInputFirstNameCrtPrfl => Browser._Driver.FindElement(_FieldInputFirstNameCrtPrfl);
        public readonly static By _FieldInputFirstNameCrtPrfl = By.XPath("//input[@name = 'firstName']");

        public IWebElement FieldInputLastNameCrtPrfl => Browser._Driver.FindElement(_FieldInputLastNameCrtPrfl);
        public readonly static By _FieldInputLastNameCrtPrfl = By.XPath("//input[@name = 'lastName']");

        public IWebElement FieldInputPhoneNumberCrtPrfl => Browser._Driver.FindElement(_FieldInputPhoneNumberCrtPrfl);
        public readonly static By _FieldInputPhoneNumberCrtPrfl = By.XPath("//input[@name = 'phone']");

        public IWebElement FieldInputAddressCrtPrfl => Browser._Driver.FindElement(_FieldInputAddressCrtPrfl);
        public readonly static By _FieldInputAddressCrtPrfl = By.XPath("//input[@type = 'text']");

        public IWebElement FieldInputEmail => Browser._Driver.FindElement(_FieldInputEmail);
        public readonly static By _FieldInputEmail = By.XPath("//input[@name = 'email']");

        public IWebElement ButtonNextCrtPrfl => Browser._Driver.FindElement(_ButtonNextCrtPrfl);
        public readonly static By _ButtonNextCrtPrfl = By.XPath("//button[@class = 'btn icon grey']");

        #endregion
    }
}
