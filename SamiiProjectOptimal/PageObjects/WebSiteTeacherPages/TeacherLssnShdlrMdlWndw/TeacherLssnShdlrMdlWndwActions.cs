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

        #region TeacherDetailsTab

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

        public TeacherLssnShdlrMdlWndw EnterMinPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(PriceForLesson.minPrice);

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonNext()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabBeforeSaved);
            ButtonNextDetailsTabBeforeSaved.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonAssignLessonTo()
        {
            WaitUntil.ShouldLocate(_ButtonAssignLessonToAfterSaved);
            ButtonAssignLessonToAfterSaved.Click();

            return this;
        }

        #endregion

        #region TeacherLessonShedulerTab

        public TeacherLssnShdlrMdlWndw ClickButtonSaveForTeacher()
        {
            WaitUntil.ShouldLocate(_ButtonSaveForTeacher);
            ButtonSaveForTeacher.Click();

            return this;
        }

        #endregion

        public TeacherLssnShdlrMdlWndw ClickDeleteDtlsTab()
        {
            WaitUntil.ShouldLocate(_ButtonDeleteDetailsTab);
            ButtonDeleteDetailsTab.Click();

            return this;
        }

        #region AssignStudentsModalWindow

        public TeacherLssnShdlrMdlWndw SelectFirstStudentToAssign()
        {
            WaitUntil.WaitSomeInterval(5);
            ButtonDropDownStudents.Click();
            WaitUntil.WaitSomeInterval(3);
            CheckBoxFirststudent.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonAssignStudents);
            ButtonAssignStudents.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonNextAfterAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabAfterSaved);
            ButtonNextDetailsTabAfterSaved.Click();

            return this;
        }

        #endregion

        #region ModalWindowDeleteLesson

        public TeacherLssnShdlrMdlWndw ClickButtonYes()
        {
            WaitUntil.ShouldLocate(_ButtonYesDeleteLessonMdlWndw);
            ButtonYesDeleteLessonMdlWndw.Click();

            return this;
        }

        public TeacherLssnShdlrMdlWndw ClickButtonYNo()
        {
            WaitUntil.ShouldLocate(_ButtonNoDeleteLessonMdlWndw);
            ButtonNoDeleteLessonMdlWndw.Click();

            return this;
        }

        #endregion
    }
}
