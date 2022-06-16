﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Allure.Core;
using NUnit.Framework;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System.Threading.Tasks;
using SamiiProjectOptimal.PageObjects;
using System.Threading;
using SamiiProjectOptimal.Additional;
using OpenQA.Selenium;
using SamiiProjectOptimal.PageObjects.WebSiteStudentPages.ConfirmationCodePage;

namespace SamiiProjectOptimal.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteStudentTests : TestBaseWeb
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]
        public void LogInAsStudent()
        {
            Pages.LogInStudent
                .EnterEmailPassword();
            Pages.LogInStudent
                .ClickButtonSignIn();
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "qatester91311@gmail.com")]
        [AllureSuite("Client")]
        [AllureSubSuite("Login")]
        public void CreateAccountForStudent()
        {
            Pages.LogInStudent
                .ClickLinkCreateAnAccount();
            Pages.CreateAccountStudent
                .EnterEmailPasswordCnfrmPsswrd();
            Pages.CreateAccountStudent
                .ClickSignUpButtonCrtAccnt();
            Pages.EmailXitroo
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.emailUrlXitroo);
            Pages.EmailXitroo
                .OpenWelcomeToSammii();

            string verificationCode = Pages.EmailXitroo.CopyVerificationCode();

            Pages.EmailXitroo
                .CloseNewTab();
            Pages.ConfirmationCodeStudent
                .EnterDataVerify(verificationCode);
            Pages.ConfirmationCodeStudent
                .ClickNextButton();
            Thread.Sleep(10000);
        }

        [Test]

        public void Demo()
        {
            Pages.EmailXitroo
                .OpenNewTab();
            Thread.Sleep(5000);
        }
    }
}
