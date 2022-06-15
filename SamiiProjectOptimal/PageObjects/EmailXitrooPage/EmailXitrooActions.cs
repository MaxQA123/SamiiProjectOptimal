using OpenQA.Selenium;
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

        public EmailXitroo OpenNewLetterResetPassword()
        {
            WaitUntil.ElementVisibileAndClickable(By.XPath("//tbody[@id = 'mailList']//th[text() = '1']"));
            SelectLetterNumberOneNew.Click();

            return this;
        }

        public string CopyVerificationCode()
        {
            WaitUntil.ShouldLocate(_VerificationCodeXitroo);
            //string code = VerificationCodeXitroo.Text.Trim(new char[] { 'V', 'e', 'r', 'f', 'c', 'a', 't', 'i', 'o', 'n', ' ', 'd', ':' });
            string code = VerificationCodeXitroo.Text.Substring(20, 25);

            return code;
        }

    }
}