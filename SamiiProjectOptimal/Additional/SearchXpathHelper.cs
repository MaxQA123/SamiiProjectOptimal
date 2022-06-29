﻿using OpenQA.Selenium;
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
        public static IList<IWebElement> SelectorShedulerLessonMdlWndwForMoveLesson(string location)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//ngb-modal-window[@class = 'modal fade show d-block'][2]//div[@class = 'modal-content']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{location}')]/ancestor::tr//td"));
        }

        public static IList<IWebElement> SelectorShedulerLessonPage(string locationpage)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = "//div[@class = 'container-fluid']//div[@class = 'timeline-container']//table";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{locationpage}')]/ancestor::tr//td"));
        }

        public static IList<IWebElement> SelectorShedulerLessonPageAddotional(string _locationpage)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = "//div[@class = 'container-fluid']//div[@class = 'timeline-container']//table";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{_locationpage}')]/ancestor::tr//td"));
        }
    }
}