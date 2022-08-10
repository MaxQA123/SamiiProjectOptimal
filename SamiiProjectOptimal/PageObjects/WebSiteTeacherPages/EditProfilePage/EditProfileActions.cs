using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.WebSiteTeacherPages.EditProfilePage
{
    public partial class EditProfile
    {
        [AllureStep("ClickIconEditBadgesEdtPrfPg")]
        public EditProfile ClickIconEditBadgesEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(5);
            WaitUntil.ElementIsClickable(IconEditBadgesEdtPrfPg);
            IconEditBadgesEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ClickIconConfirmEditBadgesEdtPrfPg")]
        public EditProfile ClickIconConfirmEditBadgesEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ElementIsClickable(IconConfirmEditBadgesEdtPrfPg);
            IconConfirmEditBadgesEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ClickButtonArrowWithRightBadgesEdtPrfPg")]
        public EditProfile ClickButtonArrowWithRightBadgesEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowWithRightBadgesEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ClickIconEditIntroductionEdtPrfPg")]
        public EditProfile ClickIconEditIntroductionEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            IconEditIntroductionEdtPrfPg.Click();

            return this;
        }

        [AllureStep("EnterTextInFieldInputEditIntroductionEdtPrfPg")]
        public EditProfile EnterTextInFieldInputEditIntroductionEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputEditIntroductionEdtPrfPg, TestData.textIntroductionEditProfileVarTwo);

            return this;
        }

        [AllureStep("ClickIconConfirmIntroductionBadgesEdtPrfPg")]
        public EditProfile ClickIconConfirmIntroductionBadgesEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            IconConfirmIntroductionBadgesEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ClickIconEditLocationEdtPrfPg")]
        public EditProfile ClickIconEditLocationEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            IconEditLocationEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ClickButtonAddForLocationEdtPrfPg")]
        public EditProfile ClickButtonAddForLocationEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonAddForLocationEdtPrfPg.Click();

            return this;
        }

        [AllureStep("ScrollToButtonAddForLocationEdtPrfPg")]
        public EditProfile ScrollToButtonAddForLocationEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            Scrolling.ScrollToElement(ButtonAddForLocationEdtPrfPg);

            return this;
        }

        [AllureStep("ScrollToRadioButtonProfileListedOnDirectoryEdtPrfPg")]
        public EditProfile ScrollToRadioButtonProfileListedOnDirectoryEdtPrfPg()
        {
            WaitUntil.WaitSomeInterval(1);
            Scrolling.ScrollToElement(RadioButtonProfileListedOnDirectoryEdtPrfPg);

            return this;
        }

        [AllureStep("SelectLocationForTeacherEdtPrfPg")]
        public EditProfile SelectLocationFieldsWithLeftForTeacherEdtPrfPg(int numberItem, string locationPlace)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorLocationFieldsWithLeftForTeacherEdtPrfPg(locationPlace);

            _numberItem[numberItem].Click();
            _numberItem[numberItem].SendKeys(TestDataNameLocations.homeStudio);

            return this;
        }

        [AllureStep("SelectItemBadgesEdtPrflPg")]
        public EditProfile SelectItemBadgesEdtPrflPg(int numberItem, string locationItemBadges)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorItemBadgesEdtPrflPg(locationItemBadges);

            _numberItem[numberItem].Click();

            return this;
        }

        [AllureStep("SelectInstrumentConfirmationtabPayPg")]
        public EditProfile SelectInstrumentConfirmationtabPayPg(int numberItem, string locationInstrument)
        {
            WaitUntil.WaitSomeInterval(1);
            IList<IWebElement> _numberItem = SearchXpathHelper.SelectorInstrumentConfirmationtabPayPg(locationInstrument);

            _numberItem[numberItem].Click();

            return this;
        }
    }
}
