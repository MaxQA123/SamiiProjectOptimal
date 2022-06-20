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

        public IWebElement ButtonAssignLessonTo => Browser._Driver.FindElement(_ButtonAssignLessonTo);
        public readonly static By _ButtonAssignLessonTo = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[2]");

        public IWebElement ButtonNextDetailsTab => Browser._Driver.FindElement(_ButtonNextDetailsTab);
        public readonly static By _ButtonNextDetailsTab = By.XPath("//div[@class = 'd-flex justify-content-between pc-markup']//button[3]");

        #endregion

        #region DropDownMenuInstruments

        public IWebElement CheckBoxSelectAll => Browser._Driver.FindElement(_CheckBoxSelectAll);
        public readonly static By _CheckBoxSelectAll = By.XPath("//li[@class = 'multiselect-item-checkbox ng-star-inserted']//div[text() = 'Select All']");

        #endregion

        #region TeacherLessonShedulerTab

        public IWebElement ButtonSaveForTeacher => Browser._Driver.FindElement(_ButtonSaveForTeacher);
        public readonly static By _ButtonSaveForTeacher = By.XPath("//div[@class = 'lesson-create-resources-container']//button[@class = 'btn btn-primary']");

        #endregion
    }
}