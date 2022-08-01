using RimuTec.Faker;
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
        public TeacherCreateAccount EnterEmailPasswordConfirmPassword()
        {
            WaitUntil.ShouldLocate(_FieldInputUsernameEmail);
            FieldInputUsernameEmail.SendKeys(RandomGenerateData.RandomEmail(6) + NameDomen.Xitroo);
            WaitUntil.WaitSomeInterval(1);
            FieldInputPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);
            WaitUntil.WaitSomeInterval(1);
            FieldInputConfirmPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        public TeacherCreateAccount ClickSignUpButton()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonSignUpCrtAccnt.Click();

            return this;
        }

        public TeacherCreateAccount ClickIconShowPassword()
        {
            WaitUntil.WaitSomeInterval(1);
            IconShowPassword.Click();

            return this;
        }

        public string CopyEmailFromCrtAccntPg()
        {
            WaitUntil.WaitSomeInterval(1);
            string getemail = Browser._Driver.FindElement(_FieldInputUsernameEmail).GetAttribute("value");
            string email = getemail.ToLower();

            return email;
        }

        #region TeacherProfileSetupAdministratorTab

        public TeacherCreateAccount EnterFirstLastNameAddressPhone()
        {
            WaitUntil.ShouldLocate(_FieldInputTeacherFirstName);
            FieldInputTeacherFirstName.SendKeys(Name.FirstName());
            WaitUntil.WaitSomeInterval(1);
            FieldInputTeacherLastName.SendKeys(Name.LastName());
            WaitUntil.WaitSomeInterval(1);
            FieldInputTeachingAddress.SendKeys(Address.FullAddress());
            WaitUntil.WaitSomeInterval(1);
            FieldInputTeacherPhoneNumber.SendKeys(CountryCode.russia + RandomGenerateData.RandomPhoneNumber);

            return this;
        }

        public TeacherCreateAccount SelectInstrument()
        {
            WaitUntil.ShouldLocate(_FieldInputTeacherAllInstrumentsTaughte);
            FieldInputTeacherAllInstrumentsTaughte.Click();
            WaitUntil.ShouldLocate(_ButtonInstrumentAccompanistTeacher);
            ButtonInstrumentAccompanistTeacher.Click();

            return this;
        }

        public TeacherCreateAccount ScrollToFieldDateOfBirth()
        {
            WaitUntil.ShouldLocate(_FieldInputTeacherDateOfBirth);
            Scrolling.ScrollToElement(FieldInputTeacherDateOfBirth);

            return this;
        }

        public TeacherCreateAccount EnterForTeacherDateOfBirth()
        {
            Input.InputFunctionWithClear(FieldInputTeacherDateOfBirth, "15/04/1985");

            return this;
        }

        public TeacherCreateAccount CkickOnCheckBoxShowLessonPriceRange()
        {
            WaitUntil.ElementIsClickable(CheckBoxShowLessonPriceRange);
            CheckBoxShowLessonPriceRange.Click();

            return this;
        }

        public TeacherCreateAccount ClickButtonNextStep()
        {
            WaitUntil.ShouldLocate(_ButtonTeacherNextStepButton);
            ButtonTeacherNextStepButton.Click();

            return this;
        }

        #endregion
    }
}