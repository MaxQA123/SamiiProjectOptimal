using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.LogInTeacher
{
    public partial class LogInTeacher
    {
        public LogInTeacher ClickCreateAnAccount()
        {
            LinkCreateAnAccountl.Click();

            return this;
        }
    }
}
