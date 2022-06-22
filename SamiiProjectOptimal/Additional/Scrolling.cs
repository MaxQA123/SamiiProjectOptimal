using NUnit.Allure.Attributes;
using OpenQA.Selenium;
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

        //public static IWebElement ScrollToElement(IWebElement element)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)Browser._Driver;
        //    js.ExecuteScript("arguments[0].scrollIntoView();", element);

        //    return element;
        //}
    }
}
