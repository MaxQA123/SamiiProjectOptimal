using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteStudentPages.EditProfilePage
{
    public partial class StudentProfileSetUp
    {
        [AllureStep("GetEmailFromLogIn")]
        public string GetEmailFromLogIn()
        {
            WaitUntil.WaitSomeInterval(1);
            string getEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'email']")).GetAttribute("value");
            string getEmailFromLogIn = getEmail.ToString();

            return getEmailFromLogIn;
        }

        [AllureStep("VerifyEmailIsRight")]
        public StudentProfileSetUp VerifyEmailIsRight(string getEmailFromLogIn)
        {
            WaitUntil.WaitSomeInterval(1);
            string emailProfileSetUp = FieldInputEmail.GetAttribute("value");

            Assert.AreEqual(getEmailFromLogIn, emailProfileSetUp);

            return this;
        }
    }
 }
