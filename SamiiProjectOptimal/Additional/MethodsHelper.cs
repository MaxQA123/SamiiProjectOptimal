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

    #region MethodsForSearchXPathHelper

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

            return this;
        }

        [AllureStep("SelectUserOnMessengerPage")]
        public Click SelectUserOnMessengerPage(int numberUser, string locationUserInList)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberUser = SearchXpathHelper.SelectorUsersOnMessengerPage(locationUserInList);

            _numberUser[numberUser].Click();

            return this;
        }

        [AllureStep("SelectItemBadgesEdtPrflPg")]
        public Click SelectItemBadgesEdtPrflPg(int numberItem, string locationItemBadges)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorItemBadgesEdtPrflPg(locationItemBadges);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("SelectInstrumentConfirmationtabPayPg")]
        public Click SelectInstrumentConfirmationtabPayPg(int numberItem, string locationInstrument)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorInstrumentConfirmationtabPayPg(locationInstrument);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("SelectRoleOnCreateaccountPage")]
        public Click SelectRoleOnCreateAccountPage(int numberItem, string locationRole)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorRoleOnCreateaccountPage(locationRole);

            _numberItem[numberItem].Click();

            return this;
        }

    }

    #endregion

    public class KeyBoardActions
    {
        [AllureStep("InputFunctionWithoutClear")]
        public static void InputFunctionWithoutClearSec(IWebElement element)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(Keys.Enter);
        }

        [AllureStep("InputFunctionWithoutClear")]
        public static void ClickEnterButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
        }
    }
}