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

        public IWebElement FieldInputConfirmPasswordRstPsswrdPg => Browser._Driver.FindElement(_FieldInputConfirmPasswordRstPsswrdPg);
        public readonly static By _FieldInputConfirmPasswordRstPsswrdPg = By.XPath("//input[@id= 'confirm-password']");

        public IWebElement IconShowCurrentPsswrdTabPsswrdTchrPrflStp => Browser._Driver.FindElement(_IconShowCurrentPsswrdTabPsswrdTchrPrflStp);
        public readonly static By _IconShowCurrentPsswrdTabPsswrdTchrPrflStp = By.XPath("//div[@class = 'change-password-teacher']//i[@class = 'fas fa-eye']");

        public IWebElement IconShowPsswrdTabPsswrdTchrPrflStp => Browser._Driver.FindElement(_IconShowPsswrdTabPsswrdTchrPrflStp);
        public readonly static By _IconShowPsswrdTabPsswrdTchrPrflStp = By.XPath("//div[@class = 'change-password-teacher']//div[@formgroupname = 'passwords']//i[@class = 'fas fa-eye']");

        #endregion

        #region TabAvailableResources

        public IWebElement ButtonPreviousStepAvlbRsrcsTchrPrflStp => Browser._Driver.FindElement(_ButtonPreviousStepAvlbRsrcsTchrPrflStp);
        public readonly static By _ButtonPreviousStepAvlbRsrcsTchrPrflStp = By.XPath("//div[@id = 'resources-panel']//button[contains(text(),  ' Previous Step')]");

        public IWebElement ButtonCompleteAvlbRsrcsTchrPrflStp => Browser._Driver.FindElement(_ButtonCompleteAvlbRsrcsTchrPrflStp);
        public readonly static By _ButtonCompleteAvlbRsrcsTchrPrflStp = By.XPath("//div[@id = 'resources-panel']//button[contains(text(),  'Complete ')]");

        #endregion
    }
}
