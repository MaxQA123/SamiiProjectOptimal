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
        public TeacherLssnShdlrMdlWndw SelectAllInstruments()
        {
            //WaitUntil.WaitSomeInterval(3);
            //Browser._Driver.SwitchTo().Frame(IframeLssnShdlrMdlWndwTeacher);
            //WaitUntil.WaitSomeInterval(3);
            WaitUntil.ShouldLocate(_ButtonDropDownInstruments);
            ButtonDropDownInstruments.Click();
            WaitUntil.WaitSomeInterval(1);
            CheckBoxSelectAll.Click();

            return this;
        }

    }
}
