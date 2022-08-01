using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects.EmailXitrooPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage
{
    public partial class ConfirmationCodeStudent
    {
        public ConfirmationCodeStudent EnterDataVerify(string code)
        {
            
            WaitUntil.ShouldLocate(_FieldInputConfirmCode);
            FieldInputConfirmCode.SendKeys(code);

            return this;
        }
        public ConfirmationCodeStudent ClickNextButton()
        {
            
            WaitUntil.WaitSomeInterval(2);
            ButtonNextConfirmCode.Click();

            return this;   
        }
    }
}