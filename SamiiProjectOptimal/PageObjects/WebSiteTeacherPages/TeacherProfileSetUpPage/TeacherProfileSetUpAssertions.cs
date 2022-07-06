using NUnit.Allure.Attributes;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherProfileSetUpPage
{
    public partial class TeacherProfileSetUp
    {
        [AllureStep("CopyPasswordTabAvlbRsrcsTchrPrflStp")]
        public string CopyPasswordTabAvlbRsrcsTchrPrflStp()
        {
            string getPassword = Browser._Driver.FindElement(_FieldInputConfirmPasswordRstPsswrdPg).GetAttribute("value");
            string passwordFromTabPasswordTchrPrflStp = getPassword.ToString();

            return passwordFromTabPasswordTchrPrflStp;
        }

    }
}
