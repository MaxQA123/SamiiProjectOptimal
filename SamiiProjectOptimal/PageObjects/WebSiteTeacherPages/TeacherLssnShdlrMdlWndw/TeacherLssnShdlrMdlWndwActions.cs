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
            WaitUntil.ShouldLocate(_ButtonDropDownInstruments);
            ButtonDropDownInstruments.Click();
            WaitUntil.WaitSomeInterval(1);
            CheckBoxSelectAll.Click();
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowCloseDropDownInstruments.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw SelectRecurrenceOnce()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownOnceRecurrence);
            ButtonDropDownOnceRecurrence.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw EnterPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(RandomGenerateData.RandomPriceInteger(2) + "." + RandomGenerateData.RandomPriceKopeck(2));

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonNext()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTab);
            ButtonNextDetailsTab.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonSaveForTeacher()
        {
            WaitUntil.ShouldLocate(_ButtonSaveForTeacher);
            ButtonSaveForTeacher.Click();

            return this;
        }

    }
}
