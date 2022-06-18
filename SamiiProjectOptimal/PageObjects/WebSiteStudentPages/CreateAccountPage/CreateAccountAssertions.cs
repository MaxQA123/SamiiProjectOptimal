using NUnit.Framework;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.Header;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.CreateAccountPage
{
    public partial class CreateAccountStudent
    {
        public IWebElement FieldHiUsernameHdr => Browser._Driver.FindElement(_FieldHiUsernameHdr);
        public readonly static By _FieldHiUsernameHdr = By.XPath("//ul[@class = 'navbar-nav right desktop']//span[contains(text(), 'Hi')]");

        public static string GetFirstName()
        {
            string getFirstName = Browser._Driver.FindElement(By.XPath("//input[@name = 'firstName']")).GetAttribute("value");
            string firstName = getFirstName.ToString();

            return firstName;
        }

        public CreateAccountStudent VerifyFirstName(string firstName)
        {
            WaitUntil.WaitSomeInterval(3);
            string profileFirstName = FieldHiUsernameHdr.GetAttribute("value");

            Assert.AreEqual(firstName, profileFirstName);

            return this;
        }
       
    }
}
