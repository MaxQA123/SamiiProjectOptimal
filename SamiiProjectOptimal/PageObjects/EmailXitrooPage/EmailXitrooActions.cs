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
        public EmailXitroo OpenNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.open();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.Last());

            return this;    
        }

        public EmailXitroo CloseNewTab()
        {
            ((IJavaScriptExecutor)Browser._Driver).ExecuteScript("window.close();");
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.First());

            return this;
        }

        public EmailXitroo OpenWelcomeToSammii()
        {
            WaitUntil.ElementVisibileAndClickable(By.XPath("//tbody[@id = 'mailList']//th[text() = '1']"), 120);
            SelectLetterNumberOneNew.Click();

            return this;
        }

        public string CopyVerificationCode()
        {
            WaitUntil.WaitSomeInterval(5);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.ShouldLocate(_VerificationCodeXitroo);
            string code = VerificationCodeXitroo.Text.Trim(new char[] { 'V', 'e', 'r', 'f', 'c', 'a', 't', 'i', 'o', 'n', ' ', 'd', ':' });
            //string code = VerificationCodeXitroo.Text.Substring(20, 25);

            return code;
        }

        public EmailXitroo EnterEmail(string email)
        {
            WaitUntil.ShouldLocate(_FieldInputEmail);
            FieldInputEmail.SendKeys(email);

            return this;
        }

        public EmailXitroo ClickSearchButton()
        {
            WaitUntil.ShouldLocate(_ButtonSearchEmail);
            ButtonSearchEmail.Click();
            WaitUntil.ShouldLocate(_SelectLetterNumberOneNew);

            return this;
        }

    }
}