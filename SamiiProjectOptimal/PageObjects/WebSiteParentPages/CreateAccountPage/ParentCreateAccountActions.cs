using NUnit.Allure.Attributes;
using RimuTec.Faker;
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
        [AllureStep("EnterFirstLastNameParentStudentDetails")]
        public ParentCreateAccount EnterFirstLastNameParentStudentDetails()
        {
            WaitUntil.WaitSomeInterval(3);
            Input.InputFunctionWithClear(FieldInputFirstNameStudentDetailsParentCrtPg, Name.FirstName());
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputLastNameStudentDetailsParentCrtPg, Name.LastName());

            return this;
        }

        [AllureStep("EnterFieldInputParentDateOfBirth")]
        public ParentCreateAccount EnterFieldInputParentDateOfBirth()
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputParentDateOfBirth, TestData.parentDateOfBirth);

            return this;
        }

        [AllureStep("EnterFieldInputParentStudentDetailsDateOfBirth")]
        public ParentCreateAccount EnterFieldInputParentStudentDetailsDateOfBirth()
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputParentStudentDetailsDateOfBirth, TestData.studentDateOfBirth);

            return this;
        }

        [AllureStep("SelectRoleParent")]
        public ParentCreateAccount SelectRoleParent()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsClickable(ButtonSelectRoleParent);
            ButtonSelectRoleParent.Click();

            return this;
        }
    }
}
