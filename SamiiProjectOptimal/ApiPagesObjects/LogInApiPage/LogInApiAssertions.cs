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
        public static void VerifyingLoggedUser(ResponseLogIn response)
        {
            Assert.AreEqual("agitatedvolhard@xitroo.com", response.Email);
        }

    }
}
