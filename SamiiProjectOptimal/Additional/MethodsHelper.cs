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
        public static void InputFunctionWithClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        public static void InputFunctionWithoutClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(text);
        }
    }
}
