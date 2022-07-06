using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.LogInTeacher
{
    public partial class LogInTeacher
    {
        [AllureStep("GetEmailFromlogIn")]
        public string GetEmailFromlogIn()
        {
            WaitUntil.WaitSomeInterval(1);
            string getEmal = Browser._Driver.FindElement(_FIeldInputEmail).GetAttribute("value");
            string getEmailFromlogIn = getEmal.ToString();

            return getEmailFromlogIn;
        }

        [AllureStep("GetEmailFromlogIn")]
        public LogInTeacher VerifyByEmail(string getEmailFromlogIn)
        {
            WaitUntil.WaitSomeInterval(1);
            string getEmailFromAccount = FieldInputEmailTabSetupTchrPrflStp.GetAttribute("value");

            Assert.AreEqual(getEmailFromlogIn, getEmailFromAccount);

            return this;
        }
    }
}
