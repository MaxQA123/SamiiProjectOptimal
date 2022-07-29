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
        public IWebElement ButtonViewAsSeenOnDirectoryEdtPrfPg => Browser._Driver.FindElement(_ButtonViewAsSeenOnDirectoryEdtPrfPg);
        public readonly static By _ButtonViewAsSeenOnDirectoryEdtPrfPg = By.XPath("//button[@class = 'btn btn-primary directory-button w-100']");

        public IWebElement ButtonCreateLessonsEdtPrfPg => Browser._Driver.FindElement(_ButtonCreateLessonsEdtPrfPg);
        public readonly static By _ButtonCreateLessonsEdtPrfPg = By.XPath("//button[@class = 'btn btn-primary create-lesson-button w-100']");

        public IWebElement ButtonProfileCompleteEdtPrfPg => Browser._Driver.FindElement(_ButtonProfileCompleteEdtPrfPg);
        public readonly static By _ButtonProfileCompleteEdtPrfPg = By.XPath("//button[@class = 'btn btn-primary profile-full-percent w-100']");

        public IWebElement IconEditBadgesEdtPrfPg => Browser._Driver.FindElement(_IconEditBadgesEdtPrfPg);
        public readonly static By _IconEditBadgesEdtPrfPg = By.XPath("//button[@class = 'btn icon ng-star-inserted']//i[@class = 'fas fa-pencil-alt']");

        public IWebElement ButtonArrowWithRightBadgesEdtPrfPg => Browser._Driver.FindElement(_ButtonArrowWithRightBadgesEdtPrfPg);
        public readonly static By _ButtonArrowWithRightBadgesEdtPrfPg = By.XPath("//button[@class = 'slick-next slick-arrow']");

        public IWebElement ButtonArrowWithLeftBadgesEdtPrfPg => Browser._Driver.FindElement(_ButtonArrowWithLeftBadgesEdtPrfPg);
        public readonly static By _ButtonArrowWithLeftBadgesEdtPrfPg = By.XPath("//button[@class = 'slick-prev slick-arrow']");

        public IWebElement IconConfirmEditBadgesEdtPrfPg => Browser._Driver.FindElement(_IconConfirmEditBadgesEdtPrfPg);
        public readonly static By _IconConfirmEditBadgesEdtPrfPg = By.XPath("//button[@class = 'btn icon ng-star-inserted']//i[@class = 'fas fa-check']");

        public IWebElement IconEditIntroductionEdtPrfPg => Browser._Driver.FindElement(_IconEditIntroductionEdtPrfPg);
        public readonly static By _IconEditIntroductionEdtPrfPg = By.XPath("//div[@class = 'row introduction']//button[@class = 'btn icon ng-star-inserted']//i[@class = 'fas fa-pencil-alt']");

        public IWebElement FieldInputEditIntroductionEdtPrfPg => Browser._Driver.FindElement(_FieldInputEditIntroductionEdtPrfPg);
        public readonly static By _FieldInputEditIntroductionEdtPrfPg = By.XPath("//div[@class = 'ck-blurred ck ck-content ck-editor__editable ck-rounded-corners ck-editor__editable_inline']");

        public IWebElement IconConfirmIntroductionBadgesEdtPrfPg => Browser._Driver.FindElement(_IconConfirmIntroductionBadgesEdtPrfPg);
        public readonly static By _IconConfirmIntroductionBadgesEdtPrfPg = By.XPath("//button[@class = 'btn icon float-right']//i[@class = 'fas fa-check']");

        public IWebElement IconEditLocationEdtPrfPg => Browser._Driver.FindElement(_IconEditLocationEdtPrfPg);
        public readonly static By _IconEditLocationEdtPrfPg = By.XPath("//th[@class = 'mobile-location-header']//button[@class = 'btn icon ng-star-inserted']");
    }
}
