using OpenQA.Selenium;
using RimuTec.Faker;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage
{
    public partial class CreateAccountStudent
    {
        public CreateAccountStudent EnterEmailPasswordCnfrmPsswrd()
        {
            WaitUntil.ShouldLocate(_FieldInputUsernameEmail);
            FieldInputUsernameEmail.SendKeys(RandomGenerateData.RandomEmail(6) + NameDomen.Xitroo);
            WaitUntil.WaitSomeInterval(1);
            FieldInputPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);
            WaitUntil.WaitSomeInterval(1);
            FieldInputConfirmPasswordCrtAccnt.SendKeys(Credentials.passwordTeacherOne);

            return this;
        }

        public CreateAccountStudent ClickSignUpButtonCrtAccnt()
        {
            ButtonSignUpCrtAccntt.Click();

            return this;
        }

        #region ContinueRegistrationAfterConfirmEmail

        public CreateAccountStudent ClickButtonRoleStudent()
        {
            WaitUntil.ShouldLocate(_ButtonSelectRoleStudent);
            ButtonSelectRoleStudent.Click();

            return this;
        }

        #endregion

        #region StudentProfileSetupAdministratorTab

        public CreateAccountStudent EnterFirslastNamePhoneAddress()
        {
            WaitUntil.ShouldLocate(_FieldInputFirstNameCrtPrfl);
            FieldInputFirstNameCrtPrfl.SendKeys(Name.FirstName());
            WaitUntil.WaitSomeInterval(1);
            FieldInputLastNameCrtPrfl.SendKeys(Name.LastName());
            WaitUntil.WaitSomeInterval(1);
            FieldInputPhoneNumberCrtPrfl.SendKeys(CountryCode.russia + RandomGenerateData.RandomPhoneNumber(10));
            WaitUntil.WaitSomeInterval(1);
            FieldInputAddressCrtPrfl.SendKeys(Address.FullAddress());
            Thread.Sleep(5000);

            return this;
        }

        public CreateAccountStudent UploadImage()
        {
            WaitUntil.WaitSomeInterval(3);
            IconAddAvatarCrtPrfl.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.avatarStudent));

            return this;
        }

        public CreateAccountStudent ClickNextButton()
        {
            WaitUntil.ElementIsClickable(ButtonNextCrtPrfl);
            ButtonNextCrtPrfl.Click();

            return this;
        }

        #endregion

        #region StudentProfileSetupBillingTab

        public CreateAccountStudent ClickCompleteButton()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(ButtonCompleteBillingCrtAccnt, 60);
            ButtonCompleteBillingCrtAccnt.Click();

            return this;
        }

        #endregion

        #region EditImagePageAfterUploadAvatar

        public CreateAccountStudent ClickButtonDone()
        {
            WaitUntil.ShouldLocate(_ButtonDoneCrtAccnt);
            ButtonDoneCrtAccntt.Click();

            return this;
        }

        #endregion

    }

}