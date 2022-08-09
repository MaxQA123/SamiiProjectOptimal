using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.PayLessonStudentPage
{
    public partial class PayLessonStudent
    {
        #region ModalWindowLogInAsStudent

        public IWebElement FormPayModalWndw => Browser._Driver.FindElement(_FormPayModalWndw);
        public readonly static By _FormPayModalWndw = By.XPath("//form[@class = 'w-75 position-center ng-valid ng-star-inserted ng-dirty ng-touched']");

        public IWebElement FieldInputEmailAddressLogForPay => Browser._Driver.FindElement(_FieldInputEmailAddressLogForPay);
        public readonly static By _FieldInputEmailAddressLogForPay = By.XPath("//div[@class = 'modal-content']//input[@id = 'email']");

        public IWebElement FieldInputPasswordLogForPay => Browser._Driver.FindElement(_FieldInputPasswordLogForPay);
        public readonly static By _FieldInputPasswordLogForPay = By.XPath("//input[@id = 'password']");

        public IWebElement ButtonShowLogForPay => Browser._Driver.FindElement(_ButtonShowLogForPay);
        public readonly static By _ButtonShowLogForPay = By.XPath("//span[@class = 'show']//i");

        public IWebElement ButtonLogInLogForPayy => Browser._Driver.FindElement(_ButtonLogInLogForPay);
        public readonly static By _ButtonLogInLogForPay = By.XPath("//form[@class = 'w-75 position-center ng-valid ng-star-inserted ng-dirty ng-touched']//div[3]//button");

        #endregion

        #region PageEnrolInALessonTabDetailsVersion1.0

        public IWebElement ButtonNextPayLssnStdntDtlsTab => Browser._Driver.FindElement(_ButtonNextPayLssnStdntDtlsTab);
        public readonly static By _ButtonNextPayLssnStdntDtlsTab = By.XPath("//div[@class = 'd-flex justify-content-between button-area']//button[2]");

        #endregion

        #region PageEnrolInALessonTabDetailsVersion2.0

        public IWebElement ButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab => Browser._Driver.FindElement(_ButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab);
        public readonly static By _ButtonCloseForMdlWndwTenLessonsInadvancePayLssnStdntDtlsTab = By.XPath("//div[@class = 'time-slot-create-container']//i[@class = 'fas fa-times fa-lg']");

        #endregion

        #region PageEnrolInALessonTabConfirmation

        public IWebElement CheckBoxIAgreeToTheTermsAndConditions => Browser._Driver.FindElement(_CheckBoxIAgreeToTheTermsAndConditions);
        public readonly static By _CheckBoxIAgreeToTheTermsAndConditions = By.XPath("//input[@class = 'form-check-input ng-untouched ng-pristine ng-valid']");

        public IWebElement ButtonNextPayLssnStdntCnfrmtnTab => Browser._Driver.FindElement(_ButtonNextPayLssnStdntCnfrmtnTab);
        public readonly static By _ButtonNextPayLssnStdntCnfrmtnTab = By.XPath("//app-booking-confirmation//div[@class = 'd-flex justify-content-between button-area']//button[contains(text(), 'Next')]");

        #endregion

        #region PageEnrolInALessonTabPayment

        public IWebElement ButtonEnrolTabPayment => Browser._Driver.FindElement(_ButtonEnrolTabPayment);
        public readonly static By _ButtonEnrolTabPayment = By.XPath("//button[contains(text(), 'Enrol')]");

        public IWebElement RadioButtonPayForTenLessonsTabPayment => Browser._Driver.FindElement(_RadioButtonPayForTenLessonsTabPayment);
        public readonly static By _RadioButtonPayForTenLessonsTabPayment = By.XPath("//label[contains(text(), 'Pay for 10 lessons')]");

        public IWebElement RadioButtonSetUpReoccurringTabPayment => Browser._Driver.FindElement(_RadioButtonSetUpReoccurringTabPayment);
        public readonly static By _RadioButtonSetUpReoccurringTabPayment = By.XPath("//app-booking-payment[@class = 'ng-star-inserted']//div[5]//div[2]//div[2]//input");

        public IWebElement ButtonCloseMdlWndwPerLessonDdTabPayment => Browser._Driver.FindElement(_ButtonCloseMdlWndwPerLessonDdTabPayment);
        public readonly static By _ButtonCloseMdlWndwPerLessonDdTabPayment = By.XPath("//div[@class = 'time-slot-create-container']//span[@class = 'd-flex align-items-center justify-content-center']");

        public IWebElement ButtonConfirmMdlWndwYouveDone => Browser._Driver.FindElement(_ButtonConfirmMdlWndwYouveDone);
        public readonly static By _ButtonConfirmMdlWndwYouveDone = By.XPath("//i[@class = 'fas fa-check']");

        #endregion
    }
}
