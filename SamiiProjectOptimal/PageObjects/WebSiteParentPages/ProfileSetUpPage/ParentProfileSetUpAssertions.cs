using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.ProfileSetUpPage
{
    public partial class ParentProfileSetUp
    {
        [AllureStep("GetEmailFromLogIn")]
        public string GetEmailFromLogIn()
        {
            WaitUntil.WaitSomeInterval(1);
            string getEmail = Browser._Driver.FindElement(_FIeldInputEmailLogInPg).GetAttribute("value");
            string getEmailExpected = getEmail.ToString();

            return getEmailExpected;
        }

        [AllureStep("VerifyParentEamail")]
        public ParentProfileSetUp VerifyParentEamail(string getEmailExpected)
        {
            WaitUntil.WaitSomeInterval(1);
            string getEmailActual = FieldInputEmailFromParentProfileSetUp.GetAttribute("value");

            Assert.AreEqual(getEmailExpected, getEmailActual);

            return this;
        }
    }
}
