using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherConfirmCodePage
{
    public partial class TeacherConfirmCode
    {
        public TeacherConfirmCode EnterDataVerifyCode(string code)
        {
            WaitUntil.ShouldLocate(_FieldInputConfirmCode);
            FieldInputConfirmCode.SendKeys(code);

            return this;
        }

        public TeacherConfirmCode ClickButtonNext()
        {
            WaitUntil.ShouldLocate(_ButtonNextConfirmCode);
            ButtonNextConfirmCode.Click();

            return this;
        }
    }
}
