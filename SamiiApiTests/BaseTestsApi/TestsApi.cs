using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamiiProjectOptimal.ApiPagesObjects;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.ApiHelpers;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;
using SamiiProjectOptimal.ApiPagesObjects.CreateAccountApiPage;

namespace SamiiApiTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApi
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("GeneralLogIn")]
        [AllureSubSuite("LoginRandomData")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public static void MakeLogInRandom()
        {
            //LogInApi.GetUserData(CredentialsApi.emailForLogInAdmin, CredentialsApi.password); (This string can use too.)

            var email = CredentialsApi.emailForLogInAdmin;

            var payload = LogInApi.GetUserData(email, Credentials.passwordAdmin);

            var response = LogInApi.ExecuteLogIn(payload);

            LogInApi.VerifyingLoggedUserRandom(response, email);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("GeneralLogIn")]
        [AllureSubSuite("LoginConstData")]

        public static void MakeLogInConst()
        {
            LogInApi.GetUserData(CredentialsApi.emailForLogInStudent, CredentialsApi.password);

            var payload = LogInApi.GetUserData(CredentialsApi.emailForLogInStudent, CredentialsApi.password);

            LogInApi.VerifyingLoggedUserConst(LogInApi.ExecuteLogIn(payload));
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SignUp")]
        [AllureSubSuite("SignUpStudent")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully creating the user student.
        //Comment: 
        //Path to cheking's: 

        public void SignUpStudent()
        {
            var payload = CreateAccountApi.CreatePayload(Randomaser.RandomFullEmailApi(), CredentialsApi.passwordLong, CredentialsApi.passwordLong);

            var response = CreateAccountApi.ExecuteSignUp(payload);

            CreateAccountApi.VerifyingSignedUpUser(response);
        }

        //public void SignUpStudent()
        //{
        //    var randomData = CreateAccountApi.UserRandomForCreateStudent();

        //    var payload = CreateAccountApi.CreatePayload(randomData.EmailAddress, randomData.Password, randomData.ConfirmPassword);

        //    var response = ResponseTestsData.responseForSignUpStudent;
        //    //var response = CreateAccountApi.ExecuteSignUp(payload);

        //    CreateAccountApi.VerifyingSignedUpUser(response, payload);
        //}
    }
}