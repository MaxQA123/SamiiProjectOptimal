using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteAdminPages.AdminHomePage
{
    public partial class AdminHome
    {
        [AllureStep("GetNameAdminFromAdminPage")]
        public string GetNameAdminFromAdminPage()
        {
            WaitUntil.ShouldLocate(_CurrentNameAdmin);
            string getNameAdmin = Browser._Driver.FindElement(_CurrentNameAdmin).Text;
            string getCurrentNameAdmin = getNameAdmin.ToString();

            return getCurrentNameAdmin;
        }

        [AllureStep("VerifyCurrentNameAdmin")]
        public AdminHome VerifyCurrentNameAdmin(string getCurrentNameAdmin)
        {
            WaitUntil.WaitSomeInterval(1);
            string nameAdmin = "Pete Barter";
            Assert.AreEqual(nameAdmin, getCurrentNameAdmin);

            return this;
        }
    }
}
