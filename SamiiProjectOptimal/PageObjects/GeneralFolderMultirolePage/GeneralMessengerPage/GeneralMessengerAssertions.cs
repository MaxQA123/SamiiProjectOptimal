using NUnit.Allure.Attributes;
using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.PageObjects.GeneralFolderMultirolePage.GeneralMessengerPage
{
    public partial class GeneralMessenger
    {
        [AllureStep("GetTextMessage")]
        public string GetTextMessage()
        {
            WaitUntil.WaitSomeInterval(1);
            string getTextInjected = Browser._Driver.FindElement(_FieldInputMessageOnMessengerPg).GetAttribute("value");
            string getTextInjectedExpexted = getTextInjected.ToString();

            return getTextInjectedExpexted;
        }

        [AllureStep("VerifyTextMessage")]
        public GeneralMessenger VerifyTextMessage(string getTextInjectedExpexted)
        {
            WaitUntil.WaitSomeInterval(1);
            string getTextDisplayed = LastStringMessageInListMessengerPg.Text;

            Assert.AreEqual(getTextInjectedExpexted, getTextDisplayed);

            return this;

        }

    }
}
