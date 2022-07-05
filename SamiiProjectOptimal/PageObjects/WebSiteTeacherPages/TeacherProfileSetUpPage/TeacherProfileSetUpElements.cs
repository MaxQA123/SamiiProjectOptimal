using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherProfileSetUpPage
{
    public partial class TeacherProfileSetUp
    {
        public IWebElement TabSetupTchrPrflStp => Browser._Driver.FindElement(_TabSetupTchrPrflStp);
        public readonly static By _TabSetupTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'setup']");

        public IWebElement TabGetPaidTchrPrflStp => Browser._Driver.FindElement(_TabGetPaidTchrPrflStp);
        public readonly static By _TabGetPaidTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'payment']");

        public IWebElement TabPasswordTchrPrflStp => Browser._Driver.FindElement(_TabPasswordTchrPrflStp);
        public readonly static By _TabPasswordTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'password']");

        public IWebElement TabAvailableResourcesTchrPrflStp => Browser._Driver.FindElement(_TabAvailableResourcesTchrPrflStp);
        public readonly static By _TabAvailableResourcesTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'resources']");

        #region TabPassword

        public IWebElement IconShowCurrentPsswrdTabPsswrdTchrPrflStp => Browser._Driver.FindElement(_IconShowCurrentPsswrdTabPsswrdTchrPrflStp);
        public readonly static By _IconShowCurrentPsswrdTabPsswrdTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'setup']");

        public IWebElement IconShowPsswrdTabPsswrdTchrPrflStp => Browser._Driver.FindElement(_IconShowPsswrdTabPsswrdTchrPrflStp);
        public readonly static By _IconShowPsswrdTabPsswrdTchrPrflStp = By.XPath("//ul[@role = 'tablist']//a[@id = 'setup']");

        #endregion
    }
}
