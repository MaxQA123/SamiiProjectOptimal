using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class Scrolling
    {
        [AllureStep("ScrollToElement")]
        public static IWebElement ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

            return element;
        }

        [AllureStep("ScrollToDownWebPage")]
        public static void ScrollToDownWebPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }

    }
}