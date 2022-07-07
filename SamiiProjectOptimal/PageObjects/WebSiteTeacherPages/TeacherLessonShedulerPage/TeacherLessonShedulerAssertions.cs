using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.TeacherLessonShedulerPage
{
    public partial class TeacherLessonSheduler
    {
        [AllureStep("VerifyDeletelesson")]
        public TeacherLessonSheduler VerifyDeletelesson(string time)
        {
            WaitUntil.WaitSomeInterval(1);

            Assert.Throws<NoSuchElementException>(() => Browser._Driver.FindElement(By.XPath($".//div[contains(text(), '{time}')]")));
           
            return this;
        }

        [AllureStep("GetTime")]
        public string GetTime(int timeSlot, string location)
        {
            WaitUntil.WaitSomeInterval(1);

            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

            string time = _shedulerLessonPage[timeSlot].FindElement(By.XPath(".//div[contains(@class, 'date')]")).Text;
            
            return time;
        }

    }
}
