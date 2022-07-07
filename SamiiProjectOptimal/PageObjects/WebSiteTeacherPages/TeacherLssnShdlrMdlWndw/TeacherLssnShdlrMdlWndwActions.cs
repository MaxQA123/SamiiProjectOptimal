using NUnit.Allure.Attributes;
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

        [AllureStep("SelectAllInstruments")]
        public TeacherLssnShdlrMdlWndw SelectAllInstruments()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ShouldLocate(_ButtonDropDownInstruments);
            ButtonDropDownInstruments.Click();
            WaitUntil.WaitSomeInterval(1);
            CheckBoxSelectAll.Click();
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowCloseDropDownInstruments.Click();

            return this;
        }

        [AllureStep("SelectRecurrenceOnce")]
        public TeacherLssnShdlrMdlWndw SelectRecurrenceOnce()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownOnceRecurrence);
            ButtonDropDownOnceRecurrence.Click();

            return this;
        }

        [AllureStep("EnterPriceToStudentsPerGroup")]
        public TeacherLssnShdlrMdlWndw EnterPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(RandomGenerateData.RandomPriceInteger(2) + "." + RandomGenerateData.RandomPriceKopeck(2));

            return this;
        }

        [AllureStep("EnterMinPriceToStudentsPerGroup")]
        public TeacherLssnShdlrMdlWndw EnterMinPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(PriceForLesson.minPrice);

            return this;
        }

        [AllureStep("ClickButtonNext")]
        public TeacherLssnShdlrMdlWndw ClickButtonNext()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabBeforeSaved);
            ButtonNextDetailsTabBeforeSaved.Click();

            return this;
        }

        [AllureStep("ClickButtonAssignLessonTo")]
        public TeacherLssnShdlrMdlWndw ClickButtonAssignLessonTo()
        {
            WaitUntil.ShouldLocate(_ButtonAssignLessonToAfterSaved);
            ButtonAssignLessonToAfterSaved.Click();

            return this;
        }

        #endregion

        #region TeacherLessonShedulerTab

        [AllureStep("ClickButtonSaveForTeacher")]
        public TeacherLssnShdlrMdlWndw ClickButtonSaveForTeacher()
        {
            WaitUntil.ShouldLocate(_ButtonSaveForTeacher);
            ButtonSaveForTeacher.Click();

            return this;
        }

        #endregion

        [AllureStep("ClickDeleteDtlsTab")]
        public TeacherLssnShdlrMdlWndw ClickDeleteDtlsTab()
        {
            WaitUntil.ShouldLocate(_ButtonDeleteDetailsTab);
            ButtonDeleteDetailsTab.Click();

            return this;
        }

        #region AssignStudentsModalWindow

        [AllureStep("SelectFirstStudentToAssign")]
        public TeacherLssnShdlrMdlWndw SelectFirstStudentToAssign()
        {
            WaitUntil.WaitSomeInterval(5);
            ButtonDropDownStudents.Click();
            WaitUntil.WaitSomeInterval(3);
            CheckBoxFirststudent.Click();

            return this;
        }

        [AllureStep("ClickButtonAssignStudent")]
        public TeacherLssnShdlrMdlWndw ClickButtonAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonAssignStudents);
            ButtonAssignStudents.Click();

            return this;
        }

        [AllureStep("ClickButtonNextAfterAssignStudent")]
        public TeacherLssnShdlrMdlWndw ClickButtonNextAfterAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabAfterSaved);
            ButtonNextDetailsTabAfterSaved.Click();

            return this;
        }

        #endregion

        #region ModalWindowDeleteLesson

        [AllureStep("ClickButtonYes")]
        public TeacherLssnShdlrMdlWndw ClickButtonYes()
        {
            WaitUntil.ShouldLocate(_ButtonYesDeleteLessonMdlWndw);
            ButtonYesDeleteLessonMdlWndw.Click();

            return this;
        }

        [AllureStep("ClickButtonNo")]
        public TeacherLssnShdlrMdlWndw ClickButtonNo()
        {
            WaitUntil.ShouldLocate(_ButtonNoDeleteLessonMdlWndw);
            ButtonNoDeleteLessonMdlWndw.Click();

            return this;
        }

        #endregion
    }
}
