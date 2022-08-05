using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects
{
    public partial class LogInApi
    {
        public static void VerifyingLoggedUserRandom(ResponseLogIn response, string email)
        {
            Assert.AreEqual(email, response.Email);
        }

        public static void VerifyingLoggedUserConst(ResponseLogIn response)
        {
            Assert.AreEqual("newstud@xitroo.com", response.Email);
        }

    }
}
