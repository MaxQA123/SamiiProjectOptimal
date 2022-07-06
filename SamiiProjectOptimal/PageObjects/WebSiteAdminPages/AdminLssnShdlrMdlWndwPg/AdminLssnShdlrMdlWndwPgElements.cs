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
        public IWebElement IframeLssnShdlrMdlWndwTeacher => Browser._Driver.FindElement(_IframeLssnShdlrMdlWndwTeacher);
        public readonly static By _IframeLssnShdlrMdlWndwTeacher = By.XPath("//iframe[@id = 'cb-master-frame']");

        public IWebElement TabDetails => Browser._Driver.FindElement(_TabDetails);
        public readonly static By _TabDetails = By.XPath("//button[@class = 'btn-clear selected']");

        public IWebElement TabResources => Browser._Driver.FindElement(_TabResources);
        public readonly static By _TabResources = By.XPath("//button[@class = 'btn-clear']");

        public IWebElement ButtonCloseViaCross => Browser._Driver.FindElement(_ButtonCloseViaCross);
        public readonly static By _ButtonCloseViaCross = By.XPath("//button[@class = 'btn close-box']");
        
        #region ModalWindowLessonBelongsTo

        public IWebElement ButtonSelectAllLessonBelongsTo => Browser._Driver.FindElement(_ButtonSelectAllLessonBelongsTo);
        public readonly static By _ButtonSelectAllLessonBelongsTo = By.XPath("//div[@class = 'lesson-create-container']//button");

        public IWebElement ButtonMoveOneLessonLessonBelongsTo => Browser._Driver.FindElement(_ButtonMoveOneLessonLessonBelongsTo);
        public readonly static By _ButtonMoveOneLessonLessonBelongsTo = By.XPath("//div[@class = 'lesson-create-container']//button[2]");

        public IWebElement ButtonMoveAllFtrLessonsLessonBelongsTo => Browser._Driver.FindElement(_ButtonMoveAllFtrLessonsLessonBelongsTo);
        public readonly static By _ButtonMoveAllFtrLessonsLessonBelongsTo = By.XPath("//div[@class = 'lesson-create-container']//button[3]");

        public IWebElement CheckBoxsMdlWndwLessonBelongsTo => Browser._Driver.FindElement(_CheckBoxsMdlWndwLessonBelongsTo);
        public readonly static By _CheckBoxsMdlWndwLessonBelongsTo = By.XPath("//input[@class = 'ng-valid ng-star-inserted ng-dirty ng-touched']");

        public IWebElement ButtonMoveStudentsMdlWndwLssnShdlr => Browser._Driver.FindElement(_ButtonMoveStudentsMdlWndwLssnShdlr);
        public readonly static By _ButtonMoveStudentsMdlWndwLssnShdlr = By.XPath("//button[@class = 'btn btn-primary justify-content-center mx-auto mb-3 d-flex ng-star-inserted']");

        #endregion

        #region ModalWindowLessonSchedulerForMoveLessonOnTheAnyTime

        public IWebElement ButtonDropDownInstrumentsForMoveLesson => Browser._Driver.FindElement(_ButtonDropDownInstrumentsForMoveLesson);
        public readonly static By _ButtonDropDownInstrumentsForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//span");

        public IWebElement CheckBoxSelectAllForMoveLesson => Browser._Driver.FindElement(_CheckBoxSelectAllForMoveLesson);
        public readonly static By _CheckBoxSelectAllForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//div[@class = 'd-flex flexwrap-variable'][2]//li");
        
        public IWebElement ButtonArrowCloseDropDownInstrumentsForMoveLesson => Browser._Driver.FindElement(_ButtonArrowCloseDropDownInstrumentsForMoveLesson);
        public readonly static By _ButtonArrowCloseDropDownInstrumentsForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//span[@class = 'dropdown-up']");

        public IWebElement ButtonDropDownOnceRecurrenceForMoveLesson => Browser._Driver.FindElement(_ButtonDropDownOnceRecurrenceForMoveLesson);
        public readonly static By _ButtonDropDownOnceRecurrenceForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//div[@class = 'd-flex flexwrap-variable'][5]//option[3]");

        public IWebElement FieldInputStudentsPerGroupPriceForMoveLesson => Browser._Driver.FindElement(_FieldInputStudentsPerGroupPriceForMoveLesson);
        public readonly static By _FieldInputStudentsPerGroupPriceForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//div[@class = 'd-flex flexwrap-variable'][8]//input");

        public IWebElement ButtonNextDetailsTabForMoveLesson => Browser._Driver.FindElement(_ButtonNextDetailsTabForMoveLesson);
        public readonly static By _ButtonNextDetailsTabForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-details-container']//div[@class = 'd-flex justify-content-between pc-markup']//button[3]");

        public IWebElement ButtonSaveRecourceTabForMoveLesson => Browser._Driver.FindElement(_ButtonSaveRecourceTabForMoveLesson);
        public readonly static By _ButtonSaveRecourceTabForMoveLesson = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][3]//div[@class = 'modal-content']//div[@class = 'lesson-create-resources-container']//button[2]");

        #endregion

        #region TeacherDetailsTab

        public IWebElement FieldTitleTeacherDetailsTab => Browser._Driver.FindElement(_FieldTitleTeacherDetailsTab);
        public readonly static By _FieldTitleTeacherDetailsTab = By.XPath("//input[@name = 'title']");

        public IWebElement ButtonDropDownInstruments => Browser._Driver.FindElement(_ButtonDropDownInstruments);
        public readonly static By _ButtonDropDownInstruments = By.XPath("//span[@class = 'dropdown-btn']//span");

        public IWebElement ButtonArrowCloseDropDownInstruments => Browser._Driver.FindElement(_ButtonArrowCloseDropDownInstruments);
        public readonly static By _ButtonArrowCloseDropDownInstruments = By.XPath("//span[@class = 'dropdown-up']");

        public IWebElement ButtonDropDownWeeklyRecurrence => Browser._Driver.FindElement(_ButtonDropDownWeeklyRecurrence);
        public readonly static By _ButtonDropDownWeeklyRecurrence = By.XPath("//select[@name = 'recurrenceType']//option");

        public IWebElement ButtonDropDownDailyRecurrence => Browser._Driver.FindElement(_ButtonDropDownDailyRecurrence);
        public readonly static By _ButtonDropDownDailyRecurrence = By.XPath("//select[@name = 'recurrenceType']//option[2]");
       
        public IWebElement ButtonDropDownOnceRecurrence => Browser._Driver.FindElement(_ButtonDropDownOnceRecurrence);
        public readonly static By _ButtonDropDownOnceRecurrence = By.XPath("//select[@name = 'recurrenceType']//option[3]");

        public IWebElement ButtonDropDownFortnightlyRecurrence => Browser._Driver.FindElement(_ButtonDropDownFortnightlyRecurrence);
        public readonly static By _ButtonDropDownFortnightlyRecurrence = By.XPath("//select[@name = 'recurrenceType']//option[4]");

        public IWebElement RadioButtonLessonTypeGroup => Browser._Driver.FindElement(_RadioButtonLessonTypeGroup);
        public readonly static By _RadioButtonLessonTypeGroup = By.XPath("//input[@name = 'isGroupLessonGroup']");

        public IWebElement FieldStudentsPerGroupPrice => Browser._Driver.FindElement(_FieldStudentsPerGroupPrice);
        public readonly static By _FieldStudentsPerGroupPrice = By.XPath("//input[@class = 'form-control mr-4 ng-untouched ng-pristine ng-valid']");

        //The button is _ButtonAssignLessonToAfterSaved on the third place, after had saved the lesson and then had opened LessonSheduler the modal window
        public IWebElement ButtonAssignLessonToAfterSaved => Browser._Driver.FindElement(_ButtonAssignLessonToAfterSaved);
        public readonly static By _ButtonAssignLessonToAfterSaved = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[3]");

        public IWebElement ButtonNextDetailsTabBeforeSaved => Browser._Driver.FindElement(_ButtonNextDetailsTabBeforeSaved);
        public readonly static By _ButtonNextDetailsTabBeforeSaved = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[3]");

        public IWebElement ButtonNextDetailsTabAfterSaved => Browser._Driver.FindElement(_ButtonNextDetailsTabAfterSaved);
        public readonly static By _ButtonNextDetailsTabAfterSaved = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[4]");

        public IWebElement ButtonDeleteDetailsTab => Browser._Driver.FindElement(_ButtonDeleteDetailsTab);
        public readonly static By _ButtonDeleteDetailsTab = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[1]");

        #endregion

        #region DropDownMenuInstruments

        public IWebElement CheckBoxSelectAll => Browser._Driver.FindElement(_CheckBoxSelectAll);
        public readonly static By _CheckBoxSelectAll = By.XPath("//li[@class = 'multiselect-item-checkbox ng-star-inserted']//div[text() = 'Select All']");

        #endregion

        #region TeacherLessonShedulerTab

        public IWebElement ButtonSaveForTeacher => Browser._Driver.FindElement(_ButtonSaveForTeacher);
        public readonly static By _ButtonSaveForTeacher = By.XPath("//div[@class = 'lesson-create-resources-container']//button[@class = 'btn btn-primary']");

        #endregion

        #region AssignStudentsModalWindow

        public IWebElement ButtonDropDownStudents => Browser._Driver.FindElement(_ButtonDropDownStudents);
        public readonly static By _ButtonDropDownStudents = By.XPath("//span[text() = 'Students...']");

        public IWebElement CheckBoxFirststudent => Browser._Driver.FindElement(_CheckBoxFirststudent);
        public readonly static By _CheckBoxFirststudent = By.XPath("//div[@class = 'lesson-assign-container']//div[@class = 'dropdown-list']//ul[2]//li//div");

        public IWebElement ButtonArrowCloseListStudents => Browser._Driver.FindElement(_ButtonArrowCloseListStudents);
        public readonly static By _ButtonArrowCloseListStudents = By.XPath("//div[@class = 'lesson-assign-container']//span[@class = 'dropdown-up']");

        public IWebElement ButtonAssignStudents => Browser._Driver.FindElement(_ButtonAssignStudents);
        public readonly static By _ButtonAssignStudents = By.XPath("//div[@class = 'd-flex justify-content-between ng-star-inserted']//button[2]");

        #endregion

        #region ModalWindowDeleteLesson

        public IWebElement ButtonNoDeleteLessonMdlWndw => Browser._Driver.FindElement(_ButtonNoDeleteLessonMdlWndw);
        public readonly static By _ButtonNoDeleteLessonMdlWndw = By.XPath("//div[@class = 'lesson-delete-container']//button[1]");

        public IWebElement ButtonYesDeleteLessonMdlWndw => Browser._Driver.FindElement(_ButtonYesDeleteLessonMdlWndw);
        public readonly static By _ButtonYesDeleteLessonMdlWndw = By.XPath("//div[@class = 'lesson-delete-container']//button[2]");

        #endregion

        #region CalendarModalWindowLessonSheduler

        public IWebElement ButtonArrowRightClndrLssnShdlrs => Browser._Driver.FindElement(_ButtonArrowRightClndrLssnShdlr);
        public readonly static By _ButtonArrowRightClndrLssnShdlr = By.XPath("//div[@class = 'row']//button[2]//i");

        public IWebElement ButtonArrowLeftClndrLssnShdlrs => Browser._Driver.FindElement(_ButtonArrowLeftClndrLssnShdlr);
        public readonly static By _ButtonArrowLeftClndrLssnShdlr = By.XPath("//div[@class = 'row']//button//i");

        #endregion

        #region ScrollToLeftOrRight

        public IWebElement CellElevenPmScrollingMdlWndw => Browser._Driver.FindElement(_CellElevenPmScrollingMdlWndw);
        public readonly static By _CellElevenPmScrollingMdlWndw = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][2]//div[@class = 'timeline-container']//td[48]");

        public IWebElement CellTwelveAmScrollingMdlWndw => Browser._Driver.FindElement(_CellTwelveAmScrollingMdlWndw);
        public readonly static By _CellTwelveAmScrollingMdlWndw = By.XPath("//ngb-modal-window[@class = 'modal fade show d-block'][2]//div[@class = 'timeline-container']//td");

        #endregion

    }
}