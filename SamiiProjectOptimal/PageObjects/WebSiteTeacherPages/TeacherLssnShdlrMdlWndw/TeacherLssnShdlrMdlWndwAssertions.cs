using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLssnShdlrMdlWndw
{
    public partial class TeacherLssnShdlrMdlWndw
    {
        [AllureStep("GetTitle")]
        public string GetTitle()
        {
            WaitUntil.ShouldLocate(_FieldTitleTeacherDetailsTab);
            string getTitleExpected = Browser._Driver.FindElement(_FieldTitleTeacherDetailsTab).GetAttribute("value");
            string getTitleCompareEx = getTitleExpected.ToString();

            return getTitleCompareEx;
        }

        [AllureStep("VerifyTitle")]
        public TeacherLssnShdlrMdlWndw VerifyTitle(string getTitleCompareEx)
        {
            WaitUntil.WaitSomeInterval(1);
            string getTitleActual = FieldTitleTeacherDetailsTab.GetAttribute("value");

            Assert.AreEqual(getTitleCompareEx, getTitleActual);
            return this;
        }
    }
}
