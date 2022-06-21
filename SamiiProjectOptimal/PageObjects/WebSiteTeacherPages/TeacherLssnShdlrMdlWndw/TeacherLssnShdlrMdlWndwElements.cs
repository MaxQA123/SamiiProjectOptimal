using OpenQA.Selenium;
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
        public IWebElement IframeLssnShdlrMdlWndwTeacher => Browser._Driver.FindElement(_IframeLssnShdlrMdlWndwTeacher);
        public readonly static By _IframeLssnShdlrMdlWndwTeacher = By.XPath("//iframe[@id = 'cb-master-frame']");

        public IWebElement TabDetails => Browser._Driver.FindElement(_TabDetails);
        public readonly static By _TabDetails = By.XPath("//button[@class = 'btn-clear selected']");

        public IWebElement TabResources => Browser._Driver.FindElement(_TabResources);
        public readonly static By _TabResources = By.XPath("//button[@class = 'btn-clear']");

        #region TeacherDetailsTab

        public IWebElement ButtonDropDownInstruments => Browser._Driver.FindElement(_ButtonDropDownInstruments);
        public readonly static By _ButtonDropDownInstruments = By.XPath("//span[@class = 'dropdown-btn']//span");

        public IWebElement ButtonArrowCloseDropDownInstruments => Browser._Driver.FindElement(_ButtonArrowCloseDropDownInstruments);
        public readonly static By _ButtonArrowCloseDropDownInstruments = By.XPath("//span[@class = 'dropdown-up']");

        public IWebElement ButtonDropDownOnceRecurrence => Browser._Driver.FindElement(_ButtonDropDownOnceRecurrence);
        public readonly static By _ButtonDropDownOnceRecurrence = By.XPath("//select[@name = 'recurrenceType']//option[3]");

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
    }
}