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

        [AllureStep("SelectorShedulerLessonPageAdditional")]
        public static IList<IWebElement> SelectorShedulerLessonPageAdditional(string _locationpage)
        {
            WaitUntil.WaitSomeInterval(10);
            var str = "//div[@class = 'container-fluid']//div[@class = 'timeline-container']//table";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{_locationpage}')]/ancestor::tr//td"));
        }

        //[AllureStep("SelectorOnsideRghtCalendarShedulerLessonPage")]
        //public static IList<IWebElement> SelectorOnsideRghtCalendarShedulerLessonPage(string locationmonth)
        //{
        //    WaitUntil.WaitSomeInterval(10);
        //    var str = $"//li[contains(text(), '{locationmonth}')]/ancestor::div/ul[@class = 'days']";
        //    _element = Browser._Driver.FindElement(By.XPath(str));
        //    return _element.FindElements(By.XPath($".//li"));
        //}

        [AllureStep("SelectorUsersOnMessengerPage")]
        public static IList<IWebElement> SelectorUsersOnMessengerPage(string locationUser)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//div[@class = 'inbox_people']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[@class = 'chat_people ng-star-inserted']//h5[contains(text(), '{locationUser}')]"));
        }

        [AllureStep("SelectorItemBadgesEdtPrflPg")]
        public static IList<IWebElement> SelectorItemBadgesEdtPrflPg(string locationItemBadges)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//div[@class = 'slick-list draggable']//div[@class = 'slick-track']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{locationItemBadges}')]"));
        }

        [AllureStep("SelectorInstrumentConfirmationtabPayPg")]
        public static IList<IWebElement> SelectorInstrumentConfirmationtabPayPg(string locationIInstrument)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//select[@id = 'instrument']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//option[contains(text(), '{locationIInstrument}')]"));
        }

        [AllureStep("SelectorRoleOnCreateaccountPage")]
        public static IList<IWebElement> SelectorRoleOnCreateAccountPage(string locationRole)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//div[@class = 'container']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(text(), '{locationRole}')]"));
        }

        //[AllureStep("SelectorLocationForTeacherEdtPrfPg")]
        //public static IList<IWebElement> SelectorLocationForTeacherEdtPrfPg(string locationPlace)
        //{
        //    WaitUntil.WaitSomeInterval(1);
        //    var str = "//div[@class = 'h-100 d-flex flex-column justify-content-between']";
        //    _element = Browser._Driver.FindElement(By.XPath(str));
        //    return _element.FindElements(By.XPath($".//tr[contains(@class, '{locationPlace}')]//input[@class = 'form-control ng-untouched ng-pristine ng-valid ng-star-inserted']"));
        //}

        [AllureStep("SelectorLocationForTeacherEdtPrfPg")]
        public static IList<IWebElement> SelectorLocationForTeacherEdtPrfPg(string locationPlace)
        {
            WaitUntil.WaitSomeInterval(1);
            //var str = "//div[@class = 'h-100 d-flex flex-column justify-content-between']";
            //_element = Browser._Driver.FindElement(By.XPath(str));
            return Browser._Driver.FindElements(By.XPath($".//tbody/tr/td/input"));
        }

        [AllureStep("SelectorNumberPaginationForTeacherAdminPg")]
        public static IList<IWebElement> SelectorNumberPaginationForTeacherAdminPg(string locationNumber)
        {
            WaitUntil.WaitSomeInterval(1);
            var str = "//nav[@class = 'pagination ng-star-inserted']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//li[contains(@class, '{locationNumber}')]//a"));
        }
    }
}