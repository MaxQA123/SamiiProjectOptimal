using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteParentPages.CreateAccountPage
{
    public partial class ParentCreateAccount
    {
        IWebElement FieldInputFirstNameStudentDetailsParentCrtPg => Browser._Driver.FindElement(_FieldInputFirstNameStudentDetailsParentCrtPg);
        public readonly By _FieldInputFirstNameStudentDetailsParentCrtPg = By.XPath("//div[@class = 'studets ng-star-inserted']//input[@name = 'firstName']");

        IWebElement FieldInputLastNameStudentDetailsParentCrtPg => Browser._Driver.FindElement(_FieldInputLastNameStudentDetailsParentCrtPg);
        public readonly By _FieldInputLastNameStudentDetailsParentCrtPg = By.XPath("//div[@class = 'studets ng-star-inserted']//input[@name = 'lastName']");

        public IWebElement FieldInputParentDateOfBirth => Browser._Driver.FindElement(_FieldInputParentDateOfBirth);
        public readonly static By _FieldInputParentDateOfBirth = By.XPath("//div[@class = 'ng-star-inserted']//input[@name = 'dp']");

        public IWebElement FieldInputParentStudentDetailsDateOfBirth => Browser._Driver.FindElement(_FieldInputParentStudentDetailsDateOfBirth);
        public readonly static By _FieldInputParentStudentDetailsDateOfBirth = By.XPath("//div[@class = 'studets ng-star-inserted']//input[@name = 'dp']");

        public IWebElement ButtonSelectRoleParent => Browser._Driver.FindElement(_ButtonSelectRoleParent);
        public readonly static By _ButtonSelectRoleParent = By.XPath("//div[contains(text(), 'Parent')]");
    }
}
