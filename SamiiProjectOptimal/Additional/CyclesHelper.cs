using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class CycleForResetPassword
    {
        #region ElementsForStudent
        public IWebElement FIeldInputPassword => Browser._Driver.FindElement(_FIeldInputPassword);
        public readonly static By _FIeldInputPassword = By.XPath("//input[@id = 'password']");

        public IWebElement FieldInputCurrentPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputCurrentPasswordRstPsswrdPg);
        public readonly static By _FieldInputCurrentPasswordRstPsswrdPg = By.XPath("//input[@id= 'oldPassword']");

        public IWebElement FieldInputPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputPasswordRstPsswrdPg);
        public readonly static By _FieldInputPasswordRstPsswrdPg = By.XPath("//input[@id= 'password']");

        public IWebElement FieldInputConfirmPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputConfirmPasswordRstPsswrdPg);
        public readonly static By _FieldInputConfirmPasswordRstPsswrdPg = By.XPath("//input[@id= 'confirm-password']");

        #endregion

        public IWebElement FIeldInputCurrentPasswordTabPsswrd => Browser._Driver.FindElement(_FIeldInputCurrentPasswordTabPsswrd);
        public readonly static By _FIeldInputCurrentPasswordTabPsswrd = By.XPath("//div[@class = 'change-password-teacher']//input[@id = 'oldPassword']");

        public IWebElement FIeldInputPasswordTabPsswrd => Browser._Driver.FindElement(_FieldInputPasswordRstPsswrdPg);
        public readonly static By _FIeldInputPasswordTabPsswrd = By.XPath("//div[@class = 'change-password-teacher']//input[@id = 'password']");

        public IWebElement FIeldInputConfirmPasswordTabPsswrd => Browser._Driver.FindElement(_FIeldInputConfirmPasswordTabPsswrd);
        public readonly static By _FIeldInputConfirmPasswordTabPsswrd = By.XPath("//div[@class = 'change-password-teacher']//input[@id = 'confirm-password']");


        #region ElementsForTeacher


        #endregion
        [AllureStep("SelectPassword")]
        public string SelectPassword(string passwordEnding)
        {
            string[] password = { "1111", "1234" };

            var passwordNew = password.Where(x => x.EndsWith(passwordEnding)).ToList();
            string passwordDrop = passwordNew[0];

            return passwordDrop;
        }

        [AllureStep("EnterPasswordForLogIn")]
        public CycleForResetPassword EnterPasswordForLogIn(string pass)
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FIeldInputPassword, pass);

            return this;
        }

        [AllureStep("EnterPasswordHowLogIn")]
        public CycleForResetPassword EnterPasswordHowLogIn(string pass)
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputCurrentPasswordRstPsswrdPg, pass);

            return this;
        }

        [AllureStep("EnterNewPasswordForResetedPassword")]
        public CycleForResetPassword EnterNewPasswordForResetedPassword(string pass)
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputPasswordRstPsswrdPg, pass);
            Input.InputFunctionWithClear(FieldInputConfirmPasswordRstPsswrdPg, pass);

            return this;
        }

        [AllureStep("SelectPasswordAlternativeWay")]
        public string SelectPasswordAlternativeway(string passEnd)
        {
            string[] password = { "1111", "1234" };

            var selectedPassword = (from p in password
                                   where p.EndsWith(passEnd)
                                   && p.
                                   select p).ToList();

                return selectedPassword[0];
        }

        [AllureStep("EnterCurrentPasswordForTchrPrflStp")]
        public CycleForResetPassword EnterCurrentPasswordForTchrPrflStp(string passEnd)
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FIeldInputPassword, passEnd);

            return this;
        }

    }
}