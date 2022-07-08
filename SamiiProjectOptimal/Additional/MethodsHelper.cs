using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class Input
    {
        [AllureStep("InputFunctionWithClear")]
        public static void InputFunctionWithClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        [AllureStep("InputFunctionWithoutClear")]
        public static void InputFunctionWithoutClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(text);
        }

        public class Click
        {
            [AllureStep("ClickTwiceOnLessonPage")]
            public Click ClickTwiceOnLessonPage(int timeSlot, string location)
            {
                WaitUntil.WaitSomeInterval(3);
                IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

                _shedulerLessonPage[timeSlot].Click();
                _shedulerLessonPage[timeSlot].Click();

                return this;
            }

            [AllureStep("ClickOnceLessonPage")]
            public Click ClickOnceLessonPage(int timeSlot, string location)
            {
                WaitUntil.WaitSomeInterval(3);
                IList<IWebElement> _schedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

                _schedulerLessonPage[timeSlot].Click();
                _schedulerLessonPage[timeSlot].Click();

                return this;
            }

        }
    }
}