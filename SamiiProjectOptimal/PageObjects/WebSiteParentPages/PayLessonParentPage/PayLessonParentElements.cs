﻿using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.PayLessonParentPage
{
    public partial class PayLessonParent
    {
        public IWebElement FieldInputEmailAddressLogForPay => Browser._Driver.FindElement(_FieldInputEmailAddressLogForPay);
        public readonly static By _FieldInputEmailAddressLogForPay = By.XPath("//div[@class = 'modal-content']//input[@id = 'email']");

        public IWebElement FieldInputPasswordLogForPay => Browser._Driver.FindElement(_FieldInputPasswordLogForPay);
        public readonly static By _FieldInputPasswordLogForPay = By.XPath("//input[@id = 'password']");

        public IWebElement ButtonShowLogForPay => Browser._Driver.FindElement(_ButtonShowLogForPay);
        public readonly static By _ButtonShowLogForPay = By.XPath("//span[@class = 'show']//i");

        public IWebElement ButtonLogInLogForPayy => Browser._Driver.FindElement(_ButtonLogInLogForPay);
        public readonly static By _ButtonLogInLogForPay = By.XPath("//form[@class = 'w-75 position-center ng-valid ng-star-inserted ng-dirty ng-touched']//div[3]//button");
    }
}
