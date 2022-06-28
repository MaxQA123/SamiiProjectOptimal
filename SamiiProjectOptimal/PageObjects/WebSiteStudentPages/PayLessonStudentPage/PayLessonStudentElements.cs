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

        //div[@class = 'modal-content']//input[@id = 'email']
        //form[@class = 'w-75 position-center ng-valid ng-star-inserted ng-dirty ng-touched']//input[@id = 'email']
        public IWebElement FieldInputEmailAddressLogForPay => Browser._Driver.FindElement(_FieldInputEmailAddressLogForPay);
        public readonly static By _FieldInputEmailAddressLogForPay = By.XPath("//div[@class = 'modal-content']//input[@id = 'email']");

        public IWebElement FieldInputPasswordLogForPay => Browser._Driver.FindElement(_FieldInputPasswordLogForPay);
        public readonly static By _FieldInputPasswordLogForPay = By.XPath("//input[@id = 'password']");

        public IWebElement ButtonShowLogForPay => Browser._Driver.FindElement(_ButtonShowLogForPay);
        public readonly static By _ButtonShowLogForPay = By.XPath("//span[@class = 'show']//i");

        public IWebElement ButtonLogInLogForPayy => Browser._Driver.FindElement(_ButtonLogInLogForPay);
        public readonly static By _ButtonLogInLogForPay = By.XPath("//form[@class = 'w-75 position-center ng-valid ng-star-inserted ng-dirty ng-touched']//div[3]//button");

        #endregion

        #region PageEnrolInALessonTabDetails

        public IWebElement ButtonNextPayLssnStdntDtlsTab => Browser._Driver.FindElement(_ButtonNextPayLssnStdntDtlsTab);
        public readonly static By _ButtonNextPayLssnStdntDtlsTab = By.XPath("//div[@class = 'd-flex justify-content-between button-area']//button[2]");

        #endregion

        #region PageEnrolInALessonTabConfirmation

        public IWebElement DropDownMenuLessonInstrumentPiano => Browser._Driver.FindElement(_DropDownMenuLessonInstrumentPiano);
        public readonly static By _DropDownMenuLessonInstrumentPiano= By.XPath("//div[@_ngcontent-c6][3]//select[@id = 'instrument']//option[2]");

        public IWebElement CheckBoxIAgreeToTheTermsAndConditions => Browser._Driver.FindElement(_CheckBoxIAgreeToTheTermsAndConditions);
        public readonly static By _CheckBoxIAgreeToTheTermsAndConditions = By.XPath("//div[@_ngcontent-c6][3]//div[6]//input");

        public IWebElement ButtonNextPayLssnStdntCnfrmtnTab => Browser._Driver.FindElement(_ButtonNextPayLssnStdntCnfrmtnTab);
        public readonly static By _ButtonNextPayLssnStdntCnfrmtnTab = By.XPath("//div[@_ngcontent-c6][3]//div[7]//button[2]");

        #endregion

        #region PageEnrolInALessonTabPayment

        public IWebElement ButtonEnrolTabPayment => Browser._Driver.FindElement(_ButtonEnrolTabPayment);
        public readonly static By _ButtonEnrolTabPayment = By.XPath("//button[contains(text(), 'Enrol')]");

        public IWebElement RadioButtonPayForTenLessonsTabPayment => Browser._Driver.FindElement(_RadioButtonPayForTenLessonsTabPayment);
        public readonly static By _RadioButtonPayForTenLessonsTabPayment = By.XPath("//label[contains(text(), 'Pay for 10 lessons')]");

        public IWebElement RadioButtonSetUpReoccurringTabPayment => Browser._Driver.FindElement(_RadioButtonSetUpReoccurringTabPayment);
        public readonly static By _RadioButtonSetUpReoccurringTabPayment = By.XPath("//app-booking-payment[@class = 'ng-star-inserted']//div[5]//div[2]//div[2]//input");

        public IWebElement CloseButtonMdlWndwPerLessonDdTabPayment => Browser._Driver.FindElement(_CloseButtonMdlWndwPerLessonDdTabPayment);
        public readonly static By _CloseButtonMdlWndwPerLessonDdTabPayment = By.XPath("//div[@class = 'time-slot-create-container']//div//button");

        public IWebElement ButtonConfirmMdlWndwYouveDone => Browser._Driver.FindElement(_ButtonConfirmMdlWndwYouveDone);
        public readonly static By _ButtonConfirmMdlWndwYouveDone = By.XPath("//i[@class = 'fas fa-check']");

        #endregion
    }
}
