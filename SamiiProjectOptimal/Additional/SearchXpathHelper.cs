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
        public static IList<IWebElement> SelectorHomeStudioElevenPm(string location)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//ngb-modal-window[@class = 'modal fade show d-block'][2]//div[@class = 'modal-content']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{location}')]/ancestor::tr//td"));
        }
    }
}