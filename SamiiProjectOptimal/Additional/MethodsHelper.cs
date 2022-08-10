using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    }

    public class Click
    {
        [AllureStep("Click")]
        public void ClickElement(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.CustomElevemtIsVisible(element);
            element.Click();
        }
    }

    public class KeyBoardActions
    {
        [AllureStep("InputFunctionWithoutClearSec")]
        public static void InputFunctionWithoutClearSec(IWebElement element)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(Keys.Enter);
        }

        [AllureStep("ClickEnterButton")]
        public static void ClickEnterButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
        }
    }
}