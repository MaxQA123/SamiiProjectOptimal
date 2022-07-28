using OpenQA.Selenium;
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
        public IWebElement FieldInputMessageOnMessengerPg => Browser._Driver.FindElement(_FieldInputMessageOnMessengerPg);
        public readonly static By _FieldInputMessageOnMessengerPg = By.XPath("//textarea[@class = 'write_msg']");

        public IWebElement ButtonArrowSendMessageOnMessengerPg => Browser._Driver.FindElement(_ButtonArrowSendMessageOnMessengerPg);
        public readonly static By _ButtonArrowSendMessageOnMessengerPg = By.XPath("//i[@class = 'fas fa-paper-plane']");

        // For XPath "//div[@class = 'ng-star-inserted'][494]" need change the number in the breckets "[494]"
        public IWebElement LastStringMessageViaNumberStringInListMessengerPg => Browser._Driver.FindElement(_LastStringMessageViaNumberStringInListMessengerPg);
        public readonly static By _LastStringMessageViaNumberStringInListMessengerPg = By.XPath("//div[@class = 'ng-star-inserted'][494]//p[@style = 'overflow-wrap: break-word;']//div");

        //Find the elements using the text message.
        public IWebElement LastStringMessageViaTextInListMessengerPg => Browser._Driver.FindElement(_LastStringMessageViaTextInListMessengerPg);
        public readonly static By _LastStringMessageViaTextInListMessengerPg = By.XPath("//div[text() = 'I am Admin! Do you fine?']");
        
    }
}
