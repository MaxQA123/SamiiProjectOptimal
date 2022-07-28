using NUnit.Allure.Attributes;
using RimuTec.Faker;
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
        [AllureStep("EnterMessageOnMessengerPage")]
        public GeneralMessenger EnterMessageOnMessengerPage()
        {
            WaitUntil.WaitSomeInterval(1);
            Input.InputFunctionWithClear(FieldInputMessageOnMessengerPg, TestData.messageForMessenger);

            return this;
        }

        [AllureStep("ClickButtonArrowSendMessageOnMessengerPg")]
        public GeneralMessenger ClickButtonArrowSendMessageOnMessengerPg()
        {
            WaitUntil.WaitSomeInterval(1);
            ButtonArrowSendMessageOnMessengerPg.Click();

            return this;
        }
    }
}
