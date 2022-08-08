using RimuTec.Faker;
using SamiiProjectOptimal.ApiPagesObjects.CreateAccountApiPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiHelpers
{
    public class EndPointsApi
    {
        public const string apiHost = "https://samii-api-refact.anuitexdevelopment.com";
    }
    public class CredentialsApi
    {
        public const string emailForLogInAdmin = "admin@admin.com1";
        public const string emailForLogInTeacher = "testteach@xitroo.com1";
        public const string emailForLogInStudent = "newstud@xitroo.com";
        public const string emailForLogInParent = "testparent@xitroo.com";

        public const string password = "1111";
        public const long passwordLong = 1111;
    }

    public class RequestGeneralTestDataProfileSetUp
    {
        public const string firstNameTeacher = "TestTeacher";
        public const string lastNameTeacher = "NewTeacher";
    }

    public class ResponseTestsData
    {
        public const string responseForSignUpStudent = "Account created";
    }

    //public class TestDataForCreatingUsers
    //{
    //    public static string emailForCreating = CreateAccountApi.UserRandomForCreateStudent().EmailAddress;
    //    public static long passwordForCreating = CreateAccountApi.UserRandomForCreateStudent().Password;
    //    public static long confirmPasswordForCreating = CreateAccountApi.UserRandomForCreateStudent().ConfirmPassword;
    //}

    //public class CredentialsAdminCms
    //{
    //    public const string email = "bennospencer@gmail.com";
    //    public const string password = "1289Raffle@!CMS";
    //}

}
