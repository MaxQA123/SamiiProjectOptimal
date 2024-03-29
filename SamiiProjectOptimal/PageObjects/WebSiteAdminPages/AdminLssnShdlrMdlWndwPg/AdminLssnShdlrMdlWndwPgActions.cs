﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;
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
        #region ModalWindowLessonBelongsTo

        [AllureStep("ClickButtonMoveStudentsMdlWndwLssnShdlr")]
        public AdminLssnShdlrMdlWndwPg ClickButtonMoveStudentsMdlWndwLssnShdlr()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(ButtonMoveStudentsMdlWndwLssnShdlr);
            ButtonMoveStudentsMdlWndwLssnShdlr.Click();

            return this;
        }

        [AllureStep("ClickButtonSelectAllLessonBelongsTo")]
        public AdminLssnShdlrMdlWndwPg ClickButtonSelectAllLessonBelongsTo()
        {
            WaitUntil.ElementIsClickable(ButtonSelectAllLessonBelongsTo);
            ButtonSelectAllLessonBelongsTo.Click();

            return this;
        }

        [AllureStep("ClickButtonMoveOneLessonLessonBelongsTo")]
        public AdminLssnShdlrMdlWndwPg ClickButtonMoveOneLessonLessonBelongsTo()
        {
            WaitUntil.ElementIsClickable(ButtonMoveOneLessonLessonBelongsTo);
            ButtonMoveOneLessonLessonBelongsTo.Click();

            return this;
        }

        [AllureStep("ScrollToCellElevenPmPmMdlWndwCalendar")]
        public AdminLssnShdlrMdlWndwPg ScrollToCellElevenPmPmMdlWndwCalendar()
        {
            WaitUntil.ShouldLocate(_CellElevenPmScrollingMdlWndw);
            Scrolling.ScrollToElement(CellElevenPmScrollingMdlWndw);

            return this;
        }

        #endregion

        #region ModalWindowLessonSchedulerForMoveLessonOnTheAnyTime

        [AllureStep("SelectInstrumentsForMoveLesson")]
        public AdminLssnShdlrMdlWndwPg SelectInstrumentsForMoveLesson()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownInstrumentsForMoveLesson);
            ButtonDropDownInstrumentsForMoveLesson.Click();
            WaitUntil.WaitSomeInterval(1);
            CheckBoxSelectAllForMoveLesson.Click();
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowCloseDropDownInstrumentsForMoveLesson.Click();

            return this;
        }

        [AllureStep("SelectRecurrenceForMoveLesson")]
        public AdminLssnShdlrMdlWndwPg SelectRecurrenceForMoveLesson()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownOnceRecurrenceForMoveLesson);
            ButtonDropDownOnceRecurrenceForMoveLesson.Click();

            return this;
        }

        [AllureStep("EnterMinPriceToStudentsPerGroupForMoveLesson")]
        public AdminLssnShdlrMdlWndwPg EnterMinPriceToStudentsPerGroupForMoveLesson()
        {
            WaitUntil.ShouldLocate(_FieldInputStudentsPerGroupPriceForMoveLesson);
            FieldInputStudentsPerGroupPriceForMoveLesson.SendKeys(PriceForLesson.minPrice);

            return this;
        }

        [AllureStep("ClickButtonNextDetailsTabForMoveLesson")]
        public AdminLssnShdlrMdlWndwPg ClickButtonNextDetailsTabForMoveLesson()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabForMoveLesson);
            ButtonNextDetailsTabForMoveLesson.Click();

            return this;
        }

        [AllureStep("ClickButtonSaveRecourceTabForMoveLesson")]
        public AdminLssnShdlrMdlWndwPg ClickButtonSaveRecourceTabForMoveLesson()
        {
            WaitUntil.ShouldLocate(_ButtonSaveRecourceTabForMoveLesson);
            ButtonSaveRecourceTabForMoveLesson.Click();

            return this;
        }

        #endregion

        #region TeacherDetailsTab

        [AllureStep("SelectAllInstruments")]
        public AdminLssnShdlrMdlWndwPg SelectAllInstruments()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownInstruments);
            ButtonDropDownInstruments.Click();
            WaitUntil.WaitSomeInterval(1);
            CheckBoxSelectAll.Click();
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowCloseDropDownInstruments.Click();

            return this;
        }

        [AllureStep("SelectRecurrenceOnce")]
        public AdminLssnShdlrMdlWndwPg SelectRecurrenceOnce()
        {
            WaitUntil.ShouldLocate(_ButtonDropDownOnceRecurrence);
            ButtonDropDownOnceRecurrence.Click();

            return this;
        }

        [AllureStep("EnterPriceToStudentsPerGroup")]
        public AdminLssnShdlrMdlWndwPg EnterPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(RandomGenerateData.RandomPriceInteger(2) + "." + RandomGenerateData.RandomPriceKopeck(2));

            return this;
        }

        [AllureStep("EnterMinPriceToStudentsPerGroup")]
        public AdminLssnShdlrMdlWndwPg EnterMinPriceToStudentsPerGroup()
        {
            WaitUntil.ShouldLocate(_FieldStudentsPerGroupPrice);
            FieldStudentsPerGroupPrice.SendKeys(PriceForLesson.minPrice);

            return this;
        }

        [AllureStep("ClickButtonNext")]
        public AdminLssnShdlrMdlWndwPg ClickButtonNext()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabBeforeSaved);
            ButtonNextDetailsTabBeforeSaved.Click();

            return this;
        }

        [AllureStep("ClickButtonAssignLessonTo")]
        public AdminLssnShdlrMdlWndwPg ClickButtonAssignLessonToAfterSaved()
        {
            WaitUntil.ShouldLocate(_ButtonAssignLessonToAfterSaved);
            ButtonAssignLessonToAfterSaved.Click();

            return this;
        }

        [AllureStep("ClickButtonCloseViaCross")]
        public AdminLssnShdlrMdlWndwPg ClickButtonCloseViaCross()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonCloseViaCross.Click();

            return this;
        }

        #endregion

        #region TeacherLessonShedulerTab

        [AllureStep("ClickButtonSaveForAdmin")]
        public AdminLssnShdlrMdlWndwPg ClickButtonSaveForAdmin()
        {
            WaitUntil.ShouldLocate(_ButtonSaveForTeacher);
            ButtonSaveForTeacher.Click();
            WaitUntil.WaitSomeInterval(10);

            return this;
        }

        #endregion

        [AllureStep("ClickDeleteDtlsTab")]
        public AdminLssnShdlrMdlWndwPg ClickDeleteDtlsTab()
        {
            WaitUntil.ShouldLocate(_ButtonDeleteDetailsTab);
            ButtonDeleteDetailsTab.Click();

            return this;
        }

        #region AssignStudentsModalWindow

        [AllureStep("SelectFirstStudentToAssign")]
        public AdminLssnShdlrMdlWndwPg SelectFirstStudentToAssign()
        {
            WaitUntil.WaitSomeInterval(5);
            ButtonDropDownStudents.Click();
            WaitUntil.WaitSomeInterval(3);
            CheckBoxFirststudent.Click();

            return this;
        }

        [AllureStep("ClickButtonAssignStudent")]
        public AdminLssnShdlrMdlWndwPg ClickButtonAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonAssignStudents);
            ButtonAssignStudents.Click();

            return this;
        }

        [AllureStep("ClickButtonNextAfterAssignStudent")]
        public AdminLssnShdlrMdlWndwPg ClickButtonNextAfterAssignStudent()
        {
            WaitUntil.ShouldLocate(_ButtonNextDetailsTabAfterSaved);
            ButtonNextDetailsTabAfterSaved.Click();

            return this;
        }

        #endregion

        #region ModalWindowDeleteLesson

        [AllureStep("ClickButtonYes")]
        public AdminLssnShdlrMdlWndwPg ClickButtonYes()
        {
            WaitUntil.ShouldLocate(_ButtonYesDeleteLessonMdlWndw);
            ButtonYesDeleteLessonMdlWndw.Click();

            return this;
        }

        [AllureStep("ClickButtonNo")]
        public AdminLssnShdlrMdlWndwPg ClickButtonNo()
        {
            WaitUntil.ShouldLocate(_ButtonNoDeleteLessonMdlWndw);
            ButtonNoDeleteLessonMdlWndw.Click();

            return this;
        }

        #endregion
    }
}
