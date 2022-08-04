using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamiiProjectOptimal.ApiPagesObjects;
using SamiiProjectOptimal.Additional;
using SamiiProjectOptimal.ApiHelpers;

namespace SamiiApiTests.BaseTestsApi
{
    [TestFixture]

    public class TestsApi
    {
        [Test]
        public static void MakeLogIn()
        {
            LogInApi.ExecuteLogIn(CredentialsApi.emailForLogInAdmin, CredentialsApi.password);
        }
    }
}