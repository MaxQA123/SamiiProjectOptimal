using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [AllureStep("OpenNewTab")]
        public EmailXitroo OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;    
        }

        [AllureStep("CloseNewTab")]
        public EmailXitroo CloseNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.close();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.First());

            return this;
        }

        [AllureStep("OpenWelcomeToSammii")]
        public EmailXitroo OpenWelcomeToSammii()
        {
            WaitUntil.ElementVisibileAndClickable(By.XPath("//tbody[@id = 'mailList']//th[text() = '1']"), 120);
            SelectLetterNumberOneNew.Click();

            return this;
        }

        [AllureStep("CopyVerificationCode")]
        public string CopyVerificationCode()
        {
            WaitUntil.WaitSomeInterval(5);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.ShouldLocate(_VerificationCodeXitroo);
            string code = VerificationCodeXitroo.Text.Trim(new char[] { 'V', 'e', 'r', 'f', 'c', 'a', 't', 'i', 'o', 'n', ' ', 'd', ':' });
            //string code = VerificationCodeXitroo.Text.Substring(20, 25);

            return code;
        }

        [AllureStep("EnterEmail")]
        public EmailXitroo EnterEmail(string _email)
        {
            WaitUntil.ShouldLocate(_FieldInputEmail);
            FieldInputEmail.SendKeys(_email);

            return this;
        }

        [AllureStep("ClickSearchButton")]
        public EmailXitroo ClickSearchButton()
        {
            WaitUntil.ShouldLocate(_ButtonSearchEmail);
            ButtonSearchEmail.Click();

            WaitUntil.ShouldLocate(_SelectLetterNumberOneNew);

            return this;
        }

        [AllureStep("ClickButtonBack")]
        public EmailXitroo ClickButtonBack()
        {
            WaitUntil.ShouldLocate(_ButtonBackEmail);
            ButtonBackEmail.Click();

            return this;
        }

        [AllureStep("CopyEmailPgXitroo")]
        public string CopyEmailPgXitroo()
        {
            WaitUntil.ShouldLocate(_FieldInputEmailXitroo);
            string getEmail = Browser._Driver.FindElement(_FieldInputEmailXitroo).GetAttribute("value");
            string _email = getEmail.ToLower();

            return _email;
        }

        [AllureStep("EnterRepeatEmail")]
        public EmailXitroo EnterRepeatEmail(string _email)
        {
            WaitUntil.ShouldLocate(_FIeldInputEmailLogInPage);
            FIeldInputEmailLogInPage.SendKeys(_email);

            return this;
        }

        [AllureStep("SwitchOnLogInPage")]
        public EmailXitroo SwitchOnLogInPage()
        {
            WaitUntil.WaitSomeInterval(3);
            List<string> tablist = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tablist[0]);

            return this;
        }


    }
}