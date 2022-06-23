using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.EducatorsViewPage
{
    public partial class EducatorsView
    {
        public EducatorsView ClickButtonImpersonateEducatorView()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ShouldLocate(_ButtonImpersonateEducatorView);
            ButtonImpersonateEducatorView.Click();

            return this;
        }
    }
}
