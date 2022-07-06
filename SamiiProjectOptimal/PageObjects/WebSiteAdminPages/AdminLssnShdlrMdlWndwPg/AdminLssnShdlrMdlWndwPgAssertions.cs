using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminLssnShdlrMdlWndwPg
{
    public partial class AdminLssnShdlrMdlWndwPg
    {
        [AllureStep("GetTitle")]
        public string GetTitle()
        {
            WaitUntil.WaitSomeInterval(1);
            string getTitleExpected = Browser._Driver.FindElement(_FieldTitleTeacherDetailsTab).GetAttribute("value");
            string getTitleFromModalWndw = getTitleExpected.ToString();

            return getTitleFromModalWndw;
        }

        [AllureStep("VerifySetLesson")]
        public AdminLssnShdlrMdlWndwPg VerifySetLesson(string getTitleFromModalWndw)
        {
            WaitUntil.WaitSomeInterval(1);
            string getTitleActual = FieldTitleTeacherDetailsTab.GetAttribute("value");

            Assert.AreEqual(getTitleFromModalWndw, getTitleActual);

            return this;
        }
    }
}
