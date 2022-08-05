using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects.CreateAccountApiPage
{
    public partial class CreateAccountApi
    {
        public static void VerifyingSignedUpUser(ResponseCreateAccountStudentApi response)
        {
            Assert.AreEqual("Account created", response.Message);
        }
    }
}
