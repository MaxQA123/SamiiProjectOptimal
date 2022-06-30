using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class SearchXpathHelper
    {
        private static IWebElement _element;

        [AllureStep("SelectorShedulerLessonMdlWndwForMoveLesson")]
        public static IList<IWebElement> SelectorShedulerLessonMdlWndwForMoveLesson(string location)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//ngb-modal-window[@class = 'modal fade show d-block'][2]//div[@class = 'modal-content']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{location}')]/ancestor::tr//td"));
        }

        [AllureStep("SelectorShedulerLessonPage")]
        public static IList<IWebElement> SelectorShedulerLessonPage(string locationpage)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = "//div[@class = 'container-fluid']//div[@class = 'timeline-container']//table";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{locationpage}')]/ancestor::tr//td"));
        }

        [AllureStep("SelectorShedulerLessonPageAdditional")]
        public static IList<IWebElement> SelectorShedulerLessonPageAdditional(string _locationpage)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = "//div[@class = 'container-fluid']//div[@class = 'timeline-container']//table";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{_locationpage}')]/ancestor::tr//td"));
        }

        [AllureStep("SelectorShedulerLessonPage")]
        public static IList<IWebElement> SelectorOnsideRghtCalendarShedulerLessonPage(string locationmonth)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = $"//li[contains(text(), '{locationmonth}')]/ancestor::div/ul[@class = 'days']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//li"));
        }
    }
}