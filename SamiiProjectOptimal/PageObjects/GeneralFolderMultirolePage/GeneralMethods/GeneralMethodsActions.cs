using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralMethods
{
    public partial class GeneralMethods
    {
        [AllureStep("ClickTwiceOnLessonPage")]
        public GeneralMethods ClickTwiceOnLessonPage(int timeSlot, string location)
        {
            WaitUntil.WaitSomeInterval(3);
            IList<IWebElement> _shedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

            _shedulerLessonPage[timeSlot].Click();
            _shedulerLessonPage[timeSlot].Click();

            return this;
        }

        [AllureStep("ClickOnceLessonPage")]
        public GeneralMethods ClickOnceLessonPage(int timeSlot, string location)
        {
            WaitUntil.WaitSomeInterval(3);
            IList<IWebElement> _schedulerLessonPage = SearchXpathHelper.SelectorShedulerLessonPageAdditional(location);

            _schedulerLessonPage[timeSlot].Click();

            return this;
        }

        [AllureStep("SelectUserOnMessengerPage")]
        public GeneralMethods SelectUserOnMessengerPage(int numberUser, string locationUserInList)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberUser = SearchXpathHelper.SelectorUsersOnMessengerPage(locationUserInList);

            _numberUser[numberUser].Click();

            return this;
        }

        [AllureStep("SelectRoleOnCreateAccountPage")]
        public GeneralMethods SelectRoleOnCreateAccountPage(int numberItem, string locationRole)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorRoleOnCreateAccountPage(locationRole);

            _numberItem[numberItem].Click();

            return this;
        }
    }
}
